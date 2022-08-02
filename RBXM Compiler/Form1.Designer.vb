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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputField = New System.Windows.Forms.TextBox()
        Me.FindFileInput = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OutputField = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FindFileLuau = New System.Windows.Forms.Button()
        Me.LuauField = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.OpenerControl = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input File"
        '
        'InputField
        '
        Me.InputField.Location = New System.Drawing.Point(12, 28)
        Me.InputField.Name = "InputField"
        Me.InputField.Size = New System.Drawing.Size(279, 20)
        Me.InputField.TabIndex = 1
        '
        'FindFileInput
        '
        Me.FindFileInput.Location = New System.Drawing.Point(297, 28)
        Me.FindFileInput.Name = "FindFileInput"
        Me.FindFileInput.Size = New System.Drawing.Size(75, 23)
        Me.FindFileInput.TabIndex = 2
        Me.FindFileInput.Text = "Find File"
        Me.FindFileInput.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Output File"
        '
        'OutputField
        '
        Me.OutputField.Location = New System.Drawing.Point(12, 67)
        Me.OutputField.Name = "OutputField"
        Me.OutputField.Size = New System.Drawing.Size(360, 20)
        Me.OutputField.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Luau Executable"
        '
        'FindFileLuau
        '
        Me.FindFileLuau.Location = New System.Drawing.Point(297, 106)
        Me.FindFileLuau.Name = "FindFileLuau"
        Me.FindFileLuau.Size = New System.Drawing.Size(75, 23)
        Me.FindFileLuau.TabIndex = 7
        Me.FindFileLuau.Text = "Find File"
        Me.FindFileLuau.UseVisualStyleBackColor = True
        '
        'LuauField
        '
        Me.LuauField.Location = New System.Drawing.Point(12, 106)
        Me.LuauField.Name = "LuauField"
        Me.LuauField.Size = New System.Drawing.Size(279, 20)
        Me.LuauField.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Compile"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 146)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(279, 23)
        Me.ProgressBar1.Step = 5
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 181)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FindFileLuau)
        Me.Controls.Add(Me.LuauField)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OutputField)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FindFileInput)
        Me.Controls.Add(Me.InputField)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "RBXM Compiler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InputField As TextBox
    Friend WithEvents FindFileInput As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OutputField As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FindFileLuau As Button
    Friend WithEvents LuauField As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents OpenerControl As OpenFileDialog
End Class
