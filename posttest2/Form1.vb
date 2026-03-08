Public Class Form1

    'TOMBOL TAMBAH
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim judul As String = txtJudulTambah.Text
        Dim genre As String = txtGenre.Text

        'Validasi
        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi!")
            Exit Sub
        End If

        'Format data buku
        Dim data As String = judul & " - " & genre

        'Tambahkan ke textbox daftar
        txtDaftar.AppendText(data & Environment.NewLine)

        'Kosongkan textbox
        txtJudulTambah.Clear()
        txtGenre.Clear()

    End Sub


    'TOMBOL HAPUS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim judulHapus As String = txtJudulHapus.Text

        If judulHapus = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!")
            Exit Sub
        End If

        Dim daftar() As String = txtDaftar.Lines
        Dim hasil As String = ""
        Dim ditemukan As Boolean = False

        For Each buku As String In daftar
            If buku.ToLower.Contains(judulHapus.ToLower) Then
                ditemukan = True
            Else
                hasil &= buku & Environment.NewLine
            End If
        Next

        txtDaftar.Text = hasil

        If ditemukan Then
            MessageBox.Show("Buku berhasil dihapus")
        Else
            MessageBox.Show("Buku tidak ditemukan")
        End If

        txtJudulHapus.Clear()

    End Sub

End Class