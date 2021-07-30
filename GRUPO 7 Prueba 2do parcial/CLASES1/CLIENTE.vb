Public Class CLIENTE
    Inherits PERSONA
    'ATRIBUTOS
    Private _categoria As String
    Private _codigo As String
    'PROPIEDADES
    Public Property categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    'OPERACIONES 
    Public Sub generarCodigo()
        Me.codigo = "C" & Me.APELLIDOM.Substring(0, 3) & "16"
        Me.codigo = "C" & Me.APELLIDOP.Substring(0, 3) & "16"
    End Sub

End Class
