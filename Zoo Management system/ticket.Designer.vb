<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lemon", 24F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.ImageAlign = ContentAlignment.TopCenter
        Label3.Location = New Point(198, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(405, 42)
        Label3.TabIndex = 7
        Label3.Text = "WILDLIFE HAVEN PARK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(12, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 24)
        Label1.TabIndex = 8
        Label1.Text = "TICKET"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 19)
        Label2.TabIndex = 9
        Label2.Text = "Ticket ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 263)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 17)
        Label4.TabIndex = 10
        Label4.Text = "Price:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(12, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 17)
        Label5.TabIndex = 11
        Label5.Text = "Valid Date:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(112, 208)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(217, 23)
        TextBox1.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(112, 260)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(217, 20)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(112, 319)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(217, 23)
        TextBox3.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(352, 406)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 32)
        Button1.TabIndex = 15
        Button1.Text = "BOOK TICKET"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
End Class
