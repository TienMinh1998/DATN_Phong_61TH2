Public Class FrmBotrithep

    Dim i As Integer
    Private Sub btnvatlieu_Click(sender As Object, e As EventArgs) Handles btnvatlieu.Click

        FrmVatlieu.Show()
    End Sub

    Private Sub btnbanve_Click(sender As Object, e As EventArgs) Handles btnbanve.Click
        Me.Close()
        FrmBanve.Show()
    End Sub


    Private Sub btnnoiluc_Click(sender As Object, e As EventArgs) Handles btnnoiluc.Click

        FrmThongsodam.Show()

    End Sub
#Region "Load dữ liệu đã lưu vào datagridview"
    Private Sub FrmBotrithep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If KetQuaDam.count <> 0 Then
            For i = 0 To KetQuaDam.count - 2
                dgvKetqua.Rows.Add(KetQuaDam.Dam(i).TenDam, KetQuaDam.Dam(i).Vitri, KetQuaDam.Dam(i).Astt, KetQuaDam.Dam(i).Muy, KetQuaDam.Dam(i).ThepDoc)
            Next
            txtAs.Text = KetQuaDam.Dam(0).Astt
            Dim str As String = KetQuaDam.Dam(0).ThepDoc
            Dim length As Integer = Len(str)
            Select Case length
                Case 4
                    cbst1.Text = Mid(str, 1, 1)
                    cbdk1.Text = Mid(str, 3, 2)
                Case 11
                    cbst1.Text = Mid(str, 1, 1)
                    cbdk1.Text = Mid(str, 3, 2)
                    cbst2.Text = Mid(str, 8, 1)
                    cbdk2.Text = Mid(str, 10, 2)
            End Select
        End If
    End Sub
#End Region

#Region "Đưa dữ liệu từ datagridview xuống textbox"

    Private Sub dgvKetqua_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKetqua.CellClick
        If dgvKetqua.Rows.Count <> 0 Then
            Dim i As Byte = dgvKetqua.CurrentCell.RowIndex
            txtAs.Text = dgvKetqua.Rows(i).Cells(2).Value
            cbst1.Text = ""
            cbst2.Text = ""
            cbdk1.Text = ""
            cbdk2.Text = ""
            Dim str As String = dgvKetqua.Rows(i).Cells(4).Value
            Dim length As Integer = Len(str)
            Select Case length
                Case 4
                    cbst1.Text = Mid(str, 1, 1)
                    cbdk1.Text = Mid(str, 3, 2)
                Case 11
                    cbst1.Text = Mid(str, 1, 1)
                    cbdk1.Text = Mid(str, 3, 2)
                    cbst2.Text = Mid(str, 8, 1)
                    cbdk2.Text = Mid(str, 10, 2)
            End Select
        End If
    End Sub

#End Region
#Region "Bố trí cốt thép"
    Private Sub btnbotri_Click(sender As Object, e As EventArgs) Handles btnbotri.Click
        Dim i As Byte = dgvKetqua.CurrentCell.RowIndex

        If (cbst1.Text = "" And cbst2.Text = "") Or (cbdk1.Text = "" And cbdk2.Text = "") Then
            MsgBox("Bạn chưa nhập đủ số lượng thanh thép bố trí")
        Else
            If lbKetqua.Text = "thỏa mãn" Then

                If cbst1.Text = "" Or cbdk1.Text = "" Then
                    dgvKetqua.Rows(i).Cells(4).Value = cbst2.Text & "Ø" & cbdk2.Text
                    KetQuaDam.Dam(i).ThepDoc = cbst2.Text & "Ø" & cbdk2.Text

                ElseIf cbst2.Text = "" Or cbdk2.Text = "" Then
                    dgvKetqua.Rows(i).Cells(4).Value = cbst1.Text + "Ø" + cbdk1.Text
                    KetQuaDam.Dam(i).ThepDoc = cbst1.Text + "Ø" + cbdk1.Text

                Else
                    If cbdk1.Text <> cbdk2.Text Then
                        dgvKetqua.Rows(i).Cells(4).Value = cbst1.Text + "Ø" + cbdk1.Text & " + " & cbst2.Text + "Ø" + cbdk2.Text
                        KetQuaDam.Dam(i).ThepDoc = cbst1.Text + "Ø" + cbdk1.Text & " + " & cbst2.Text + "Ø" + cbdk2.Text

                    Else
                        dgvKetqua.Rows(i).Cells(4).Value = (Val(cbst1.Text) + Val(cbst2.Text)) & "Ø" & cbdk1.Text
                        KetQuaDam.Dam(i).ThepDoc = (Val(cbst1.Text) + Val(cbst2.Text)) & "Ø" & cbdk1.Text

                    End If
                End If

            Else
                MsgBox("Diện tích cốt thép bố trí chưa đủ" & vbNewLine & "Yêu cầu bố trí lại")
            End If
        End If
    End Sub
