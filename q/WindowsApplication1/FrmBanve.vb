Public Class FrmBanve

    Public BV As VDProLib5.vdEntities


    Private Sub Banve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i, a As Integer
        cbtendam.Items.Clear()
        For i = 0 To KetQuaDam.count - 2
            cbtendam.Items.Add(KetQuaDam.Dam(i).TenDam)
            For a = 1 To KetQuaDam.count - 2

                If KetQuaDam.Dam(i).TenDam = KetQuaDam.Dam(a).TenDam Then
                    i = i + 1
                End If
            Next
        Next


    End Sub

    Private Sub btnbotrithep_Click(sender As Object, e As EventArgs) Handles btnbotrithep.Click
        Me.Close()
        FrmBotrithep.Show()

    End Sub
    Dim kc1, kc2, kc3 As Double
    Dim GL_nhip
    Private Sub cbtendam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtendam.SelectedIndexChanged

        Dim i As Integer = cbtendam.SelectedIndex
        txtL.Text = KetQuaDam.Dam(3 * i).Dai
        txtb.Text = KetQuaDam.Dam(3 * i).Rong
        txth.Text = KetQuaDam.Dam(3 * i).Cao
        txtvitri1.Text = KetQuaDam.Dam(3 * i).Vitri
        txtvitri2.Text = KetQuaDam.Dam(3 * i + 1).Vitri
        txtvitri3.Text = KetQuaDam.Dam(3 * i + 2).Vitri
        txtthepdoc1.Text = KetQuaDam.Dam(3 * i).ThepDoc
        txtthepdoc2.Text = KetQuaDam.Dam(3 * i + 1).ThepDoc
        txtthepdoc3.Text = KetQuaDam.Dam(3 * i + 2).ThepDoc

        Dim nhip As Double = Convert.ToDouble(txtL.Text) * 1000
        Dim nhip1 As Double = nhip / 4
        Dim nhip2 As Double
        nhip2 = nhip - 2 * nhip1
        Dim sothanh As Double = Math.Truncate(nhip1 / 100) + 1 ' Cộng thêm 1 ra số thanh
        Dim sothanhgiua As Double = Math.Truncate(nhip2 / 200) + 1 ' Cộng thêm 1 ra số thanh
        txtthepdai1.Text = sothanh.ToString + "Ø8a100"
        txtthepdai2.Text = sothanhgiua.ToString + "Ø8a200"
        txtthepdai3.Text = sothanh.ToString + "Ø8a100"
    End Sub

    Private Sub btnve_Click(sender As Object, e As EventArgs) Handles btnve.Click
        Try
#Region "Khai báo các thông số và lấy màu vẽ"
            khungve.ActiveDocument.Open(Application.StartupPath + "\\mauchuan1.dxf", 0, 0)
            khungve.ActiveDocument.Entities.EraseAll()
            BV = Me.khungve.ActiveDocument.Entities

            ' lấy chiều dài và chiều rộng ở bên trên xuống đẻ vẽ 
            Dim nhip, l, h, b, b_cot As Double
            l = Convert.ToDouble(txtL.Text) * 1000 + 1400
            nhip = l - 700 * 2 ' 600 tạm thời là 2 cột
            b_cot = 700 ' tạm thời vậy
            h = Convert.ToDouble(txth.Text) * 1000 ' chuyển sang mm
            b = Convert.ToDouble(txtb.Text) * 1000 ' chuyển sang mm
            Dim layerdam As String = "3"
            Dim lopbaove As Double = 70 ' tạm thế
            Dim chieucaodimtren As Double = 300
