<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kode_transaksi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_pelanggan = New System.Windows.Forms.ComboBox()
        Me.cb_barang = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txtsubtotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.namabarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hargasatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(263, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Kasir Sederhana"
        '
        'kode_transaksi
        '
        Me.kode_transaksi.AutoSize = True
        Me.kode_transaksi.Location = New System.Drawing.Point(61, 106)
        Me.kode_transaksi.Name = "kode_transaksi"
        Me.kode_transaksi.Size = New System.Drawing.Size(48, 16)
        Me.kode_transaksi.TabIndex = 1
        Me.kode_transaksi.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kode Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(445, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Barang"
        '
        'cb_pelanggan
        '
        Me.cb_pelanggan.FormattingEnabled = True
        Me.cb_pelanggan.Location = New System.Drawing.Point(187, 176)
        Me.cb_pelanggan.Name = "cb_pelanggan"
        Me.cb_pelanggan.Size = New System.Drawing.Size(223, 24)
        Me.cb_pelanggan.TabIndex = 4
        '
        'cb_barang
        '
        Me.cb_barang.FormattingEnabled = True
        Me.cb_barang.Location = New System.Drawing.Point(546, 176)
        Me.cb_barang.Name = "cb_barang"
        Me.cb_barang.Size = New System.Drawing.Size(223, 24)
        Me.cb_barang.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Jumlah"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(187, 234)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(223, 22)
        Me.txtjumlah.TabIndex = 7
        '
        'txtsubtotal
        '
        Me.txtsubtotal.Enabled = False
        Me.txtsubtotal.Location = New System.Drawing.Point(546, 234)
        Me.txtsubtotal.Name = "txtsubtotal"
        Me.txtsubtotal.Size = New System.Drawing.Size(223, 22)
        Me.txtsubtotal.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(446, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Subtotal"
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(614, 288)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(155, 32)
        Me.btn_tambah.TabIndex = 10
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.namabarang, Me.jumlah, Me.hargasatuan, Me.subtotal})
        Me.DataGridView1.Location = New System.Drawing.Point(64, 374)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(705, 221)
        Me.DataGridView1.TabIndex = 11
        '
        'namabarang
        '
        Me.namabarang.HeaderText = "Nama Barang"
        Me.namabarang.MinimumWidth = 6
        Me.namabarang.Name = "namabarang"
        Me.namabarang.Width = 125
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 6
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Width = 125
        '
        'hargasatuan
        '
        Me.hargasatuan.HeaderText = "Harga Satuan"
        Me.hargasatuan.MinimumWidth = 6
        Me.hargasatuan.Name = "hargasatuan"
        Me.hargasatuan.Width = 125
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.MinimumWidth = 6
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Width = 125
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(614, 697)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(155, 32)
        Me.btnsimpan.TabIndex = 12
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(461, 632)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total:"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(661, 632)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(0, 16)
        Me.lbltotal.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 769)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.txtsubtotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_barang)
        Me.Controls.Add(Me.cb_pelanggan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kode_transaksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents kode_transaksi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_pelanggan As ComboBox
    Friend WithEvents cb_barang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_tambah As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnsimpan As Button
    Friend WithEvents namabarang As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents hargasatuan As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents lbltotal As Label
End Class
