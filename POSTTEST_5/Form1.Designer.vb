<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        txtUmur = New TextBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        txtKeluhan = New TextBox()
        dgvKeluhan = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvKeluhan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama Pasien"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(183, 23)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(563, 31)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 2
        Label2.Text = "Umur"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(183, 78)
        txtUmur.Name = "txtUmur"
        txtUmur.PlaceholderText = "Umur"
        txtUmur.Size = New Size(563, 31)
        txtUmur.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 4
        Label3.Text = "Poli Tujuan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Items.AddRange(New Object() {"Umum", "Gigi", "Anak", "Kandungan", "Saraf"})
        ComboBox1.Location = New Point(183, 135)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(563, 33)
        ComboBox1.TabIndex = 5
        ComboBox1.Text = "Pilih Poli"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(56, 202)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 25)
        Label4.TabIndex = 6
        Label4.Text = "Keluhan"
        ' 
        ' txtKeluhan
        ' 
        txtKeluhan.Location = New Point(183, 199)
        txtKeluhan.Multiline = True
        txtKeluhan.Name = "txtKeluhan"
        txtKeluhan.Size = New Size(563, 47)
        txtKeluhan.TabIndex = 7
        ' 
        ' dgvKeluhan
        ' 
        dgvKeluhan.BackgroundColor = Color.Pink
        dgvKeluhan.ColumnHeadersHeight = 34
        dgvKeluhan.Location = New Point(54, 270)
        dgvKeluhan.Name = "dgvKeluhan"
        dgvKeluhan.RowHeadersWidth = 62
        dgvKeluhan.Size = New Size(692, 230)
        dgvKeluhan.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.HotPink
        Button1.Location = New Point(41, 520)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 38)
        Button1.TabIndex = 9
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.HotPink
        Button2.Location = New Point(239, 520)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 38)
        Button2.TabIndex = 10
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.HotPink
        Button3.Location = New Point(446, 520)
        Button3.Name = "Button3"
        Button3.Size = New Size(89, 38)
        Button3.TabIndex = 11
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.HotPink
        Button4.Location = New Point(653, 520)
        Button4.Name = "Button4"
        Button4.Size = New Size(93, 38)
        Button4.TabIndex = 12
        Button4.Text = "Reset"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(800, 570)
        Controls.Add(Label1)
        Controls.Add(txtNama)
        Controls.Add(Label2)
        Controls.Add(txtUmur)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(txtKeluhan)
        Controls.Add(dgvKeluhan)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Name = "Form1"
        Text = "Form Pasien"
        CType(dgvKeluhan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKeluhan As TextBox
    Friend WithEvents dgvKeluhan As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class