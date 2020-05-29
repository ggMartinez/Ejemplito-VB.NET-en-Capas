Imports CapaLogica

Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim persona(2) As String

        persona = ControladorPersona.ObtenerPersonas()

        txtNombre.Text = persona(1)
        txtApellido.Text = persona(2)

    End Sub
End Class
