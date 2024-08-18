Imports System.Data.SqlClient

Public Class Form1

    Private kuncimember As Boolean = False
    Private total As Integer = 0
    Private dgv As DataGridView = DataGridView1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call start()
        cb_pelanggan.Enabled = True
    End Sub

    Sub start()
        Call isicbbarang()
        Call isicbpelanggan()
        Call generatekodetransaksi()
        cb_barang.Text = ""
        cb_pelanggan.Text = ""
        txtjumlah.Text = ""
        txtsubtotal.Text = ""
        DataGridView1.Rows.Clear()
        total = 0
        lbltotal.Text = 0
        cb_pelanggan.Enabled = True
    End Sub


    Sub generatekodetransaksi()
        Dim currentDate As Date = Date.Now
        Dim formatedDate As String = currentDate.ToString("yyMMdd")
        Dim jumlahTransaksi As Integer

        Using conn As New SqlConnection(lokasi)
            conn.Open()
            Using cmd As New SqlCommand("select Count(*) as jumlah from tb_transaksi where tgl_transaksi = '" & DateTime.Now.ToString("yyyy-MM-dd") & "'", conn)
                Dim rd As SqlDataReader = cmd.ExecuteReader
                rd.Read()
                If rd!jumlah! = 0 Then
                    jumlahTransaksi = 1
                Else
                    jumlahTransaksi = rd!jumlah + 1
                End If
            End Using
        End Using

        Dim kodetr = "T" & formatedDate & jumlahTransaksi.ToString("D3")
        kode_transaksi.Text = kodetr

    End Sub

    Sub isicbpelanggan()
        Using conn As New SqlConnection(lokasi)
            conn.Open()
            Using cmd As New SqlCommand("Select * from tb_pelanggan", conn)
                Dim rd As SqlDataReader = cmd.ExecuteReader
                While rd.Read
                    If rd.HasRows Then
                        cb_pelanggan.Items.Add(rd!kode_pelanggan)
                    End If
                End While
            End Using
            conn.Close()
        End Using
    End Sub

    Sub isicbbarang()
        Using conn As New SqlConnection(lokasi)
            conn.Open()
            Using cmd As New SqlCommand("Select * from tb_barang", conn)
                Dim rd As SqlDataReader = cmd.ExecuteReader
                While rd.Read
                    If rd.HasRows Then
                        cb_barang.Items.Add(rd!nama_barang)
                    End If
                End While
            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim harga As Integer
        Dim ketemu As Boolean = False
        For i As Integer = 0 To DataGridView1.RowCount - 2
            If DataGridView1.Rows(i).Cells(0).Value = cb_barang.Text Then
                ketemu = True
                DataGridView1.Rows(i).Cells(1).Value += Val(txtjumlah.Text)
                DataGridView1.Rows(i).Cells(3).Value = DataGridView1.Rows(i).Cells(1).Value * DataGridView1.Rows(i).Cells(2).Value
                total += DataGridView1.Rows(i).Cells(2).Value * Val(txtjumlah.Text)
                lbltotal.Text = total
                Exit For
            End If
        Next
        If ketemu = False Then
            Using conn As New SqlConnection(lokasi)
                conn.Open()
                Using cmd As New SqlCommand("Select * from tb_barang where nama_barang = '" & cb_barang.Text & "'", conn)
                    Dim rd As SqlDataReader = cmd.ExecuteReader
                    rd.Read()
                    If rd.HasRows Then
                        harga = rd!harga_barang
                        total += harga * txtjumlah.Text
                        lbltotal.Text = total
                    End If
                End Using
                DataGridView1.Rows.Add(cb_barang.Text, txtjumlah.Text, harga, harga * Val(txtjumlah.Text))


                conn.Close()
            End Using
        End If
    End Sub

    Private Sub cb_pelanggan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_pelanggan.SelectedIndexChanged
        kuncimember = True
        cb_pelanggan.Enabled = False
    End Sub


    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged
        Using conn As New SqlConnection(lokasi)
            conn.Open()
            Using cmd As New SqlCommand("Select harga_barang from tb_barang where nama_barang = '" & cb_barang.Text & "'", conn)
                Dim rd As SqlDataReader = cmd.ExecuteReader
                rd.Read()
                If txtjumlah.Text = "0" Or txtjumlah.Text = "" Then
                    txtsubtotal.Text = 0
                Else
                    txtsubtotal.Text = rd!harga_barang * txtjumlah.Text
                End If
            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub cb_barang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_barang.SelectedIndexChanged
        txtjumlah.Text = ""
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Dim idpel As Integer
        Using conn As New SqlConnection(lokasi)
            conn.Open()
            Using cmd As New SqlCommand("Select * from tb_pelanggan where kode_pelanggan = '" & cb_pelanggan.Text & "'", conn)
                Dim rd As SqlDataReader = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows Then
                    idpel = rd!id_pelanggan
                End If
            End Using
            conn.Close()
        End Using
        For i As Integer = 0 To DataGridView1.RowCount - 2
            Using conn As New SqlConnection(lokasi)
                conn.Open()
                Using cmd1 As New SqlCommand(
                    "INSERT INTO tb_transaksi (kode_transaksi, id_barang, id_pelanggan, subtotal, tgl_transaksi) VALUES(" &
                    "'" & kode_transaksi.Text & "'," &
                    "(SELECT id_barang FROM tb_barang where nama_barang = '" & DataGridView1.Rows(i).Cells(0).Value & "')," &
                    "'" & idpel & "'," &
                    "'" & DataGridView1.Rows(i).Cells(3).Value & "'," &
                    "'" & Date.Now.ToString("yyyy-MM-dd") & "')",
                    conn)
                    cmd1.ExecuteNonQuery()

                End Using
                Using cmd2 As New SqlCommand(
                    "UPDATE tb_barang set stok -= '" & DataGridView1.Rows(i).Cells(1).Value & "'",
                    conn
                    )
                    cmd2.ExecuteNonQuery()
                End Using
                conn.Close()
            End Using

            Call start()
            MsgBox("Data Transaksi Berhasil Ditambahkan")
        Next
    End Sub
End Class
