﻿
' Changelog
' v2 7/28/16
'  - Added ExtractToExcel
' v1.4 2/17/16
'  - Log Module
' v1.3 11/19/15
'  - CommandPrompt Added
' v1.2 11/6/15
'  - Added ESK File
' v1.1 10/20/15
'  - Added decimal . in DigitOnly
'  - Added isMoney

Imports Microsoft.Office.Interop
Module mod_system
    ''' <summary>
    ''' This region declare the neccessary variable in this system.
    ''' </summary>
    ''' <remarks></remarks>
#Region "Global Variables"
    Dim frmCollection As New FormCollection()
    Public DEV_MODE As Boolean = False
    Public PROTOTYPE As Boolean = False
    Public ADS_ESKIE As Boolean = False
    Public ADS_SHOW As Boolean = False

    Public CurrentDate As Date = Now
    Public SystemUser As New Sys_user
    Public UserIDX As Integer = SystemUser.ID
    'Public BranchCode As String = GetOption("BranchCode")
    'Public SetCount As Integer = GetOption("SetCount")
    'Public branchName As String = GetOption("BranchName")
    'Public AREACODE As String = GetOption("BranchArea")
    'Public REVOLVING_FUND As String = GetOption("RevolvingFund")
    'Public OTPDisable As Boolean = IIf(GetOption("OTP") = "YES", True, False)
    'Public IsLocked As Boolean = IIf(GetOption("LOCKED") = "YES", True, False)

    'Friend isAuthorized As Boolean = False
    'Public backupPath As String = "."

    'Friend advanceInterestDays As Integer = 30
    'Friend MaintainBal As Double = GetOption("MaintainingBalance")
    'Friend InitialBal As Double = GetOption("CurrentBalance")
    Friend RepDep As Double = 0
    Friend DollarRate As Double = 48
    Friend DollarAllRate As Double
    Friend RequirementLevel As Integer = 1
    Friend dailyID As Integer = 1

    Friend TBLINT_HASH As String = ""
    Friend PAWN_JE As Boolean = False
    Friend DBVERSION As String = ""


    Public PASSWORD_AGE_COUNT As Integer = 0
    Public PASSWORD_EXPIRY_COUNT As Integer = 0


    Public UType As String = ""
    Public FullName As String = ""

    Public AccountRule As New User_Line_RULES
    Public tmpPassword As String = ""

