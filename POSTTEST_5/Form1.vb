Public Class Form1

    ' ================= LOAD =================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvKeluhan.Columns.Add("Nama", "Nama Pasien")
        dgvKeluhan.Columns.Add("Umur", "Umur")
        dgvKeluhan.Columns.Add("Poli", "Poli Tujuan")
        dgvKeluhan.Columns.Add("Keluhan", "Keluhan")

        dgvKeluhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKeluhan.MultiSelect = False
    End Sub

    ' ================= VALIDASI =================
    Private Function Validasi() As Boolean
        ErrorProvider1.Clear()

        If txtNama.Text = "" Then
            ErrorProvider1.SetError(txtNama, "Nama wajib diisi")
            Return False
        End If

        If txtUmur.Text = "" Or Not IsNumeric(txtUmur.Text) Then
            ErrorProvider1.SetError(txtUmur, "Umur harus angka")
            Return False
        End If

        If ComboBox1.Text = "" Or ComboBox1.Text = "Pilih Poli" Then
            ErrorProvider1.SetError(ComboBox1, "Pilih poli tujuan")
            Return False
        End If

        If txtKeluhan.Text = "" Then
            ErrorProvider1.SetError(txtKeluhan, "Keluhan wajib diisi")
            Return False
        End If

        Return True
    End Function

    ' ================= SIMPAN =================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Validasi() Then Exit Sub

        dgvKeluhan.Rows.Add(txtNama.Text, txtUmur.Text, ComboBox1.Text, txtKeluhan.Text)

        MessageBox.Show("Data berhasil disimpan")
        ResetForm()
    End Sub

    ' ================= UPDATE =================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvKeluhan.SelectedRows.Count > 0 Then
            If Not Validasi() Then Exit Sub

            With dgvKeluhan.SelectedRows(0)
                .Cells(0).Value = txtNama.Text
                .Cells(1).Value = txtUmur.Text
                .Cells(2).Value = ComboBox1.Text
                .Cells(3).Value = txtKeluhan.Text
            End With

            MessageBox.Show("Data berhasil diupdate")
        Else
            MessageBox.Show("Pilih data terlebih dahulu")
        End If
    End Sub

    ' ================= HAPUS =================
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgvKeluhan.SelectedRows.Count > 0 Then
            dgvKeluhan.Rows.Remove(dgvKeluhan.SelectedRows(0))
            MessageBox.Show("Data berhasil dihapus")
        Else
            MessageBox.Show("Pilih data terlebih dahulu")
        End If
    End Sub

    ' ================= RESET =================
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ResetForm()
    End Sub

    ' ================= RESET FORM =================
    Private Sub ResetForm()
        txtNama.Clear()
        txtUmur.Clear()
        txtKeluhan.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox1.Text = "Pilih Poli"
        txtNama.Focus()
        ErrorProvider1.Clear()
    End Sub

    ' ================= KLIK DATAGRID =================
    Private Sub dgvKeluhan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKeluhan.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvKeluhan.Rows(e.RowIndex)

            txtNama.Text = row.Cells(0).Value.ToString()
            txtUmur.Text = row.Cells(1).Value.ToString()
            ComboBox1.Text = row.Cells(2).Value.ToString()
            txtKeluhan.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

End Class