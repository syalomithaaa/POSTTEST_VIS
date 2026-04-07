<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Me.Label1 = New Label()
        Me.Label2 = New Label()
        Me.Label3 = New Label()
        Me.Label4= New Label()
        Me.lblHobi = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(95, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(228, 314)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Location = New Point(372, 58)
        Me.Label1.Name = "lblNama"
        Me.Label1.Size = New Size(59, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama"
        ' 
        ' lblID
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Location = New Point(372, 104)
        Me.Label2.Name = "lblID"
        Me.Label2.Size = New Size(30, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        ' 
        ' lblKomunitas
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Location = New Point(372, 151)
        Me.Label3.Name = "lblKomunitas"
        Me.Label3.Size = New Size(96, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Komunitas"
        ' 
        ' lblKontak
        ' 
        Me.Label4.AutoSize = True
        Me.Label4.Location = New Point(372, 196)
        Me.Label4.Name = "lblKontak"
        Me.Label4.Size = New Size(67, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kontak"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(372, 244)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(51, 25)
        lblHobi.TabIndex = 5
        lblHobi.Text = "Hobi"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHobi)
        Controls.Add(Me.Label1)
        Controls.Add(Me.Label2)
        Controls.Add(Me.Label3)
        Controls.Add(Me.Label4)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblHobi As Label
End Class
