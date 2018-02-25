<Serializable()> Public Class ModuloEE
    Private _moduloID As String
    Private _moduloNome As String
    Private _moduloTipo As String
    Private _moduloCompLog As String
    Private _moduloLanc As String
    Private _moduloEE As String

    Property moduloID As String
        Get
            Return _moduloID
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 11 Or value = "" Then
                Throw New Exception("Invalid ID")
                Exit Property
            End If
            _moduloID = value
        End Set
    End Property

    Property moduloNome As String
        Get
            Return _moduloNome
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 35 Or value = "" Then
                Throw New Exception("Invalid Name")
                Exit Property
            End If
            _moduloNome = value
        End Set
    End Property

    Property moduloTipo As String
        Get
            Return _moduloTipo
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 20 Or value = "" Then
                Throw New Exception("Invalid Module Type")
                Exit Property
            End If
            _moduloTipo = value
        End Set
    End Property

    Property moduloCompLog As String
        Get
            Return _moduloCompLog
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 9 Or TestString < 9 Then
                Throw New Exception("Invalid Company NIF")
                Exit Property
            End If
            _moduloCompLog = value
        End Set
    End Property

    Property moduloLanc As String
        Get
            Return _moduloLanc
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            'If TestString > 11 Or value = "" Then
            'Throw New Exception("Invalid Launch ID")
            'Exit Property
            'End If
            _moduloLanc = value
        End Set
    End Property

    Property moduloEE As String
        Get
            Return _moduloEE
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 11 Or value = "" Then
                Throw New Exception("Invalid EE ID")
                Exit Property
            End If
            _moduloEE = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

    Overrides Function ToString() As String
        Return _moduloNome & "   "
    End Function
End Class
