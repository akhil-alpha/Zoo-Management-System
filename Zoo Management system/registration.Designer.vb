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
            MyBase.Dispose(disposing, components)
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
        Label2 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 167)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 19)
        Label1.TabIndex = 6
        Label1.Text = "Full Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Inter", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 230)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 19)
        Label2.TabIndex = 7
        Label2.Text = "Email Address:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century", 18F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label4.Location = New Point(12, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(205, 28)
        Label4.TabIndex = 8
        Label4.Text = "REGISTRATION"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(262, 167)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(233, 23)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(262, 226)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(233, 23)
        TextBox2.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(334, 507)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 37)
        Button1.TabIndex = 11
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lemon", 24F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(197, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(405, 42)
        Label3.TabIndex = 5
        Label3.Text = "WILDLIFE HAVEN PARK"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Inter", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(12, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 19)
        Label5.TabIndex = 13
        Label5.Text = "Username:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Inter", 11.249999F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(12, 350)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 19)
        Label6.TabIndex = 14
        Label6.Text = "Password:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(262, 288)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(233, 23)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(262, 350)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(233, 23)
        TextBox4.TabIndex = 16
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 556)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Name = "Form2"
        Text = "DESIGNATION DETAILES"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
