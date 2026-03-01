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
        txtIPS = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        label2 = New Label()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        label1 = New Label()
        SuspendLayout()
        ' 
        ' txtIPS
        ' 
        txtIPS.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        txtIPS.Font = New Font("STKaiti", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtIPS.Location = New Point(58, 130)
        txtIPS.Name = "txtIPS"
        txtIPS.Size = New Size(150, 31)
        txtIPS.TabIndex = 1
        txtIPS.Text = "masukkan IP !!"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnTambah.Location = New Point(58, 349)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnReset.Location = New Point(206, 349)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(56, 210)
        label2.Name = "label2"
        label2.Size = New Size(107, 25)
        label2.TabIndex = 4
        label2.Text = "IP Kumulatif"
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        txtIPK.Font = New Font("STLiti", 8.999999F, FontStyle.Italic, GraphicsUnit.Point, CByte(134))
        txtIPK.ForeColor = Color.Red
        txtIPK.Location = New Point(56, 240)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(150, 27)
        txtIPK.TabIndex = 5
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.BackColor = Color.Purple
        lblPredikat.ForeColor = SystemColors.ButtonHighlight
        lblPredikat.Location = New Point(206, 298)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 25)
        lblPredikat.TabIndex = 6
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(58, 102)
        label1.Name = "label1"
        label1.Size = New Size(105, 25)
        label1.TabIndex = 7
        label1.Text = "IP Semester"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(label1)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(label2)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPS)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents label2 As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label
    Friend WithEvents label1 As Label

End Class
