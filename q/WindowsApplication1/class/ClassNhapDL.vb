Public Class ClassNhapDL
    Private m_TenDam As String
    Private m_Vitri As String
    Private m_Momen As Double
    Private m_Dai As Double
    Private m_rong As Double
    Private m_cao As Double


    Property TenDam() As String
        Get
            Return m_TenDam
        End Get
        Set(value As String)
            m_TenDam = value
        End Set
    End Property
    Property Vitri() As String
        Get
            Return m_Vitri
        End Get
        Set(value As String)
            m_Vitri = value
        End Set
    End Property
    Property Momen() As Double
        Get
            Return m_Momen
        End Get
        Set(value As Double)
            m_Momen = value
        End Set
    End Property
    Property Dai() As Double
        Get
            Return m_Dai
        End Get
        Set(value As Double)
            m_Dai = value
        End Set
    End Property
    Property Rong() As Double
        Get
            Return m_rong
        End Get
        Set(value As Double)
            m_rong = value
        End Set
    End Property
    Property Cao() As Double
        Get
            Return m_cao
        End Get
        Set(value As Double)
            m_cao = value
        End Set
    End Property
End Class
