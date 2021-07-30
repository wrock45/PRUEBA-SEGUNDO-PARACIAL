Public Class EMPLEADO
    Inherits PERSONA

    'ATRIBUTOS
    Private _tipocontrato As String
    Private _sueldo As Double

    'PROPIEDADES
    Public Property tipocontrato As String
        Get
            Return _tipocontrato
        End Get
        Set(value As String)
            _tipocontrato = value
        End Set
    End Property
    Public Property sueldo As Double
        Get
            Return _sueldo
        End Get
        Set(value As Double)
            _sueldo = value
        End Set
    End Property

    'OPERACIONES
    Public Sub calcularsueldo(sueldobase As Double)
        If (Me.tipocontrato = "C") Then
            Me.sueldo = sueldobase + 400
        ElseIf (Me.tipocontrato = "N") Then
            Me.sueldo = sueldobase + 750
        Else
            Me.sueldo = 0
        End If
    End Sub
End Class