#End Region
#Region "Vẽ thép lớp trên( momen âm), vẽ đoạn cắt thép, vẽ đoạn vươn 1/4 nhịp, dim luôn và gán số lượng cốt đai đã tính  "
            Dim list_p As New DiemDauDiemCuoi()
            list_p = thuvienve.CreateNewLineR2(BV, New Point(0 - b_cot + lopbaove, h - lopbaove), New Point(nhip + b_cot - lopbaove, h - lopbaove), "1") ' ve thep tren va tra ve 2 diem dau cuoi, lopbaove là đi xuống 1 đoạn 
            thuvienve.CreateNewLine(BV, list_p.start_point, New Point(list_p.start_point.X + lopbaove, list_p.start_point.Y - lopbaove), "1") ' Đoạn thép neo bên trái
            thuvienve.CreateNewLine(BV, list_p.end_point, New Point(list_p.end_point.X - lopbaove, list_p.end_point.Y - lopbaove), "1")
            'Vẽ 1/4 chiều dài nhip bên trái, phải
            Dim nhip_1_4 As Double = nhip / 4.0#
            Dim rs_point As New DiemDauDiemCuoi()
            rs_point = thuvienve.CreateNewLineR2(BV, New Point(list_p.start_point.X, list_p.start_point.Y - lopbaove), New Point(list_p.start_point.X + nhip_1_4 + b_cot - lopbaove, list_p.start_point.Y - lopbaove), "1")
            ' VẼ ĐOẠN CẮT THÉP CHO THANH BÊN TRÁI
            thuvienve.CreateNewLine(BV, rs_point.start_point, New Point(rs_point.start_point.X + lopbaove, rs_point.start_point.Y - lopbaove), "1") ' đoạn cắt 1
            thuvienve.CreateNewLine(BV, rs_point.end_point, New Point(rs_point.end_point.X - lopbaove, rs_point.end_point.Y - lopbaove), "1") ' đoạn cắt thép 2
            ' Thanh bên tay phải : 
            Dim rs_point1 As New DiemDauDiemCuoi()
            rs_point1 = thuvienve.CreateNewLineR2(BV, New Point(list_p.end_point.X, list_p.end_point.Y - lopbaove), New Point(list_p.end_point.X - nhip_1_4 - b_cot + lopbaove, list_p.end_point.Y - lopbaove), "1")
            thuvienve.CreateNewLine(BV, rs_point1.end_point, New Point(rs_point1.end_point.X + lopbaove, rs_point1.end_point.Y - lopbaove), "1")
            thuvienve.CreateNewLine(BV, rs_point1.start_point, New Point(rs_point1.start_point.X - lopbaove, rs_point1.start_point.Y - lopbaove), "1")

            ' DIM CHO ĐOẠN 1/4 BÊN TRÁI ---------------------------------------------------------------------------------------------
            Dim diem1, diem2, diemdatdim As Point
            diem1.X = 0
            diem1.Y = 0 + h + b_cot - 120 + chieucaodimtren
            diem2.Y = diem1.Y
            diem2.X = rs_point.end_point.X
            diemdatdim.X = (diem1.X + diem2.X) / 2
            diemdatdim.Y = diem2.Y + 120
            thuvienve.CreateVewDim(BV, diem1, diem2, diemdatdim)
            Dim diem3, diemdatdim2 As Point
            diem3.X = rs_point1.end_point.X
            diem3.Y = diem2.Y
            diemdatdim2.X = (diem3.X + diem2.X) / 2
            diemdatdim2.Y = diem2.Y + 120
            thuvienve.CreateVewDim(BV, diem2, diem3, diemdatdim2)
            Dim diem4, diemdatdim3 As Point
            diem4.X = rs_point1.start_point.X + lopbaove - b_cot
            diem4.Y = diem3.Y
            diemdatdim3.X = (diem4.X + diem3.X) / 2
            diemdatdim3.Y = diemdatdim.Y
            thuvienve.CreateVewDim(BV, diem3, diem4, diemdatdim3)

