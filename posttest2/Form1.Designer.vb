<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        grpTambah = New GroupBox()
        Button1 = New Button()
        lblGenre = New Label()
        lblJudulTambah = New Label()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        grpHapus = New GroupBox()
        Button2 = New Button()
        txtJudulHapus = New TextBox()
        lblJudulHapus = New Label()
        txtDaftar = New TextBox()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpTambah
        ' 
        grpTambah.BackColor = Color.LightPink
        grpTambah.Controls.Add(Button1)
        grpTambah.Controls.Add(lblGenre)
        grpTambah.Controls.Add(lblJudulTambah)
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(txtJudulTambah)
        grpTambah.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpTambah.Location = New Point(12, 12)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(359, 211)
        grpTambah.TabIndex = 0
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LavenderBlush
        Button1.Location = New Point(231, 171)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 1
        Button1.Text = "Tambah"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(21, 126)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(61, 20)
        lblGenre.TabIndex = 3
        lblGenre.Text = "Genre"
        ' 
        ' lblJudulTambah
        ' 
        lblJudulTambah.AutoSize = True
        lblJudulTambah.Location = New Point(21, 65)
        lblJudulTambah.Name = "lblJudulTambah"
        lblJudulTambah.Size = New Size(114, 20)
        lblJudulTambah.TabIndex = 2
        lblJudulTambah.Text = "Judul Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.BackColor = Color.LavenderBlush
        txtGenre.Location = New Point(146, 120)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(175, 31)
        txtGenre.TabIndex = 1
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.BackColor = Color.LavenderBlush
        txtJudulTambah.Location = New Point(146, 62)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(175, 31)
        txtJudulTambah.TabIndex = 0
        ' 
        ' grpHapus
        ' 
        grpHapus.BackColor = Color.LightPink
        grpHapus.Controls.Add(Button2)
        grpHapus.Controls.Add(txtJudulHapus)
        grpHapus.Controls.Add(lblJudulHapus)
        grpHapus.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpHapus.Location = New Point(422, 12)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(366, 211)
        grpHapus.TabIndex = 0
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LavenderBlush
        Button2.Location = New Point(237, 171)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 1
        Button2.Text = "Hapus"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.BackColor = Color.LavenderBlush
        txtJudulHapus.Location = New Point(155, 62)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(175, 31)
        txtJudulHapus.TabIndex = 2
        ' 
        ' lblJudulHapus
        ' 
        lblJudulHapus.AutoSize = True
        lblJudulHapus.Location = New Point(29, 65)
        lblJudulHapus.Name = "lblJudulHapus"
        lblJudulHapus.Size = New Size(114, 20)
        lblJudulHapus.TabIndex = 1
        lblJudulHapus.Text = "Judul Buku"
        ' 
        ' txtDaftar
        ' 
        txtDaftar.BackColor = Color.LightPink
        txtDaftar.Font = New Font("STZhongsong", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDaftar.Location = New Point(200, 238)
        txtDaftar.Multiline = True
        txtDaftar.Name = "txtDaftar"
        txtDaftar.ScrollBars = ScrollBars.Vertical
        txtDaftar.Size = New Size(371, 256)
        txtDaftar.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleVioletRed
        ClientSize = New Size(800, 501)
        Controls.Add(txtDaftar)
        Controls.Add(grpHapus)
        Controls.Add(grpTambah)
        Name = "Form1"
        Text = "Form1"
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents lblJudulTambah As Label
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents lblJudulHapus As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDaftar As TextBox

End Class
