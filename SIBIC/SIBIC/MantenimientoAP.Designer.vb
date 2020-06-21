'
' Created by SharpDevelop.
' User: Daniel
' Date: 15/06/2020
' Time: 02:10 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Mantenimiento
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
		Me.btnVerificar = New System.Windows.Forms.Button()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.label11 = New System.Windows.Forms.Label()
		Me.cmbElegir = New System.Windows.Forms.ComboBox()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.txtIdProducto = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'btnVerificar
		'
		Me.btnVerificar.Location = New System.Drawing.Point(201, 303)
		Me.btnVerificar.Name = "btnVerificar"
		Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
		Me.btnVerificar.TabIndex = 29
		Me.btnVerificar.Text = "Verificar"
		Me.btnVerificar.UseVisualStyleBackColor = true
		'
		'btnGuardar
		'
		Me.btnGuardar.Location = New System.Drawing.Point(73, 303)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
		Me.btnGuardar.TabIndex = 28
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = true
		AddHandler Me.btnGuardar.Click, AddressOf Me.BtnGuardarClick
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(110, 35)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(100, 23)
		Me.label11.TabIndex = 27
		Me.label11.Text = "PRODUCTOS"
		'
		'cmbElegir
		'
		Me.cmbElegir.FormattingEnabled = true
		Me.cmbElegir.Items.AddRange(New Object() {"Neutralizador de olores", "Espuma limpiadora", "Limpiador quita grasa", "Limpiador blanqueador", "Aromatizante", "Limpiador de pisos", "Limpiador de alfombra", "Legia", "Limpiador multi-usos", "Desinfectante de superficies", "Suavizante", "Detergente industrial", "Desengrasante Industrial"})
		Me.cmbElegir.Location = New System.Drawing.Point(172, 146)
		Me.cmbElegir.Name = "cmbElegir"
		Me.cmbElegir.Size = New System.Drawing.Size(125, 21)
		Me.cmbElegir.TabIndex = 26
		'
		'txtPrecio
		'
		Me.txtPrecio.Location = New System.Drawing.Point(172, 218)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(125, 20)
		Me.txtPrecio.TabIndex = 25
		'
		'txtIdProducto
		'
		Me.txtIdProducto.Location = New System.Drawing.Point(172, 80)
		Me.txtIdProducto.Name = "txtIdProducto"
		Me.txtIdProducto.Size = New System.Drawing.Size(125, 20)
		Me.txtIdProducto.TabIndex = 24
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(48, 221)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(100, 23)
		Me.label4.TabIndex = 23
		Me.label4.Text = "Precio:"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(48, 146)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 22
		Me.label2.Text = "Elegir mercancia:"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(48, 80)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(114, 32)
		Me.label1.TabIndex = 21
		Me.label1.Text = "Codigo de producto:"
		'
		'Mantenimiento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(345, 391)
		Me.Controls.Add(Me.btnVerificar)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.label11)
		Me.Controls.Add(Me.cmbElegir)
		Me.Controls.Add(Me.txtPrecio)
		Me.Controls.Add(Me.txtIdProducto)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Name = "Mantenimiento"
		Me.Text = "MantenimientoAP"
		AddHandler Load, AddressOf Me.MantenimientoLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private txtIdProducto As System.Windows.Forms.TextBox
	Private txtPrecio As System.Windows.Forms.TextBox
	Private cmbElegir As System.Windows.Forms.ComboBox
	Private label11 As System.Windows.Forms.Label
	Private btnGuardar As System.Windows.Forms.Button
	Private btnVerificar As System.Windows.Forms.Button
End Class
