Public Class Usuarios
    Private IdUsua As Integer
    Private Nombres, Apellidos, Usuario, Contrasena, TAcceso As String

    'Metodos GET y SET
    Public Property cIdUsua()
        Get
            Return IdUsua
        End Get
        Set(value)
            IdUsua = value
        End Set
    End Property

    Public Property cNombres()
        Get
            Return Nombres
        End Get
        Set(value)
            Nombres = value
        End Set
    End Property

    Public Property cApellidos()
        Get
            Return Apellidos
        End Get
        Set(value)
            Apellidos = value
        End Set
    End Property

    Public Property cUsuario()
        Get
            Return Usuario
        End Get
        Set(value)
            Usuario = value
        End Set
    End Property

    Public Property cContrasena()
        Get
            Return Contrasena
        End Get
        Set(value)
            Contrasena = value
        End Set
    End Property

    Public Property cTAcceso()
        Get
            Return TAcceso
        End Get
        Set(value)
            TAcceso = value
        End Set
    End Property

    'Constructores
    Public Sub New()
        'Constructor en Blanco o Vacío
    End Sub

    Public Sub New(IdUsuario As Integer, Nombres As String, Apellidos As String, Usuario As String, Contrasena As String, TAcceso As String)
        'Constructor que recibe todos los datos 
        cIdUsua = IdUsuario
        cNombres = Nombres
        cApellidos = Apellidos
        cUsuario = Usuario
        cContrasena = cContrasena
        cTAcceso = TAcceso
    End Sub





End Class
