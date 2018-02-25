<Serializable()> Public Class compLog
    Private _compLogNIF As String

    Property compLogNIF As String
        Get
            Return _compLogNIF
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 9 Or value = "" Then
                Throw New Exception("Invalid NIF")
                Exit Property
            End If
            _compLogNIF = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

End Class