#End Region
#Region "Vẽ cho thép lớp 1 momen duong"
            ' vẽ thép momen dương,vị trí: ngay trên điểm 0,0
            list_p = thuvienve.CreateNewLineR2(BV, New Point(0 - 450, 0 + lopbaove), New Point(nhip + 450, 0 + lopbaove), "1")
            thuvienve.CreateNewLine(BV, list_p.start_point, New Point(list_p.start_point.X + lopbaove, list_p.start_point.Y + lopbaove), "1")
            thuvienve.CreateNewLine(BV, list_p.end_point, New Point(list_p.end_point.X - lopbaove, list_p.end_point.Y + lopbaove), "1")
#End Region
#Region "Vẽ cho doạn thép bụng cấu tạo ở dưới : "
            If h >= 700 Then
                Dim a As New DiemDauDiemCuoi()
                a = thuvienve.CreateNewLineR2(BV, New Point(0 - 450, 0 + h / 2), New Point(nhip + 450, 0 + h / 2), "1")
                thuvienve.CreateNewLine(BV, a.start_point, New Point(a.start_point.X + lopbaove, a.start_point.Y + lopbaove), "1")
                thuvienve.CreateNewLine(BV, a.end_point, New Point(a.end_point.X - lopbaove, a.end_point.Y + lopbaove), "1")
                Dim diemchenthepcautao As New Point()
                diemchenthepcautao.X = (a.start_point.X + a.end_point.X) / 4
                diemchenthepcautao.Y = a.start_point.Y
                thuvienve.CreateNewThepCauTao(BV, diemchenthepcautao, "2Ø14")
            End If

#End Region
#Region "Thép momen dương lớp 2, vẽ cho đoạn 1/6 của nhịp:"
            ' vẽ thép momen Dương đoạn nhỏ bên trên, khoảng cách đến cột là 1/3 nhịp, ta có  : 
            ' b1 : Tính nhip 1/6
            ' b2 : vẽ từ 1/6 nhịp này sang 1/6 nhịp kia là được đoạn ở giữa 
            ' b3 : vẽ mở thép 
            Dim nhi_1_6 As Double
            nhi_1_6 = nhip / 6.0#
            Dim st_point, edpoint As New Point()
            st_point = New Point(0 + nhi_1_6, 0 + lopbaove + lopbaove) ' nằm trên đoạn momen dương chạy thẳng
            edpoint = New Point(nhip - nhi_1_6, 0 + lopbaove + lopbaove) ' nằm ngay trên đoạn momen chạy thẳng nên nó cộng thêm lopbaove nữa
            thuvienve.CreateNewLine(BV, st_point, edpoint, "1") ' 1 là màu đỏ
            thuvienve.CreateNewLine(BV, st_point, New Point(st_point.X + lopbaove, st_point.Y + lopbaove), "1")
            thuvienve.CreateNewLine(BV, edpoint, New Point(edpoint.X - lopbaove, edpoint.Y + lopbaove), "1")

            Dim d1, d2, d3 As New Point()
            d1.X = 0
            d1.Y = 0 - b_cot
            d2.X = nhi_1_6
            d2.Y = d1.Y
            d3.X = (d1.X + d2.X) / 2
            d3.Y = d2.Y
            thuvienve.CreateVewDim(BV, d1, d2, d3)
            Dim d4, d5 As New Point()
            d4.X = nhip - nhi_1_6
            d4.Y = d3.Y
            d5.X = (d4.X + d3.X) / 2
            d5.Y = d4.Y
            thuvienve.CreateVewDim(BV, d3, d4, d5)
            Dim d6, d7 As New Point()
            d6.X = nhip
            d6.Y = d4.Y
            thuvienve.CreateVewDim(BV, d4, d6, d4)
            thuvienve.CreateVewDim(BV, d1, d6, New Point(0, 0 - b_cot - b_cot / 2))

