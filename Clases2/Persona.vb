Public Class Persona
    Private _apellidoPa As String
    Private _apellidoMa As String
    Private _Sexo As String
    Private _numSeguroSocial As String
    Public Property ApellidoPaterno As String
        Get
            Return _apellidoPa
        End Get
        Set(value As String)
            _apellidoPa = value
        End Set

    End Property
    Public Property ApellidoMaterno As String
        Get
            Return _apellidoMa
        End Get
        Set(value As String)
            _apellidoMa = value
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
    Public Property NumeroSeguroSocial As String
        Get
            Return _numSeguroSocial
        End Get
        Set(value As String)
            _numSeguroSocial = value
        End Set

    End Property

End Class
