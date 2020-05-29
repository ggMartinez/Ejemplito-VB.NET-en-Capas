Imports CapaFisica


Public Module ControladorPersona
    Public Function ObtenerPersonas()
        Dim p As New ModeloPersona()
        Return p.Listar()
    End Function
End Module
