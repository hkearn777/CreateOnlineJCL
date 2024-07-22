Imports System.IO

Public Class Form1
  Dim swJCLFile As StreamWriter

  Private Sub btnSelectFile_Click(sender As Object, e As EventArgs) Handles btnSelectFile.Click

    Dim ofd_listofprograms As New OpenFileDialog
    If ofd_listofprograms.ShowDialog = DialogResult.OK Then
      txtListOfPrograms.Text = ofd_listofprograms.FileName
      Dim myFileInfo As System.IO.FileInfo
      myFileInfo = My.Computer.FileSystem.GetFileInfo(txtListOfPrograms.Text)
      Dim folderPath As String = myFileInfo.DirectoryName
      txtOnlineJclFileName.Text = folderPath & "\" & "ONLINE.jcl"
    End If
  End Sub


  Private Sub btnMakeJCL_Click(sender As Object, e As EventArgs) Handles btnMakeJCL.Click
    swJCLFile = My.Computer.FileSystem.OpenTextFileWriter(txtOnlineJclFileName.Text, False)
    swJCLFile.WriteLine("//ONLINE JOB '0000','ONLINE PROGRAMS'")
    Dim programLines As String() = File.ReadAllLines(txtListOfPrograms.Text)
    Dim cnt As Integer = 0
    For Each program In programLines
      cnt += 1
      swJCLFile.WriteLine("//STEP" & LTrim(Str(cnt)) & " EXEC PGM=" & program)
      swJCLFile.WriteLine("//STEPLIB DD DSN=FROM.ONLINE.SYSTEM,DISP=SHR")
    Next
    swJCLFile.Close()
    MessageBox.Show("Process complete.")
  End Sub

  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    Me.Close()
  End Sub
End Class
