Public Class ClassKetqua
    Private m_TenDam As String
    Private m_Vitri As String
    Private m_dai As Double
    Private m_rong As Double
    Private m_cao As Double
    Private m_Astt As Double
    Private m_muy As Double
    Private m_ThepDoc As String

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
    Property Dai() As Double
        Get
            Return m_dai
        End Get
        Set(value As Double)
            m_dai = value
        End Set
    End Property
    Property Rong() As String
        Get
            Return m_rong
        End Get
        Set(value As String)
            m_rong = value
        End Set
    End Property
    Property Cao() As String
        Get
            Return m_cao
        End Get
        Set(value As String)
            m_cao = value
        End Set
    End Property

    Property Astt As Double
        Get
            Return m_Astt
        End Get
        Set(value As Double)
            m_Astt = value
        End Set
    End Property
    Property Muy As Double
        Get
            Return m_muy
        End Get
        Set(value As Double)
            m_muy = value
        End Set
    End Property
    Property ThepDoc As String
        Get
            Return m_ThepDoc
        End Get
        Set(value As String)
            m_ThepDoc = value
        End Set
    End Property

End Class
