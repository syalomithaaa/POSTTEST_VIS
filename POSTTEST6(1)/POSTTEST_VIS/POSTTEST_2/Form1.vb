
Imports System.Data.SqlClient

Public Class Form1
    Dim conn As New SqlConnection("Data Source=.;Initial Catalog=KlinikDB;Integrated Security=True")
    Dim dt As New DataTable

    Sub LoadData()
        Dim query As String = "SELECT Antrian.idAntrian, Pasien.namaPasien, Antrian.tanggal, Antrian.keluhan FROM Antrian JOIN Pasien ON Antrian.idPasien = Pasien.idPasien"
        Dim da As New SqlDataAdapter(query, conn)
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim cmd As New SqlCommand("INSERT INTO Antrian (idPasien, tanggal, keluhan) VALUES (@idPasien, @tanggal, @keluhan)", conn)
        cmd.Parameters.AddWithValue("@idPasien", txtIdPasien.Text)
        cmd.Parameters.AddWithValue("@tanggal", DateTimePicker1.Value)
        cmd.Parameters.AddWithValue("@keluhan", txtKeluhan.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        LoadData()
    End Sub
End Class
