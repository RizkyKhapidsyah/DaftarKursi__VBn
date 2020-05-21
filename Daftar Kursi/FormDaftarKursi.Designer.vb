<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDaftarKursi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDaftarKursi))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tombolTampil = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.teksBaris = New System.Windows.Forms.TextBox()
        Me.teksKol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelHarga = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(435, 444)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tombolTampil
        '
        Me.tombolTampil.Location = New System.Drawing.Point(12, 455)
        Me.tombolTampil.Name = "tombolTampil"
        Me.tombolTampil.Size = New System.Drawing.Size(108, 37)
        Me.tombolTampil.TabIndex = 1
        Me.tombolTampil.Text = "Tampilkan Harga"
        Me.tombolTampil.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(270, 455)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(108, 37)
        Me.tombolKeluar.TabIndex = 2
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Masukkan Baris"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Masukkan Kolom"
        '
        'teksBaris
        '
        Me.teksBaris.Location = New System.Drawing.Point(107, 21)
        Me.teksBaris.Name = "teksBaris"
        Me.teksBaris.Size = New System.Drawing.Size(60, 20)
        Me.teksBaris.TabIndex = 5
        '
        'teksKol
        '
        Me.teksKol.Location = New System.Drawing.Point(107, 47)
        Me.teksKol.Name = "teksKol"
        Me.teksKol.Size = New System.Drawing.Size(60, 20)
        Me.teksKol.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(267, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Harga Kursi"
        '
        'labelHarga
        '
        Me.labelHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelHarga.Location = New System.Drawing.Point(335, 24)
        Me.labelHarga.Name = "labelHarga"
        Me.labelHarga.Size = New System.Drawing.Size(92, 23)
        Me.labelHarga.TabIndex = 8
        Me.labelHarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormDaftarKursi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 500)
        Me.Controls.Add(Me.labelHarga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.teksKol)
        Me.Controls.Add(Me.teksBaris)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolTampil)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormDaftarKursi"
        Me.Text = "Daftar Kursi"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tombolTampil As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents teksBaris As System.Windows.Forms.TextBox
    Friend WithEvents teksKol As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labelHarga As System.Windows.Forms.Label

End Class
