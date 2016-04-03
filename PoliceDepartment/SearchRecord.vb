Public Class SearchRecord
    Dim list As List(Of Criminal)

    Public Property listCrim As List(Of Criminal)
        Get
            Return list
        End Get
        Set(value As List(Of Criminal))
            list = value
        End Set
    End Property


End Class
