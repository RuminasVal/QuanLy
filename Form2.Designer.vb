<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SanPham
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
        Me.lblqlybancafe = New System.Windows.Forms.Label()
        Me.lblnhansanpham = New System.Windows.Forms.Label()
        Me.lblnhapnhanvien = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnnhap = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.txtmasanpham = New System.Windows.Forms.TextBox()
        Me.txtsanpham = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblqlybancafe
        '
        Me.lblqlybancafe.AutoSize = True
        Me.lblqlybancafe.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqlybancafe.Location = New System.Drawing.Point(177, 9)
        Me.lblqlybancafe.Name = "lblqlybancafe"
        Me.lblqlybancafe.Size = New System.Drawing.Size(144, 31)
        Me.lblqlybancafe.TabIndex = 0
        Me.lblqlybancafe.Text = "Sản phẩm"
        '
        'lblnhansanpham
        '
        Me.lblnhansanpham.AutoSize = True
        Me.lblnhansanpham.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnhansanpham.Location = New System.Drawing.Point(24, 67)
        Me.lblnhansanpham.Name = "lblnhansanpham"
        Me.lblnhansanpham.Size = New System.Drawing.Size(141, 16)
        Me.lblnhansanpham.TabIndex = 2
        Me.lblnhansanpham.Text = "Nhập mã sản phẩm"
        '
        'lblnhapnhanvien
        '
        Me.lblnhapnhanvien.AutoSize = True
        Me.lblnhapnhanvien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnhapnhanvien.Location = New System.Drawing.Point(24, 139)
        Me.lblnhapnhanvien.Name = "lblnhapnhanvien"
        Me.lblnhapnhanvien.Size = New System.Drawing.Size(141, 16)
        Me.lblnhapnhanvien.TabIndex = 3
        Me.lblnhapnhanvien.Text = "Nhập tên sản phẩm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nhập đơn giá"
        '
        'btnnhap
        '
        Me.btnnhap.Location = New System.Drawing.Point(27, 290)
        Me.btnnhap.Name = "btnnhap"
        Me.btnnhap.Size = New System.Drawing.Size(139, 60)
        Me.btnnhap.TabIndex = 7
        Me.btnnhap.Text = "Nhập"
        Me.btnnhap.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(183, 290)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(142, 60)
        Me.btnxoa.TabIndex = 8
        Me.btnxoa.Text = "Xoá"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(343, 290)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(142, 60)
        Me.btnthoat.TabIndex = 9
        Me.btnthoat.Text = "Trở lại "
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'txtmasanpham
        '
        Me.txtmasanpham.Location = New System.Drawing.Point(193, 64)
        Me.txtmasanpham.Name = "txtmasanpham"
        Me.txtmasanpham.Size = New System.Drawing.Size(291, 20)
        Me.txtmasanpham.TabIndex = 10
        '
        'txtsanpham
        '
        Me.txtsanpham.Location = New System.Drawing.Point(194, 135)
        Me.txtsanpham.Name = "txtsanpham"
        Me.txtsanpham.Size = New System.Drawing.Size(291, 20)
        Me.txtsanpham.TabIndex = 11
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(193, 209)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(291, 20)
        Me.txtdongia.TabIndex = 12
        '
        'SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 371)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txtsanpham)
        Me.Controls.Add(Me.txtmasanpham)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnnhap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnhapnhanvien)
        Me.Controls.Add(Me.lblnhansanpham)
        Me.Controls.Add(Me.lblqlybancafe)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "SanPham"
        Me.Text = "SanPham"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblqlybancafe As Label
    Friend WithEvents lblnhansanpham As Label
    Friend WithEvents lblnhapnhanvien As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnnhap As Button
    Friend WithEvents btnxoa As Button
    Friend WithEvents btnthoat As Button
    Friend WithEvents txtmasanpham As TextBox
    Friend WithEvents txtsanpham As TextBox
    Friend WithEvents txtdongia As TextBox
End Class
