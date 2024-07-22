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
    OpenFileDialog1 = New OpenFileDialog()
    btnSelectFile = New Button()
    txtListOfPrograms = New TextBox()
    txtOnlineJclFileName = New TextBox()
    btnMakeJCL = New Button()
    btnClose = New Button()
    Label1 = New Label()
    Label2 = New Label()
    SuspendLayout()
    ' 
    ' OpenFileDialog1
    ' 
    OpenFileDialog1.FileName = "OpenFileDialog1"
    ' 
    ' btnSelectFile
    ' 
    btnSelectFile.Location = New Point(47, 49)
    btnSelectFile.Name = "btnSelectFile"
    btnSelectFile.Size = New Size(112, 34)
    btnSelectFile.TabIndex = 0
    btnSelectFile.Text = "Select File"
    btnSelectFile.UseVisualStyleBackColor = True
    ' 
    ' txtListOfPrograms
    ' 
    txtListOfPrograms.Location = New Point(49, 97)
    txtListOfPrograms.Name = "txtListOfPrograms"
    txtListOfPrograms.Size = New Size(1091, 31)
    txtListOfPrograms.TabIndex = 1
    ' 
    ' txtOnlineJclFileName
    ' 
    txtOnlineJclFileName.Location = New Point(49, 198)
    txtOnlineJclFileName.Name = "txtOnlineJclFileName"
    txtOnlineJclFileName.Size = New Size(1091, 31)
    txtOnlineJclFileName.TabIndex = 2
    txtOnlineJclFileName.Text = "ONLINE.jcl"
    ' 
    ' btnMakeJCL
    ' 
    btnMakeJCL.Location = New Point(51, 279)
    btnMakeJCL.Name = "btnMakeJCL"
    btnMakeJCL.Size = New Size(112, 34)
    btnMakeJCL.TabIndex = 3
    btnMakeJCL.Text = "Make JCL"
    btnMakeJCL.UseVisualStyleBackColor = True
    ' 
    ' btnClose
    ' 
    btnClose.Location = New Point(1028, 279)
    btnClose.Name = "btnClose"
    btnClose.Size = New Size(112, 34)
    btnClose.TabIndex = 4
    btnClose.Text = "Close"
    btnClose.UseVisualStyleBackColor = True
    ' 
    ' Label1
    ' 
    Label1.AutoSize = True
    Label1.Location = New Point(51, 162)
    Label1.Name = "Label1"
    Label1.Size = New Size(176, 25)
    Label1.TabIndex = 5
    Label1.Text = "Output JCL file name"
    ' 
    ' Label2
    ' 
    Label2.AutoSize = True
    Label2.Location = New Point(165, 54)
    Label2.Name = "Label2"
    Label2.Size = New Size(366, 25)
    Label2.TabIndex = 6
    Label2.Text = "Text file with a List of Online Program names."
    ' 
    ' Form1
    ' 
    AutoScaleDimensions = New SizeF(10F, 25F)
    AutoScaleMode = AutoScaleMode.Font
    ClientSize = New Size(1185, 345)
    Controls.Add(Label2)
    Controls.Add(Label1)
    Controls.Add(btnClose)
    Controls.Add(btnMakeJCL)
    Controls.Add(txtOnlineJclFileName)
    Controls.Add(txtListOfPrograms)
    Controls.Add(btnSelectFile)
    Name = "Form1"
    Text = "Create JCL for ONLINE programs"
    ResumeLayout(False)
    PerformLayout()
  End Sub

  Friend WithEvents OpenFileDialog1 As OpenFileDialog
  Friend WithEvents btnSelectFile As Button
  Friend WithEvents txtListOfPrograms As TextBox
  Friend WithEvents txtOnlineJclFileName As TextBox
  Friend WithEvents btnMakeJCL As Button
  Friend WithEvents btnClose As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
End Class
