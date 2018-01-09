Public Class frmDec
    Dim i As Integer = 100000
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Win32.AllocConsole()
            ' Win32.FreeConsole()

            For ii As Integer = 0 To i
                Console.WriteLine("Running! Count: " & ii)
            Next
        Else
            Win32.FreeConsole()
        End If
        Win32.FreeConsole()
    End Sub
End Class