<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PictureBox1 = New PictureBox()
        btnBrowse = New Button()
        label1 = New Label()
        label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        boxNama = New TextBox()
        boxUmur = New TextBox()
        boxTelfon = New TextBox()
        boxAlamat = New TextBox()
        pickerTanggal = New DateTimePicker()
        boxJenkel = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        boxHobby = New GroupBox()
        checkGame = New CheckBox()
        checkOlahraga = New CheckBox()
        checkReading = New CheckBox()
        checkCoding = New CheckBox()
        btnCetak = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        boxJenkel.SuspendLayout()
        boxHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Location = New Point(41, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(270, 340)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.ButtonShadow
        btnBrowse.Location = New Point(97, 440)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(148, 52)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(373, 83)
        label1.Name = "label1"
        label1.Size = New Size(77, 32)
        label1.TabIndex = 2
        label1.Text = "Nama"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(373, 152)
        label2.Name = "label2"
        label2.Size = New Size(73, 32)
        label2.TabIndex = 3
        label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(373, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 32)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(373, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 32)
        Label4.TabIndex = 5
        Label4.Text = "No Telfon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(373, 338)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 32)
        Label5.TabIndex = 6
        Label5.Text = "Alamat"
        ' 
        ' boxNama
        ' 
        boxNama.Location = New Point(579, 83)
        boxNama.Name = "boxNama"
        boxNama.Size = New Size(406, 39)
        boxNama.TabIndex = 7
        ' 
        ' boxUmur
        ' 
        boxUmur.Location = New Point(579, 145)
        boxUmur.Name = "boxUmur"
        boxUmur.Size = New Size(406, 39)
        boxUmur.TabIndex = 8
        ' 
        ' boxTelfon
        ' 
        boxTelfon.Location = New Point(579, 271)
        boxTelfon.Name = "boxTelfon"
        boxTelfon.Size = New Size(406, 39)
        boxTelfon.TabIndex = 10
        ' 
        ' boxAlamat
        ' 
        boxAlamat.Location = New Point(579, 331)
        boxAlamat.Name = "boxAlamat"
        boxAlamat.Size = New Size(406, 39)
        boxAlamat.TabIndex = 11
        ' 
        ' pickerTanggal
        ' 
        pickerTanggal.CustomFormat = "dd MMMM yyyy"
        pickerTanggal.Format = DateTimePickerFormat.Custom
        pickerTanggal.Location = New Point(579, 210)
        pickerTanggal.Name = "pickerTanggal"
        pickerTanggal.Size = New Size(406, 39)
        pickerTanggal.TabIndex = 12
        ' 
        ' boxJenkel
        ' 
        boxJenkel.Controls.Add(RadioButton2)
        boxJenkel.Controls.Add(RadioButton1)
        boxJenkel.ForeColor = SystemColors.ActiveCaptionText
        boxJenkel.Location = New Point(373, 426)
        boxJenkel.Name = "boxJenkel"
        boxJenkel.RightToLeft = RightToLeft.No
        boxJenkel.Size = New Size(344, 236)
        boxJenkel.TabIndex = 13
        boxJenkel.TabStop = False
        boxJenkel.Text = "Jenis Kelamin"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(18, 114)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(166, 36)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(18, 62)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(151, 36)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki - Laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' boxHobby
        ' 
        boxHobby.Controls.Add(checkGame)
        boxHobby.Controls.Add(checkOlahraga)
        boxHobby.Controls.Add(checkReading)
        boxHobby.Controls.Add(checkCoding)
        boxHobby.Location = New Point(734, 428)
        boxHobby.Name = "boxHobby"
        boxHobby.Size = New Size(362, 234)
        boxHobby.TabIndex = 14
        boxHobby.TabStop = False
        boxHobby.Text = "Hobby"
        ' 
        ' checkGame
        ' 
        checkGame.AutoSize = True
        checkGame.Location = New Point(193, 122)
        checkGame.Name = "checkGame"
        checkGame.Size = New Size(108, 36)
        checkGame.TabIndex = 3
        checkGame.Text = "Game"
        checkGame.UseVisualStyleBackColor = True
        ' 
        ' checkOlahraga
        ' 
        checkOlahraga.AutoSize = True
        checkOlahraga.Location = New Point(193, 60)
        checkOlahraga.Name = "checkOlahraga"
        checkOlahraga.Size = New Size(142, 36)
        checkOlahraga.TabIndex = 2
        checkOlahraga.Text = "Olahraga"
        checkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' checkReading
        ' 
        checkReading.AutoSize = True
        checkReading.Location = New Point(6, 122)
        checkReading.Name = "checkReading"
        checkReading.Size = New Size(151, 36)
        checkReading.TabIndex = 1
        checkReading.Text = "Membaca"
        checkReading.UseVisualStyleBackColor = True
        ' 
        ' checkCoding
        ' 
        checkCoding.AutoSize = True
        checkCoding.Location = New Point(6, 60)
        checkCoding.Name = "checkCoding"
        checkCoding.Size = New Size(123, 36)
        checkCoding.TabIndex = 0
        checkCoding.Text = "Coding"
        checkCoding.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.MediumSeaGreen
        btnCetak.Location = New Point(41, 673)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(1055, 62)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1186, 904)
        Controls.Add(btnCetak)
        Controls.Add(boxHobby)
        Controls.Add(boxJenkel)
        Controls.Add(pickerTanggal)
        Controls.Add(boxAlamat)
        Controls.Add(boxTelfon)
        Controls.Add(boxUmur)
        Controls.Add(boxNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(label2)
        Controls.Add(label1)
        Controls.Add(btnBrowse)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        boxJenkel.ResumeLayout(False)
        boxJenkel.PerformLayout()
        boxHobby.ResumeLayout(False)
        boxHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents boxNama As TextBox
    Friend WithEvents boxUmur As TextBox
    Friend WithEvents boxTelfon As TextBox
    Friend WithEvents boxAlamat As TextBox
    Friend WithEvents pickerTanggal As DateTimePicker
    Friend WithEvents boxJenkel As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents boxHobby As GroupBox
    Friend WithEvents checkGame As CheckBox
    Friend WithEvents checkOlahraga As CheckBox
    Friend WithEvents checkReading As CheckBox
    Friend WithEvents checkCoding As CheckBox
    Friend WithEvents btnCetak As Button

End Class
