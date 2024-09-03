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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtCourse = New TextBox()
        txtPrelim = New TextBox()
        txtMterm = New TextBox()
        txtPfinal = New TextBox()
        txtFinal = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        txtFullCourse = New Label()
        txtFullname = New Label()
        txtRema = New TextBox()
        Label8 = New Label()
        txtAve = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Label1.Location = New Point(12, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 23)
        Label1.TabIndex = 0
        Label1.Text = "Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Label2.Location = New Point(12, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 1
        Label2.Text = "Course :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Label3.Location = New Point(38, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 23)
        Label3.TabIndex = 2
        Label3.Text = "Prelim : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Label4.Location = New Point(26, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 23)
        Label4.TabIndex = 3
        Label4.Text = "Mid Term :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Label5.Location = New Point(38, 137)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 23)
        Label5.TabIndex = 4
        Label5.Text = "Pre-Final :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Label6.Location = New Point(38, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 23)
        Label6.TabIndex = 5
        Label6.Text = "Final :"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(85, 34)
        txtName.Name = "txtName"
        txtName.Size = New Size(174, 23)
        txtName.TabIndex = 6
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(97, 86)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(174, 23)
        txtCourse.TabIndex = 7
        ' 
        ' txtPrelim
        ' 
        txtPrelim.Location = New Point(152, 58)
        txtPrelim.Name = "txtPrelim"
        txtPrelim.Size = New Size(174, 23)
        txtPrelim.TabIndex = 8
        ' 
        ' txtMterm
        ' 
        txtMterm.Location = New Point(152, 96)
        txtMterm.Name = "txtMterm"
        txtMterm.Size = New Size(174, 23)
        txtMterm.TabIndex = 9
        ' 
        ' txtPfinal
        ' 
        txtPfinal.Location = New Point(152, 140)
        txtPfinal.Name = "txtPfinal"
        txtPfinal.Size = New Size(174, 23)
        txtPfinal.TabIndex = 10
        ' 
        ' txtFinal
        ' 
        txtFinal.Location = New Point(152, 183)
        txtFinal.Name = "txtFinal"
        txtFinal.Size = New Size(174, 23)
        txtFinal.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtPrelim)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtFinal)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtPfinal)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtMterm)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(12, 139)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(375, 263)
        Panel1.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtFullCourse)
        Panel2.Controls.Add(txtFullname)
        Panel2.Controls.Add(txtRema)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(txtAve)
        Panel2.Controls.Add(Label7)
        Panel2.Location = New Point(418, 139)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(415, 262)
        Panel2.TabIndex = 13
        ' 
        ' txtFullCourse
        ' 
        txtFullCourse.AutoSize = True
        txtFullCourse.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        txtFullCourse.Location = New Point(43, 72)
        txtFullCourse.Name = "txtFullCourse"
        txtFullCourse.Size = New Size(84, 23)
        txtFullCourse.TabIndex = 19
        txtFullCourse.Text = "Course : "
        ' 
        ' txtFullname
        ' 
        txtFullname.AutoSize = True
        txtFullname.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        txtFullname.Location = New Point(43, 24)
        txtFullname.Name = "txtFullname"
        txtFullname.Size = New Size(74, 23)
        txtFullname.TabIndex = 15
        txtFullname.Text = "Name : "
        ' 
        ' txtRema
        ' 
        txtRema.Location = New Point(157, 181)
        txtRema.Name = "txtRema"
        txtRema.Size = New Size(174, 23)
        txtRema.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Label8.Location = New Point(43, 178)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 23)
        Label8.TabIndex = 17
        Label8.Text = "Remarks : "
        ' 
        ' txtAve
        ' 
        txtAve.Location = New Point(157, 118)
        txtAve.Name = "txtAve"
        txtAve.Size = New Size(174, 23)
        txtAve.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Label7.Location = New Point(43, 121)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 23)
        Label7.TabIndex = 15
        Label7.Text = "Average : "
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Romantic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(2))
        Button1.Location = New Point(319, 458)
        Button1.Name = "Button1"
        Button1.Size = New Size(192, 57)
        Button1.TabIndex = 14
        Button1.Text = "Compute"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(884, 565)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(txtCourse)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtPrelim As TextBox
    Friend WithEvents txtMterm As TextBox
    Friend WithEvents txtPfinal As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtFullname As Label
    Friend WithEvents txtRema As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAve As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFullCourse As Label

End Class
