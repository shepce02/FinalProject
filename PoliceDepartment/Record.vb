Public Class Record
    Dim arrestDate As String
    Dim crimeCommmited As String
    Dim arrestedBy As String
    Dim sentenceLength As String
    Dim released As String
    Dim releaseDate As String

    'Properties
    Public Property arrestDateP As String
        Get
            Return arrestDate
        End Get
        Set(value As String)
            arrestDate = value
        End Set
    End Property
    Public Property crimeCommitedP As String
        Get
            Return crimeCommmited
        End Get
        Set(value As String)
            crimeCommmited = value
        End Set
    End Property
    Public Property arrestedByP As String
        Get
            Return arrestedBy
        End Get
        Set(value As String)
            arrestedBy = value
        End Set
    End Property
    Public Property sentenceLengthP As String
        Get
            Return sentenceLength
        End Get
        Set(value As String)
            sentenceLength = value
        End Set
    End Property
    Public Property releasedP As String
        Get
            Return released
        End Get
        Set(value As String)
            released = value
        End Set
    End Property
    Public Property releasedDateP As String
        Get
            Return releaseDate
        End Get
        Set(value As String)
            releaseDate = value
        End Set
    End Property

    'Constructor
    Public Sub New(ByVal pArrestDate As String, ByVal pCrimeCommited As String, ByVal pArrestedBy As String, ByVal pSentenceLength As String, ByVal pReleased As String, ByVal pReleaseDate As String)
        arrestDate = pArrestDate
        crimeCommmited = pCrimeCommited
        arrestedBy = pArrestedBy
        sentenceLength = pSentenceLength
        released = pReleased
        releaseDate = pReleaseDate
    End Sub
End Class
