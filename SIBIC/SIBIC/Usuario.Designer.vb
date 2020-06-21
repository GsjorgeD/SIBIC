'
' Created by SharpDevelop.
' User: Daniel
' Date: 14/06/2020
' Time: 12:57 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Usuario
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
		Me.lblUsuario = New System.Windows.Forms.Label()
		Me.lblpass = New System.Windows.Forms.Label()
		Me.lblCodi = New System.Windows.Forms.Label()
		Me.btnRegistro = New System.Windows.Forms.Button()
		Me.txtUsuario = New System.Windows.Forms.TextBox()
		Me.txtPass = New System.Windows.Forms.TextBox()
		Me.txtCodi = New System.Windows.Forms.TextBox()
		Me.btnVerify = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'lblUsuario
		'
		Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblUsuario.Location = New System.Drawing.Point(29, 35)
		Me.lblUsuario.Name = "lblUsuario"
		Me.lblUsuario.Size = New System.Drawing.Size(80, 29)
		Me.lblUsuario.TabIndex = 0
		Me.lblUsuario.Text = "Usuario:"
		'
		'lblpass
		'
		Me.lblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblpass.Location = New System.Drawing.Point(29, 85)
		Me.lblpass.Name = "lblpass"
		Me.lblpass.Size = New System.Drawing.Size(120, 23)
		Me.lblpass.TabIndex = 1
		Me.lblpass.Text = "Contraseña:"
		'
		'lblCodi
		'
		Me.lblCodi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lblCodi.Location = New System.Drawing.Point(40, 162)
		Me.lblCodi.Name = "lblCodi"
		Me.lblCodi.Size = New System.Drawing.Size(100, 31)
		Me.lblCodi.TabIndex = 2
		Me.lblCodi.Text = "Codigo:"
		AddHandler Me.lblCodi.Click, AddressOf Me.LblCodiClick
		'
		'btnRegistro
		'
		Me.btnRegistro.BackColor = System.Drawing.Color.Lavender
		Me.btnRegistro.Enabled = false
		Me.btnRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnRegistro.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.btnRegistro.Location = New System.Drawing.Point(64, 247)
		Me.btnRegistro.Name = "btnRegistro"
		Me.btnRegistro.Size = New System.Drawing.Size(115, 34)
		Me.btnRegistro.TabIndex = 6
		Me.btnRegistro.Text = "Registrar"
		Me.btnRegistro.UseVisualStyleBackColor = false
		AddHandler Me.btnRegistro.Click, AddressOf Me.BtnRegistroClick
		'
		'txtUsuario
		'
		Me.txtUsuario.Location = New System.Drawing.Point(146, 37)
		Me.txtUsuario.Name = "txtUsuario"
		Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
		Me.txtUsuario.TabIndex = 1
		'
		'txtPass
		'
		Me.txtPass.Location = New System.Drawing.Point(146, 85)
		Me.txtPass.Name = "txtPass"
		Me.txtPass.Size = New System.Drawing.Size(100, 20)
		Me.txtPass.TabIndex = 2
		'
		'txtCodi
		'
		Me.txtCodi.Location = New System.Drawing.Point(146, 162)
		Me.txtCodi.Multiline = true
		Me.txtCodi.Name = "txtCodi"
		Me.txtCodi.Size = New System.Drawing.Size(130, 20)
		Me.txtCodi.TabIndex = 3
		'
		'btnVerify
		'
		Me.btnVerify.BackColor = System.Drawing.Color.Lavender
		Me.btnVerify.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.btnVerify.ForeColor = System.Drawing.Color.LightSeaGreen
		Me.btnVerify.Location = New System.Drawing.Point(196, 246)
		Me.btnVerify.Name = "btnVerify"
		Me.btnVerify.Size = New System.Drawing.Size(111, 35)
		Me.btnVerify.TabIndex = 7
		Me.btnVerify.Text = "Verificar"
		Me.btnVerify.UseVisualStyleBackColor = false
		AddHandler Me.btnVerify.Click, AddressOf Me.BtnVerifyClick
		'
		'Usuario
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Honeydew
		Me.ClientSize = New System.Drawing.Size(355, 304)
		Me.Controls.Add(Me.btnVerify)
		Me.Controls.Add(Me.txtCodi)
		Me.Controls.Add(Me.txtPass)
		Me.Controls.Add(Me.lblUsuario)
		Me.Controls.Add(Me.txtUsuario)
		Me.Controls.Add(Me.lblpass)
		Me.Controls.Add(Me.btnRegistro)
		Me.Controls.Add(Me.lblCodi)
		Me.Name = "Usuario"
		Me.Text = "Usuario"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnVerify As System.Windows.Forms.Button
	Private txtUsuario As System.Windows.Forms.TextBox
	Private txtPass As System.Windows.Forms.TextBox
	Private txtCodi As System.Windows.Forms.TextBox
	Private btnRegistro As System.Windows.Forms.Button
	Private lblUsuario As System.Windows.Forms.Label
	Private lblpass As System.Windows.Forms.Label
	Private lblCodi As System.Windows.Forms.Label
	
	Sub Label1Click(sender As Object, e As EventArgs)
		
	End Sub
	
	
	
	
End Class
