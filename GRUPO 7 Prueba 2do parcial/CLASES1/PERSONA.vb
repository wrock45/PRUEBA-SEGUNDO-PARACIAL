Public Class PERSONA
    'ATRIBUTOS
    Private _APELLIDOM As String
    Private _APELLIDOP As String
    Private _SeguroS As String
    Private _Sexo As String


    'PROPIEDADES 
    Public Property APELLIDOM As String
        Get
            Return _APELLIDOM
        End Get
        Set(value As String)
            _APELLIDOM = value
        End Set
    End Property
    Public Property APELLIDOP As String
        Get
            Return _APELLIDOP
        End Get
        Set(value As String)
            _APELLIDOP = value
        End Set
    End Property

    Public Property SeguroS As String
        Get
            Return _SeguroS
        End Get
        Set(value As String)
            _SeguroS = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _Sexo
        End Get
        Set(value As String)
            _Sexo = value
        End Set
    End Property
End Class