#End Region
#Region "Kiểm tra diện tích cốt thép"
    Dim asbt As Double
    Dim sl1, sl2, phi1, phi2 As Integer
    Private Sub cbst1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbst1.SelectedIndexChanged
        sl1 = Val(cbst1.Text)
        sl2 = Val(cbst2.Text)
        phi1 = Val(cbdk1.Text)
        phi2 = Val(cbdk2.Text)
        asbt = Math.Round(sl1 * ((3.14 * ((phi1 / 10) ^ 2)) / 4) + sl2 * ((3.14 * ((phi2 / 10) ^ 2)) / 4), 2)
        txtAsbt.Text = asbt
        If asbt < txtAs.Text Then
            lbKetqua.Text = "chưa thỏa mãn"
            lbKetqua.ForeColor = Color.Red
        Else
            lbKetqua.Text = "thỏa mãn"
            lbKetqua.ForeColor = Color.LimeGreen
        End If
    End Sub
    Private Sub cbdk1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdk1.SelectedIndexChanged
        sl1 = Val(cbst1.Text)
        sl2 = Val(cbst2.Text)
        phi1 = Val(cbdk1.Text)
        phi2 = Val(cbdk2.Text)
        asbt = Math.Round(sl1 * ((3.14 * ((phi1 / 10) ^ 2)) / 4) + sl2 * ((3.14 * ((phi2 / 10) ^ 2)) / 4), 2)
        txtAsbt.Text = asbt
        If asbt < txtAs.Text Then
            lbKetqua.Text = "chưa thỏa mãn"
            lbKetqua.ForeColor = Color.Red
        Else
            lbKetqua.Text = "thỏa mãn"
            lbKetqua.ForeColor = Color.LimeGreen
        End If
    End Sub

    Private Sub cbst2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbst2.SelectedIndexChanged
        sl1 = Val(cbst1.Text)
        sl2 = Val(cbst2.Text)
        phi1 = Val(cbdk1.Text)
        phi2 = Val(cbdk2.Text)
        asbt = Math.Round(sl1 * ((3.14 * ((phi1 / 10) ^ 2)) / 4) + sl2 * ((3.14 * ((phi2 / 10) ^ 2)) / 4), 2)
        txtAsbt.Text = asbt
        If asbt < txtAs.Text Then
            lbKetqua.Text = "chưa thỏa mãn"
            lbKetqua.ForeColor = Color.Red
        Else
            lbKetqua.Text = "thỏa mãn"
            lbKetqua.ForeColor = Color.LimeGreen
        End If
    End Sub

    Private Sub cbdk2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdk2.SelectedIndexChanged
        sl1 = Val(cbst1.Text)
        sl2 = Val(cbst2.Text)
        phi1 = Val(cbdk1.Text)
        phi2 = Val(cbdk2.Text)
        asbt = Math.Round(sl1 * ((3.14 * ((phi1 / 10) ^ 2)) / 4) + sl2 * ((3.14 * ((phi2 / 10) ^ 2)) / 4), 2)
        txtAsbt.Text = asbt
        If asbt < txtAs.Text Then
            lbKetqua.Text = "chưa thỏa mãn"
            lbKetqua.ForeColor = Color.Red
        Else
            lbKetqua.Text = "thỏa mãn"
            lbKetqua.ForeColor = Color.LimeGreen
        End If
    End Sub

#End Region

End Class