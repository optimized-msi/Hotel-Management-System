Imports System.Runtime.InteropServices
Public Class Win32
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean

    End Function
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean

    End Function
End Class
