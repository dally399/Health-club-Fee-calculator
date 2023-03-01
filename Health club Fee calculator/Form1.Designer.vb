<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        radSenior = New RadioButton()
        radStudent = New RadioButton()
        radChild = New RadioButton()
        radAdult = New RadioButton()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        chkTrainer = New CheckBox()
        chkKarate = New CheckBox()
        chkYoga = New CheckBox()
        GroupBox3 = New GroupBox()
        txtMonths = New TextBox()
        Label2 = New Label()
        GroupBox4 = New GroupBox()
        lblMonthlyFee = New Label()
        lblTotalFee = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(radSenior)
        GroupBox1.Controls.Add(radStudent)
        GroupBox1.Controls.Add(radChild)
        GroupBox1.Controls.Add(radAdult)
        GroupBox1.Location = New Point(200, 69)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(218, 205)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Type of Membership"' 
        ' radSenior
        ' 
        radSenior.AutoSize = True
        radSenior.Location = New Point(27, 139)
        radSenior.Name = "radSenior"
        radSenior.Size = New Size(121, 24)
        radSenior.TabIndex = 3
        radSenior.TabStop = True
        radSenior.Text = "Senior Citizen"
        radSenior.UseVisualStyleBackColor = True
        ' 
        ' radStudent
        ' 
        radStudent.AutoSize = True
        radStudent.Location = New Point(27, 109)
        radStudent.Name = "radStudent"
        radStudent.Size = New Size(81, 24)
        radStudent.TabIndex = 2
        radStudent.TabStop = True
        radStudent.Text = "Student"
        radStudent.UseVisualStyleBackColor = True
        ' 
        ' radChild
        ' 
        radChild.AutoSize = True
        radChild.Location = New Point(27, 79)
        radChild.Name = "radChild"
        radChild.Size = New Size(140, 24)
        radChild.TabIndex = 1
        radChild.TabStop = True
        radChild.Text = "Child (12 & under)"
        radChild.UseVisualStyleBackColor = True
        ' 
        ' radAdult
        ' 
        radAdult.AutoSize = True
        radAdult.Location = New Point(27, 49)
        radAdult.Name = "radAdult"
        radAdult.Size = New Size(130, 24)
        radAdult.TabIndex = 0
        radAdult.TabStop = True
        radAdult.Text = "Standard Adult"
        radAdult.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(297, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 25)
        Label1.TabIndex = 1
        Label1.Text = "Membership fee calculator"' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Control
        GroupBox2.Controls.Add(chkTrainer)
        GroupBox2.Controls.Add(chkKarate)
        GroupBox2.Controls.Add(chkYoga)
        GroupBox2.Location = New Point(460, 69)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(223, 205)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Options"' 
        ' chkTrainer
        ' 
        chkTrainer.AutoSize = True
        chkTrainer.Location = New Point(60, 109)
        chkTrainer.Name = "chkTrainer"
        chkTrainer.Size = New Size(135, 24)
        chkTrainer.TabIndex = 2
        chkTrainer.Text = "Personal Trainer"
        chkTrainer.UseVisualStyleBackColor = True
        ' 
        ' chkKarate
        ' 
        chkKarate.AutoSize = True
        chkKarate.Location = New Point(60, 79)
        chkKarate.Name = "chkKarate"
        chkKarate.Size = New Size(74, 24)
        chkKarate.TabIndex = 1
        chkKarate.Text = "Karate"
        chkKarate.UseVisualStyleBackColor = True
        ' 
        ' chkYoga
        ' 
        chkYoga.AutoSize = True
        chkYoga.Location = New Point(60, 49)
        chkYoga.Name = "chkYoga"
        chkYoga.Size = New Size(64, 24)
        chkYoga.TabIndex = 0
        chkYoga.Text = "Yoga"
        chkYoga.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtMonths)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Location = New Point(200, 298)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(218, 169)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Membership Length"' 
        ' txtMonths
        ' 
        txtMonths.Location = New Point(10, 85)
        txtMonths.Name = "txtMonths"
        txtMonths.Size = New Size(193, 27)
        txtMonths.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(197, 20)
        Label2.TabIndex = 0
        Label2.Text = "Enter the Number of Months"' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lblMonthlyFee)
        GroupBox4.Controls.Add(lblTotalFee)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Location = New Point(460, 298)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(223, 169)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "Membership fees"' 
        ' lblMonthlyFee
        ' 
        lblMonthlyFee.AutoSize = True
        lblMonthlyFee.BackColor = SystemColors.ButtonShadow
        lblMonthlyFee.Location = New Point(110, 49)
        lblMonthlyFee.Name = "lblMonthlyFee"
        lblMonthlyFee.Size = New Size(0, 20)
        lblMonthlyFee.TabIndex = 3
        ' 
        ' lblTotalFee
        ' 
        lblTotalFee.AutoSize = True
        lblTotalFee.BackColor = SystemColors.ButtonShadow
        lblTotalFee.Location = New Point(110, 92)
        lblTotalFee.Name = "lblTotalFee"
        lblTotalFee.Size = New Size(0, 20)
        lblTotalFee.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 1
        Label4.Text = "Totals"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 0
        Label3.Text = "Monthly Fee:"' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(227, 493)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(399, 493)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(554, 493)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 7
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(874, 622)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Membership fee Calculator"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents lblTotalFee As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
