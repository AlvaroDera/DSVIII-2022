Public Class Form1
    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Dim rnd As New Random()
        txt_computadora.Text = rnd.Next(1, 100 + 1)
        txt_usuario.Clear()
        txt_intentos.Clear()
        txt_mensaje.Clear()
    End Sub

    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        If Val(txt_usuario.Text) < Val(txt_computadora.Text) Then
            txt_mensaje.Text = "Muy Bajo"
        ElseIf val(txt_usuario.Text) > val(txt_computadora.Text) Then
            txt_mensaje.Text = "Muy Alto"
        Else
            txt_mensaje.Text = "Correcto"
        End If
        txt_intentos.Text = Val(txt_intentos.Text) + 1

    End Sub

    Private Sub btn_ocultar_Click(sender As Object, e As EventArgs) Handles btn_ocultar.Click
        If txt_computadora.Visible Then
            txt_computadora.Visible = False
            btn_ocultar.Text = "Mostrar"
        Else
            txt_computadora.Visible = True
            btn_ocultar.Text = "Ocutar"
        End If
    End Sub
End Class
