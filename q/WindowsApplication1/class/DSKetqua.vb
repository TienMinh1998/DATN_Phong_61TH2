Public Class DSKetqua
    Private m_KetQua As New List(Of ClassKetqua)
    Private m_count As Integer

    Public ReadOnly Property count() As Integer
        Get
            Return m_count
        End Get
    End Property

    'Thêm dữ liệu vào class
    Public Sub Add(TenDam As String, Vitri As String, Dai As Double, Rong As Double, Cao As Double, Astt As Double, muy As Double, ThepDoc As String)
        m_count = m_count + 1
        Dim KQ As New ClassKetqua

        KQ.TenDam = TenDam
        KQ.Vitri = Vitri
        KQ.Dai = Dai
        KQ.Rong = Rong
        KQ.Cao = Cao
        KQ.Astt = Astt
        KQ.Muy = muy
        KQ.ThepDoc = ThepDoc
        m_KetQua.Add(KQ)
    End Sub

    Public Property Dam(chiso As Integer) As ClassKetqua
        Get
            Return m_KetQua(chiso)
        End Get
        Set(value As ClassKetqua)
            m_KetQua(chiso) = value
        End Set
    End Property

    Public Sub Delete(ByVal chiso As Integer)
        m_count = m_count - 1
        m_KetQua.RemoveAt(chiso)
    End Sub

    Public Sub Clear()
        m_count = 0
        m_KetQua.Clear()
    End Sub
End Class
