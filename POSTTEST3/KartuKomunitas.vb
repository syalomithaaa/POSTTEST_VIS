Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms

' ============================= DATA MODULE =============================
Module DataModule
    Public Nama As String = ""
    Public Umur As String = ""
    Public NoTelpon As String = ""
    Public Alamat As String = ""
    Public TanggalLahir As String = ""
    Public JenisKelamin As String = ""
    Public Hobbies As String = ""
    Public FotoPath As String = ""
End Module

' ============================= FORM 1 =============================
Public Class Form1
    Inherits Form

    ' --- Controls ---
    Private picProfil As PictureBox
    Private btnBrowse As Button
    Private txtNama As TextBox
    Private txtUmur As TextBox
    Private txtNoTelpon As TextBox
    Private txtAlamat As TextBox
    Private dtpTanggalLahir As DateTimePicker
    Private rbLakiLaki As RadioButton
    Private rbPerempuan As RadioButton
    Private grpJK As GroupBox
    Private grpHobby As GroupBox
    Private btnCetak As Button
    Private pnlHeader As Panel
    Private pnlLeft As Panel
    Private pnlRight As Panel

    Private chkList() As CheckBox
    Private chkNames() As String = {"Gaming", "Coding", "Traveling", "Menggambar", "Menulis",
                                      "Memancing", "Membaca", "Olahraga", "Menyanyi", "Menari",
                                      "Memasak", "Fotografi"}

    Public Sub New()
        InitUI()
    End Sub

    Private Sub InitUI()
        Me.Text = "Form Cetak Kartu Komunitas"
        Me.Size = New Size(680, 640)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.BackColor = Color.FromArgb(240, 244, 255)
        Me.Font = New Font("Segoe UI", 9)

        ' ---- HEADER ----
        pnlHeader = New Panel()
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Height = 72
        pnlHeader.BackColor = Color.FromArgb(18, 28, 68)

        Dim lblTitle As New Label()
        lblTitle.Text = "  🎴  KOMUNITAS CARD MAKER"
        lblTitle.Font = New Font("Segoe UI", 17, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(10, 8)
        lblTitle.AutoSize = True

        Dim lblSub As New Label()
        lblSub.Text = "  Isi data diri untuk membuat kartu anggota komunitas"
        lblSub.Font = New Font("Segoe UI", 9)
        lblSub.ForeColor = Color.FromArgb(170, 195, 255)
        lblSub.Location = New Point(10, 45)
        lblSub.AutoSize = True

        pnlHeader.Controls.AddRange({lblTitle, lblSub})
        Me.Controls.Add(pnlHeader)

        ' ---- LEFT PANEL (foto) ----
        pnlLeft = New Panel()
        pnlLeft.Location = New Point(18, 86)
        pnlLeft.Size = New Size(155, 260)
        pnlLeft.BackColor = Color.Transparent

        ' foto border panel
        Dim pnlFotoBorder As New Panel()
        pnlFotoBorder.Location = New Point(0, 0)
        pnlFotoBorder.Size = New Size(150, 175)
        pnlFotoBorder.BackColor = Color.FromArgb(200, 210, 240)
        pnlFotoBorder.BorderStyle = BorderStyle.FixedSingle

        picProfil = New PictureBox()
        picProfil.Location = New Point(1, 1)
        picProfil.Size = New Size(148, 173)
        picProfil.SizeMode = PictureBoxSizeMode.Zoom
        picProfil.BackColor = Color.FromArgb(225, 230, 250)
        pnlFotoBorder.Controls.Add(picProfil)

        Dim lblFotoHint As New Label()
        lblFotoHint.Text = "📷 Foto Profil"
        lblFotoHint.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        lblFotoHint.ForeColor = Color.SlateGray
        lblFotoHint.Location = New Point(0, 180)
        lblFotoHint.AutoSize = True

        btnBrowse = New Button()
        btnBrowse.Text = "📁  Browse Foto"
        btnBrowse.Location = New Point(0, 200)
        btnBrowse.Size = New Size(150, 38)
        btnBrowse.BackColor = Color.FromArgb(60, 120, 210)
        btnBrowse.ForeColor = Color.White
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.FlatAppearance.BorderSize = 0
        btnBrowse.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnBrowse.Cursor = Cursors.Hand

        pnlLeft.Controls.AddRange({pnlFotoBorder, lblFotoHint, btnBrowse})
        Me.Controls.Add(pnlLeft)

        ' ---- RIGHT PANEL (fields) ----
        pnlRight = New Panel()
        pnlRight.Location = New Point(185, 86)
        pnlRight.Size = New Size(470, 270)
        pnlRight.BackColor = Color.Transparent

        Dim yPos As Integer = 0
        Dim fieldColor As Color = Color.FromArgb(18, 28, 68)

        ' Nama
        AddFieldLabel(pnlRight, "Nama Lengkap", 0, yPos)
        txtNama = AddTextBox(pnlRight, 0, yPos + 18, 455)

        ' Umur + Telepon
        yPos = 58
        AddFieldLabel(pnlRight, "Umur", 0, yPos)
        AddFieldLabel(pnlRight, "No. Telepon", 130, yPos)
        txtUmur = AddTextBox(pnlRight, 0, yPos + 18, 115)
        txtNoTelpon = AddTextBox(pnlRight, 130, yPos + 18, 325)

        ' Tanggal Lahir
        yPos = 116
        AddFieldLabel(pnlRight, "Tanggal Lahir", 0, yPos)
        dtpTanggalLahir = New DateTimePicker()
        dtpTanggalLahir.Location = New Point(0, yPos + 18)
        dtpTanggalLahir.Size = New Size(225, 28)
        dtpTanggalLahir.Format = DateTimePickerFormat.Short
        dtpTanggalLahir.Font = New Font("Segoe UI", 10)
        dtpTanggalLahir.Value = New DateTime(2000, 1, 1)
        dtpTanggalLahir.MaxDate = DateTime.Today
        pnlRight.Controls.Add(dtpTanggalLahir)

        ' Alamat
        yPos = 165
        AddFieldLabel(pnlRight, "Alamat", 0, yPos)
        txtAlamat = AddTextBox(pnlRight, 0, yPos + 18, 455)

        Me.Controls.Add(pnlRight)

        ' ---- JENIS KELAMIN GROUPBOX ----
        grpJK = New GroupBox()
        grpJK.Text = "Jenis Kelamin"
        grpJK.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        grpJK.ForeColor = Color.FromArgb(18, 28, 68)
        grpJK.Location = New Point(18, 362)
        grpJK.Size = New Size(210, 60)
        grpJK.BackColor = Color.White

        rbLakiLaki = New RadioButton()
        rbLakiLaki.Text = "♂  Laki-Laki"
        rbLakiLaki.Font = New Font("Segoe UI", 9)
        rbLakiLaki.Location = New Point(10, 26)
        rbLakiLaki.AutoSize = True

        rbPerempuan = New RadioButton()
        rbPerempuan.Text = "♀  Perempuan"
        rbPerempuan.Font = New Font("Segoe UI", 9)
        rbPerempuan.Location = New Point(105, 26)
        rbPerempuan.AutoSize = True

        grpJK.Controls.AddRange({rbLakiLaki, rbPerempuan})
        Me.Controls.Add(grpJK)

        ' ---- HOBBY GROUPBOX ----
        grpHobby = New GroupBox()
        grpHobby.Text = "Hobby (Pilih minimal 1)"
        grpHobby.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        grpHobby.ForeColor = Color.FromArgb(18, 28, 68)
        grpHobby.Location = New Point(238, 362)
        grpHobby.Size = New Size(418, 110)
        grpHobby.BackColor = Color.White

        ReDim chkList(chkNames.Length - 1)
        For i As Integer = 0 To chkNames.Length - 1
            chkList(i) = New CheckBox()
            chkList(i).Text = chkNames(i)
            chkList(i).Font = New Font("Segoe UI", 8.5F)
            Dim col As Integer = i Mod 4
            Dim row As Integer = i \ 4
            chkList(i).Location = New Point(8 + col * 102, 24 + row * 26)
            chkList(i).AutoSize = True
            grpHobby.Controls.Add(chkList(i))
        Next
        Me.Controls.Add(grpHobby)

        ' ---- CETAK BUTTON ----
        btnCetak = New Button()
        btnCetak.Text = "🎴   CETAK KARTU"
        btnCetak.Location = New Point(18, 492)
        btnCetak.Size = New Size(638, 52)
        btnCetak.BackColor = Color.FromArgb(18, 28, 68)
        btnCetak.ForeColor = Color.White
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        btnCetak.Cursor = Cursors.Hand
        Me.Controls.Add(btnCetak)

        ' ---- EVENTS ----
        AddHandler btnBrowse.Click, AddressOf BrowseClick
        AddHandler btnCetak.Click, AddressOf CetakClick
        AddHandler txtNama.KeyPress, AddressOf HanyaHuruf
        AddHandler txtUmur.KeyPress, AddressOf HanyaAngka
        AddHandler txtNoTelpon.KeyPress, AddressOf HanyaAngka
    End Sub

    Private Function AddTextBox(parent As Control, x As Integer, y As Integer, w As Integer) As TextBox
        Dim tb As New TextBox()
        tb.Location = New Point(x, y)
        tb.Size = New Size(w, 28)
        tb.Font = New Font("Segoe UI", 10)
        tb.BorderStyle = BorderStyle.FixedSingle
        tb.BackColor = Color.White
        parent.Controls.Add(tb)
        Return tb
    End Function

    Private Sub AddFieldLabel(parent As Control, text As String, x As Integer, y As Integer)
        Dim lbl As New Label()
        lbl.Text = text
        lbl.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(18, 28, 68)
        lbl.Location = New Point(x, y)
        lbl.AutoSize = True
        parent.Controls.Add(lbl)
    End Sub

    ' --- Validasi ---
    Private Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BrowseClick(sender As Object, e As EventArgs)
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Foto Profil"
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim folder As String = Path.Combine(Application.StartupPath, "Foto")
                If Not Directory.Exists(folder) Then Directory.CreateDirectory(folder)
                Dim dest As String = Path.Combine(folder, "profil" & Path.GetExtension(ofd.FileName))
                File.Copy(ofd.FileName, dest, True)
                DataModule.FotoPath = dest
                picProfil.Image = Image.FromFile(dest)
            Catch ex As Exception
                MessageBox.Show("Gagal memuat foto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CetakClick(sender As Object, e As EventArgs)
        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            Warn("Nama Lengkap") : Return
        End If
        If String.IsNullOrWhiteSpace(txtUmur.Text) Then
            Warn("Umur") : Return
        End If
        If String.IsNullOrWhiteSpace(txtNoTelpon.Text) Then
            Warn("No. Telepon") : Return
        End If
        If String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            Warn("Alamat") : Return
        End If
        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan 'Jenis Kelamin' tidak boleh kosong!", "⚠️ Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedHobbies As New System.Collections.Generic.List(Of String)
        For Each cb As CheckBox In chkList
            If cb.Checked Then selectedHobbies.Add(cb.Text)
        Next
        If selectedHobbies.Count = 0 Then
            MessageBox.Show("Inputan 'Hobby' tidak boleh kosong! Pilih minimal 1.", "⚠️ Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataModule.Nama = txtNama.Text.Trim()
        DataModule.Umur = txtUmur.Text.Trim()
        DataModule.NoTelpon = txtNoTelpon.Text.Trim()
        DataModule.Alamat = txtAlamat.Text.Trim()
        DataModule.TanggalLahir = dtpTanggalLahir.Value.ToString("dd/MM/yyyy")
        DataModule.JenisKelamin = If(rbLakiLaki.Checked, "Laki-Laki", "Perempuan")
        DataModule.Hobbies = String.Join(", ", selectedHobbies)

        Dim f2 As New Form2()
        f2.ShowDialog()
    End Sub

    Private Sub Warn(field As String)
        MessageBox.Show($"Inputan '{field}' tidak boleh kosong!", "⚠️ Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class

' ============================= FORM 2 =============================
Public Class Form2
    Inherits Form

    Private picCard As PictureBox

    Public Sub New()
        Me.Text = "Hasil Kartu Komunitas"
        Me.Size = New Size(620, 680)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.BackColor = Color.FromArgb(18, 28, 68)

        Dim lblTop As New Label()
        lblTop.Text = "✨  KARTU ANGGOTA KOMUNITAS  ✨"
        lblTop.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        lblTop.ForeColor = Color.FromArgb(190, 210, 255)
        lblTop.TextAlign = ContentAlignment.MiddleCenter
        lblTop.Location = New Point(0, 14)
        lblTop.Size = New Size(604, 28)
        Me.Controls.Add(lblTop)

        ' Card PictureBox — kita gambar pakai GDI+
        picCard = New PictureBox()
        picCard.Location = New Point(40, 50)
        picCard.Size = New Size(524, 540)
        picCard.BackColor = Color.White
        AddHandler picCard.Paint, AddressOf DrawCard
        Me.Controls.Add(picCard)

        Dim btnBack As New Button()
        btnBack.Text = "◀  KEMBALI KE FORM CETAK"
        btnBack.Location = New Point(40, 606)
        btnBack.Size = New Size(524, 46)
        btnBack.BackColor = Color.FromArgb(60, 120, 210)
        btnBack.ForeColor = Color.White
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnBack.Cursor = Cursors.Hand
        AddHandler btnBack.Click, Sub(s, ev) Me.Close()
        Me.Controls.Add(btnBack)
    End Sub

    Private Sub DrawCard(sender As Object, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit

        Dim W As Integer = picCard.Width
        Dim H As Integer = picCard.Height

        ' ---- Background card ----
        g.Clear(Color.White)

        ' ---- Header gradient ----
        Dim headerRect As New Rectangle(0, 0, W, 90)
        Using br As New LinearGradientBrush(headerRect, Color.FromArgb(18, 28, 68), Color.FromArgb(50, 90, 180), LinearGradientMode.Horizontal)
            g.FillRectangle(br, headerRect)
        End Using

        ' ---- Header text ----
        Using fBig As New Font("Segoe UI", 22, FontStyle.Bold)
            g.DrawString("🎴  KOMUNITAS", fBig, Brushes.White, New PointF(160, 14))
        End Using
        Using fSub As New Font("Segoe UI", 9, FontStyle.Italic)
            g.DrawString("KARTU TANDA ANGGOTA", fSub, New SolidBrush(Color.FromArgb(180, 210, 255)), New PointF(186, 58))
        End Using

        ' ---- Foto area ----
        Dim fotoRect As New Rectangle(18, 105, 140, 165)
        Using border As New Pen(Color.FromArgb(18, 28, 68), 2)
            g.DrawRectangle(border, fotoRect)
        End Using
        If Not String.IsNullOrEmpty(DataModule.FotoPath) AndAlso File.Exists(DataModule.FotoPath) Then
            Try
                Using img As Image = Image.FromFile(DataModule.FotoPath)
                    g.DrawImage(img, fotoRect)
                End Using
            Catch
                DrawDefaultAvatar(g, fotoRect)
            End Try
        Else
            DrawDefaultAvatar(g, fotoRect)
        End Using

        ' ---- Divider ----
        Using pen As New Pen(Color.FromArgb(200, 210, 240), 1)
            g.DrawLine(pen, 18, 283, W - 18, 283)
        End Using

        ' ---- Data fields ----
        Dim fields As (String, String)() = {
            ("NAMA", DataModule.Nama),
            ("UMUR", DataModule.Umur & " tahun"),
            ("TANGGAL LAHIR", DataModule.TanggalLahir),
            ("JENIS KELAMIN", DataModule.JenisKelamin),
            ("NO. TELEPON", DataModule.NoTelpon),
            ("HOBBY", DataModule.Hobbies),
            ("ALAMAT", DataModule.Alamat)
        }

        Dim startX As Integer = 172
        Dim startY As Integer = 108
        Dim lineH As Integer = 60

        Using fLabel As New Font("Segoe UI", 7.5F, FontStyle.Bold)
        Using fValue As New Font("Segoe UI", 11, FontStyle.Bold)
        Using fValueSmall As New Font("Segoe UI", 9)
        Using brLabel As New SolidBrush(Color.FromArgb(130, 140, 180))
        Using brValue As New SolidBrush(Color.FromArgb(18, 28, 68))

            Dim col As Integer = 0
            Dim row As Integer = 0
            For i As Integer = 0 To fields.Length - 1
                Dim colX As Integer = startX + col * 175
                Dim rowY As Integer = startY + row * lineH

                ' For hobby and alamat, full width below foto
                If fields(i).Item1 = "HOBBY" OrElse fields(i).Item1 = "ALAMAT" Then
                    colX = 18
                    rowY = 295 + (i - 5) * 58
                    Dim sf2 As New StringFormat()
                    sf2.Trimming = StringTrimming.EllipsisWord
                    g.DrawString(fields(i).Item1, fLabel, brLabel, New PointF(colX, rowY))
                    Dim valRect As New RectangleF(colX, rowY + 14, W - 36, 38)
                    g.DrawString(fields(i).Item2, fValueSmall, brValue, valRect, sf2)
                    Continue For
                End If

                g.DrawString(fields(i).Item1, fLabel, brLabel, New PointF(colX, rowY))
                If i = 0 Then
                    ' Nama - large font
                    g.DrawString(fields(i).Item2, fValue, brValue, New PointF(colX, rowY + 14))
                Else
                    g.DrawString(fields(i).Item2, fValueSmall, brValue, New PointF(colX, rowY + 14))
                End If

                col += 1
                If col = 2 Then col = 0 : row += 1
                If i = 0 Then col = 0 : row = 1  ' nama full width, next row
            Next

        End Using : End Using : End Using : End Using : End Using

        ' ---- Footer ----
        Dim footerRect As New Rectangle(0, H - 50, W, 50)
        Using br As New LinearGradientBrush(footerRect, Color.FromArgb(18, 28, 68), Color.FromArgb(50, 90, 180), LinearGradientMode.Horizontal)
            g.FillRectangle(br, footerRect)
        End Using
        Using fFooter As New Font("Segoe UI", 9, FontStyle.Bold)
        Using sfCenter As New StringFormat()
            sfCenter.Alignment = StringAlignment.Center
            sfCenter.LineAlignment = StringAlignment.Center
            g.DrawString("STUDENT IDENTIFICATION · VALID MEMBER", fFooter,
                New SolidBrush(Color.FromArgb(180, 210, 255)),
                New RectangleF(0, H - 50, W, 50), sfCenter)
        End Using : End Using
    End Sub

    Private Sub DrawDefaultAvatar(g As Graphics, r As Rectangle)
        g.FillRectangle(New SolidBrush(Color.FromArgb(220, 225, 245)), r)
        Using f As New Font("Segoe UI", 36)
            Dim sf As New StringFormat()
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center
            g.DrawString("👤", f, Brushes.LightGray, New RectangleF(r.X, r.Y, r.Width, r.Height), sf)
        End Using
    End Sub
End Class

' ============================= ENTRY POINT =============================
Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub
End Module
