Imports System.IO

Public Class Form1

    ' ===================== VALIDASI HELPER =====================
    Private Function ValidasiTextBox(tb As TextBox, fieldName As String) As Boolean
        If String.IsNullOrWhiteSpace(tb.Text) Then
            MessageBox.Show($"Inputan '{fieldName}' tidak boleh kosong!", "⚠️ Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tb.Focus()
            Return False
        End If
        Return True
    End Function

    ' ===================== INPUT VALIDATION EVENTS =====================
    ' Hanya angka untuk Umur dan No Telepon
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtNoTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelpon.KeyPress
        HanyaAngka(sender, e)
    End Sub

    ' Hanya huruf untuk Nama
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ' ===================== BROWSE FOTO =====================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        openFileDialog.Title = "Pilih Foto Profil"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                Dim namaFile As String = "profil" & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, namaFile)
                File.Copy(openFileDialog.FileName, destinationPath, True)

                DataModule.FotoPath = destinationPath
                picProfil.Image = Image.FromFile(destinationPath)
                picProfil.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
                MessageBox.Show("Gagal memuat foto: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' ===================== CETAK KARTU =====================
    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        ' Validasi semua input
        If Not ValidasiTextBox(txtNama, "Nama Lengkap") Then Return
        If Not ValidasiTextBox(txtUmur, "Umur") Then Return
        If Not ValidasiTextBox(txtNoTelpon, "No. Telepon") Then Return
        If Not ValidasiTextBox(txtAlamat, "Alamat") Then Return

        ' Validasi Jenis Kelamin
        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan 'Jenis Kelamin' tidak boleh kosong!", "⚠️ Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi Hobby (minimal 1 dipilih)
        Dim checkboxes As CheckBox() = {chkGaming, chkCoding, chkTraveling, chkMenggambar, chkMenulis,
                                         chkMemancing, chkMembaca, chkOlahraga, chkMenyanyi, chkMenari,
                                         chkMemasak, chkFotografi}
        Dim adaHobby As Boolean = False
        For Each cb In checkboxes
            If cb.Checked Then adaHobby = True : Exit For
        Next
        If Not adaHobby Then
            MessageBox.Show("Inputan 'Hobby' tidak boleh kosong! Pilih minimal 1 hobby.", "⚠️ Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Kumpulkan hobby yang dipilih
        Dim hobbiesList As New List(Of String)
        For Each cb In checkboxes
            If cb.Checked Then hobbiesList.Add(cb.Text)
        Next

        ' Simpan ke DataModule
        DataModule.Nama = txtNama.Text.Trim()
        DataModule.Umur = txtUmur.Text.Trim()
        DataModule.NoTelpon = txtNoTelpon.Text.Trim()
        DataModule.Alamat = txtAlamat.Text.Trim()
        DataModule.TanggalLahir = dtpTanggalLahir.Value.ToString("dd/MM/yyyy")
        DataModule.JenisKelamin = If(rbLakiLaki.Checked, "Laki-Laki", "Perempuan")
        DataModule.Hobbies = String.Join(", ", hobbiesList)

        ' Tampilkan Form2
        Dim frm2 As New Form2()
        frm2.ShowDialog()
    End Sub

    ' ===================== FORM LOAD =====================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default tanggal lahir ke tahun relevan
        dtpTanggalLahir.Value = New DateTime(2000, 1, 1)
        dtpTanggalLahir.MaxDate = DateTime.Today
    End Sub

End Class
