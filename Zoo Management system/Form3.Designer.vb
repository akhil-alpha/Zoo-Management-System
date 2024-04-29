<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(12, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 22)
        Label1.TabIndex = 0
        Label1.Text = "CUSTOMER"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lemon", 24F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(174, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(405, 42)
        Label3.TabIndex = 6
        Label3.Text = "WILDLIFE HAVEN PARK"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 8
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 9
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 339)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 10
        Label6.Text = "Label6"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 539)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