#End Region
#Region "Vẽ dầm (bao ngoài), vẽ nét cắt"

            thuvienve.CreateNewLine(BV, New Point(0, 0), New Point(nhip, 0), layerdam)

            thuvienve.CreateNewLine(BV, New Point(0, 0), New Point(0, -b_cot), layerdam)
            thuvienve.CreateNewLine(BV, New Point(nhip, 0), New Point(nhip, -b_cot), layerdam) ' bên phải dưới
            thuvienve.CreateNewLine(BV, New Point(0, h), New Point(nhip, h), layerdam)



            Dim stp, edp, stp1, edp1 As Point
            ' stp1 = thuvienve.CreateNewLineR(BV, New Point(0, -b_cot), New Point(0 - b_cot, -b_cot), "5")
            ' stp = thuvienve.CreateNewLineR(BV, New Point(nhip, -b_cot), New Point(nhip + b_cot, -b_cot), "5")

            thuvienve.CreateNewLine(BV, New Point(0, h), New Point(0, h + b_cot), layerdam) ' đoạn thanh đứng bên trên
            ' edp1 = thuvienve.CreateNewLineR(BV, New Point(0, h + b_cot), New Point(0 - b_cot, h + b_cot), "5") ' đoạn đua ra trái trên
            ' edp = thuvienve.CreateNewLineR(BV, New Point(nhip, h + b_cot), New Point(nhip + b_cot, h + b_cot), "5")
            thuvienve.CreateNewLine(BV, New Point(nhip, h), New Point(nhip, h + b_cot), layerdam) ' đoạn đứng phải trên
            thuvienve.CreateNewLine(BV, New Point(nhip + b_cot, -b_cot), New Point(nhip + b_cot, h + b_cot), layerdam)
            thuvienve.CreateNewLine(BV, New Point(0 - b_cot, -b_cot), New Point(0 - b_cot, h + b_cot), layerdam) ' thanh đứng
            ' vẽ cột 1
            'thuvienve.CreateNewLine(BV, New Point(0, 0), New Point(0 - b_cot, 0), layerdam)
            'thuvienve.CreateNewLine(BV, New Point(0 - b_cot, 0), New Point(0 - b_cot, h), layerdam)
            'thuvienve.CreateNewLine(BV, New Point(0 - b_cot, h), New Point(0, h), layerdam)
            '' vẽ cột 2  : 
            'thuvienve.CreateNewLine(BV, New Point(0 + nhip, h), New Point(0 + nhip + b_cot, h), layerdam)
            'thuvienve.CreateNewLine(BV, New Point(0 + nhip + b_cot, h), New Point(0 + nhip + b_cot, 0), layerdam)
            'thuvienve.CreateNewLine(BV, New Point(0 + nhip + b_cot, 0), New Point(0 + nhip, 0), layerdam)
            ' vẽ cái kí hiệu nét cắt
            Dim r As Double = b_cot / 2
            thuvienve.Hamvenetcat(BV, New Point(0 - r, 0 + h + b_cot), layerdam)
            thuvienve.Hamvenetcat(BV, New Point(0 + nhip + r, h + b_cot), layerdam)
            thuvienve.Hamvenetcat(BV, New Point(0 + nhip + r, -b_cot), layerdam)
            thuvienve.Hamvenetcat(BV, New Point(0 - r, -b_cot), layerdam)
