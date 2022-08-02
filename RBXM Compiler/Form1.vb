

Public Class Form1
    Dim LuauExecutablePath As String = My.Settings.LuauExecutablePath
    Dim InputFilePath As String
    Dim OutputFilePath As String
    Dim PreviousSuggestedOutput As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LuauExecutablePath <> "" Then
            LuauField.Text = LuauExecutablePath
        End If
    End Sub

    Private Sub FindFileInput_Click(sender As Object, e As EventArgs) Handles FindFileInput.Click
        OpenerControl.Title = "Open RBXM File..."
        OpenerControl.Filter = "Roblox Model|*.rbxm|Roblox Place|*.rbxl"

        Dim Result = OpenerControl.ShowDialog()
        If Result = Windows.Forms.DialogResult.OK Then
            ' assume they opened a file
            InputFilePath = OpenerControl.FileName
            InputField.Text = InputFilePath

            Dim SuggestedPath As String = InputFilePath & ".compiled"

            If OutputFilePath = PreviousSuggestedOutput Then
                ' generate output "COMPILED_file.rbxm
                OutputFilePath = SuggestedPath
                OutputField.Text = SuggestedPath
            End If

            PreviousSuggestedOutput = SuggestedPath
        End If
    End Sub

    Private Sub FindFileLuau_Click(sender As Object, e As EventArgs) Handles FindFileLuau.Click
        OpenerControl.Title = "Open Luau Executable"
        OpenerControl.Filter = "Luau|luau.exe"

        Dim Result = OpenerControl.ShowDialog()
        If Result = Windows.Forms.DialogResult.OK Then
            ' assume they opened a file
            LuauExecutablePath = OpenerControl.FileName
            LuauField.Text = LuauExecutablePath
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LuauExecutablePath = "" Or InputFilePath = "" Or OutputFilePath = "" Then
            MsgBox("One or more fields are invalid", vbExclamation, "Invalid Files Provided")
        Else
            Button1.Enabled = False
            ProgressBar1.Visible = True

            My.Settings.LuauExecutablePath = LuauExecutablePath
            My.Settings.Save()

            Compiler.Compile(InputFilePath, OutputFilePath, LuauExecutablePath)

            ProgressBar1.Visible = False
            Button1.Enabled = True
            MsgBox("Compiled Successfully!", vbInformation, "Success!")
        End If
    End Sub

    Private Sub InputField_TextChanged(sender As Object, e As EventArgs) Handles InputField.TextChanged
        InputFilePath = InputField.Text
    End Sub

    Private Sub OutputField_TextChanged(sender As Object, e As EventArgs) Handles OutputField.TextChanged
        OutputFilePath = OutputField.Text
    End Sub

    Private Sub LuauField_TextChanged(sender As Object, e As EventArgs) Handles LuauField.TextChanged
        LuauExecutablePath = LuauField.Text
    End Sub

End Class
