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
        txt_NP = New TextBox()
        txt_MP = New TextBox()
        Lbl_NP = New Label()
        Lbl_MP = New Label()
        ComboBox1 = New ComboBox()
        Lbl_r = New Label()
        Btn_entre = New Button()
        SuspendLayout()
        ' 
        ' txt_NP
        ' 
        txt_NP.Location = New Point(180, 68)
        txt_NP.Name = "txt_NP"
        txt_NP.Size = New Size(125, 27)
        txt_NP.TabIndex = 0
        ' 
        ' txt_MP
        ' 
        txt_MP.Location = New Point(180, 152)
        txt_MP.Name = "txt_MP"
        txt_MP.Size = New Size(125, 27)
        txt_MP.TabIndex = 1
        ' 
        ' Lbl_NP
        ' 
        Lbl_NP.AutoSize = True
        Lbl_NP.Location = New Point(42, 75)
        Lbl_NP.Name = "Lbl_NP"
        Lbl_NP.Size = New Size(122, 20)
        Lbl_NP.TabIndex = 2
        Lbl_NP.Text = "Nom et prenom :"
        ' 
        ' Lbl_MP
        ' 
        Lbl_MP.AutoSize = True
        Lbl_MP.Location = New Point(59, 159)
        Lbl_MP.Name = "Lbl_MP"
        Lbl_MP.Size = New Size(105, 20)
        Lbl_MP.TabIndex = 3
        Lbl_MP.Text = "mot de passe :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"ADMIN", "USER"})
        ComboBox1.Location = New Point(180, 223)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(125, 28)
        ComboBox1.TabIndex = 4
        ' 
        ' Lbl_r
        ' 
        Lbl_r.AutoSize = True
        Lbl_r.Location = New Point(69, 231)
        Lbl_r.Name = "Lbl_r"
        Lbl_r.Size = New Size(85, 20)
        Lbl_r.TabIndex = 5
        Lbl_r.Text = "Votre Role :"
        ' 
        ' Btn_entre
        ' 
        Btn_entre.Location = New Point(320, 335)
        Btn_entre.Name = "Btn_entre"
        Btn_entre.Size = New Size(94, 29)
        Btn_entre.TabIndex = 6
        Btn_entre.Text = "Entre"
        Btn_entre.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_entre)
        Controls.Add(Lbl_r)
        Controls.Add(ComboBox1)
        Controls.Add(Lbl_MP)
        Controls.Add(Lbl_NP)
        Controls.Add(txt_MP)
        Controls.Add(txt_NP)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_NP As TextBox
    Friend WithEvents txt_MP As TextBox
    Friend WithEvents Lbl_NP As Label
    Friend WithEvents Lbl_MP As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Lbl_r As Label
    Friend WithEvents Btn_entre As Button

End Class