#End Region
#Region "vẽ cốt đai"
            Dim kc_dai As Double = 100 ' tạm thế
            ' lấy tọa độ y của đai để vẽ :
            Dim _toado_y_dai_tren As Double = h - lopbaove
            Dim _toado_y_dai_duoi As Double = 0 + lopbaove
            ' lấy điểm đầu và điểm cuối của đoạn 1/4 thứ nhất
            Dim _toadodau As Double = rs_point.start_point.X + b_cot
            Dim _toadocuoi As Double = rs_point.end_point.X
            ' vẽ đai cho đoạn biên 1
            For i As Integer = 1 To 3
                thuvienve.CreateNewLine(BV, New Point(_toadodau, _toado_y_dai_tren), New Point(_toadodau, _toado_y_dai_duoi), "11")
                _toadodau = _toadodau + kc_dai
            Next
            For i As Integer = 3 To 1 Step -1
                thuvienve.CreateNewLine(BV, New Point(_toadocuoi, _toado_y_dai_tren), New Point(_toadocuoi, _toado_y_dai_duoi), "11")
                _toadocuoi = _toadocuoi - kc_dai
            Next
            '----------------------------------------------------------------------------------------------------------------------
            ' vẽ đai cho đoạn biên 2 : 
            Dim _toadodau1 As Double = rs_point1.end_point.X
            Dim _toadocuoi1 As Double = rs_point1.start_point.X - b_cot
            For i As Integer = 1 To 3
                thuvienve.CreateNewLine(BV, New Point(_toadodau1, _toado_y_dai_tren), New Point(_toadodau1, _toado_y_dai_duoi), "11")
                _toadodau1 = _toadodau1 + kc_dai
            Next
            For i As Integer = 3 To 1 Step -1
                thuvienve.CreateNewLine(BV, New Point(_toadocuoi1, _toado_y_dai_tren), New Point(_toadocuoi1, _toado_y_dai_duoi), "11")
                _toadocuoi1 = _toadocuoi1 - kc_dai
            Next
            '-----------------------------------------------------------------------------------------------------------------------
            ' vẽ thép dai cho đoạn ở giữa
            Dim diemdau, diemcuoi As Double
            diemdau = rs_point.end_point.X
            diemcuoi = rs_point1.end_point.X
            Dim kc_dai2 As Double = 200
            For i As Integer = 1 To 3
                diemdau = diemdau + kc_dai2
                thuvienve.CreateNewLine(BV, New Point(diemdau, _toado_y_dai_tren), New Point(diemdau, _toado_y_dai_duoi), "11")
            Next
            For i As Integer = 3 To 1 Step -1
                diemcuoi = diemcuoi - kc_dai2
                thuvienve.CreateNewLine(BV, New Point(diemcuoi, _toado_y_dai_tren), New Point(diemcuoi, _toado_y_dai_duoi), "11")
            Next
            '--------------------------------------------------------------------------------------------------------------------------
            ' vẽ bên dưới
            thuvienve.CreateNewblockMC(BV, New Point(0, -200), "1")
            thuvienve.CreateNewblockMC(BV, New Point(rs_point1.end_point.X - 400, -200), "2")
            thuvienve.CreateNewblockMC(BV, New Point(rs_point1.start_point.X - b_cot + lopbaove - 350, -200), "3")
            ' vẽ bên trên : 
            thuvienve.CreateNewblockMC(BV, New Point(0, 0 + h + 200), "1")
            thuvienve.CreateNewblockMC(BV, New Point(rs_point1.end_point.X - 400, 0 + h + 200), "2")
            thuvienve.CreateNewblockMC(BV, New Point(rs_point1.start_point.X - b_cot + lopbaove - 350, 0 + h + 200), "3")


