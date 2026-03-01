Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ips As Double

        If Double.TryParse(txtIPS.Text, ips) Then

            totalIP += ips
            jumlahSemester += 1

            Dim ipk As Double = totalIP / jumlahSemester
            txtIPK.Text = ipk.ToString("0.00")

            ' Predikat
            If ipk >= 2.0 AndAlso ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 AndAlso ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

            txtIPS.Clear()
            txtIPS.Focus()

        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = ""
        txtIPS.Focus()

    End Sub

    Private Sub txtIPS_TextChanged(sender As Object, e As EventArgs) Handles txtIPS.TextChanged

    End Sub

    Private Sub txtIPK_TextChanged(sender As Object, e As EventArgs) Handles txtIPK.TextChanged

    End Sub
End Class