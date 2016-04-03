Public Class Form1
    'Create list of criminals
    Dim iCriminal As New List(Of Criminal)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Show login form
        login.Show()


        'Disable toolstip items besides login 
        CriminalRecordToolStripMenuItem.Enabled = False
        RegiserOfficerToolStripMenuItem.Enabled = False

        AboutToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False


    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        'Show login form
        Login.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        'Disable toolstip items besides login 
        CriminalRecordToolStripMenuItem.Enabled = False
        RegiserOfficerToolStripMenuItem.Enabled = False
        AboutToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True

        'Show logout message
        MessageBox.Show("You have successfully been logged out")

    End Sub

    Private Sub RegiserOfficerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegiserOfficerToolStripMenuItem.Click
        'Show register officer form
        RegisterOfficer.Show()
    End Sub

    Private Sub CriminalRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriminalRecordToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRecordToolStripMenuItem.Click
        'Pass list of criminals to addRecord
        AddRecord.listC = iCriminal
        AddRecord.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This project was created by Conner Shepherd to emulate a criminal record system.")
    End Sub

    Private Sub ViewRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordToolStripMenuItem.Click
        'Pass list of criminals to search

        'Show form
        SearchRecords.Show()
    End Sub

    Private Sub PrintRecordToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class