#End Region
#Region "kí hiệu thép"
            ' lấy thép
            Dim str, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2 As String

            ' diểm chèn 1 
            Dim diemchenkishieu As New Point()
            diemchenkishieu.X = (rs_point.start_point.X + b_cot + rs_point.end_point.X) / 2
            diemchenkishieu.Y = rs_point.end_point.Y
            ' diem chen 2
            Dim diemchenkihieu2 As New Point()
            diemchenkihieu2.X = (rs_point1.start_point.X - b_cot + lopbaove + rs_point1.end_point.X) / 2 - 300
            diemchenkihieu2.Y = diemchenkishieu.Y
            ' diem chen 3 :
            Dim diemchengiua As New Point()
            diemchengiua.X = (st_point.X + edpoint.X) / 2
            diemchengiua.Y = st_point.Y

            str = txtthepdoc1.Text
            If str.Length >= 6 Then
                thep_lop_tren_goi_ab = str.Substring(0, 4)
                thep_lop_tren_goi_ab2 = str.Substring(7, 4)
                thuvienve.CreateNewThepMuAB1(BV, diemchenkishieu, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2)
            Else
                ' truong hop chon thep doi
                If str.Length = 4 Then
                    Dim sothanh, sothanh1, sothanh2 As Double
                    sothanh = Convert.ToDouble(str.Substring(0, 1))
                    sothanh1 = Math.Truncate(sothanh / 2)
                    sothanh2 = sothanh - sothanh1
                    thep_lop_tren_goi_ab = sothanh1.ToString + str.Substring(1, 3)
                    thep_lop_tren_goi_ab2 = sothanh2.ToString + str.Substring(1, 3)
                    thuvienve.CreateNewThepMuAB1(BV, diemchenkishieu, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2)
                Else
                    Dim sothanh, sothanh1, sothanh2 As Double
                    sothanh = Convert.ToDouble(str.Substring(0, 2))
                    sothanh1 = Math.Truncate(sothanh / 2)
                    sothanh2 = sothanh - sothanh1
                    thep_lop_tren_goi_ab = sothanh1.ToString + str.Substring(2, 3)
                    thep_lop_tren_goi_ab2 = sothanh2.ToString + str.Substring(2, 3)
                    thuvienve.CreateNewThepMuAB1(BV, diemchenkishieu, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2)
                End If
            End If
            str = txtthepdoc3.Text
            If str.Length >= 6 Then
                thep_lop_tren_goi_ab = str.Substring(0, 4)
                thep_lop_tren_goi_ab2 = str.Substring(7, 4)
                thuvienve.CreateNewThepMuAB2(BV, diemchenkihieu2, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2)
            Else
                ' truong hop chon thep doi
                If str.Length = 4 Then
                    Dim sothanh, sothanh1, sothanh2 As Double
                    sothanh = Convert.ToDouble(str.Substring(0, 1))
                    sothanh1 = Math.Truncate(sothanh / 2)
                    sothanh2 = sothanh - sothanh1
                    thep_lop_tren_goi_ab = sothanh1.ToString + str.Substring(1, 3)
                    thep_lop_tren_goi_ab2 = sothanh2.ToString + str.Substring(1, 3)
                    thuvienve.CreateNewThepMuAB2(BV, diemchenkihieu2, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2)
                Else
                    Dim sothanh, sothanh1, sothanh2 As Double
                    sothanh = Convert.ToDouble(str.Substring(0, 2))
                    sothanh1 = Math.Truncate(sothanh / 2)
                    sothanh2 = sothanh - sothanh1
                    thep_lop_tren_goi_ab = sothanh1.ToString + str.Substring(2, 3)
                    thep_lop_tren_goi_ab2 = sothanh2.ToString + str.Substring(2, 3)
                    thuvienve.CreateNewThepMuAB2(BV, diemchenkihieu2, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2)
                End If
            End If
            'thep_lop_tren_goi_ab = str.substring(0, 4)
            'thep_lop_tren_goi_ab2 = str.substring(7, 4)
            'thuvienve.createnewthepmuab1(bv, diemchenkihieu2, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2)

            str = txtthepdoc2.Text
            If str.Length >= 6 Then
                thep_lop_tren_goi_ab = str.Substring(0, 4)
                thep_lop_tren_goi_ab2 = str.Substring(7, 4)
                thuvienve.CreateNewThepNhipGiuaAB(BV, diemchengiua, thep_lop_tren_goi_ab2, thep_lop_tren_goi_ab)
            Else
                ' truong hop chon thep doi
                If str.Length = 4 Then
                    Dim sothanh, sothanh1, sothanh2 As Double
                    sothanh = Convert.ToDouble(str.Substring(0, 1))
                    sothanh1 = Math.Truncate(sothanh / 2)
                    sothanh2 = sothanh - sothanh1
                    thep_lop_tren_goi_ab = sothanh1.ToString + str.Substring(1, 3)
                    thep_lop_tren_goi_ab2 = sothanh2.ToString + str.Substring(1, 3)
                    thuvienve.CreateNewThepNhipGiuaAB(BV, diemchengiua, thep_lop_tren_goi_ab2, thep_lop_tren_goi_ab)
                Else
                    Dim sothanh, sothanh1, sothanh2 As Double
                    sothanh = Convert.ToDouble(str.Substring(0, 2))
                    sothanh1 = Math.Truncate(sothanh / 2)
                    sothanh2 = sothanh - sothanh1
                    thep_lop_tren_goi_ab = sothanh1.ToString + str.Substring(2, 3)
                    thep_lop_tren_goi_ab2 = sothanh2.ToString + str.Substring(2, 3)
                    thuvienve.CreateNewThepNhipGiuaAB(BV, diemchengiua, thep_lop_tren_goi_ab2, thep_lop_tren_goi_ab)
                End If
            End If
            'thep_lop_tren_goi_ab = str.substring(0, 4)
            'thep_lop_tren_goi_ab2 = str.substring(7, 4)
            'thuvienve.createnewthepnhipgiuaab(bv, diemchengiua, thep_lop_tren_goi_ab, thep_lop_tren_goi_ab2)


