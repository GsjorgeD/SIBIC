'
' Created by SharpDevelop.
' User: Daniel
' Date: 13/06/2020
' Time: 08:04 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.lblNewCuenta = New System.Windows.Forms.Label()
		Me.txtPass = New System.Windows.Forms.TextBox()
		Me.btnEntrar = New System.Windows.Forms.Button()
		Me.txtUsuario = New System.Windows.Forms.TextBox()
		Me.lblPass = New System.Windows.Forms.Label()
		Me.lblUsuario = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'lblNewCuenta
		'
		Me.lblNewCuenta.Location = New System.Drawing.Point(102, 176)
		Me.lblNewCuenta.Name = "lblNewCuenta"
		Me.lblNewCuenta.Size = New System.Drawing.Size(72, 23)
		Me.lblNewCuenta.TabIndex = 26
		Me.lblNewCuenta.Text = "Crear cuenta"
		AddHandler Me.lblNewCuenta.Click, AddressOf Me.LblNewCuentaClick
		'
		'txtPass
		'
		Me.txtPass.Location = New System.Drawing.Point(133, 62)
		Me.txtPass.Name = "txtPass"
		Me.txtPass.Size = New System.Drawing.Size(100, 20)
		Me.txtPass.TabIndex = 22
		'
		'btnEntrar
		'
		Me.btnEntrar.Location = New System.Drawing.Point(99, 142)
		Me.btnEntrar.Name = "btnEntrar"
		Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
		Me.btnEntrar.TabIndex = 25
		Me.btnEntrar.Text = "INGRESAR"
		Me.btnEntrar.UseVisualStyleBackColor = true
		AddHandler Me.btnEntrar.Click, AddressOf Me.BtnEntrarClick
		'
		'txtUsuario
		'
		Me.txtUsuario.Location = New System.Drawing.Point(133, 17)
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
		Me.txtUsuario.TabIndex = 21
		'
		'lblPass
		'
		Me.lblPass.Location = New System.Drawing.Point(47, 65)
		Me.lblPass.Name = "lblPass"
		Me.lblPass.Size = New System.Drawing.Size(100, 23)
		Me.lblPass.TabIndex = 24
		Me.lblPass.Text = "Contraseña:"
		'
		'lblUsuario
		'
		Me.lblUsuario.Location = New System.Drawing.Point(47, 20)
		Me.lblUsuario.Name = "lblUsuario"
		Me.lblUsuario.Size = New System.Drawing.Size(80, 23)
		Me.lblUsuario.TabIndex = 23
		Me.lblUsuario.Text = "Usuario:"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(284, 247)
		Me.Controls.Add(Me.lblNewCuenta)
		Me.Controls.Add(Me.txtPass)
		Me.Controls.Add(Me.lblUsuario)
		Me.Controls.Add(Me.btnEntrar)
		Me.Controls.Add(Me.lblPass)
		Me.Controls.Add(Me.txtUsuario)
		Me.Name = "MainForm"
		Me.Text = "SIBIC"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lblUsuario As System.Windows.Forms.Label
	Private lblPass As System.Windows.Forms.Label
	Private txtUsuario As System.Windows.Forms.TextBox
	Private btnEntrar As System.Windows.Forms.Button
	Private txtPass As System.Windows.Forms.TextBox
	Private lblNewCuenta As System.Windows.Forms.Label
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		MsgBox("Bienvenido al sistema de bitacora de clientes...")
	End Sub
End Class
