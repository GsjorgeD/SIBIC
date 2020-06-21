'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 08:50 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MoviientoCl
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
		Me.label3 = New System.Windows.Forms.Label()
		Me.pnl1 = New System.Windows.Forms.Panel()
		Me.TxtDireccion = New System.Windows.Forms.TextBox()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.txtCantidad = New System.Windows.Forms.TextBox()
		Me.txtProducto = New System.Windows.Forms.TextBox()
		Me.txtTel = New System.Windows.Forms.TextBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.btnVerificar = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		Me.txtIDCl = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.lblIdClie = New System.Windows.Forms.Label()
		Me.pnl1.SuspendLayout
		Me.SuspendLayout
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(132, 15)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(135, 23)
		Me.label3.TabIndex = 29
		Me.label3.Text = "CAMBIOS CLIENTE"
		'
		'pnl1
		'
		Me.pnl1.Controls.Add(Me.TxtDireccion)
		Me.pnl1.Controls.Add(Me.txtNombre)
		Me.pnl1.Controls.Add(Me.label13)
		Me.pnl1.Controls.Add(Me.txtCantidad)
		Me.pnl1.Controls.Add(Me.txtProducto)
		Me.pnl1.Controls.Add(Me.txtTel)
		Me.pnl1.Controls.Add(Me.txtCorreo)
		Me.pnl1.Controls.Add(Me.label10)
		Me.pnl1.Controls.Add(Me.label6)
		Me.pnl1.Controls.Add(Me.btnVerificar)
		Me.pnl1.Controls.Add(Me.btnModificar)
		Me.pnl1.Controls.Add(Me.label9)
		Me.pnl1.Controls.Add(Me.label11)
		Me.pnl1.Controls.Add(Me.label12)
		Me.pnl1.Location = New System.Drawing.Point(12, 120)
		Me.pnl1.Name = "pnl1"
		Me.pnl1.Size = New System.Drawing.Size(353, 296)
		Me.pnl1.TabIndex = 30
		Me.pnl1.Visible = false
		'
		'TxtDireccion
		'
		Me.TxtDireccion.Location = New System.Drawing.Point(190, 53)
		Me.TxtDireccion.Name = "TxtDireccion"
		Me.TxtDireccion.Size = New System.Drawing.Size(100, 20)
		Me.TxtDireccion.TabIndex = 80
		'
		'txtNombre
		'
		Me.txtNombre.Location = New System.Drawing.Point(184, 14)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(100, 20)
		Me.txtNombre.TabIndex = 79
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(62, 13)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(100, 23)
		Me.label13.TabIndex = 71
		Me.label13.Text = "Nombre:"
		'
		'txtCantidad
		'
		Me.txtCantidad.Location = New System.Drawing.Point(191, 203)
		Me.txtCantidad.Name = "txtCantidad"
		Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
		Me.txtCantidad.TabIndex = 84
		'
		'txtProducto
		'
		Me.txtProducto.Location = New System.Drawing.Point(191, 167)
		Me.txtProducto.Name = "txtProducto"
		Me.txtProducto.Size = New System.Drawing.Size(100, 20)
		Me.txtProducto.TabIndex = 83
		'
		'txtTel
		'
		Me.txtTel.Location = New System.Drawing.Point(188, 132)
		Me.txtTel.Name = "txtTel"
		Me.txtTel.Size = New System.Drawing.Size(100, 20)
		Me.txtTel.TabIndex = 82
		'
		'txtCorreo
		'
		Me.txtCorreo.Location = New System.Drawing.Point(188, 91)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
		Me.txtCorreo.TabIndex = 81
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(67, 167)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(117, 23)
		Me.label10.TabIndex = 78
		Me.label10.Text = "Codigo de producto:"
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(66, 203)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 23)
		Me.label6.TabIndex = 77
		Me.label6.Text = "Cantidad:"
		'
		'btnVerificar
		'
		Me.btnVerificar.Location = New System.Drawing.Point(195, 259)
		Me.btnVerificar.Name = "btnVerificar"
		Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
		Me.btnVerificar.TabIndex = 76
		Me.btnVerificar.Text = "Verificar"
		Me.btnVerificar.UseVisualStyleBackColor = true
		'
		'btnModificar
		'
		Me.btnModificar.Location = New System.Drawing.Point(87, 260)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(75, 23)
		Me.btnModificar.TabIndex = 75
		Me.btnModificar.Text = "Modificar"
		Me.btnModificar.UseVisualStyleBackColor = true
		AddHandler Me.btnModificar.Click, AddressOf Me.BtnModificarClick
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(67, 133)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 74
		Me.label9.Text = "Telefono:"
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(66, 91)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 73
		Me.label11.Text = "Correo:"
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(66, 50)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(100, 23)
		Me.label12.TabIndex = 72
		Me.label12.Text = "Direccion:"
		'
		'txtIDCl
		'
		Me.txtIDCl.Location = New System.Drawing.Point(200, 44)
		Me.txtIDCl.Name = "txtIDCl"
		Me.txtIDCl.Size = New System.Drawing.Size(43, 20)
		Me.txtIDCl.TabIndex = 64
		'
		'btnBuscar
		'
		Me.btnBuscar.Location = New System.Drawing.Point(76, 72)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
		Me.btnBuscar.TabIndex = 63
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = true
		AddHandler Me.btnBuscar.Click, AddressOf Me.BtnBuscarClick
		'
		'lblIdClie
		'
		Me.lblIdClie.Location = New System.Drawing.Point(76, 46)
		Me.lblIdClie.Name = "lblIdClie"
		Me.lblIdClie.Size = New System.Drawing.Size(100, 23)
		Me.lblIdClie.TabIndex = 54
		Me.lblIdClie.Text = "ID de cliente:"
		'
		'MoviientoCl
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(377, 439)
		Me.Controls.Add(Me.txtIDCl)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.lblIdClie)
		Me.Controls.Add(Me.pnl1)
		Me.Controls.Add(Me.label3)
		Me.Name = "MoviientoCl"
		Me.Text = "MoviientoClUpdate"
		Me.pnl1.ResumeLayout(false)
		Me.pnl1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private pnl1 As System.Windows.Forms.Panel
	Private txtCantidad As System.Windows.Forms.TextBox
	Private txtProducto As System.Windows.Forms.TextBox
	Private txtTel As System.Windows.Forms.TextBox
	Private txtCorreo As System.Windows.Forms.TextBox
	Private TxtDireccion As System.Windows.Forms.TextBox
	Private txtNombre As System.Windows.Forms.TextBox
	Private txtIDCl As System.Windows.Forms.TextBox
	Private btnBuscar As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private lblIdClie As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private btnModificar As System.Windows.Forms.Button
	Private btnVerificar As System.Windows.Forms.Button
	Private label6 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
End Class
