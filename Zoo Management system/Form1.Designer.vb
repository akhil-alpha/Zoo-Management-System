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
        Label3 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lemon", 24F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(208, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(405, 42)
        Label3.TabIndex = 6
        Label3.Text = "WILDLIFE HAVEN PARK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(12, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 28)
        Label1.TabIndex = 7
        Label1.Text = "LOGIN :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 218)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 19)
        Label2.TabIndex = 8
        Label2.Text = "Username:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 19)
        Label4.TabIndex = 9
        Label4.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(136, 214)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 23)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(136, 274)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 23)
        TextBox2.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(372, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 36)
        Button1.TabIndex = 12
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
