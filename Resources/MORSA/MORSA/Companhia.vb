<Serializable()> Public Class Companhia
    Private _companhiaNome As String
    Private _companhiaNIF As String
    Private _companhiaTelef As String
    Private _companhiaEnder As String
    Private _companhiaCodPos As String
    Private _companhiaSede As String

    Property companhiaNome As String
        Get
            Return _companhiaNome
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 35 Or value = "" Then
                Throw New Exception("ID too long")
                Exit Property
            End If
            _companhiaNome = value
        End Set
    End Property


    Property companhiaNIF As String
        Get
            Return _companhiaNIF
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 9 Or TestString < 9 Or value = "" Then
                Throw New Exception("NIF mismatch")
                Exit Property
            End If
            _companhiaNIF = value
        End Set
    End Property

    Property companhiaTelef As String
        Get
            Return _companhiaTelef
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 9 Or TestString < 9 Or value = "" Then
                Throw New Exception("Telef mismatch")
                Exit Property
            End If
            _companhiaTelef = value
        End Set
    End Property

    Property companhiaEnder As String
        Get
            Return _companhiaEnder
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 40 Or value = "" Then
                Throw New Exception("Ender mismatch")
                Exit Property
            End If
            _companhiaEnder = value
        End Set
    End Property

    Property companhiaCodPos As String
        Get
            Return _companhiaCodPos
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 8 Or TestString < 8 Or value = "" Then
                Throw New Exception("CodPos mismatch")
                Exit Property
            End If
            _companhiaCodPos = value
        End Set
    End Property

    Property companhiaSede As String
        Get
            Return _companhiaSede
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 20 Or value = "" Then
                Throw New Exception("Sede mismatch")
                Exit Property
            End If
            _companhiaSede = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _companhiaNome & "   "
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

End Class