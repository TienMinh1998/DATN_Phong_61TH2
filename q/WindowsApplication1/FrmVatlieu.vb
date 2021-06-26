
Public Class FrmVatlieu


#Region " Chọn bê tông"
    Private Sub cb_chonBT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_chonBT.SelectedIndexChanged
        ' Chọn bê tông
        ChonBetong(cb_chonBT.SelectedItem.ToString)
        txtEb.Text = Eb
        txtRb.Text = Rb
        txtRbt.Text = Rbt

    End Sub
#End Region
#Region " Chọn cốt thép"

    Private Sub cb_chonCT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_chonCT.SelectedIndexChanged
        ' Chọn cốt thép
        Choncotthep(cb_chonCT.SelectedItem.ToString)
        txtRs.Text = Rs
        txtEs.Text = Es
        txtRsc.Text = Rsc
        Dim xicma As Double
        Dim omega As Double
        ' Tính hệ số anphaR và goxiR *********************************************************
        omega = 0.85 - 0.008 * Rb
        xicma = 500
        GoxiR = omega / (1 + Rs * (1 - omega / 1.1) / xicma)
        anphaR = GoxiR * (1 - 0.5 * GoxiR)
        txteR.Text = GoxiR
        txtaR.Text = anphaR

    End Sub

#End Region
    Dim check As Boolean = False
    'Lưu vật liệu và mở form nhập dữ liệu
    Private Sub btnluuvatlieu_Click(sender As Object, e As EventArgs) Handles btnluuvatlieu.Click
        BeTong = cb_chonBT.Text
        Rb = txtRb.Text
        Rbt = txtRbt.Text
        CotThep = cb_chonCT.Text
        Rs = txtRs.Text
        Rsc = txtRsc.Text
        GoxiR = txteR.Text
        anphaR = txtaR.Text
        check = True
        Me.Close()
        FrmThongsodam.Show()
    End Sub
    'Lưu dữ liệu khi đóng form
    Private Sub FrmVatlieu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If check = False Then
            If MsgBox("Bạn có muốn lưu dữ liệu", vbYesNoCancel) = vbYes Then
                BeTong = cb_chonBT.Text
                Rb = txtRb.Text
                Rbt = txtRbt.Text
                CotThep = cb_chonCT.Text
                Rs = txtRs.Text
                Rsc = txtRsc.Text
                GoxiR = txteR.Text
                anphaR = txtaR.Text
                Eb = txtEb.Text
                Es = txtEs.Text

            End If
        End If
    End Sub
    'Load vật liệu đã lưu
    Private Sub FrmVatlieu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_chonBT.Text = BeTong
        txtRb.Text = Rb
        txtRbt.Text = Rbt
        cb_chonCT.Text = CotThep
        txtRs.Text = Rs
        txtRsc.Text = Rsc
        txtaR.Text = anphaR
        txteR.Text = GoxiR
        txtEb.Text = Eb
        txtEs.Text = Es
    End Sub

End Class