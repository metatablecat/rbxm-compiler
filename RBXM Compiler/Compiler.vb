Imports System.IO
Imports RobloxFiles
Imports RobloxFiles.DataTypes

Module Compiler
    Dim FilePath As String = Environment.GetEnvironmentVariable("TEMP") & "/cstdin"
    Private Function CompileStream(sourceCode As String, executable As String) As Byte()
        File.WriteAllText(FilePath, sourceCode)

        Dim ActiveLuauProcess As New Process
        ActiveLuauProcess.StartInfo.FileName = executable
        ActiveLuauProcess.StartInfo.CreateNoWindow = True
        ActiveLuauProcess.StartInfo.Arguments = "--compile=binary " & FilePath
        ActiveLuauProcess.StartInfo.UseShellExecute = False
        ActiveLuauProcess.StartInfo.RedirectStandardOutput = True
        ActiveLuauProcess.Start()

        Dim stdout As StreamReader = ActiveLuauProcess.StandardOutput
        Dim realOutput As String = stdout.ReadToEnd()

        File.Delete(FilePath)
        Return System.Text.Encoding.Default.GetBytes(realOutput)
    End Function

    Public Sub Compile(InputPath As String, OutputPath As String, LuauExecutable As String)
        Dim NewFile As RobloxFile = RobloxFile.Open(InputPath)
        For Each INST As Instance In NewFile.GetDescendants()
            If INST.ClassName = "ModuleScript" Or INST.ClassName = "Script" Or INST.ClassName = "LocalScript" Then
                Dim SourceCode As ProtectedString = INST.GetProperty("Source").CastValue(Of ProtectedString)
                If Not SourceCode.IsCompiled Then
                    Dim CompiledSource As Byte() = CompileStream(SourceCode.ToString(), LuauExecutable)
                    INST.GetProperty("Source").Value = CompiledSource
                End If
            End If
        Next

        NewFile.Save(OutputPath)
    End Sub
End Module
