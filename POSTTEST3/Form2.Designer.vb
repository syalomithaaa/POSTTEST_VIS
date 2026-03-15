<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.pnlCardHeader = New System.Windows.Forms.Panel()
        Me.lblCardTitle = New System.Windows.Forms.Label()
        Me.lblCardSubTitle = New System.Windows.Forms.Label()
        Me.picProfilCard = New System.Windows.Forms.PictureBox()
        Me.pnlCardBody = New System.Windows.Forms.Panel()
        Me.lblCardNamaLbl = New System.Windows.Forms.Label()
        Me.lblCardNama = New System.Windows.Forms.Label()
        Me.lblCardUmurLbl = New System.Windows.Forms.Label()
        Me.lblCardUmur = New System.Windows.Forms.Label()
        Me.lblCardTglLahirLbl = New System.Windows.Forms.Label()
        Me.lblCardTglLahir = New System.Windows.Forms.Label()
        Me.lblCardJKLbl = New System.Windows.Forms.Label()
        Me.lblCardJK = New System.Windows.Forms.Label()
        Me.lblCardTelpLbl = New System.Windows.Forms.Label()
        Me.lblCardTelp = New System.Windows.Forms.Label()
        Me.lblCardHobbyLbl = New System.Windows.Forms.Label()
        Me.lblCardHobby = New System.Windows.Forms.Label()
        Me.lblCardAlamatLbl = New System.Windows.Forms.Label()
        Me.lblCardAlamat = New System.Windows.Forms.Label()
        Me.pnlCardFooter = New System.Windows.Forms.Panel()
        Me.lblCardFooter = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.lblWindowTitle = New System.Windows.Forms.Label()

        CType(Me.picProfilCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCard.SuspendLayout()
        Me.pnlCardHeader.SuspendLayout()
        Me.pnlCardBody.SuspendLayout()
        Me.pnlCardFooter.SuspendLayout()
        Me.SuspendLayout()

        ' Form2 window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(30, 40, 80)
        Me.ClientSize = New System.Drawing.Size(580, 600)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Text = "Hasil Kartu Komunitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen

        ' lblWindowTitle
        Me.lblWindowTitle.Text = "✨ KARTU ANGGOTA KOMUNITAS ✨"
        Me.lblWindowTitle.Font = New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)
        Me.lblWindowTitle.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255)
        Me.lblWindowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWindowTitle.Location = New System.Drawing.Point(0, 15)
        Me.lblWindowTitle.Size = New System.Drawing.Size(580, 30)

        ' pnlCard - the card container with shadow effect
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Location = New System.Drawing.Point(40, 55)
        Me.pnlCard.Size = New System.Drawing.Size(500, 460)
        Me.pnlCard.Controls.Add(Me.pnlCardHeader)
        Me.pnlCard.Controls.Add(Me.picProfilCard)
        Me.pnlCard.Controls.Add(Me.pnlCardBody)
        Me.pnlCard.Controls.Add(Me.pnlCardFooter)

        ' pnlCardHeader
        Me.pnlCardHeader.BackColor = System.Drawing.Color.FromArgb(20, 30, 70)
        Me.pnlCardHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlCardHeader.Size = New System.Drawing.Size(500, 70)
        Me.pnlCardHeader.Controls.Add(Me.lblCardTitle)
        Me.pnlCardHeader.Controls.Add(Me.lblCardSubTitle)

        ' lblCardTitle
        Me.lblCardTitle.Text = "🎴 KOMUNITAS"
        Me.lblCardTitle.Font = New System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold)
        Me.lblCardTitle.ForeColor = System.Drawing.Color.White
        Me.lblCardTitle.Location = New System.Drawing.Point(170, 8)
        Me.lblCardTitle.AutoSize = True

        ' lblCardSubTitle
        Me.lblCardSubTitle.Text = "KARTU TANDA ANGGOTA"
        Me.lblCardSubTitle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Italic)
        Me.lblCardSubTitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255)
        Me.lblCardSubTitle.Location = New System.Drawing.Point(185, 44)
        Me.lblCardSubTitle.AutoSize = True

        ' picProfilCard
        Me.picProfilCard.Location = New System.Drawing.Point(15, 85)
        Me.picProfilCard.Size = New System.Drawing.Size(130, 150)
        Me.picProfilCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfilCard.BackColor = System.Drawing.Color.FromArgb(220, 230, 255)
        Me.picProfilCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle

        ' pnlCardBody
        Me.pnlCardBody.Location = New System.Drawing.Point(155, 78)
        Me.pnlCardBody.Size = New System.Drawing.Size(335, 320)
        Me.pnlCardBody.BackColor = System.Drawing.Color.White
        Me.pnlCardBody.Controls.Add(Me.lblCardNamaLbl)
        Me.pnlCardBody.Controls.Add(Me.lblCardNama)
        Me.pnlCardBody.Controls.Add(Me.lblCardUmurLbl)
        Me.pnlCardBody.Controls.Add(Me.lblCardUmur)
        Me.pnlCardBody.Controls.Add(Me.lblCardTglLahirLbl)
        Me.pnlCardBody.Controls.Add(Me.lblCardTglLahir)
        Me.pnlCardBody.Controls.Add(Me.lblCardJKLbl)
        Me.pnlCardBody.Controls.Add(Me.lblCardJK)
        Me.pnlCardBody.Controls.Add(Me.lblCardTelpLbl)
        Me.pnlCardBody.Controls.Add(Me.lblCardTelp)
        Me.pnlCardBody.Controls.Add(Me.lblCardHobbyLbl)
        Me.pnlCardBody.Controls.Add(Me.lblCardHobby)
        Me.pnlCardBody.Controls.Add(Me.lblCardAlamatLbl)
        Me.pnlCardBody.Controls.Add(Me.lblCardAlamat)

        ' Row layout helper
        Dim lblFont As New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
        Dim valFont As New System.Drawing.Font("Segoe UI", 9)
        Dim labelColor As System.Drawing.Color = System.Drawing.Color.FromArgb(100, 110, 160)
        Dim valueColor As System.Drawing.Color = System.Drawing.Color.FromArgb(20, 30, 70)

        ' Nama
        Me.lblCardNamaLbl.Text = "NAMA" : Me.lblCardNamaLbl.Font = lblFont : Me.lblCardNamaLbl.ForeColor = labelColor : Me.lblCardNamaLbl.Location = New System.Drawing.Point(8, 10) : Me.lblCardNamaLbl.AutoSize = True
        Me.lblCardNama.Text = "-" : Me.lblCardNama.Font = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold) : Me.lblCardNama.ForeColor = valueColor : Me.lblCardNama.Location = New System.Drawing.Point(8, 26) : Me.lblCardNama.Size = New System.Drawing.Size(320, 22)

        ' Umur
        Me.lblCardUmurLbl.Text = "UMUR" : Me.lblCardUmurLbl.Font = lblFont : Me.lblCardUmurLbl.ForeColor = labelColor : Me.lblCardUmurLbl.Location = New System.Drawing.Point(8, 58) : Me.lblCardUmurLbl.AutoSize = True
        Me.lblCardUmur.Text = "-" : Me.lblCardUmur.Font = valFont : Me.lblCardUmur.ForeColor = valueColor : Me.lblCardUmur.Location = New System.Drawing.Point(8, 72) : Me.lblCardUmur.AutoSize = True

        ' Tanggal Lahir
        Me.lblCardTglLahirLbl.Text = "TANGGAL LAHIR" : Me.lblCardTglLahirLbl.Font = lblFont : Me.lblCardTglLahirLbl.ForeColor = labelColor : Me.lblCardTglLahirLbl.Location = New System.Drawing.Point(130, 58) : Me.lblCardTglLahirLbl.AutoSize = True
        Me.lblCardTglLahir.Text = "-" : Me.lblCardTglLahir.Font = valFont : Me.lblCardTglLahir.ForeColor = valueColor : Me.lblCardTglLahir.Location = New System.Drawing.Point(130, 72) : Me.lblCardTglLahir.AutoSize = True

        ' Jenis Kelamin
        Me.lblCardJKLbl.Text = "JENIS KELAMIN" : Me.lblCardJKLbl.Font = lblFont : Me.lblCardJKLbl.ForeColor = labelColor : Me.lblCardJKLbl.Location = New System.Drawing.Point(8, 102) : Me.lblCardJKLbl.AutoSize = True
        Me.lblCardJK.Text = "-" : Me.lblCardJK.Font = valFont : Me.lblCardJK.ForeColor = valueColor : Me.lblCardJK.Location = New System.Drawing.Point(8, 116) : Me.lblCardJK.AutoSize = True

        ' No Telepon
        Me.lblCardTelpLbl.Text = "NO. TELEPON" : Me.lblCardTelpLbl.Font = lblFont : Me.lblCardTelpLbl.ForeColor = labelColor : Me.lblCardTelpLbl.Location = New System.Drawing.Point(130, 102) : Me.lblCardTelpLbl.AutoSize = True
        Me.lblCardTelp.Text = "-" : Me.lblCardTelp.Font = valFont : Me.lblCardTelp.ForeColor = valueColor : Me.lblCardTelp.Location = New System.Drawing.Point(130, 116) : Me.lblCardTelp.AutoSize = True

        ' Hobby
        Me.lblCardHobbyLbl.Text = "HOBBY" : Me.lblCardHobbyLbl.Font = lblFont : Me.lblCardHobbyLbl.ForeColor = labelColor : Me.lblCardHobbyLbl.Location = New System.Drawing.Point(8, 146) : Me.lblCardHobbyLbl.AutoSize = True
        Me.lblCardHobby.Text = "-" : Me.lblCardHobby.Font = valFont : Me.lblCardHobby.ForeColor = valueColor : Me.lblCardHobby.Location = New System.Drawing.Point(8, 162) : Me.lblCardHobby.Size = New System.Drawing.Size(320, 50)

        ' Alamat
        Me.lblCardAlamatLbl.Text = "ALAMAT" : Me.lblCardAlamatLbl.Font = lblFont : Me.lblCardAlamatLbl.ForeColor = labelColor : Me.lblCardAlamatLbl.Location = New System.Drawing.Point(8, 220) : Me.lblCardAlamatLbl.AutoSize = True
        Me.lblCardAlamat.Text = "-" : Me.lblCardAlamat.Font = valFont : Me.lblCardAlamat.ForeColor = valueColor : Me.lblCardAlamat.Location = New System.Drawing.Point(8, 236) : Me.lblCardAlamat.Size = New System.Drawing.Size(320, 40)

        ' pnlCardFooter
        Me.pnlCardFooter.BackColor = System.Drawing.Color.FromArgb(20, 30, 70)
        Me.pnlCardFooter.Location = New System.Drawing.Point(0, 415)
        Me.pnlCardFooter.Size = New System.Drawing.Size(500, 45)
        Me.pnlCardFooter.Controls.Add(Me.lblCardFooter)

        ' lblCardFooter
        Me.lblCardFooter.Text = "STUDENT IDENTIFICATION · VALID MEMBER"
        Me.lblCardFooter.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblCardFooter.ForeColor = System.Drawing.Color.FromArgb(180, 200, 255)
        Me.lblCardFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCardFooter.Dock = System.Windows.Forms.DockStyle.Fill

        ' btnKembali
        Me.btnKembali.Text = "◀  KEMBALI KE FORM CETAK"
        Me.btnKembali.Location = New System.Drawing.Point(40, 530)
        Me.btnKembali.Size = New System.Drawing.Size(500, 45)
        Me.btnKembali.BackColor = System.Drawing.Color.FromArgb(70, 130, 220)
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.FlatAppearance.BorderSize = 0
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)

        Me.Controls.Add(Me.lblWindowTitle)
        Me.Controls.Add(Me.pnlCard)
        Me.Controls.Add(Me.btnKembali)

        CType(Me.picProfilCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCardHeader.ResumeLayout(False)
        Me.pnlCardHeader.PerformLayout()
        Me.pnlCardBody.ResumeLayout(False)
        Me.pnlCardBody.PerformLayout()
        Me.pnlCardFooter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents pnlCardHeader As System.Windows.Forms.Panel
    Friend WithEvents lblCardTitle As System.Windows.Forms.Label
    Friend WithEvents lblCardSubTitle As System.Windows.Forms.Label
    Friend WithEvents picProfilCard As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCardBody As System.Windows.Forms.Panel
    Friend WithEvents lblCardNamaLbl As System.Windows.Forms.Label
    Friend WithEvents lblCardNama As System.Windows.Forms.Label
    Friend WithEvents lblCardUmurLbl As System.Windows.Forms.Label
    Friend WithEvents lblCardUmur As System.Windows.Forms.Label
    Friend WithEvents lblCardTglLahirLbl As System.Windows.Forms.Label
    Friend WithEvents lblCardTglLahir As System.Windows.Forms.Label
    Friend WithEvents lblCardJKLbl As System.Windows.Forms.Label
    Friend WithEvents lblCardJK As System.Windows.Forms.Label
    Friend WithEvents lblCardTelpLbl As System.Windows.Forms.Label
    Friend WithEvents lblCardTelp As System.Windows.Forms.Label
    Friend WithEvents lblCardHobbyLbl As System.Windows.Forms.Label
    Friend WithEvents lblCardHobby As System.Windows.Forms.Label
    Friend WithEvents lblCardAlamatLbl As System.Windows.Forms.Label
    Friend WithEvents lblCardAlamat As System.Windows.Forms.Label
    Friend WithEvents pnlCardFooter As System.Windows.Forms.Panel
    Friend WithEvents lblCardFooter As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents lblWindowTitle As System.Windows.Forms.Label
End Class
