Public Class Login
    Dim TxtReader As System.IO.TextReader
    Dim TxtWriter As System.IO.TextWriter
    Dim FileName As String = "password.txt"
    Dim user As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsername.Select()

        'Check if password file does not exist.
        If System.IO.File.Exists(FileName) = False Then
            'Create text file
            TxtWriter = System.IO.File.CreateText(FileName)
            'Write default username and password to text file
            TxtWriter.Write("admin" & " " & "123456")
            TxtWriter.Close()
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        ErrorProvider1.Clear()

        'Read password file
        TxtReader = System.IO.File.OpenText(FileName)

        'Check if username is blank
        If txtUsername.Text = "" Then
            ErrorProvider1.SetError(txtUsername, "Enter a username")
            Return
        End If

        'Check if password is blank
        If txtPassword.Text = "" Then
            ErrorProvider1.SetError(txtPassword, "Enter a password")

            Return
        End If
        'Read file line by line
        Do
            user = TxtReader.ReadLine

            ' Check if username and password match
            If user = txtUsername.Text & " " & txtPassword.Text Then
                TxtReader.Close()
                Me.Close()

                'Enable all menu items but login
                Form1.CriminalRecordToolStripMenuItem.Enabled = True
                Form1.RegiserOfficerToolStripMenuItem.Enabled = True

                Form1.AboutToolStripMenuItem.Enabled = True
                Form1.LogoutToolStripMenuItem.Enabled = True
                Form1.LoginToolStripMenuItem.Enabled = False
                Return
            End If

        Loop Until user = Nothing

        If user = Nothing Then
            MessageBox.Show("Username or Password is incorrect")
            txtUsername.Text = ""
            txtPassword.Text = ""
            TxtReader.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class