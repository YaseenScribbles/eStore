Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class ClsEncodeDecode

    'Shared bytes As Byte() = ASCIIEncoding.ASCII.GetBytes("ZeroCool")

    'Public Shared Function Encrypt(ByVal originalString As String) As String
    '    If [String].IsNullOrEmpty(originalString) Then
    '        Throw New ArgumentNullException("The string which needs to be encrypted can not be null.")
    '    End If
    '    Dim cryptoProvider As New DESCryptoServiceProvider()
    '    Dim memoryStream As New MemoryStream()
    '    Dim cryptoStream As New CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write)
    '    Dim writer As New StreamWriter(cryptoStream)
    '    writer.Write(originalString)
    '    writer.Flush()
    '    cryptoStream.FlushFinalBlock()
    '    writer.Flush()
    '    Return Convert.ToBase64String(memoryStream.GetBuffer(), 0, CInt(memoryStream.Length))
    'End Function

    'Public Shared Function Decrypt(ByVal cryptedString As String) As String
    '    If [String].IsNullOrEmpty(cryptedString) Then
    '        Throw New ArgumentNullException("The string which needs to be encrypted can not be null.")
    '    End If
    '    Dim cryptoProvider As New DESCryptoServiceProvider()
    '    Dim memoryStream As New MemoryStream(Convert.ToBase64String(cryptedString))
    '    Dim cryptoStream As New CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read)
    '    Dim reader As New StreamReader(cryptoStream)
    '    Return reader.ReadToEnd()
    'End Function

    Public Shared Function Encode(ByVal InputValue As String) As String

        Dim Tmp As String = ""

        For i As Byte = 1 To InputValue.Length
            Tmp &= Chr(Asc(Mid(InputValue, i, i)) + 17)
        Next

        Return Tmp

    End Function

    Public Shared Function DCode(ByVal InputValue As String) As String

        Dim Tmp As String = ""

        For i As Byte = 1 To InputValue.Length
            Tmp &= Chr(Asc(Mid(InputValue, i, i)) - 17)
        Next

        Return Tmp

    End Function

End Class
