Public Class Criminal
    Private criminalID As Integer
    Private firstName As String
    Private middleName As String
    Private lastName As String
    Private gender As String
    Private age As Integer
    Private height As Double
    Private weight As Double
    Private race As String
    Private eyeColor As String
    Private rec As Record

    'Properties for criminal variables

    Public Property criminalIDP As Integer
        Get
            Return criminalID
        End Get
        Set(value As Integer)
            criminalID = value
        End Set
    End Property
    Public Property firstNameP As String
        Get
            Return firstName
        End Get
        Set(value As String)
            firstName = value
        End Set
    End Property
    Public Property middleNameP As String
        Get
            Return middleName
        End Get
        Set(value As String)
            middleName = value
        End Set
    End Property
    Public Property lastNameP As String
        Get
            Return lastName
        End Get
        Set(value As String)
            lastName = value
        End Set
    End Property
    Public Property genderP As String
        Get
            Return gender
        End Get
        Set(value As String)
            gender = value
        End Set
    End Property
    Public Property ageP As Integer
        Get
            Return age
        End Get
        Set(value As Integer)
            age = value
        End Set
    End Property
    Public Property heightP As Double
        Get
            Return height
        End Get
        Set(value As Double)
            height = value
        End Set
    End Property
    Public Property weightP As Double
        Get
            Return weight
        End Get
        Set(value As Double)
            weight = value
        End Set
    End Property
    Public Property raceP As String
        Get
            Return race
        End Get
        Set(value As String)
            race = value
        End Set
    End Property
    Public Property eyeP As String
        Get
            Return eyeColor
        End Get
        Set(value As String)
            eyeColor = value
        End Set
    End Property
    Public Property recordP As Record
        Get
            Return rec
        End Get
        Set(value As Record)
            rec = value
        End Set
    End Property

    'Constructor
    Public Sub New(ByVal pCriminalID As Integer, ByVal pFirstName As String, ByVal pMiddleName As String, ByVal pLastName As String, ByVal pGender As String, ByVal pAge As Integer, ByVal pHeight As Double, ByVal pWeight As Double, ByVal pEyeColor As String, ByVal pRace As String, ByVal pRec As Record)
        criminalID = criminalIDP
        firstName = pFirstName
        middleName = pMiddleName
        lastName = pLastName
        gender = pGender
        age = pAge
        height = pHeight
        weight = pWeight
        eyeColor = pEyeColor
        race = pRace
        rec = pRec
    End Sub
End Class
