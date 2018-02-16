<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ERB = New System.Windows.Forms.RadioButton()
        Me.TRB = New System.Windows.Forms.RadioButton()
        Me.HARB = New System.Windows.Forms.RadioButton()
        Me.SARB = New System.Windows.Forms.RadioButton()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.NameBoxLbl = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ERB)
        Me.GroupBox1.Controls.Add(Me.TRB)
        Me.GroupBox1.Controls.Add(Me.HARB)
        Me.GroupBox1.Controls.Add(Me.SARB)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 56)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
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
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(534, 13)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddBtn.TabIndex = 2
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(16, 61)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 3
        '
        'NameBoxLbl
        '
        Me.NameBoxLbl.AutoSize = True
        Me.NameBoxLbl.Location = New System.Drawing.Point(13, 42)
        Me.NameBoxLbl.Name = "NameBoxLbl"
        Me.NameBoxLbl.Size = New System.Drawing.Size(35, 13)
        Me.NameBoxLbl.TabIndex = 4
        Me.NameBoxLbl.Text = "Name"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(16, 160)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(313, 69)
        Me.ListBox1.TabIndex = 5
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"hah", "bla", "werih", "wefjk"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(400, 97)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(271, 184)
        Me.CheckedListBox1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 529)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.NameBoxLbl)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ERB As RadioButton
    Friend WithEvents TRB As RadioButton
    Friend WithEvents HARB As RadioButton
    Friend WithEvents SARB As RadioButton
    Friend WithEvents AddBtn As Button
    Friend WithEvents NameBox As TextBox
    Friend WithEvents NameBoxLbl As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
