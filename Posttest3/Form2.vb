Imports System.Drawing.Drawing2D

Public Class Form2

    Public Property Nama As String
    Public Property Umur As String
    Public Property NoTelp As String
    Public Property Hobby As String
    Public Property TanggalLahir As String
    Public Property Alamat As String
    Public Property JenisKelamin As String
    Public Property FotoProfil As Image

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FotoProfil IsNot Nothing Then
            pbFotoKartu.Image = FotoProfil
        End If

        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, pbFotoKartu.Width, pbFotoKartu.Height)
        pbFotoKartu.Region = New Region(gp)

        lblNama.Text = Nama & " (" & JenisKelamin & ")"
        lblUmur.Text = Umur & " Tahun (" & TanggalLahir & ")"
        lblNoTelp.Text = NoTelp
        lblHobby.Text = Hobby
        lblAlamat.Text = Alamat
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
