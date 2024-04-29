<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(70, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 19)
        Label1.TabIndex = 0
        Label1.Text = "USERNAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(70, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 19)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(247, 136)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(262, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(247, 251)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(262, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lemon", 24F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(313, 26)
        Label3.Name = "Label3"
        Label3.Size = New Size(405, 42)
        Label3.TabIndex = 4
        Label3.Text = "WILDLIFE HAVEN PARK"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Orbitron", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(449, 446)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 37)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(989, 524)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "loginpage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
