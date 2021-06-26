
Imports Microsoft.Office.Interop

Public Class FrmThongsodam
    'Nhập dữ liệu khi nhấn nút nhập
    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        dgvNhap.Rows.Clear()
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "Excel (*.xls;*.xlsx)|*.xls;*.xlsx"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(OpenFileDialog1.FileName)
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
            'Dem so hang
            Dim sh As Integer
            For i As Integer = 2 To 100
                If xlWorkSheet.Cells(i, 1).value <> Nothing Then
                    sh = i - 1
                Else
                    Exit For
                End If
            Next
            Me.dgvNhap.Rows.Clear()
            For i As Integer = 2 To sh + 1
                dgvNhap.Rows.Add(xlWorkSheet.Cells(i, 1).value, xlWorkSheet.Cells(i, 2).value, xlWorkSheet.Cells(i, 3).value, xlWorkSheet.Cells(i, 4).value, xlWorkSheet.Cells(i, 5).value, xlWorkSheet.Cells(i, 6).value)
            Next
            xlWorkBook.Close()
            xlApp.Quit()
        End If
        If dgvNhap.Rows.Count <> 0 Then
            txtTendam.Text = dgvNhap.Rows(0).Cells(0).Value
            txtVitri.Text = dgvNhap.Rows(0).Cells(1).Value
            txtDai.Text = dgvNhap.Rows(0).Cells(2).Value
            txtRong.Text = dgvNhap.Rows(0).Cells(3).Value
            txtCao.Text = dgvNhap.Rows(0).Cells(4).Value
            txtMomen.Text = dgvNhap.Rows(0).Cells(5).Value

        End If
    End Sub

    'Thêm dữ liệu khi nhấn nút thêm
    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        If txtTendam.Text = "" Or txtDai.Text = "" Or txtRong.Text = "" Or txtCao.Text = "" Or txtVitri.Text = "" Or txtMomen.Text = "" Then
            MsgBox("Bạn chưa nhập đủ dữ liệu cho cột" & vbNewLine & "Vui lòng kiểm tra lại", MsgBoxStyle.Information, "Thông báo")
        Else
            If IsNumeric(txtDai.Text) = False Or IsNumeric(txtRong.Text) = False Or IsNumeric(txtCao.Text) = False Or IsNumeric(txtMomen.Text) = False Then
                MsgBox("Dữ liệu nhập vào chưa đúng định dạng" & vbNewLine & "Vui lòng kiểm tra lại", MsgBoxStyle.Information, "Thông báo")
            Else
                dgvNhap.Rows.Add(txtTendam.Text, txtVitri.Text, txtDai.Text, txtRong.Text, txtCao.Text, txtMomen.Text)
                txtTendam.Clear()
                txtDai.Clear()
                txtRong.Clear()
                txtCao.Clear()
                txtVitri.Clear()
                txtMomen.Clear()

            End If
        End If
    End Sub


    'Xóa dữ liệu khi nhấn nút xóa
    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim giatri, i As Byte
        i = dgvNhap.CurrentCell.RowIndex
        giatri = MsgBox("Bạn có muốn xóa dữ liệu dòng thứ " & i + 1, MsgBoxStyle.YesNoCancel, "Thông báo")
        If giatri = 6 Then
            dgvNhap.Rows.RemoveAt(i)
        End If
        If i = dgvNhap.Rows.Count Then
            txtTendam.Text = dgvNhap.Rows(i - 1).Cells(0).Value
            txtDai.Text = dgvNhap.Rows(i - 1).Cells(2).Value
            txtRong.Text = dgvNhap.Rows(i - 1).Cells(3).Value
            txtCao.Text = dgvNhap.Rows(i - 1).Cells(4).Value
            txtMomen.Text = dgvNhap.Rows(i - 1).Cells(5).Value
            txtVitri.Text = dgvNhap.Rows(i - 1).Cells(1).Value
        Else
            txtTendam.Text = dgvNhap.Rows(i).Cells(0).Value
            txtDai.Text = dgvNhap.Rows(i).Cells(2).Value
            txtRong.Text = dgvNhap.Rows(i).Cells(3).Value
            txtCao.Text = dgvNhap.Rows(i).Cells(4).Value
            txtMomen.Text = dgvNhap.Rows(i).Cells(5).Value
            txtVitri.Text = dgvNhap.Rows(i).Cells(1).Value
        End If
    End Sub
    Dim KiemTra As Boolean = False
    'Lưu dữ liệu khi nhấn nút lưu
    Private Sub btnluu_Click(sender As Object, e As EventArgs) Handles btnluu.Click
        DSDam.Clear()
        hf = txthf.Text
        Dim i As Byte

        For i = 0 To dgvNhap.Rows.Count - 1

            DSDam.Add(dgvNhap.Rows(i).Cells(0).Value, dgvNhap.Rows(i).Cells(1).Value, dgvNhap.Rows(i).Cells(2).Value, dgvNhap.Rows(i).Cells(3).Value, dgvNhap.Rows(i).Cells(4).Value, dgvNhap.Rows(i).Cells(5).Value)
        Next
        KiemTra = True
        MsgBox("Đã lưu thành công")
    End Sub
