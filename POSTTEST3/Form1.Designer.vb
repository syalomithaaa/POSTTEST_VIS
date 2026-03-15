<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picProfil = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.lblNoTelpon = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblTanggalLahir = New System.Windows.Forms.Label()
        Me.lblHobby = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtNoTelpon = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.grpJenisKelamin = New System.Windows.Forms.GroupBox()
        Me.rbLakiLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.grpHobby = New System.Windows.Forms.GroupBox()
        Me.chkGaming = New System.Windows.Forms.CheckBox()
        Me.chkCoding = New System.Windows.Forms.CheckBox()
        Me.chkTraveling = New System.Windows.Forms.CheckBox()
        Me.chkMenggambar = New System.Windows.Forms.CheckBox()
        Me.chkMenulis = New System.Windows.Forms.CheckBox()
        Me.chkMemancing = New System.Windows.Forms.CheckBox()
        Me.chkMembaca = New System.Windows.Forms.CheckBox()
        Me.chkOlahraga = New System.Windows.Forms.CheckBox()
        Me.chkMenyanyi = New System.Windows.Forms.CheckBox()
        Me.chkMenari = New System.Windows.Forms.CheckBox()
        Me.chkMemasak = New System.Windows.Forms.CheckBox()
        Me.chkFotografi = New System.Windows.Forms.CheckBox()
        Me.btnCetakKartu = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.pnlFoto = New System.Windows.Forms.Panel()
        Me.lblFotoHint = New System.Windows.Forms.Label()

        CType(Me.picProfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpJenisKelamin.SuspendLayout()
        Me.grpHobby.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFoto.SuspendLayout()
        Me.SuspendLayout()

        ' pnlHeader
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(20, 30, 70)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 80
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubTitle)

        ' lblTitle
        Me.lblTitle.Text = "🎴 KOMUNITAS CARD MAKER"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 10)
        Me.lblTitle.AutoSize = True

        ' lblSubTitle
        Me.lblSubTitle.Text = "Isi data diri untuk membuat kartu anggota komunitas"
        Me.lblSubTitle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255)
        Me.lblSubTitle.Location = New System.Drawing.Point(22, 48)
        Me.lblSubTitle.AutoSize = True

        ' pnlFoto
        Me.pnlFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFoto.BackColor = System.Drawing.Color.FromArgb(240, 242, 255)
        Me.pnlFoto.Location = New System.Drawing.Point(20, 100)
        Me.pnlFoto.Size = New System.Drawing.Size(140, 160)
        Me.pnlFoto.Controls.Add(Me.picProfil)

        ' picProfil
        Me.picProfil.Location = New System.Drawing.Point(0, 0)
        Me.picProfil.Size = New System.Drawing.Size(140, 160)
        Me.picProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfil.BackColor = System.Drawing.Color.FromArgb(230, 235, 255)

        ' lblFotoHint
        Me.lblFotoHint.Text = "📷 Foto Profil"
        Me.lblFotoHint.Font = New System.Drawing.Font("Segoe UI", 8)
        Me.lblFotoHint.ForeColor = System.Drawing.Color.Gray
        Me.lblFotoHint.Location = New System.Drawing.Point(20, 268)
        Me.lblFotoHint.AutoSize = True

        ' btnBrowse
        Me.btnBrowse.Text = "📁 Browse Foto"
        Me.btnBrowse.Location = New System.Drawing.Point(20, 285)
        Me.btnBrowse.Size = New System.Drawing.Size(140, 35)
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(70, 130, 220)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.FlatAppearance.BorderSize = 0

        ' lblNama
        Me.lblNama.Text = "Nama Lengkap"
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblNama.ForeColor = System.Drawing.Color.FromArgb(40, 50, 100)
        Me.lblNama.Location = New System.Drawing.Point(178, 100)
        Me.lblNama.AutoSize = True

        ' txtNama
        Me.txtNama.Location = New System.Drawing.Point(178, 118)
        Me.txtNama.Size = New System.Drawing.Size(260, 28)
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' lblUmur
        Me.lblUmur.Text = "Umur"
        Me.lblUmur.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblUmur.ForeColor = System.Drawing.Color.FromArgb(40, 50, 100)
        Me.lblUmur.Location = New System.Drawing.Point(178, 158)
        Me.lblUmur.AutoSize = True

        ' txtUmur
        Me.txtUmur.Location = New System.Drawing.Point(178, 176)
        Me.txtUmur.Size = New System.Drawing.Size(100, 28)
        Me.txtUmur.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtUmur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' lblNoTelpon
        Me.lblNoTelpon.Text = "No. Telepon"
        Me.lblNoTelpon.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblNoTelpon.ForeColor = System.Drawing.Color.FromArgb(40, 50, 100)
        Me.lblNoTelpon.Location = New System.Drawing.Point(298, 158)
        Me.lblNoTelpon.AutoSize = True

        ' txtNoTelpon
        Me.txtNoTelpon.Location = New System.Drawing.Point(298, 176)
        Me.txtNoTelpon.Size = New System.Drawing.Size(140, 28)
        Me.txtNoTelpon.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtNoTelpon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' lblTanggalLahir
        Me.lblTanggalLahir.Text = "Tanggal Lahir"
        Me.lblTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblTanggalLahir.ForeColor = System.Drawing.Color.FromArgb(40, 50, 100)
        Me.lblTanggalLahir.Location = New System.Drawing.Point(178, 218)
        Me.lblTanggalLahir.AutoSize = True

        ' dtpTanggalLahir
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(178, 236)
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(260, 28)
        Me.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTanggalLahir.Font = New System.Drawing.Font("Segoe UI", 10)

        ' lblAlamat
        Me.lblAlamat.Text = "Alamat"
        Me.lblAlamat.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblAlamat.ForeColor = System.Drawing.Color.FromArgb(40, 50, 100)
        Me.lblAlamat.Location = New System.Drawing.Point(178, 276)
        Me.lblAlamat.AutoSize = True

        ' txtAlamat
        Me.txtAlamat.Location = New System.Drawing.Point(178, 294)
        Me.txtAlamat.Size = New System.Drawing.Size(260, 28)
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' grpJenisKelamin
        Me.grpJenisKelamin.Text = "Jenis Kelamin"
        Me.grpJenisKelamin.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpJenisKelamin.ForeColor = System.Drawing.Color.FromArgb(40, 50, 100)
        Me.grpJenisKelamin.Location = New System.Drawing.Point(20, 335)
        Me.grpJenisKelamin.Size = New System.Drawing.Size(200, 65)
        Me.grpJenisKelamin.Controls.Add(Me.rbLakiLaki)
        Me.grpJenisKelamin.Controls.Add(Me.rbPerempuan)

        ' rbLakiLaki
        Me.rbLakiLaki.Text = "Laki-Laki"
        Me.rbLakiLaki.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.rbLakiLaki.Location = New System.Drawing.Point(10, 28)
        Me.rbLakiLaki.AutoSize = True

        ' rbPerempuan
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.rbPerempuan.Location = New System.Drawing.Point(100, 28)
        Me.rbPerempuan.AutoSize = True

        ' lblHobby
        Me.lblHobby.Text = "Hobby"
        Me.lblHobby.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblHobby.ForeColor = System.Drawing.Color.FromArgb(40, 50, 100)
        Me.lblHobby.Location = New System.Drawing.Point(178, 340)
        Me.lblHobby.AutoSize = True

        ' grpHobby
        Me.grpHobby.Text = "Pilih Hobby (min. 1)"
        Me.grpHobby.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpHobby.ForeColor = System.Drawing.Color.FromArgb(40, 50, 100)
        Me.grpHobby.Location = New System.Drawing.Point(178, 335)
        Me.grpHobby.Size = New System.Drawing.Size(420, 110)
        Me.grpHobby.Controls.Add(Me.chkGaming)
        Me.grpHobby.Controls.Add(Me.chkCoding)
        Me.grpHobby.Controls.Add(Me.chkTraveling)
        Me.grpHobby.Controls.Add(Me.chkMenggambar)
        Me.grpHobby.Controls.Add(Me.chkMenulis)
        Me.grpHobby.Controls.Add(Me.chkMemancing)
        Me.grpHobby.Controls.Add(Me.chkMembaca)
        Me.grpHobby.Controls.Add(Me.chkOlahraga)
        Me.grpHobby.Controls.Add(Me.chkMenyanyi)
        Me.grpHobby.Controls.Add(Me.chkMenari)
        Me.grpHobby.Controls.Add(Me.chkMemasak)
        Me.grpHobby.Controls.Add(Me.chkFotografi)

        ' CheckBoxes
        Dim cbFont As New System.Drawing.Font("Segoe UI", 8.5F)
        Me.chkGaming.Text = "Gaming" : Me.chkGaming.Font = cbFont : Me.chkGaming.Location = New System.Drawing.Point(8, 25) : Me.chkGaming.AutoSize = True
        Me.chkCoding.Text = "Coding" : Me.chkCoding.Font = cbFont : Me.chkCoding.Location = New System.Drawing.Point(88, 25) : Me.chkCoding.AutoSize = True
        Me.chkTraveling.Text = "Traveling" : Me.chkTraveling.Font = cbFont : Me.chkTraveling.Location = New System.Drawing.Point(168, 25) : Me.chkTraveling.AutoSize = True
        Me.chkMenggambar.Text = "Menggambar" : Me.chkMenggambar.Font = cbFont : Me.chkMenggambar.Location = New System.Drawing.Point(258, 25) : Me.chkMenggambar.AutoSize = True
        Me.chkMenulis.Text = "Menulis" : Me.chkMenulis.Font = cbFont : Me.chkMenulis.Location = New System.Drawing.Point(358, 25) : Me.chkMenulis.AutoSize = True
        Me.chkMemancing.Text = "Memancing" : Me.chkMemancing.Font = cbFont : Me.chkMemancing.Location = New System.Drawing.Point(8, 55) : Me.chkMemancing.AutoSize = True
        Me.chkMembaca.Text = "Membaca" : Me.chkMembaca.Font = cbFont : Me.chkMembaca.Location = New System.Drawing.Point(88, 55) : Me.chkMembaca.AutoSize = True
        Me.chkOlahraga.Text = "Olahraga" : Me.chkOlahraga.Font = cbFont : Me.chkOlahraga.Location = New System.Drawing.Point(168, 55) : Me.chkOlahraga.AutoSize = True
        Me.chkMenyanyi.Text = "Menyanyi" : Me.chkMenyanyi.Font = cbFont : Me.chkMenyanyi.Location = New System.Drawing.Point(258, 55) : Me.chkMenyanyi.AutoSize = True
        Me.chkMenari.Text = "Menari" : Me.chkMenari.Font = cbFont : Me.chkMenari.Location = New System.Drawing.Point(358, 55) : Me.chkMenari.AutoSize = True
        Me.chkMemasak.Text = "Memasak" : Me.chkMemasak.Font = cbFont : Me.chkMemasak.Location = New System.Drawing.Point(8, 82) : Me.chkMemasak.AutoSize = True
        Me.chkFotografi.Text = "Fotografi" : Me.chkFotografi.Font = cbFont : Me.chkFotografi.Location = New System.Drawing.Point(88, 82) : Me.chkFotografi.AutoSize = True

        ' btnCetakKartu
        Me.btnCetakKartu.Text = "🎴  CETAK KARTU"
        Me.btnCetakKartu.Location = New System.Drawing.Point(20, 460)
        Me.btnCetakKartu.Size = New System.Drawing.Size(580, 48)
        Me.btnCetakKartu.BackColor = System.Drawing.Color.FromArgb(20, 30, 70)
        Me.btnCetakKartu.ForeColor = System.Drawing.Color.White
        Me.btnCetakKartu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetakKartu.FlatAppearance.BorderSize = 0
        Me.btnCetakKartu.Font = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)

        ' Form1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 255)
        Me.ClientSize = New System.Drawing.Size(630, 530)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Text = "Form Cetak Kartu Komunitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFoto)
        Me.Controls.Add(Me.lblFotoHint)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblUmur)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.lblNoTelpon)
        Me.Controls.Add(Me.txtNoTelpon)
        Me.Controls.Add(Me.lblTanggalLahir)
        Me.Controls.Add(Me.dtpTanggalLahir)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.grpJenisKelamin)
        Me.Controls.Add(Me.grpHobby)
        Me.Controls.Add(Me.btnCetakKartu)

        CType(Me.picProfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpJenisKelamin.ResumeLayout(False)
        Me.grpHobby.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFoto.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents picProfil As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblUmur As System.Windows.Forms.Label
    Friend WithEvents lblNoTelpon As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblTanggalLahir As System.Windows.Forms.Label
    Friend WithEvents lblHobby As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtUmur As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTelpon As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpJenisKelamin As System.Windows.Forms.GroupBox
    Friend WithEvents rbLakiLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents grpHobby As System.Windows.Forms.GroupBox
    Friend WithEvents chkGaming As System.Windows.Forms.CheckBox
    Friend WithEvents chkCoding As System.Windows.Forms.CheckBox
    Friend WithEvents chkTraveling As System.Windows.Forms.CheckBox
    Friend WithEvents chkMenggambar As System.Windows.Forms.CheckBox
    Friend WithEvents chkMenulis As System.Windows.Forms.CheckBox
    Friend WithEvents chkMemancing As System.Windows.Forms.CheckBox
    Friend WithEvents chkMembaca As System.Windows.Forms.CheckBox
    Friend WithEvents chkOlahraga As System.Windows.Forms.CheckBox
    Friend WithEvents chkMenyanyi As System.Windows.Forms.CheckBox
    Friend WithEvents chkMenari As System.Windows.Forms.CheckBox
    Friend WithEvents chkMemasak As System.Windows.Forms.CheckBox
    Friend WithEvents chkFotografi As System.Windows.Forms.CheckBox
    Friend WithEvents btnCetakKartu As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle As System.Windows.Forms.Label
    Friend WithEvents pnlFoto As System.Windows.Forms.Panel
    Friend WithEvents lblFotoHint As System.Windows.Forms.Label
End Class
