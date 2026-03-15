Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate data dari DataModule
        lblCardNama.Text = DataModule.Nama
        lblCardUmur.Text = DataModule.Umur & " tahun"
        lblCardTglLahir.Text = DataModule.TanggalLahir
        lblCardJK.Text = DataModule.JenisKelamin
        lblCardTelp.Text = DataModule.NoTelpon
        lblCardAlamat.Text = DataModule.Alamat
        lblCardHobby.Text = DataModule.Hobbies

        ' Tampilkan foto profil jika ada
        If Not String.IsNullOrEmpty(DataModule.FotoPath) AndAlso System.IO.File.Exists(DataModule.FotoPath) Then
            Try
                picProfilCard.Image = Image.FromFile(DataModule.FotoPath)
                picProfilCard.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
                ' Jika foto gagal dimuat, biarkan kosong
            End Try
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

End Class