#End Region
#Region "dat label thep dai"
            ' cho đoạn 1 
            Dim diem_dat_thep_dai1 As Point
            diem_dat_thep_dai1.X = (rs_point.start_point.X + b_cot + rs_point.end_point.X) / 2 - 200 ' 200 ;à khoảng căn chỉnh để đẹp thôi
            diem_dat_thep_dai1.Y = 0 + h + b_cot
            thuvienve.CreateNewText(BV, txtthepdai1.Text, diem_dat_thep_dai1, 110)
            ' cho đoạn 2 :s
            Dim diem_dat_thep_dai2 As Point
            diem_dat_thep_dai2.X = (rs_point.end_point.X + rs_point1.end_point.X) / 2 - 150 ' 150 là khoảng căn chỉnh để đẹp thôi
            diem_dat_thep_dai2.Y = 0 + h + b_cot
            thuvienve.CreateNewText(BV, txtthepdai2.Text, diem_dat_thep_dai2, 110)
            ' cho đoạn 3 : 
            Dim diem_dat_thep_dai3 As Point
            diem_dat_thep_dai3.X = (rs_point1.start_point.X + rs_point1.end_point.X - b_cot) / 2 - 100
            diem_dat_thep_dai3.Y = 0 + h + b_cot
            thuvienve.CreateNewText(BV, txtthepdai3.Text, diem_dat_thep_dai3, 110)
#End Region
            btnbotrithep.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Lỗi Rồi") ' lỗi thì phải chạy vào  cái này sau 
        End Try
        'thuvienve.vehinhtron(BV, New Point(0, 0), lopbaove0) ' bán kính khi chưa trừ đi lớp bảo vệ
        khungve.CommandAction.Zoom("E", 200, 20)
    End Sub

    Private Sub btn_xuatbanve_Click(sender As Object, e As EventArgs) Handles btn_xuatbanve.Click
        Dim Save As New SaveFileDialog
        Save.Filter = "dxf|*.dxf"
        If (Save.ShowDialog = DialogResult.OK) Then
            Me.khungve.ActiveDocument.SaveAs(Save.FileName, 7)
        End If
    End Sub

    Private Sub khungve_CoordMouseMove(sender As Object, e As AxVDProLib5._DVdrawEvents_CoordMouseMoveEvent) Handles khungve.CoordMouseMove

    End Sub

    Private Sub txtthepdoc_TextChanged(sender As Object, e As EventArgs) Handles txtthepdoc1.TextChanged

    End Sub
End Class