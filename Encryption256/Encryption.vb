Imports System.Security.Cryptography
Imports System.Text

Public Class Entryption

    ''' <summary>
    ''' Encrypt plain string using 128 bit MD5 hashed key
    ''' </summary>
    ''' <param name="value">plain text</param>
    ''' <param name="key">encryption key</param>
    ''' <returns>encrypted text</returns>
    Public Shared Function TripleDES_Encode_128(ByVal value As String, ByVal key As String) As String

        If value.Trim = "" Then
            Return ""
        End If

        Dim des As New TripleDESCryptoServiceProvider

        If (des.IV Is Nothing) Then
            des.GenerateIV()
        End If
        des.IV = New Byte(des.IV.Length - 1) {}

        Dim pdb As New PasswordDeriveBytes(key, New Byte(-1) {})
        des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, New Byte(7) {})
        'des.Key = pdb.CryptDeriveKey("RC2", "MD5", 256, New Byte(7) {})

        Dim ms As New IO.MemoryStream((value.Length * 2) - 1)
        Dim encStream As New CryptoStream(ms, des.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        Dim plainBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(value)

        encStream.Write(plainBytes, 0, plainBytes.Length)
        encStream.FlushFinalBlock()

        Dim encryptedBytes(CInt(ms.Length - 1)) As Byte

        ms.Position = 0
        ms.Read(encryptedBytes, 0, CInt(ms.Length))
        encStream.Close()

        Return Convert.ToBase64String(encryptedBytes)

    End Function

    ''' <summary>
    ''' Decode encrypted text using 128 bit MD5 hashed key
    ''' </summary>
    ''' <param name="value">encrypted text</param>
    ''' <param name="key">encryption key</param>
    ''' <returns>plain text</returns>
    Public Shared Function TripleDES_Decode_128(ByVal value As String, ByVal key As String) As String
        If value.Trim = "" Then
            Return ""
        End If
        Dim des As New TripleDESCryptoServiceProvider

        If (des.IV Is Nothing) Then
            des.GenerateIV()
        End If
        des.IV = New Byte(des.IV.Length - 1) {}

        Dim pdb As New PasswordDeriveBytes(key, New Byte(-1) {})

        des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, New Byte(7) {})
        'des.Key = pdb.CryptDeriveKey("RC2", "MD5", 256, New Byte(7) {})

        Dim encryptedBytes As Byte() = Convert.FromBase64String(value)
        Dim ms As New IO.MemoryStream(value.Length)

        Dim decStream As New CryptoStream(ms, des.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        Dim plainBytes(CInt(ms.Length - 1)) As Byte
        ms.Position = 0
        ms.Read(plainBytes, 0, CInt(ms.Length))
        decStream.Close()

        Return System.Text.Encoding.UTF8.GetString(plainBytes)

    End Function

    ''' <summary>
    ''' Encrypt plain string using 256 bit SHA256 hashed key
    ''' </summary>
    ''' <param name="value">plain text</param>
    ''' <param name="key">encryption key</param>
    ''' <returns>encrypted text</returns>
    Public Shared Function AES_Encode_256(ByVal value As String, ByVal key As String) As String

        If value.Trim = "" Then
            Return ""
        End If

        Dim aes As New AesCryptoServiceProvider

        If (aes.IV Is Nothing) Then
            aes.GenerateIV()
        End If
        aes.IV = New Byte(aes.IV.Length - 1) {}

        Dim sha As SHA256 = SHA256Managed.Create()
        Dim passwordBytes = Encoding.Unicode.GetBytes(key)
        aes.Key = sha.ComputeHash(passwordBytes)

        Dim ms As New IO.MemoryStream((value.Length * 2) - 1)
        Dim encStream As New CryptoStream(ms, aes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        Dim plainBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(value)

        encStream.Write(plainBytes, 0, plainBytes.Length)
        encStream.FlushFinalBlock()

        Dim encryptedBytes(CInt(ms.Length - 1)) As Byte

        ms.Position = 0
        ms.Read(encryptedBytes, 0, CInt(ms.Length))
        encStream.Close()

        Return Convert.ToBase64String(encryptedBytes)

    End Function

    ''' <summary>
    ''' Decode encrypted text using 256 bit SHA256 hashed key
    ''' </summary>
    ''' <param name="value">encrypted text</param>
    ''' <param name="key">encryption key</param>
    ''' <returns>plain text</returns>
    Public Shared Function AES_Decode_256(ByVal value As String, ByVal key As String) As String
        If value.Trim = "" Then
            Return ""
        End If

        Dim aes As New AesCryptoServiceProvider

        If (aes.IV Is Nothing) Then
            aes.GenerateIV()
        End If
        aes.IV = New Byte(aes.IV.Length - 1) {}

        Dim sha As SHA256 = SHA256Managed.Create()
        Dim passwordBytes = Encoding.Unicode.GetBytes(key)
        aes.Key = sha.ComputeHash(passwordBytes)

        Dim encryptedBytes As Byte() = Convert.FromBase64String(value)
        Dim ms As New IO.MemoryStream(value.Length)

        Dim decStream As New CryptoStream(ms, aes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        Dim plainBytes(CInt(ms.Length - 1)) As Byte
        ms.Position = 0
        ms.Read(plainBytes, 0, CInt(ms.Length))
        decStream.Close()

        Return System.Text.Encoding.UTF8.GetString(plainBytes)

    End Function

End Class
