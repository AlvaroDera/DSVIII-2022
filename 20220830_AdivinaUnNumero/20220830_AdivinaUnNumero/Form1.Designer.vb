<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_computadora = New System.Windows.Forms.Label()
        Me.txt_computadora = New System.Windows.Forms.TextBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.txt_mensaje = New System.Windows.Forms.TextBox()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.lbl_intentos = New System.Windows.Forms.Label()
        Me.txt_intentos = New System.Windows.Forms.TextBox()
        Me.btn_ocultar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(350, 48)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(112, 15)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Adivina Un Numero"
        '
        'lbl_computadora
        '
        Me.lbl_computadora.AutoSize = True
        Me.lbl_computadora.Location = New System.Drawing.Point(167, 112)
        Me.lbl_computadora.Name = "lbl_computadora"
        Me.lbl_computadora.Size = New System.Drawing.Size(81, 15)
        Me.lbl_computadora.TabIndex = 1
        Me.lbl_computadora.Text = "Computadora"
        '
        'txt_computadora
        '
        Me.txt_computadora.Location = New System.Drawing.Point(279, 109)
        Me.txt_computadora.Name = "txt_computadora"
        Me.txt_computadora.Size = New System.Drawing.Size(100, 23)
        Me.txt_computadora.TabIndex = 2
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Location = New System.Drawing.Point(425, 108)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_iniciar.TabIndex = 3
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(167, 157)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(47, 15)
        Me.lbl_usuario.TabIndex = 4
        Me.lbl_usuario.Text = "Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(279, 154)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 23)
        Me.txt_usuario.TabIndex = 5
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(167, 207)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(51, 15)
        Me.lbl_mensaje.TabIndex = 6
        Me.lbl_mensaje.Text = "Mensaje"
        '
        'txt_mensaje
        '
        Me.txt_mensaje.Location = New System.Drawing.Point(279, 204)
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(100, 23)
        Me.txt_mensaje.TabIndex = 7
        '
        'btn_verificar
        '
        Me.btn_verificar.Location = New System.Drawing.Point(425, 153)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_verificar.TabIndex = 8
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = True
        '
        'lbl_intentos
        '
        Me.lbl_intentos.AutoSize = True
        Me.lbl_intentos.Location = New System.Drawing.Point(167, 261)
        Me.lbl_intentos.Name = "lbl_intentos"
        Me.lbl_intentos.Size = New System.Drawing.Size(50, 15)
        Me.lbl_intentos.TabIndex = 9
        Me.lbl_intentos.Text = "Intentos"
        '
        'txt_intentos
        '
        Me.txt_intentos.Location = New System.Drawing.Point(279, 258)
        Me.txt_intentos.Name = "txt_intentos"
        Me.txt_intentos.Size = New System.Drawing.Size(100, 23)
        Me.txt_intentos.TabIndex = 10
        '
        'btn_ocultar
        '
        Me.btn_ocultar.Location = New System.Drawing.Point(425, 203)
        Me.btn_ocultar.Name = "btn_ocultar"
        Me.btn_ocultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ocultar.TabIndex = 11
        Me.btn_ocultar.Text = "Ocultar"
        Me.btn_ocultar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_ocultar)
        Me.Controls.Add(Me.txt_intentos)
        Me.Controls.Add(Me.lbl_intentos)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.txt_mensaje)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(Me.txt_computadora)
        Me.Controls.Add(Me.lbl_computadora)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_computadora As Label
    Friend WithEvents txt_computadora As TextBox
    Friend WithEvents btn_iniciar As Button
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents txt_mensaje As TextBox
    Friend WithEvents btn_verificar As Button
    Friend WithEvents lbl_intentos As Label
    Friend WithEvents txt_intentos As TextBox
    Friend WithEvents btn_ocultar As Button
End Class