#Region "Tính toán diện tích cốt thép"
    Private Sub btntinhtoan_Click(sender As Object, e As EventArgs) Handles btntinhtoan.Click

        Dim L, h, h0, anpha_m, gnuy, b, goxi, M, Mf, Astt, bf, hf, x, muy, muymin As Double
        Dim i, j As Integer
        Dim stt As Integer = 0
        Dim check As Boolean = False

        If GoxiR = 0 Then
            MsgBox("Bạn chưa chọn thông số vật liệu")
        Else
            If dgvNhap.Rows.Count = 0 Then
                MsgBox("Không có dữ liệu để tính toán")
            Else
                a = InputBox("Nhập chiều dày lớp bảo vệ a(cm) = ", "Nhập Dữ Liệu")
                If a <> "" Then
                    If IsNumeric(a) = False Then
                        MsgBox("Dữ liệu nhập vào chưa đúng định dạng" & vbNewLine & "Vui lòng kiểm tra lại", MsgBoxStyle.Information, "Thông báo")
                    Else
                        KetQuaDam.Clear()
                        For i = 0 To dgvNhap.Rows.Count - 1
                            L = dgvNhap.Rows(i).Cells(2).Value * 100
                            b = dgvNhap.Rows(i).Cells(3).Value * 100
                            h = dgvNhap.Rows(i).Cells(4).Value * 100
                            h0 = h - a
                            muymin = 0.05
                            hf = txthf.Text * 100
                            If hf > 0.1 * h Then
                                bf = 2 * (L / 6) + b
                            Else
                                bf = 2 * Math.Min(6 * hf, L / 6) + b
                            End If
                            M = dgvNhap.Rows(i).Cells(5).Value

                            Mf = Rb / 10 * b * bf * (h0 - 0.5 * hf)

                            'Tinh dien tich hinh chu nhat
                            If M < 0 Then
                                anpha_m = Math.Abs(M) * 1000 / (Rb * b * h0 ^ 2)
                                gnuy = (1 + Math.Sqrt(1 - 2 * anpha_m)) / 2

                                If anpha_m <= anphaR Then
                                    Astt = Math.Round(Math.Abs(M) * 1000 / (Rs * gnuy * h0), 2)

                                Else
                                    MsgBox("Tiết diện quá nhỏ")
                                End If


                                'Tinh dien tich hinh chu T

                            ElseIf 0 < M < Mf Then
                                anpha_m = Math.Abs(M) * 1000 / (Rb * bf * h0 ^ 2)
                                gnuy = (1 + Math.Sqrt(1 - 2 * anpha_m)) / 2
                                If anpha_m <= anphaR Then
                                    Astt = Math.Round(Math.Abs(M) * 1000 / (Rs * gnuy * h0), 2)

                                Else
                                    MsgBox("Tiết diện quá nhỏ")
                                End If
                            Else
                                anpha_m = (Math.Abs(M) * 100 - Rb / 10 * (bf - b) * hf * (h0 - 0.5 * hf)) / (Rb / 10 * b * h0 ^ 2)
                                gnuy = (1 + Math.Sqrt(1 - 2 * anpha_m)) / 2
                                goxi = 2 * (1 - gnuy)
                                If anpha_m <= anphaR Then
                                    Astt = Math.Round(Rb * (goxi * b * h0 + (bf - b) * hf) / Rs, 2)

                                Else
                                    If anpha_m <= 0.5 Then
                                        MsgBox("Tiết diện quá nhỏ")
                                    End If
                                End If

                            End If
                            muy = Math.Round(Astt / (b * h0) * 100, 2)
                            If muy < muymin Then
                                Astt = Math.Round(b * h0 * 0.05 / 100)
                                muy = muymin
                            End If

                            If KetQuaDam.count = 0 Then
                                KetQuaDam.Add(dgvNhap.Rows(i).Cells(0).Value, dgvNhap.Rows(i).Cells(1).Value, dgvNhap.Rows(i).Cells(2).Value, dgvNhap.Rows(i).Cells(3).Value, dgvNhap.Rows(i).Cells(4).Value, Astt, muy, "")
                            Else
                                For j = 0 To KetQuaDam.count - 1
                                    If dgvNhap.Rows(i).Cells(0).Value = KetQuaDam.Dam(j).Vitri Then
                                        check = True
                                        stt = j
                                    End If
                                Next
                                If check = True Then
                                    If Astt > KetQuaDam.Dam(stt).Astt Then
                                        KetQuaDam.Dam(stt).Astt = Astt
                                        KetQuaDam.Dam(stt).Muy = muy
                                        check = False
                                    Else
                                        check = False
                                    End If

                                Else
                                    KetQuaDam.Add(dgvNhap.Rows(i).Cells(0).Value, dgvNhap.Rows(i).Cells(1).Value, dgvNhap.Rows(i).Cells(2).Value, dgvNhap.Rows(i).Cells(3).Value, dgvNhap.Rows(i).Cells(4).Value, Astt, muy, "")
                                End If
                            End If

                        Next
                        MsgBox("Đã tính toán xong")
                        Me.Close()

                        FrmBotrithep.Show()
                    End If
                End If
            End If
        End If

    End Sub
