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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button4 = New Button()
        cmbKomunitas = New ComboBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        dtpTanggal = New DateTimePicker()
        Label3 = New Label()
        TextBox2 = New TextBox()
        txtNama = New TextBox()
        Label2 = New Label()
        TabPage2 = New TabPage()
        mtbHP = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        btnSimpan = New Button()
        btnLihat = New Button()
        Label4 = New Label()
        CheckBox13 = New CheckBox()
        CheckBox12 = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        GroupBox1 = New GroupBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        btnUpload = New Button()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(112, 29)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(111, 29)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(130, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(108, 29)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(76, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(152, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(476, 45)
        Label1.TabIndex = 1
        Label1.Text = "APLIKASI KARTU KOMUNITAS"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(12, 175)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 813)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Button4)
        TabPage1.Controls.Add(cmbKomunitas)
        TabPage1.Controls.Add(RadioButton2)
        TabPage1.Controls.Add(RadioButton1)
        TabPage1.Controls.Add(dtpTanggal)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label2)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 775)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(339, 406)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 8
        Button4.Text = "Simpan File"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Location = New Point(23, 243)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(182, 33)
        cmbKomunitas.TabIndex = 7
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(561, 228)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(126, 29)
        RadioButton2.TabIndex = 6
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(561, 174)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(102, 29)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki Laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(23, 171)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(300, 31)
        dtpTanggal.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 3
        Label3.Text = "ID Anggota"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(156, 98)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(381, 31)
        TextBox2.TabIndex = 2
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(156, 21)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(381, 31)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(mtbHP)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 775)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' mtbHP
        ' 
        mtbHP.Location = New Point(74, 234)
        mtbHP.Mask = "0000-0000-0000"
        mtbHP.Name = "mtbHP"
        mtbHP.Size = New Size(150, 31)
        mtbHP.TabIndex = 3
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(74, 150)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(401, 31)
        txtAlamat.TabIndex = 2
        txtAlamat.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(74, 65)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(401, 31)
        txtEmail.TabIndex = 0
        txtEmail.Text = "Email "
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(btnLihat)
        TabPage3.Controls.Add(Label4)
        TabPage3.Controls.Add(CheckBox13)
        TabPage3.Controls.Add(CheckBox12)
        TabPage3.Controls.Add(CheckBox11)
        TabPage3.Controls.Add(CheckBox10)
        TabPage3.Controls.Add(CheckBox9)
        TabPage3.Controls.Add(CheckBox8)
        TabPage3.Controls.Add(CheckBox7)
        TabPage3.Controls.Add(CheckBox6)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnUpload)
        TabPage3.Controls.Add(PictureBox1)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(768, 775)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktifitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(435, 713)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnLihat
        ' 
        btnLihat.Location = New Point(602, 713)
        btnLihat.Name = "btnLihat"
        btnLihat.Size = New Size(112, 34)
        btnLihat.TabIndex = 4
        btnLihat.Text = "Lihat Kartu"
        btnLihat.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 449)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 11
        Label4.Text = "Hobi :"
        ' 
        ' CheckBox13
        ' 
        CheckBox13.AutoSize = True
        CheckBox13.Location = New Point(266, 654)
        CheckBox13.Name = "CheckBox13"
        CheckBox13.Size = New Size(107, 29)
        CheckBox13.TabIndex = 10
        CheckBox13.Text = "Traveling"
        CheckBox13.UseVisualStyleBackColor = True
        ' 
        ' CheckBox12
        ' 
        CheckBox12.AutoSize = True
        CheckBox12.Location = New Point(58, 654)
        CheckBox12.Name = "CheckBox12"
        CheckBox12.Size = New Size(85, 29)
        CheckBox12.TabIndex = 9
        CheckBox12.Text = "Musik"
        CheckBox12.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.Location = New Point(266, 601)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(111, 29)
        CheckBox11.TabIndex = 8
        CheckBox11.Text = "Fotografi"
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(58, 601)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(100, 29)
        CheckBox10.TabIndex = 7
        CheckBox10.Text = "Gaming"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(266, 548)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(96, 29)
        CheckBox9.TabIndex = 6
        CheckBox9.Text = "Coding"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(58, 548)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(99, 29)
        CheckBox8.TabIndex = 5
        CheckBox8.Text = "Menulis"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(266, 497)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(110, 29)
        CheckBox7.TabIndex = 4
        CheckBox7.Text = "Olahraga"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(59, 497)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(116, 29)
        CheckBox6.TabIndex = 3
        CheckBox6.Text = "Membaca"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBox5)
        GroupBox1.Controls.Add(CheckBox4)
        GroupBox1.Controls.Add(CheckBox3)
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Location = New Point(385, 138)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 217)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(6, 178)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(96, 29)
        CheckBox5.TabIndex = 6
        CheckBox5.Text = "Kurator"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 143)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(123, 29)
        CheckBox4.TabIndex = 5
        CheckBox4.Text = "Moderator"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(6, 108)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(108, 29)
        CheckBox3.TabIndex = 4
        CheckBox3.Text = "Anggota"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(6, 73)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(91, 29)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Admin"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 38)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(82, 29)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Ketua"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' btnUpload
        ' 
        btnUpload.Location = New Point(59, 321)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(112, 34)
        btnUpload.TabIndex = 1
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(59, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(213, 271)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 992)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "FormMain"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbHP As MaskedTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnUpload As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnLihat As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button4 As Button

End Class
