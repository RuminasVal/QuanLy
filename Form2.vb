Imports System.Data.SqlClient

Public Class SanPham
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmasanpham.Enabled = True
        txtdongia.Enabled = True
        txtsanpham.Enabled = True
    End Sub
    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        Dim conn As New SqlConnection("Data Source=DESKTOP-358B61J;Initial Catalog=quanlybanhangcafe;Integrated Security=True")
        conn.Open()
        If txtmasanpham.Text = "" Or txtsanpham.Text = "" Or txtdongia.Text = "" Then
            MsgBox("Vui lòng nhập đủ thông tin!")
        Else
            Dim cmd As SqlCommand
            cmd = New SqlCommand("INSERT INTO SanPham (MaSP, TenSP, DonGia) VALUES (@MaSP, @TenSP, @DonGia)", conn)
            cmd.Parameters.AddWithValue("@MaSP", txtmasanpham.Text)
            cmd.Parameters.AddWithValue("@TenSP", txtsanpham.Text)
            cmd.Parameters.AddWithValue("@DonGia", txtdongia.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Thêm thành công!")
        End If
        conn.Close()
    End Sub
    Private Sub txtsanpham_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        If txtmasanpham.Text = " " Then
            MsgBox("Nhập mã sản phẩm cần xoá!")
        Else
            Dim conn As New SqlConnection("Data Source=DESKTOP-358B61J;Initial Catalog=quanlybanhangcafe;Integrated Security=True")
            conn.Open()
            Dim cmd As SqlCommand
            cmd = New SqlCommand("DELETE from SanPham where SanPham=@SanPham", conn)
            cmd.Parameters.AddWithValue("@MaSP", txtmasanpham.Text)
            cmd.Parameters.AddWithValue("@TenSP", txtsanpham.Text)
            cmd.Parameters.AddWithValue("@DonGia", txtdongia.Text)
            Dim rowUpdate As Integer
            rowUpdate = cmd.ExecuteNonQuery()
            If rowUpdate > 0 Then
                MsgBox("Xoá thành công!")
            Else
                MsgBox("Không tồn tại MaSP này!")
            End If
        End If
    End Sub
End Class