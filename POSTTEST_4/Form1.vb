Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Book Club")
        ComboBox1.Items.Add("Coding Club")
        ComboBox1.Items.Add("Art Club")
    End Sub

    'UPLOAD FOTO
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    'SIMPAN DATA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        'AMBIL HOBI
        Dim hobi As String = ""
        For Each c As Control In GroupBox2.Controls
            If TypeOf c Is CheckBox Then
                If CType(c, CheckBox).Checked Then
                    hobi = hobi & c.Text & ", "
                End If
            End If
        Next

        'KIRIM DATA KE FORM2
        Form2.Label1.Text = "Nama: " & TextBox1.Text
        Form2.Label2.Text = "ID: " & TextBox2.Text
        Form2.Label3.Text = "Komunitas: " & ComboBox1.Text
        Form2.Label4.Text = "HP: " & MaskedTextBox1.Text
        Form2.lblHobi.Text = "Hobi: " & hobi

        Form2.Show()

    End Sub

End Class