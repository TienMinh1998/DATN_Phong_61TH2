Public Class DSNhap
    Private m_NhapDL As New List(Of ClassNhapDL)
    Private m_count As Integer

    Public ReadOnly Property count() As Integer
        Get
            Return m_count
        End Get
    End Property

    'Thêm dữ liệu vào class
    Public Sub Add(TenDam As String, Vitri As String, Dai As Double, Rong As Double, Cao As Double, Momen As Double)
        m_count = m_count + 1
        Dim DS As New ClassNhapDL
        DS.TenDam = TenDam
        DS.Vitri = Vitri
        DS.Dai = Dai
        DS.Rong = Rong
        DS.Cao = Cao
        DS.Momen = Momen
        m_NhapDL.Add(DS)
    End Sub

    Public Property Dam(chiso As Integer) As ClassNhapDL
        Get
            Return m_NhapDL(chiso)
        End Get
        Set(value As ClassNhapDL)
            m_NhapDL(chiso) = value
        End Set
    End Property

    Public Sub Delete(ByVal chiso As Integer)
        m_count = m_count - 1
        m_NhapDL.RemoveAt(chiso)
    End Sub

    Public Sub Clear()
        m_count = 0
        m_NhapDL.Clear()
    End Sub
End Class
