<Serializable()> Public Class Lanc
    Private _lancID As String
    Private _lancCoord As String
    Private _lancPais As String
    Private _lancDT As String
    Private _lancVeicN As String
    Private _lancVeicCL As String
    Private _lancObj As String

    Property lancID As String
        Get
            Return _lancID
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If value = "" Then
                Throw New Exception("Invalid ID")
                Exit Property
            End If
            _lancID = value
        End Set
    End Property

    Property lancCoord As String
        Get
            Return _lancCoord
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 25 Or value = "" Then
                Throw New Exception("Invalid Coord, format: W xx.x... N xx.x...")
                Exit Property
            End If
            _lancCoord = value
        End Set
    End Property

    Property lancPais As String
        Get
            Return _lancPais
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 20 Or value = "" Then
                Throw New Exception("Invalid Country")
                Exit Property
            End If
            _lancPais = value
        End Set
    End Property

    Property lancDT As String
        Get
            Return _lancDT
        End Get
        Set(ByVal value As String)
            If value = "" Then
                Throw New Exception("Invalid DateTime, format: YYYY-MM-DD HH:MI:SS")
                Exit Property
            End If
            _lancDT = value
        End Set
    End Property

    Property lancVeicN As String
        Get
            Return _lancVeicN
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            'If value = "" Then
            'Throw New Exception("Invalid Vehicle ID")
            'Exit Property
            'End If
            _lancVeicN = value
        End Set
    End Property

    Property lancVeicCL As String
        Get
            Return _lancVeicCL
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If value = "" Then
                Throw New Exception("Invalid Vehicle ID")
                Exit Property
            End If
            _lancVeicCL = value
        End Set
    End Property

    Property lancObj As String
        Get
            Return _lancObj
        End Get
        Set(ByVal value As String)
            _lancObj = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Overrides Function ToString() As String
        Return _lancID & "   "
    End Function
End Class
