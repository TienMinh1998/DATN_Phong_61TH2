Module xulitinhtoan
#Region " Chọn bê tông"
    ' hàm chọn bê tông *********************************************************************************************************

    Public Sub ChonBetong(ByVal Capdoben As String)

        Select Case Capdoben
            Case "B12.5"
                Rbt = 0.66
                Rb = 7.5
                Eb = 21000
            Case "B15"
                Rbt = 0.75
                Rb = 8.5
                Eb = 23000
            Case "B20"
                Rbt = 0.9
                Rb = 11.5
                Eb = 27000
            Case "B25"
                Rbt = 1.05
                Rb = 14.5
                Eb = 30000
            Case "B30"
                Rbt = 1.2
                Rb = 17
                Eb = 32500
            Case "B35"
                Rbt = 1.3
                Rb = 19.5
                Eb = 34500
            Case "B40"
                Rbt = 1.4
                Rb = 22
                Eb = 36000
            Case "B45"
                Rbt = 1.45
                Rb = 25
                Eb = 37500
            Case "B50"
                Rbt = 1.55
                Rb = 27.5
                Eb = 39000
            Case "B55"
                Rbt = 1.6
                Rb = 30
                Eb = 395000
            Case Else
                Rbt = 1.65
                Rb = 33
                Eb = 395000
        End Select
    End Sub

#End Region
#Region " Chọn cốt thép"
    'Chọn cốt thép ******************************************************************************************************

    Public Sub Choncotthep(ByVal Nhomthep As String)
        Select Case Nhomthep
            Case "CB240-T"
                Rs = 210
                Rsc = 210
                Rsw = 170
                Es = 200000
            Case "CB300-T"
                Rs = 260
                Rsc = 260
                Rsw = 210
                Es = 200000
            Case "CB300-V"
                Rs = 260
                Rsc = 260
                Rsw = 210
                Es = 200000
            Case "CB400-V"
                Rs = 350
                Rsc = 350
                Rsw = 280
                Es = 200000
            Case "CB500-V"
                Rs = 435
                Rsc = 400
                Rsw = 300
                Es = 200000
        End Select
    End Sub
#End Region



End Module
