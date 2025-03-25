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
        pbFotoKartu = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblNoTelp = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        PictureBox1 = New PictureBox()
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoKartu
        ' 
        pbFotoKartu.Location = New Point(571, 144)
        pbFotoKartu.Name = "pbFotoKartu"
        pbFotoKartu.Size = New Size(322, 320)
        pbFotoKartu.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoKartu.TabIndex = 0
        pbFotoKartu.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = SystemColors.HighlightText
        lblNama.Font = New Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(61, 122)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(138, 44)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = SystemColors.HighlightText
        lblUmur.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(61, 166)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(109, 36)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Label1"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.BackColor = SystemColors.HighlightText
        lblNoTelp.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNoTelp.Location = New Point(131, 260)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(95, 32)
        lblNoTelp.TabIndex = 3
        lblNoTelp.Text = "Label1"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.BackColor = SystemColors.HighlightText
        lblHobby.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobby.Location = New Point(131, 328)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(95, 32)
        lblHobby.TabIndex = 4
        lblHobby.Text = "Label1"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.White
        lblAlamat.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(131, 404)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(95, 32)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.test
        PictureBox1.Location = New Point(-9, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1060, 781)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1020, 598)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblNoTelp)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(pbFotoKartu)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(pbFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoKartu As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
