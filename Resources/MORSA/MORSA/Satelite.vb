<Serializable()> Public Class Satelite
    Private _satID As String
    Private _satNome As String
    Private _satServ As String
    Private _satPaisOrg As String
    Private _satCompLog As String
    Private _satLanc As String
    Private _satStatus As String
    Private _satCompsMae As String


    Property satID As String
        Get
            Return _satID
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            ' If TestString > 11 Or value = "" Then
            'Throw New Exception("Invalid ID")
            'Exit Property
            'End If
            _satID = value
        End Set
    End Property

    Property satNome As String
        Get
            Return _satNome
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 35 Then
                MsgBox("Name too long", MsgBoxStyle.OkOnly)
                Exit Property
            End If
            'Throw New Exception("Invalid Name")
            'Exit Property
            'End If
            _satNome = value
        End Set
    End Property

    Property satServ As String
        Get
            Return _satServ
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            'If TestString > 20 Or value = "" Then
            'Throw New Exception("Invalid Type of Service")
            'Exit Property
            'End If
            _satServ = value
        End Set
    End Property

    Property satPaisOrg As String
        Get
            Return _satPaisOrg
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            'If TestString > 20 Or value = "" Then
            'Throw New Exception("Invalid Country or Organization")
            'Exit Property
            'End If
            _satPaisOrg = value
        End Set
    End Property

    Property satCompLog As String
        Get
            Return _satCompLog
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            'If TestString > 9 Or TestString < 9 Then
            'Throw New Exception("Invalid NIF Company")
            'Exit Property
            'End If
            _satCompLog = value
        End Set
    End Property

    Property satLanc As String
        Get
            Return _satLanc
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            'If TestString > 11 Or value = "" Then 'Mas nao aceita se valor for null e deve de aceitar
            'Throw New Exception("Invalid Launch ID")
            'Exit Property
            'End If
            _satLanc = value
        End Set
    End Property

    Property satStatus As String
        Get
            Return _satStatus
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            'If value = "" Then
            'Throw New Exception("Invalid status ID")
            'Exit Property
            'End If
            _satStatus = value
        End Set
    End Property

    Property satCompsMae As String
        Get
            Return _satCompsMae
        End Get
        Set(ByVal value As String)
            ' If value = "" Then
            'Throw New Exception("Invalid status ID")
            'Exit Property
            'End If
            _satCompsMae = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Overrides Function ToString() As String
        Return _satNome & "   "
    End Function

End Class
