<Serializable()> Public Class EstacaoEspacial
    Private _estEspID As String
    Private _estEspNome As String
    Private _estEspPaisOrg As String
    Private _estEspCompLog As String
    Private _estStatus As String
    Private _estEspCompMae As String

    Property estEspID As String
        Get
            Return _estEspID
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 11 Or value = "" Then
                Throw New Exception("Invalid ID")
                Exit Property
            End If
            _estEspID = value
        End Set
    End Property

    Property estEspNome As String
        Get
            Return _estEspNome
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 35 Or value = "" Then
                Throw New Exception("Invalid Name")
                Exit Property
            End If
            _estEspNome = value
        End Set
    End Property

    Property estEspPaisOrg As String
        Get
            Return _estEspPaisOrg
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 30 Or value = "" Then
                Throw New Exception("Invalid Country or Organization")
                Exit Property
            End If
            _estEspPaisOrg = value
        End Set
    End Property

    Property estEspCompLog As String
        Get
            Return _estEspCompLog
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 9 Or TestString < 9 Then
                Throw New Exception("Invalid NIF Company")
                Exit Property
            End If
            _estEspCompLog = value
        End Set
    End Property

    Property estStatus As String
        Get
            Return _estStatus
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If value = "" Then
                Throw New Exception("Invalid status ID")
                Exit Property
            End If
            _estStatus = value
        End Set
    End Property

    Property estEspCompMae As String
        Get
            Return _estEspCompMae
        End Get
        Set(ByVal value As String)
            'If value = "" Then
            'Throw New Exception("Invalid compMae")
            'Exit Property
            'End If
            _estEspCompMae = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Overrides Function ToString() As String
        Return _estEspNome & "   "
    End Function

End Class
