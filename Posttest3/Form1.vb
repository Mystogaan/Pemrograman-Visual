Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Try
            If String.IsNullOrWhiteSpace(boxNama.Text) OrElse
               String.IsNullOrWhiteSpace(boxUmur.Text) OrElse
               String.IsNullOrWhiteSpace(boxTelfon.Text) OrElse
               String.IsNullOrWhiteSpace(boxAlamat.Text) OrElse
               (Not RadioButton1.Checked AndAlso Not RadioButton2.Checked) Then

                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim umur As Integer
            If Not Integer.TryParse(boxUmur.Text, umur) OrElse umur <= 0 Then
                MessageBox.Show("Umur harus berupa angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not IsNumeric(boxTelfon.Text) OrElse boxTelfon.Text.Length < 8 OrElse boxTelfon.Text.Length > 15 Then
                MessageBox.Show("Nomor telepon harus berupa angka dengan panjang 8-15 karakter!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim checkedHobbies As New List(Of String)
            For Each ctrl As Control In boxHobby.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                    If cb.Checked Then
                        checkedHobbies.Add(cb.Text)
                    End If
                End If
            Next

            If checkedHobbies.Count = 0 Then
                MessageBox.Show("Pilih minimal satu hobi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If PictureBox1.Image Is Nothing Then
                MessageBox.Show("Pilih foto profil terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim formKartu As New Form2
            formKartu.FotoProfil = PictureBox1.Image
            formKartu.Nama = boxNama.Text
            formKartu.Umur = boxUmur.Text
            formKartu.NoTelp = boxTelfon.Text
            formKartu.Hobby = String.Join(", ", checkedHobbies)
            formKartu.TanggalLahir = pickerTanggal.Text
            formKartu.Alamat = boxAlamat.Text
            formKartu.JenisKelamin = If(RadioButton1.Checked, "Laki-Laki", "Perempuan")

            formKartu.Show()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