#End Region
    'Chuyển dữ liệu lên textbox khi click vào datagridview
    Private Sub dgvNhap_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvNhap.MouseClick
        If dgvNhap.Rows.Count <> 0 Then
            Dim i As Byte = dgvNhap.CurrentCell.RowIndex
            txtTendam.Text = dgvNhap.Rows(i).Cells(0).Value
            txtVitri.Text = dgvNhap.Rows(i).Cells(1).Value
            txtDai.Text = dgvNhap.Rows(i).Cells(2).Value
            txtRong.Text = dgvNhap.Rows(i).Cells(3).Value
            txtCao.Text = dgvNhap.Rows(i).Cells(4).Value
            txtMomen.Text = dgvNhap.Rows(i).Cells(5).Value

        End If
    End Sub
    'Load dữ liệu vào datagridview khi mở form
    Private Sub FrmThongsodam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.Default


        txthf.Text = hf
        Dim i As Integer
        If DSDam.count <> 0 Then
            For i = 0 To DSDam.count - 1
                dgvNhap.Rows.Add(DSDam.Dam(i).TenDam, DSDam.Dam(i).Vitri, DSDam.Dam(i).Dai, DSDam.Dam(i).Rong, DSDam.Dam(i).Cao, DSDam.Dam(i).Momen)
            Next
            txtTendam.Text = dgvNhap.Rows(0).Cells(0).Value
            txtVitri.Text = dgvNhap.Rows(0).Cells(1).Value
            txtDai.Text = dgvNhap.Rows(0).Cells(2).Value
            txtRong.Text = dgvNhap.Rows(0).Cells(3).Value
            txtCao.Text = dgvNhap.Rows(0).Cells(4).Value
            txtMomen.Text = dgvNhap.Rows(0).Cells(5).Value

        End If
    End Sub
    'Lưu dữ liệu khi đóng form
    Private Sub FrmThongsodam_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim j As Integer
        If KiemTra = False Then
            If MsgBox("Bạn có muốn lưu dữ liệu", vbYesNoCancel) = vbYes Then
                hf = txthf.Text
                DSDam.Clear()
                For j = 0 To dgvNhap.Rows.Count - 1
                    DSDam.Add(dgvNhap.Rows(j).Cells(0).Value, dgvNhap.Rows(j).Cells(1).Value, dgvNhap.Rows(j).Cells(2).Value, dgvNhap.Rows(j).Cells(3).Value, dgvNhap.Rows(j).Cells(4).Value, dgvNhap.Rows(j).Cells(5).Value)
                Next
            End If
        End If
    End Sub
    'Sửa dữ liệu khi nhấn nút sửa
    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim giatri, i As Byte
        i = dgvNhap.CurrentCell.RowIndex
        giatri = MsgBox("Bạn có muốn sửa dữ liệu dòng thứ " & i + 1, MsgBoxStyle.YesNoCancel, "Thông báo")
        If giatri = 6 Then
            If txtTendam.Text = "" Or txtDai.Text = "" Or txtRong.Text = "" Or txtCao.Text = "" Or txtMomen.Text = "" Or txtVitri.Text = "" Then
                MsgBox("Bạn chưa nhập đủ dữ liệu cho cột" & vbNewLine & "Vui lòng kiểm tra lại", MsgBoxStyle.Information, "Thông báo")
            Else
                If IsNumeric(txtDai.Text) = False Or IsNumeric(txtRong.Text) = False Or IsNumeric(txtCao.Text) = False Or IsNumeric(txtMomen.Text) = False Then
                    MsgBox("Dữ liệu nhập vào chưa đúng định dạng" & vbNewLine & "Vui lòng kiểm tra lại", MsgBoxStyle.Information, "Thông báo")
                Else
                    dgvNhap.Rows(i).Cells(0).Value = txtTendam.Text
                    dgvNhap.Rows(i).Cells(1).Value = txtVitri.Text
                    dgvNhap.Rows(i).Cells(2).Value = txtDai.Text
                    dgvNhap.Rows(i).Cells(3).Value = txtRong.Text
                    dgvNhap.Rows(i).Cells(4).Value = txtCao.Text
                    dgvNhap.Rows(i).Cells(5).Value = txtMomen.Text

                    txtTendam.Text = dgvNhap.Rows(i).Cells(0).Value
                    txtVitri.Text = dgvNhap.Rows(i).Cells(1).Value
                    txtDai.Text = dgvNhap.Rows(i).Cells(2).Value
                    txtRong.Text = dgvNhap.Rows(i).Cells(3).Value
                    txtCao.Text = dgvNhap.Rows(i).Cells(4).Value
                    txtMomen.Text = dgvNhap.Rows(i).Cells(5).Value

                End If
            End If
        End If
    End Sub
End Class