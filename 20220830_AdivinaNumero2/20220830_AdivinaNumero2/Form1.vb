Public Class Form1
    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Dim rnd As New Random()
        txt_computadora.Text = rnd.Next(1, 100 + 1)

        btn_iniciar.Visible = False
        btn_verificar.Text = "Otra Vez"

        If Val(txt_computadora.Text) < Val(txt_usuario.Text) Then
            txt_mensaje.Text = "Muy Bajo"
        ElseIf Val(txt_computadora.Text) > Val(txt_usuario.Text) Then
            txt_mensaje.Text = "Muy Alto"
        Else
            txt_mensaje.Text = "Correcto"
            btn_verificar.Visible = False
        End If
        txt_intentos.Text = Val(txt_intentos.Text) + 1

        If Val(txt_usuario.Text) = 0 Then
            txt_mensaje.Text = "Ingrese un Numero"
            txt_computadora.Text = 0
            txt_intentos.Text = 0
            btn_iniciar.Visible = True
            btn_verificar.Visible = False
        Else
            btn_verificar.Visible = True
        End If

    End Sub

    Private Sub btn_verificar_Click(sender As Object, e As EventArgs) Handles btn_verificar.Click
        Dim rnd As New Random()

        If Val(txt_computadora.Text) < Val(txt_usuario.Text) Then
            txt_mensaje.Text = "Muy Bajo"
        ElseIf Val(txt_computadora.Text) > Val(txt_usuario.Text) Then
            txt_mensaje.Text = "Muy Alto"
        Else
            txt_mensaje.Text = "Correcto"
            btn_verificar.Visible = False
        End If
        txt_intentos.Text = Val(txt_intentos.Text) + 1

        txt_computadora.Text = rnd.Next(1, 100 + 1)
    End Sub

    Private Sub btn_reiniciar_Click(sender As Object, e As EventArgs) Handles btn_reiniciar.Click
        txt_computadora.Clear()
        txt_usuario.Clear()
        txt_mensaje.Clear()
        txt_intentos.Clear()

        btn_iniciar.Visible = True
        btn_verificar.Visible = True
    End Sub
End Class
