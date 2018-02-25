<Serializable()> Public Class Orbita
    Private _orbitaID As String
    Private _orbitaApoastro As String
    Private _orbitaPeriastro As String
    Private _orbitaInclin As String
    Private _orbitaPeriodo As String
    Private _orbitaAstro As String

    Property orbitaID As String
        Get
            Return _orbitaID
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 11 Or value = "" Then
                Throw New Exception("Invalid ID")
                Exit Property
            End If
            _orbitaID = value
        End Set
    End Property

    Property orbitaApoastro As String
        Get
            Return _orbitaApoastro
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 10 Or value = "" Then
                Throw New Exception("Invalid Apoastro")
                Exit Property
            End If
            'If value < 200 Then
            'Throw New Exception("Invalid Apoastro")
            'Exit Property
            'End If
            _orbitaApoastro = value
        End Set
    End Property

    Property orbitaPeriastro As String
        Get
            Return _orbitaPeriastro
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 10 Or value = "" Then
                Throw New Exception("Invalid Periastro")
                Exit Property
            End If
            'If value < 200 Then
            'Throw New Exception("Invalid Periastro")
            'Exit Property
            'End If
            _orbitaPeriastro = value
        End Set
    End Property

    Property orbitaInclin As String
        Get
            Return _orbitaInclin
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 7 Or value = "" Then
                Throw New Exception("Invalid Inclin")
                Exit Property
            End If
            _orbitaInclin = value
        End Set
    End Property

    Property orbitaPeriodo As String
        Get
            Return _orbitaPeriodo
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 15 Or value = "" Then
                Throw New Exception("Invalid Periodo")
                Exit Property
            End If
            _orbitaPeriodo = value
        End Set
    End Property

    Property orbitaAstro As String
        Get
            Return _orbitaAstro
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 11 Or value = "" Then
                Throw New Exception("Invalid Astro")
                Exit Property
            End If
            _orbitaAstro = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _orbitaID & "   "
    End Function

    Public Sub New()
        MyBase.New()
    End Sub
End Class
