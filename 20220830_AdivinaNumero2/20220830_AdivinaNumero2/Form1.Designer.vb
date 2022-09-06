<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_computadora = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_mensaje = New System.Windows.Forms.Label()
        Me.lbl_intentos = New System.Windows.Forms.Label()
        Me.txt_computadora = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_mensaje = New System.Windows.Forms.TextBox()
        Me.txt_intentos = New System.Windows.Forms.TextBox()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.btn_verificar = New System.Windows.Forms.Button()
        Me.btn_reiniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(236, 48)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(97, 13)
        Me.lbl_titulo.TabIndex = 0
        Me.lbl_titulo.Text = "Adivina un Numero"
        '
        'lbl_computadora
        '
        Me.lbl_computadora.AutoSize = True
        Me.lbl_computadora.Location = New System.Drawing.Point(76, 136)
        Me.lbl_computadora.Name = "lbl_computadora"
        Me.lbl_computadora.Size = New System.Drawing.Size(70, 13)
        Me.lbl_computadora.TabIndex = 1
        Me.lbl_computadora.Text = "Computadora"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Location = New System.Drawing.Point(76, 97)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_usuario.TabIndex = 2
        Me.lbl_usuario.Text = "Usuario"
        '
        'lbl_mensaje
        '
        Me.lbl_mensaje.AutoSize = True
        Me.lbl_mensaje.Location = New System.Drawing.Point(76, 174)
        Me.lbl_mensaje.Name = "lbl_mensaje"
        Me.lbl_mensaje.Size = New System.Drawing.Size(47, 13)
        Me.lbl_mensaje.TabIndex = 3
        Me.lbl_mensaje.Text = "Mensaje"
        '
        'lbl_intentos
        '
        Me.lbl_intentos.AutoSize = True
        Me.lbl_intentos.Location = New System.Drawing.Point(76, 213)
        Me.lbl_intentos.Name = "lbl_intentos"
        Me.lbl_intentos.Size = New System.Drawing.Size(45, 13)
        Me.lbl_intentos.TabIndex = 4
        Me.lbl_intentos.Text = "Intentos"
        '
        'txt_computadora
        '
        Me.txt_computadora.Location = New System.Drawing.Point(205, 133)
        Me.txt_computadora.Name = "txt_computadora"
        Me.txt_computadora.Size = New System.Drawing.Size(100, 20)
        Me.txt_computadora.TabIndex = 5
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(205, 94)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(100, 20)
        Me.txt_usuario.TabIndex = 6
        '
        'txt_mensaje
        '
        Me.txt_mensaje.Location = New System.Drawing.Point(205, 171)
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(100, 20)
        Me.txt_mensaje.TabIndex = 7
        '
        'txt_intentos
        '
        Me.txt_intentos.Location = New System.Drawing.Point(205, 210)
        Me.txt_intentos.Name = "txt_intentos"
        Me.txt_intentos.Size = New System.Drawing.Size(100, 20)
        Me.txt_intentos.TabIndex = 8
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Location = New System.Drawing.Point(360, 92)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(69, 22)
        Me.btn_iniciar.TabIndex = 9
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'btn_verificar
        '
        Me.btn_verificar.Location = New System.Drawing.Point(360, 131)
        Me.btn_verificar.Name = "btn_verificar"
        Me.btn_verificar.Size = New System.Drawing.Size(69, 22)
        Me.btn_verificar.TabIndex = 10
        Me.btn_verificar.Text = "Verificar"
        Me.btn_verificar.UseVisualStyleBackColor = True
        '
        'btn_reiniciar
        '
        Me.btn_reiniciar.Location = New System.Drawing.Point(360, 208)
        Me.btn_reiniciar.Name = "btn_reiniciar"
        Me.btn_reiniciar.Size = New System.Drawing.Size(69, 22)
        Me.btn_reiniciar.TabIndex = 12
        Me.btn_reiniciar.Text = "Reiniciar"
        Me.btn_reiniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 378)
        Me.Controls.Add(Me.btn_reiniciar)
        Me.Controls.Add(Me.btn_verificar)
        Me.Controls.Add(Me.btn_iniciar)
        Me.Controls.Add(Me.txt_intentos)
        Me.Controls.Add(Me.txt_mensaje)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_computadora)
        Me.Controls.Add(Me.lbl_intentos)
        Me.Controls.Add(Me.lbl_mensaje)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.lbl_computadora)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_computadora As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_mensaje As Label
    Friend WithEvents lbl_intentos As Label
    Friend WithEvents txt_computadora As TextBox
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_mensaje As TextBox
    Friend WithEvents txt_intentos As TextBox
    Friend WithEvents btn_iniciar As Button
    Friend WithEvents btn_verificar As Button
    Friend WithEvents btn_reiniciar As Button
End Class
