Public Class Empleados
    Inherits Persona

    Private _tipoContratoo As String
    Private _sueldo As String

    Public Property TipoContrato As String
        Get
            Return _tipoContratoo
        End Get
        Set(value As String)
            _tipoContratoo = value

        End Set
    End Property
    Public Property Sueldo As Double
        Get
            Return _sueldo
        End Get
        Set(value As Double)
            _sueldo = value
        End Set
    End Property
    Public Sub calcularSueldo(sueldoBase As Double)
        If (Me.TipoContrato = "T") Then
            Me.Sueldo = sueldoBase + 200
        ElseIf (Me.TipoContrato = "F") Then
            Me.Sueldo = sueldoBase + 100
        Else
            Me.Sueldo = 0
        End If
    End Sub
End Class
