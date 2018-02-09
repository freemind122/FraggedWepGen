<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.SkillGB = New System.Windows.Forms.GroupBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.SARB = New System.Windows.Forms.RadioButton()
        Me.HARB = New System.Windows.Forms.RadioButton()
        Me.TRB = New System.Windows.Forms.RadioButton()
        Me.ERB = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NameTB = New System.Windows.Forms.Label()
        Me.HitBox = New System.Windows.Forms.NumericUpDown()
        Me.HitLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown5 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown6 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown7 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NumericUpDown8 = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.SkillGB.SuspendLayout()
        CType(Me.HitBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkillGB
        '
        Me.SkillGB.Controls.Add(Me.ERB)
        Me.SkillGB.Controls.Add(Me.TRB)
        Me.SkillGB.Controls.Add(Me.HARB)
        Me.SkillGB.Controls.Add(Me.SARB)
        Me.SkillGB.Location = New System.Drawing.Point(25, 38)
        Me.SkillGB.Name = "SkillGB"
        Me.SkillGB.Size = New System.Drawing.Size(300, 49)
        Me.SkillGB.TabIndex = 0
        Me.SkillGB.TabStop = False
        Me.SkillGB.Text = "Skill"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(13, 13)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(70, 13)
        Me.TitleLabel.TabIndex = 1
        Me.TitleLabel.Text = "Add Weapon"
        '
        'SARB
        '
        Me.SARB.AutoSize = True
        Me.SARB.Location = New System.Drawing.Point(6, 19)
        Me.SARB.Name = "SARB"
        Me.SARB.Size = New System.Drawing.Size(76, 17)
        Me.SARB.TabIndex = 0
        Me.SARB.TabStop = True
        Me.SARB.Text = "Small Arms"
        Me.SARB.UseVisualStyleBackColor = True
        '
        'HARB
        '
        Me.HARB.AutoSize = True
        Me.HARB.Location = New System.Drawing.Point(88, 19)
        Me.HARB.Name = "HARB"
        Me.HARB.Size = New System.Drawing.Size(82, 17)
        Me.HARB.TabIndex = 1
        Me.HARB.TabStop = True
        Me.HARB.Text = "Heavy Arms"
        Me.HARB.UseVisualStyleBackColor = True
        '
        'TRB
        '
        Me.TRB.AutoSize = True
        Me.TRB.Location = New System.Drawing.Point(176, 19)
        Me.TRB.Name = "TRB"
        Me.TRB.Size = New System.Drawing.Size(63, 17)
        Me.TRB.TabIndex = 2
        Me.TRB.TabStop = True
        Me.TRB.Text = "Tactical"
        Me.TRB.UseVisualStyleBackColor = True
        '
        'ERB
        '
        Me.ERB.AutoSize = True
        Me.ERB.Location = New System.Drawing.Point(245, 19)
        Me.ERB.Name = "ERB"
        Me.ERB.Size = New System.Drawing.Size(54, 17)
        Me.ERB.TabIndex = 3
        Me.ERB.TabStop = True
        Me.ERB.Text = "Exotic"
        Me.ERB.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(25, 121)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 2
        '
        'NameTB
        '
        Me.NameTB.AutoSize = True
        Me.NameTB.Location = New System.Drawing.Point(25, 102)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(35, 13)
        Me.NameTB.TabIndex = 3
        Me.NameTB.Text = "Name"
        '
        'HitBox
        '
        Me.HitBox.Location = New System.Drawing.Point(178, 120)
        Me.HitBox.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.HitBox.Name = "HitBox"
        Me.HitBox.Size = New System.Drawing.Size(52, 20)
        Me.HitBox.TabIndex = 4
        '
        'HitLbl
        '
        Me.HitLbl.AutoSize = True
        Me.HitLbl.Location = New System.Drawing.Point(178, 101)
        Me.HitLbl.Name = "HitLbl"
        Me.HitLbl.Size = New System.Drawing.Size(20, 13)
        Me.HitLbl.TabIndex = 5
        Me.HitLbl.Text = "Hit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "End Dmg"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(236, 120)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Crit"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(294, 120)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Rng"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(352, 120)
        Me.NumericUpDown3.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown3.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(410, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Clips"
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(410, 120)
        Me.NumericUpDown4.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown4.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(504, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Ammo"
        '
        'NumericUpDown5
        '
        Me.NumericUpDown5.Location = New System.Drawing.Point(504, 120)
        Me.NumericUpDown5.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown5.Name = "NumericUpDown5"
        Me.NumericUpDown5.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown5.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(562, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Load"
        '
        'NumericUpDown6
        '
        Me.NumericUpDown6.Location = New System.Drawing.Point(562, 120)
        Me.NumericUpDown6.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown6.Name = "NumericUpDown6"
        Me.NumericUpDown6.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown6.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(620, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "RoF"
        '
        'NumericUpDown7
        '
        Me.NumericUpDown7.Location = New System.Drawing.Point(620, 120)
        Me.NumericUpDown7.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown7.Name = "NumericUpDown7"
        Me.NumericUpDown7.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown7.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(466, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "RoF x "
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Gun", "Gun or Shell (Pick One)", "Chemical", "Combat Computer", "Analytical", "Disruptor", "Impairment", "Melee", "Psionic", "Shell", "Thrown", "Drone", "Companion"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(678, 13)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(191, 199)
        Me.CheckedListBox1.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(875, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Cost"
        '
        'NumericUpDown8
        '
        Me.NumericUpDown8.Location = New System.Drawing.Point(875, 120)
        Me.NumericUpDown8.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.NumericUpDown8.Name = "NumericUpDown8"
        Me.NumericUpDown8.Size = New System.Drawing.Size(52, 20)
        Me.NumericUpDown8.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 336)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modifiers"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(586, 257)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(482, 316)
        Me.ListBox1.TabIndex = 25
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(7, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Small"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(7, 43)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(49, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Slow"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(7, 66)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Energy"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(7, 89)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(50, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Blunt"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(5, 112)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Low Tech"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(7, 135)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "Natural"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(5, 158)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(166, 17)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "No Variations or Modifications"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 628)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NumericUpDown8)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericUpDown5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.HitLbl)
        Me.Controls.Add(Me.HitBox)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.SkillGB)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.SkillGB.ResumeLayout(False)
        Me.SkillGB.PerformLayout()
        CType(Me.HitBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SkillGB As GroupBox
    Friend WithEvents ERB As RadioButton
    Friend WithEvents TRB As RadioButton
    Friend WithEvents HARB As RadioButton
    Friend WithEvents SARB As RadioButton
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NameTB As Label
    Friend WithEvents HitBox As NumericUpDown
    Friend WithEvents HitLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown5 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown6 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown7 As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents NumericUpDown8 As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ListBox1 As ListBox
End Class
