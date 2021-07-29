Public Class Clientes

    Inherits Persona

    'atributos
    Private _categoria As String
    Private _codigoPedido As String
    'propiedades
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
    Public Property CodigoPedido As String
        Get
            Return _codigoPedido
        End Get
        Set(value As String)
            _codigoPedido = value
        End Set
    End Property

    ' operaciones 

    Public Sub generarCodigo()
        Me.CodigoPedido = "A" & Me.ApellidoPaterno.Substring(0, 3) & "16"
    End Sub

End Class
