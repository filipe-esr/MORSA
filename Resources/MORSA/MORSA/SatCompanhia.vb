<Serializable()> Public Class SatCompanhia
    Private _satCompID As String
    Private _satCompNIF As String

    Property satCompID As String
        Get
            Return _satCompID
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 11 Or value = "" Then
                Throw New Exception("Invalid ID")
                Exit Property
            End If
            _satCompID = value
        End Set
    End Property

    Property satCompNIF As String
        Get
            Return _satCompNIF
        End Get
        Set(ByVal value As String)
            Dim TestString As Integer = Len(value)
            If TestString > 9 Or TestString < 9 Then
                Throw New Exception("Invalid Company NIF")
                Exit Property
            End If
            _satCompNIF = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
    End Sub

End Class
