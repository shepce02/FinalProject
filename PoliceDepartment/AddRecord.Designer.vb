<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.boxRace = New System.Windows.Forms.GroupBox()
        Me.RadButtonWhite = New System.Windows.Forms.RadioButton()
        Me.RadButtonBlack = New System.Windows.Forms.RadioButton()
        Me.RadButonHispanic = New System.Windows.Forms.RadioButton()
        Me.RadButtonAsian = New System.Windows.Forms.RadioButton()
        Me.lblEyeColor = New System.Windows.Forms.Label()
        Me.boxEyeColor = New System.Windows.Forms.ComboBox()
        Me.lblDateArr = New System.Windows.Forms.Label()
        Me.txtDateArrested = New System.Windows.Forms.TextBox()
        Me.lblCrimeCommited = New System.Windows.Forms.Label()
        Me.comboCrimeCommited = New System.Windows.Forms.ComboBox()
        Me.lblArrestingOfficer = New System.Windows.Forms.Label()
        Me.txtArrestedBy = New System.Windows.Forms.TextBox()
        Me.GroupArrestInfo = New System.Windows.Forms.GroupBox()
        Me.GroupJudgedment = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxLength = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboBoxReleased = New System.Windows.Forms.ComboBox()
        Me.lblReleaseDate = New System.Windows.Forms.Label()
        Me.txtReleaseDate = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.boxRace.SuspendLayout()
        Me.GroupArrestInfo.SuspendLayout()
        Me.GroupJudgedment.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(26, 30)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(12, 82)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(90, 17)
        Me.lblMiddleName.TabIndex = 1
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(26, 134)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 17)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(117, 30)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(183, 22)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(117, 134)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(183, 22)
        Me.txtLastName.TabIndex = 3
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(117, 82)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(183, 22)
        Me.txtMiddleName.TabIndex = 2
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(46, 189)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(56, 17)
        Me.lblGender.TabIndex = 6
        Me.lblGender.Text = "Gender"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(117, 189)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(81, 24)
        Me.ComboBoxGender.TabIndex = 4
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(233, 192)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 17)
        Me.lblAge.TabIndex = 8
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(281, 189)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(46, 22)
        Me.txtAge.TabIndex = 5
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(46, 229)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(71, 17)
        Me.lblHeight.TabIndex = 10
        Me.lblHeight.Text = "Height (ft)"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(117, 229)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(59, 22)
        Me.txtHeight.TabIndex = 6
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(191, 229)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(84, 17)
        Me.lblWeight.TabIndex = 12
        Me.lblWeight.Text = "Weight (lbs)"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(281, 229)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(46, 22)
        Me.txtWeight.TabIndex = 7
        '
        'boxRace
        '
        Me.boxRace.Controls.Add(Me.RadButtonAsian)
        Me.boxRace.Controls.Add(Me.RadButonHispanic)
        Me.boxRace.Controls.Add(Me.RadButtonBlack)
        Me.boxRace.Controls.Add(Me.RadButtonWhite)
        Me.boxRace.Location = New System.Drawing.Point(76, 326)
        Me.boxRace.Name = "boxRace"
        Me.boxRace.Size = New System.Drawing.Size(224, 118)
        Me.boxRace.TabIndex = 9
        Me.boxRace.TabStop = False
        Me.boxRace.Text = "Race"
        '
        'RadButtonWhite
        '
        Me.RadButtonWhite.AutoSize = True
        Me.RadButtonWhite.Checked = True
        Me.RadButtonWhite.Location = New System.Drawing.Point(24, 30)
        Me.RadButtonWhite.Name = "RadButtonWhite"
        Me.RadButtonWhite.Size = New System.Drawing.Size(65, 21)
        Me.RadButtonWhite.TabIndex = 0
        Me.RadButtonWhite.TabStop = True
        Me.RadButtonWhite.Text = "White"
        Me.RadButtonWhite.UseVisualStyleBackColor = True
        '
        'RadButtonBlack
        '
        Me.RadButtonBlack.AutoSize = True
        Me.RadButtonBlack.Location = New System.Drawing.Point(118, 30)
        Me.RadButtonBlack.Name = "RadButtonBlack"
        Me.RadButtonBlack.Size = New System.Drawing.Size(63, 21)
        Me.RadButtonBlack.TabIndex = 1
        Me.RadButtonBlack.Text = "Black"
        Me.RadButtonBlack.UseVisualStyleBackColor = True
        '
        'RadButonHispanic
        '
        Me.RadButonHispanic.AutoSize = True
        Me.RadButonHispanic.Location = New System.Drawing.Point(24, 71)
        Me.RadButonHispanic.Name = "RadButonHispanic"
        Me.RadButonHispanic.Size = New System.Drawing.Size(83, 21)
        Me.RadButonHispanic.TabIndex = 15
        Me.RadButonHispanic.Text = "Hispanic"
        Me.RadButonHispanic.UseVisualStyleBackColor = True
        '
        'RadButtonAsian
        '
        Me.RadButtonAsian.AutoSize = True
        Me.RadButtonAsian.Location = New System.Drawing.Point(118, 71)
        Me.RadButtonAsian.Name = "RadButtonAsian"
        Me.RadButtonAsian.Size = New System.Drawing.Size(64, 21)
        Me.RadButtonAsian.TabIndex = 16
        Me.RadButtonAsian.Text = "Asian"
        Me.RadButtonAsian.UseVisualStyleBackColor = True
        '
        'lblEyeColor
        '
        Me.lblEyeColor.AutoSize = True
        Me.lblEyeColor.Location = New System.Drawing.Point(46, 275)
        Me.lblEyeColor.Name = "lblEyeColor"
        Me.lblEyeColor.Size = New System.Drawing.Size(69, 17)
        Me.lblEyeColor.TabIndex = 15
        Me.lblEyeColor.Text = "Eye Color"
        '
        'boxEyeColor
        '
        Me.boxEyeColor.FormattingEnabled = True
        Me.boxEyeColor.Items.AddRange(New Object() {"Blue", "Green", "Brown", "Grey"})
        Me.boxEyeColor.Location = New System.Drawing.Point(121, 275)
        Me.boxEyeColor.Name = "boxEyeColor"
        Me.boxEyeColor.Size = New System.Drawing.Size(81, 24)
        Me.boxEyeColor.TabIndex = 8
        '
        'lblDateArr
        '
        Me.lblDateArr.AutoSize = True
        Me.lblDateArr.Location = New System.Drawing.Point(20, 38)
        Me.lblDateArr.Name = "lblDateArr"
        Me.lblDateArr.Size = New System.Drawing.Size(96, 17)
        Me.lblDateArr.TabIndex = 17
        Me.lblDateArr.Text = "Date Arrested"
        '
        'txtDateArrested
        '
        Me.txtDateArrested.Location = New System.Drawing.Point(136, 38)
        Me.txtDateArrested.Name = "txtDateArrested"
        Me.txtDateArrested.Size = New System.Drawing.Size(183, 22)
        Me.txtDateArrested.TabIndex = 10
        '
        'lblCrimeCommited
        '
        Me.lblCrimeCommited.AutoSize = True
        Me.lblCrimeCommited.Location = New System.Drawing.Point(11, 80)
        Me.lblCrimeCommited.Name = "lblCrimeCommited"
        Me.lblCrimeCommited.Size = New System.Drawing.Size(110, 17)
        Me.lblCrimeCommited.TabIndex = 19
        Me.lblCrimeCommited.Text = "Crime Commited"
        '
        'comboCrimeCommited
        '
        Me.comboCrimeCommited.FormattingEnabled = True
        Me.comboCrimeCommited.Items.AddRange(New Object() {"Aiding & Abetting / Accessory", "Arson", "Aggravated Assault / Battery", "Attempt", "Assault / Battery", "Bribery", "Burglary", "Child Abandonment", "Child Abuse", "Child Pornography", "Computer Crime", "Conspiracy", "Credit / Debit Card Fraud", "Criminal Contempt of Court", "Cyber Bullying", "Disorderly Conduct", "Disturbing the Peace", "Domestic Violence", "Drug Manufacturing and Cultivation", "Drug Possession", "Drug Trafficking / Distribution", "DUI / DWI", "Embezzlement", "Extortion", "Forgery", "Fraud", "Harassment", "Hate Crimes", "Homicide", "Indecent Exposure", "Identity Theft", "Insurance Fraud", "Kidnapping", "Manslaughter: Involuntary", "Manslaughter: Voluntary", "Medical Marijuana", "MIP: A Minor in Possession", "Money Laundering", "Murder: First-degree", "Murder: Second-degree", "Open Container Law", "Perjury", "Probation Violation", "Prostitution", "Public Intoxication", "Pyramid Schemes", "Racketeering / RICO", "Rape", "Robbery", "Securities Fraud", "Sexual Assault", "Shoplifting", "Solicitation", "Stalking", "Statutory Rape", "Tax Evasion / Fraud", "Theft / Larceny", "Telemarketing Fraud", "Vandalism", "White Collar Crimes", "Wire Fraud"})
        Me.comboCrimeCommited.Location = New System.Drawing.Point(136, 80)
        Me.comboCrimeCommited.Name = "comboCrimeCommited"
        Me.comboCrimeCommited.Size = New System.Drawing.Size(183, 24)
        Me.comboCrimeCommited.TabIndex = 11
        '
        'lblArrestingOfficer
        '
        Me.lblArrestingOfficer.AutoSize = True
        Me.lblArrestingOfficer.Location = New System.Drawing.Point(34, 121)
        Me.lblArrestingOfficer.Name = "lblArrestingOfficer"
        Me.lblArrestingOfficer.Size = New System.Drawing.Size(82, 17)
        Me.lblArrestingOfficer.TabIndex = 21
        Me.lblArrestingOfficer.Text = "Arrested By"
        '
        'txtArrestedBy
        '
        Me.txtArrestedBy.Location = New System.Drawing.Point(136, 121)
        Me.txtArrestedBy.Name = "txtArrestedBy"
        Me.txtArrestedBy.Size = New System.Drawing.Size(183, 22)
        Me.txtArrestedBy.TabIndex = 12
        '
        'GroupArrestInfo
        '
        Me.GroupArrestInfo.Controls.Add(Me.lblDateArr)
        Me.GroupArrestInfo.Controls.Add(Me.txtArrestedBy)
        Me.GroupArrestInfo.Controls.Add(Me.txtDateArrested)
        Me.GroupArrestInfo.Controls.Add(Me.lblArrestingOfficer)
        Me.GroupArrestInfo.Controls.Add(Me.lblCrimeCommited)
        Me.GroupArrestInfo.Controls.Add(Me.comboCrimeCommited)
        Me.GroupArrestInfo.Location = New System.Drawing.Point(370, 21)
        Me.GroupArrestInfo.Name = "GroupArrestInfo"
        Me.GroupArrestInfo.Size = New System.Drawing.Size(348, 160)
        Me.GroupArrestInfo.TabIndex = 23
        Me.GroupArrestInfo.TabStop = False
        Me.GroupArrestInfo.Text = "Arrest Information"
        '
        'GroupJudgedment
        '
        Me.GroupJudgedment.Controls.Add(Me.txtReleaseDate)
        Me.GroupJudgedment.Controls.Add(Me.lblReleaseDate)
        Me.GroupJudgedment.Controls.Add(Me.comboBoxReleased)
        Me.GroupJudgedment.Controls.Add(Me.Label2)
        Me.GroupJudgedment.Controls.Add(Me.boxLength)
        Me.GroupJudgedment.Controls.Add(Me.Label1)
        Me.GroupJudgedment.Location = New System.Drawing.Point(370, 262)
        Me.GroupJudgedment.Name = "GroupJudgedment"
        Me.GroupJudgedment.Size = New System.Drawing.Size(348, 182)
        Me.GroupJudgedment.TabIndex = 24
        Me.GroupJudgedment.TabStop = False
        Me.GroupJudgedment.Text = "Judgement Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sentenced"
        '
        'boxLength
        '
        Me.boxLength.AutoCompleteCustomSource.AddRange(New String() {"1 Month", "2 Months", "3 Months", "4 Months", "5 Months", "6 Months", "7 Months", "8 Months", "9 Months", "10 Months", "11 Months", "1 Year", "2 Years", "3 Years", "4 Years", "5 Years", "6 Years", "7 Years", "8 Years", "9 Years", "10 Years", "11 Years", "12 Years", "13 Years", "14 Years", "15+ Years"})
        Me.boxLength.FormattingEnabled = True
        Me.boxLength.ItemHeight = 16
        Me.boxLength.Items.AddRange(New Object() {"1 month", "2 months", "3 months", "4 months", "5 months", "6 months", "7 months", "8 months", "9 months", "10 months", "11 months", "1 year", "2 years", "3 years", "4 years", "5 years", "6 years", "7 years", "8 years", "9 years", "10 years", "10+ years"})
        Me.boxLength.Location = New System.Drawing.Point(136, 42)
        Me.boxLength.Name = "boxLength"
        Me.boxLength.Size = New System.Drawing.Size(183, 24)
        Me.boxLength.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Released"
        '
        'comboBoxReleased
        '
        Me.comboBoxReleased.FormattingEnabled = True
        Me.comboBoxReleased.ItemHeight = 16
        Me.comboBoxReleased.Items.AddRange(New Object() {"Yes", "No"})
        Me.comboBoxReleased.Location = New System.Drawing.Point(136, 89)
        Me.comboBoxReleased.Name = "comboBoxReleased"
        Me.comboBoxReleased.Size = New System.Drawing.Size(81, 24)
        Me.comboBoxReleased.TabIndex = 23
        '
        'lblReleaseDate
        '
        Me.lblReleaseDate.AutoSize = True
        Me.lblReleaseDate.Enabled = False
        Me.lblReleaseDate.Location = New System.Drawing.Point(14, 130)
        Me.lblReleaseDate.Name = "lblReleaseDate"
        Me.lblReleaseDate.Size = New System.Drawing.Size(102, 17)
        Me.lblReleaseDate.TabIndex = 24
        Me.lblReleaseDate.Text = "Released Date"
        '
        'txtReleaseDate
        '
        Me.txtReleaseDate.Enabled = False
        Me.txtReleaseDate.Location = New System.Drawing.Point(136, 130)
        Me.txtReleaseDate.Name = "txtReleaseDate"
        Me.txtReleaseDate.Size = New System.Drawing.Size(183, 22)
        Me.txtReleaseDate.TabIndex = 15
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(191, 480)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(136, 34)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(370, 480)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 34)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 545)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupJudgedment)
        Me.Controls.Add(Me.GroupArrestInfo)
        Me.Controls.Add(Me.boxEyeColor)
        Me.Controls.Add(Me.lblEyeColor)
        Me.Controls.Add(Me.boxRace)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.ComboBoxGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "AddRecord"
        Me.Text = "Add Criminal Record"
        Me.TopMost = True
        Me.boxRace.ResumeLayout(False)
        Me.boxRace.PerformLayout()
        Me.GroupArrestInfo.ResumeLayout(False)
        Me.GroupArrestInfo.PerformLayout()
        Me.GroupJudgedment.ResumeLayout(False)
        Me.GroupJudgedment.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblMiddleName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents ComboBoxGender As System.Windows.Forms.ComboBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents lblHeight As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents boxRace As System.Windows.Forms.GroupBox
    Friend WithEvents RadButonHispanic As System.Windows.Forms.RadioButton
    Friend WithEvents RadButtonBlack As System.Windows.Forms.RadioButton
    Friend WithEvents RadButtonWhite As System.Windows.Forms.RadioButton
    Friend WithEvents RadButtonAsian As System.Windows.Forms.RadioButton
    Friend WithEvents lblEyeColor As System.Windows.Forms.Label
    Friend WithEvents boxEyeColor As System.Windows.Forms.ComboBox
    Friend WithEvents lblDateArr As System.Windows.Forms.Label
    Friend WithEvents txtDateArrested As System.Windows.Forms.TextBox
    Friend WithEvents lblCrimeCommited As System.Windows.Forms.Label
    Friend WithEvents comboCrimeCommited As System.Windows.Forms.ComboBox
    Friend WithEvents lblArrestingOfficer As System.Windows.Forms.Label
    Friend WithEvents txtArrestedBy As System.Windows.Forms.TextBox
    Friend WithEvents GroupArrestInfo As System.Windows.Forms.GroupBox
    Friend WithEvents GroupJudgedment As System.Windows.Forms.GroupBox
    Friend WithEvents txtReleaseDate As System.Windows.Forms.TextBox
    Friend WithEvents lblReleaseDate As System.Windows.Forms.Label
    Friend WithEvents comboBoxReleased As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boxLength As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
