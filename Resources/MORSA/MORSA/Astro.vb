<Serializable()> Public Class Astro
    Private _astroID As String
    Private _astroType As String
    Private _astroSystem As String
    Private _astroGalaxy As String

    Property astroID As String
        Get
            Return _astroID
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 11 Or value = "" Then
                Throw New Exception("Invalid ID")
                Exit Property
            End If
            _astroID = value
        End Set
    End Property


    Property astroType As String
        Get
            Return _astroType
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 20 Or value = "" Then
                Throw New Exception("ID mismatch")
                Exit Property
            End If
            _astroType = value
        End Set
    End Property

    Property astroSystem As String
        Get
            Return _astroSystem
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 20 Or value = "" Then
                Throw New Exception("ID mismatch")
                Exit Property
            End If
            _astroSystem = value
        End Set
    End Property

    Property astroGalaxy As String
        Get
            Return _astroGalaxy
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 20 Or value = "" Then
                Throw New Exception("ID mismatch")
                Exit Property
            End If
            _astroGalaxy = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _astroID & "   "
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

End Class
