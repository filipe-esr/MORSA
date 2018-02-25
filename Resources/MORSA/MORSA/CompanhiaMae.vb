<Serializable()> Public Class CompanhiaMae
    Private _compMaeNIF As String
    Private _compMaeEE As String

    Property compMaeNIF As String
        Get
            Return _compMaeNIF
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 9 Or TestString < 9 Then
                Throw New Exception("Invalid NIF")
                Exit Property
            End If
            _compMaeNIF = value
        End Set
    End Property

    Property compMaeEE As String
        Get
            Return _compMaeEE
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 11 Or value = "" Then
                Throw New Exception("Invalid Station ID")
                Exit Property
            End If
            _compMaeEE = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub
End Class