#End Region

    Public Function CommandPrompt(ByVal app As String, ByVal args As String) As String
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo(app, args)
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oStartInfo.WindowStyle = ProcessWindowStyle.Hidden
        oStartInfo.CreateNoWindow = True
        oProcess.StartInfo = oStartInfo

        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using

        Return sOutput
    End Function

    Friend Sub CreateEsk(ByVal url As String, ByVal data As Hashtable)
        If System.IO.File.Exists(url) Then System.IO.File.Delete(url)

        Dim fsEsk As New System.IO.FileStream(url, IO.FileMode.CreateNew)
        Dim refNum As String, transDate As String, branchCode As String, amount As Double, remarks As String
        Dim checkSum As String

        With data
            refNum = data(0) '0 - as RefNum
            transDate = data(1) 'transDate
            branchCode = data(2) 'branchCode
            amount = data(3) 'Amount
            remarks = data(4) 'Remarks
        End With
        checkSum = HashString(refNum & transDate & branchCode & amount & remarks)
        data.Add(5, checkSum) 'CheckSum

        Dim esk As New Runtime.Serialization.Formatters.Binary.BinaryFormatter
        esk.Serialize(fsEsk, data)
        fsEsk.Close()
    End Sub

    Friend Function LoadEsk(ByVal url) As Hashtable
        If Not System.IO.File.Exists(url) Then Return Nothing

        Dim fsEsk As New System.IO.FileStream(url, IO.FileMode.Open)
        Dim bf As New Runtime.Serialization.Formatters.Binary.BinaryFormatter

        Dim hashTable As New Hashtable
        Try
            hashTable = bf.Deserialize(fsEsk)
        Catch ex As Exception
            Console.WriteLine("It seems the file is being tampered.")
            Return Nothing
        End Try
        fsEsk.Close()

        Dim isValid As Boolean = False
        If hashTable(5) = security.HashString(hashTable(0) & hashTable(1) & hashTable(2) & hashTable(3) & hashTable(4)) Then
            isValid = True
        End If

        If isValid Then Return hashTable
        Return Nothing
    End Function

    ''' <summary>
    ''' Function use to input only numbers
    ''' </summary>
    ''' <param name="e">Keypress Event</param>
    ''' <remarks>Use the Keypress Event when calling this function</remarks>
    Friend Function DigitOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs, Optional isWhole As Boolean = False)
        Console.WriteLine("char: " & e.KeyChar & " -" & Char.IsDigit(e.KeyChar))
        If e.KeyChar <> ControlChars.Back Then
            If isWhole Then
                e.Handled = Not (Char.IsDigit(e.KeyChar))
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
            End If

        End If

        Return Not (Char.IsDigit(e.KeyChar))
    End Function

    ''' <summary>
    ''' this function check if the input is numeric or character.
    ''' </summary>
    ''' <param name="txt">txt here hold the numeric value.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function checkNumeric(ByVal txt As TextBox) As Boolean
        If IsNumeric(txt.Text) Then
            Return True
        End If

        Return False
    End Function

    Friend Function DreadKnight(ByVal str As String, Optional ByVal special As String = Nothing) As String
        str = str.Replace("'", "''")
        str = str.Replace("""", """""")

        If special <> Nothing Then
            str = str.Replace(special, "")
        End If

        Return str
    End Function

    ''' <summary>
    ''' Identify if the KeyPress is enter
    ''' </summary>
    ''' <param name="e">KeyPressEventArgs</param>
    ''' <returns>Boolean</returns>
    Friend Function isEnter(ByVal e As KeyPressEventArgs) As Boolean
        If Asc(e.KeyChar) = 13 Then
            Return True
        End If
        Return False
    End Function

    Friend Function GetCurrentAge(ByVal dob As Date) As Integer
        Dim age As Integer
        age = Today.Year - dob.Year
        If (dob > Today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Friend Function isMoney(ByVal txtBox As TextBox) As Boolean
        Dim isGood As Boolean = False

        If Double.TryParse(txtBox.Text, 0.0) Then
            isGood = True
        End If

        Return isGood
    End Function

    Friend Function GetFirstDate(ByVal curDate As Date) As Date
        Dim firstDay = DateSerial(curDate.Year, curDate.Month, 1)
        Return firstDay
    End Function

    Friend Function GetLastDate(ByVal curDate As Date) As Date
        Dim original As DateTime = curDate  ' The date you want to get the last day of the month for
        Dim lastOfMonth As DateTime = original.Date.AddDays(-(original.Day - 1)).AddMonths(1).AddDays(-1)

        Return lastOfMonth
    End Function

    Friend Function GetSAPAccount(TransName As String) As String
        Dim mySql As String, ds As DataSet
        mySql = String.Format("SELECT * FROM TBLCASH WHERE TransName = '{0}'", TransName)

        ds = LoadSQL(mySql)

        Return ds.Tables(0).Rows(0).Item("SAPACCOUNT")
    End Function

    Friend Sub UpdateSAPAccount(TRANS As String, VALUE As String)
        Dim mySql As String, fillData As String = "TBLCASH"
        mySql = "SELECT * FROM " & fillData
        mySql &= String.Format(" WHERE TRANSNAME = '{0}'", TRANS)
        '"REMARKS LIKE '%{0}%'", srcStr)
        Dim ds As DataSet = LoadSQL(mySql, fillData)
        ds = LoadSQL(mySql, fillData)

        ds.Tables(fillData).Rows(0).Item("SAPACCOUNT") = VALUE
        database.SaveEntry(ds, False)
        Console.WriteLine("SAP Account Changed")
    End Sub

    ''' <summary>
    ''' Extract Data from the database
    ''' </summary>
    ''' <param name="headers">Array of HEADERS</param>
    ''' <param name="mySql">SQL Statement</param>
    ''' <param name="dest">Excel File Destination</param>
    ''' <remarks></remarks>
    Friend Sub ExtractToExcel(headers As String(), mySql As String, dest As String)
        If dest = "" Then Exit Sub

        Dim ds As DataSet = LoadSQL(mySql)

        'Load Excel
        Dim oXL As New Excel.Application
        If oXL Is Nothing Then
            MessageBox.Show("Excel is not properly installed!!")
            Return
        End If

        Dim oWB As Excel.Workbook
        Dim oSheet As Excel.Worksheet

        oXL = CreateObject("Excel.Application")
        oXL.Visible = False

        oWB = oXL.Workbooks.Add
        oSheet = oWB.ActiveSheet
        oSheet.Name = "Inventory"

        ' ADD BRANCHCODE
        InsertArrayElement(headers, 0, "BRANCHCODE")

        ' HEADERS
        Dim cnt As Integer = 0
        For Each hr In headers
            cnt += 1 : oSheet.Cells(1, cnt).value = hr
        Next

        ' EXTRACTING
        Console.Write("Extracting")
        Dim rowCnt As Integer = 2
        For Each dr As DataRow In ds.Tables(0).Rows
            For colCnt As Integer = 0 To headers.Count - 1
                If colCnt = 0 Then
                    oSheet.Cells(rowCnt, colCnt + 1).value = ""
                Else
                    oSheet.Cells(rowCnt, colCnt + 1).value = dr(colCnt - 1) 'dr(colCnt - 1) move the column by -1
                End If
            Next
            rowCnt += 1

            Console.Write(".")
            Application.DoEvents()
        Next

        oWB.SaveAs(dest)
        oSheet = Nothing
        oWB.Close(False)
        oWB = Nothing
        oXL.Quit()
        oXL = Nothing

        Console.WriteLine("Data Extracted")
    End Sub

    Private Sub InsertArrayElement(Of T)( _
          ByRef sourceArray() As T, _
          ByVal insertIndex As Integer, _
          ByVal newValue As T)

        Dim newPosition As Integer
        Dim counter As Integer

        newPosition = insertIndex
        If (newPosition < 0) Then newPosition = 0
        If (newPosition > sourceArray.Length) Then _
           newPosition = sourceArray.Length

        Array.Resize(sourceArray, sourceArray.Length + 1)

        For counter = sourceArray.Length - 2 To newPosition Step -1
            sourceArray(counter + 1) = sourceArray(counter)
        Next counter

        sourceArray(newPosition) = newValue
    End Sub

    ' HASHTABLE FUNCTIONS
    Public Function GetIDbyName(name As String, ht As Hashtable) As Integer
        For Each dt As DictionaryEntry In ht
            If dt.Value = name Then
                Return dt.Key
            End If
        Next

        Return 0
    End Function

    Public Function GetNameByID(id As Integer, ht As Hashtable) As String
        For Each dt As DictionaryEntry In ht
            If dt.Key = id Then
                Return dt.Value
            End If
        Next

        Return "ES" & "KIE GWA" & "PO"
    End Function
    ' END - HASHTABLE FUNCTIONS

    'Public Function CheckOTP() As Boolean
    '    diagOTP.ShowDialog()
    '    diagOTP.TopMost = True
    '    'Return False
    '    Return True
    'End Function

 

    ''' <summary>
    ''' This method will separate the phone number.
    ''' </summary>
    ''' <param name="PhoneField"></param>
    ''' <param name="e"></param>
    ''' <param name="isPhone"></param>
    ''' <remarks></remarks>
    Friend Sub PhoneSeparator(ByVal PhoneField As TextBox, ByVal e As KeyPressEventArgs, Optional ByVal isPhone As Boolean = False)
        Dim charPos() As Integer = {}
        If PhoneField.Text = Nothing Then Return

        Select Case PhoneField.Text.Substring(0, 1)
            Case "0"
                charPos = {4, 8}
            Case "9"
                charPos = {3, 7} '922-797-7559
            Case "+"
                charPos = {3, 7, 11} '+63-919-797-7559
            Case "6"
                charPos = {2, 6, 10} '63-919-797-7559
        End Select
        If isPhone Then
            Select Case PhoneField.Text.Substring(0, 1)
                Case "0"
                    charPos = {3, 7}
                Case Else
                    charPos = {2, 6}
            End Select
        End If

        'For Each POS In charPos
        '    If PhoneField.TextLength = POS And Not e.KeyChar = vbBack Then
        '        PhoneField.Text &= "-"
        '        PhoneField.SelectionStart = POS + 1
        '    End If
        'Next
    End Sub

    Public Function isOTPOn(ByVal Modname As String) As Boolean
        Dim mysql As String = "Select * From OTPControl Where Modname = '" & Modname & "'"
        Dim ds As DataSet = LoadSQL(mysql, "OTPCOntrol")

        If ds.Tables(0).Rows(0).Item("Status") = 1 Then Return False

        Return True
    End Function

    Friend Function GetEloadPrice(ByVal Quantity As Double)
        Select Case Quantity
            Case 14.33, 95.56, 477.78, 95.56, 28.66, 9.55
                Return 1.0468
            Case 19.11
                Return 1.0466
            Case 286.68, 47.78
                Return 1.0465
            Case 57.33
                Return 1.046572475144
        End Select
        Return 0
    End Function


    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function

    Function Date_Calculation(ByVal EXPIRATE_DATE As Date) As Integer
        Dim ValidDate As Date = CDate(EXPIRATE_DATE)
        Dim date1 As New System.DateTime(ValidDate.Year, ValidDate.Month, ValidDate.Day)

        Dim Diff1 As System.TimeSpan = date1.Subtract(Now)

        Dim TotRemDays = (Int(Diff1.TotalDays))
        Return TotRemDays + 1
    End Function

    Public Sub CloseForms(ByVal frm As String)

        Dim formNames As New List(Of String)
        For Each Form In My.Application.OpenForms
            If Form.Name <> "frmMain" Or Not Form.name <> frm Then
                formNames.Add(Form.Name)
            End If
        Next
        For Each currentFormName As String In formNames
            Application.OpenForms(currentFormName).Close()
        Next
    End Sub
#Region "Log Module"
    Const LOG_FILE As String = "syslog.txt"
    Private Sub CreateLog()
        Dim fsEsk As New System.IO.FileStream(LOG_FILE, IO.FileMode.CreateNew)
        fsEsk.Close()
    End Sub

    Friend Sub Log_Report(ByVal str As String)
        If Not System.IO.File.Exists(LOG_FILE) Then CreateLog()

        Dim recorded_log As String = _
            String.Format("[{0}] ", Now.ToString("MM/dd/yyyy HH:mm:ss")) & str

        Dim fs As New System.IO.FileStream(LOG_FILE, IO.FileMode.Append, IO.FileAccess.Write)
        Dim fw As New System.IO.StreamWriter(fs)
        fw.WriteLine(recorded_log)
        fw.Close()
        fs.Close()
        Console.WriteLine("Recorded")
    End Sub
#End Region
End Module
