Public Class AddRecord
    Dim list As List(Of Criminal)
    Dim a As Criminal
    Dim b As Record

    Public Property listC As List(Of Criminal)
        Get
            Return list
        End Get
        Set(value As List(Of Criminal))
            list = value
        End Set
    End Property
    Private Sub comboBoxReleased_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxReleased.SelectedIndexChanged
        If comboBoxReleased.SelectedItem.ToString = "Yes" Then
            lblReleaseDate.Enabled = True
            txtReleaseDate.Enabled = True
        End If
        If comboBoxReleased.SelectedItem.ToString = "No" Then
            lblReleaseDate.Enabled = False
            txtReleaseDate.Enabled = False
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ErrorProvider1.Clear()
        'Input Validation
        'Check for first name
        If txtFirstName.Text = "" Or IsNumeric(txtFirstName.Text) = True Then
            ErrorProvider1.SetError(txtFirstName, "Input proper name")
            Return
        End If
        'Check for middle name
        If IsNumeric(txtMiddleName.Text) Or txtMiddleName.Text = "" Then
            ErrorProvider1.SetError(txtMiddleName, "Input proper name")
            Return
        End If
        'Check for last name
        If IsNumeric(txtLastName.Text) Or txtLastName.Text = "" Then
            ErrorProvider1.SetError(txtLastName, "Input proper name")
            Return
        End If
        'Check for proper gender
        If ComboBoxGender.SelectedItem = Nothing Then
            ErrorProvider1.SetError(ComboBoxGender, "Select gender")
            Return
        End If
        'Check for proper age
        If IsNumeric(txtAge.Text) = False Then
            ErrorProvider1.SetError(txtAge, "Input proper age")
            Return
        End If
        'Check for ID
        If IsNumeric(txtID.Text) = False Then
            ErrorProvider1.SetError(txtID, "Input proper ID")
            Return
        End If
        'Check for proper height
        If IsNumeric(txtHeight.Text) = False Then
            ErrorProvider1.SetError(txtHeight, "Input proper height")
            Return
        End If
        'Check for proper weight
        If IsNumeric(txtWeight.Text) = False Then
            ErrorProvider1.SetError(txtWeight, "Input proper weight")
            Return
        End If
        'Check for proper eye color
        If boxEyeColor.SelectedItem = Nothing Then
            ErrorProvider1.SetError(boxEyeColor, "Select eye color")
            Return
        End If
        'Check arrest date
        If txtDateArrested.Text = "" Then
            ErrorProvider1.SetError(txtDateArrested, "Input proper arrest date")
            Return
        End If
        'Check crime commited
        If comboCrimeCommited.SelectedItem = Nothing Then
            ErrorProvider1.SetError(comboCrimeCommited, "Select crime commited")
            Return
        End If
        'Check for arresting officer
        If IsNumeric(txtArrestedBy.Text) Or txtArrestedBy.Text = "" Then
            ErrorProvider1.SetError(txtArrestedBy, "Input proper arresting officer name")
            Return
        End If
        'Check sentence length
        If boxLength.SelectedItem = Nothing Then
            ErrorProvider1.SetError(boxLength, "Select sentence length")
            Return
        End If
        'Check released informatiom
        If comboBoxReleased.SelectedItem = Nothing Then
            ErrorProvider1.SetError(comboBoxReleased, "Select if criminal has been released")
            Return
        End If
        'If criminal has been released check release date
        If comboBoxReleased.SelectedItem.ToString = "Yes" Then
            If txtReleaseDate.Text = "" Then
                ErrorProvider1.SetError(txtReleaseDate, "Enter a release date")
                Return
            End If
        End If
        'Get race
        Dim race As String
        If RadButtonWhite.Checked = True Then
            race = RadButtonWhite.ToString
        ElseIf RadButtonBlack.Checked = True Then
            race = RadButtonBlack.ToString
        ElseIf RadButtonAsian.Checked = True Then
            race = RadButtonAsian.ToString
        ElseIf RadButonHispanic.Checked = True Then
            race = RadButonHispanic.ToString
        End If

        'Add criminal 
        b = New Record(txtDateArrested.Text, comboCrimeCommited.SelectedItem.ToString, txtArrestedBy.Text, boxLength.SelectedItem.ToString, comboBoxReleased.SelectedItem.ToString, txtReleaseDate.ToString)
        a = New Criminal(txtID.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, ComboBoxGender.SelectedItem.ToString, CInt(txtAge.Text), CDbl(txtHeight.Text), CDbl(txtWeight.Text), boxEyeColor.SelectedItem.ToString, race, b)
        list.Add(a)
        MessageBox.Show("You have successfully added the criminal record to the database.")
        Me.Close()
    End Sub

    Private Sub AddRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CriminalDatebaseDataSet.CriminalTable' table. You can move, or remove it, as needed.
        Me.CriminalTableTableAdapter.Fill(Me.CriminalDatebaseDataSet.CriminalTable)
        'TODO: This line of code loads data into the 'CriminalDatebaseDataSet.CriminalTable' table. You can move, or remove it, as needed.
        Me.CriminalTableTableAdapter.Fill(Me.CriminalDatebaseDataSet.CriminalTable)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CriminalTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CriminalTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CriminalDatebaseDataSet)

    End Sub

    Private Sub CriminalTableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CriminalTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CriminalDatebaseDataSet)

    End Sub
End Class