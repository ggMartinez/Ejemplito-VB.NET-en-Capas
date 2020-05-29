Public Class ModeloPersona
    Public Nombre As String
    Public Apellido As String


    Public Function Listar()
        Me.Nombre = "Jose"
        Me.Apellido = "Martinez"
        Dim resultado(2) As String
        resultado(1) = Me.Nombre
        resultado(2) = Me.Apellido

        Return resultado

    End Function

End Class
