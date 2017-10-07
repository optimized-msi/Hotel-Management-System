Public Class frmDec

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Win32.AllocConsole()
            Console.WriteLine("Running!")
        Else
            Win32.FreeConsole()
        End If
    End Sub
End Class