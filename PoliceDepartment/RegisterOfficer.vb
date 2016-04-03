Public Class RegisterOfficer
    Dim username As String
    Dim password As String
    Dim TxtWriter As System.IO.TextWriter
    Dim TxtReader As System.IO.TextReader
    Dim FileName As String = "password.txt"
    Dim user As String
    Dim temp As String()

    Private Sub txtCancel_Click(sender As Object, e As EventArgs) Handles txtCancel.Click
        Me.Close()
    End Sub

    Private Sub txtOK_Click(sender As Object, e As EventArgs) Handles txtOK.Click

        ErrorProvider1.Clear()

        ' Get username 
        If txtUsername.Text = "" Then
            'Show error if username is blank.
            ErrorProvider1.SetError(txtUsername, "Enter a username")
            Return
        Else
            username = txtUsername.Text
        End If

        'Get password
        If txtPassword.Text = "" Then
            'Show error if username is blank.
            ErrorProvider1.SetError(txtPassword, "Enter a password")
            Return
        End If

        'Get confrim password
        If txtConfirm.Text = "" Then
            'Show error if password is blank.
            ErrorProvider1.SetError(txtConfirm, "Enter password")
            Return
        Else

            'Check if passwords match
            If String.Equals(txtPassword.Text, txtConfirm.Text) = False Then
                ErrorProvider1.SetError(txtConfirm, "Passwords must match")
            Else
                password = txtConfirm.Text

                'Check if username already exists

                'Read password file
                TxtReader = System.IO.File.OpenText(FileName)
                'Read file line by line
                Do
                    user = TxtReader.ReadLine
                    temp = Split(user, " ")

                    ' Check if username exists
                    If String.Equals(temp(0), username) = True Then
                        'Display message username already exists.
                        MessageBox.Show("Username already exists")
                        TxtReader.Close()
                        Return
                    End If
                Loop Until user = Nothing
                TxtReader.Close()

                'Write username and password to file
                If user = Nothing Then

                    'Write password to password file
                    TxtWriter = System.IO.File.AppendText(FileName)
                    'Write default username and password to text file
                    TxtWriter.WriteLine(username & " " & password)
                    TxtWriter.Close()

                    'Confirmation message
                    MessageBox.Show("Officer has successfully been registered")

                    'Close
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub RegisterOfficer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class