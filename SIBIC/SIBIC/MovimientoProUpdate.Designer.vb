'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 09:19 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MovimientoProUpdate
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
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.txtIDPro = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.pnl1 = New System.Windows.Forms.Panel()
		Me.txtPro = New System.Windows.Forms.TextBox()
		Me.btnVerificar = New System.Windows.Forms.Button()
		Me.btnModificar = New System.Windows.Forms.Button()
		Me.txtPrecio = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.pnl1.SuspendLayout
		Me.SuspendLayout
		'
		'btnBuscar
		'
		Me.btnBuscar.Location = New System.Drawing.Point(140, 84)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
		Me.btnBuscar.TabIndex = 27
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.UseVisualStyleBackColor = true
		AddHandler Me.btnBuscar.Click, AddressOf Me.BtnBuscarClick
		'
		'txtIDPro
		'
		Me.txtIDPro.Location = New System.Drawing.Point(185, 49)
		Me.txtIDPro.Name = "txtIDPro"
		Me.txtIDPro.Size = New System.Drawing.Size(100, 20)
		Me.txtIDPro.TabIndex = 24
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(61, 49)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(114, 32)
		Me.label8.TabIndex = 21
		Me.label8.Text = "Codigo de producto:"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(104, 29)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(135, 23)
		Me.label4.TabIndex = 20
		Me.label4.Text = "CAMBIOS PRODUCTOS"
		'
		'pnl1
		'
		Me.pnl1.Controls.Add(Me.txtPro)
		Me.pnl1.Controls.Add(Me.btnVerificar)
		Me.pnl1.Controls.Add(Me.btnModificar)
		Me.pnl1.Controls.Add(Me.txtPrecio)
		Me.pnl1.Controls.Add(Me.label5)
		Me.pnl1.Controls.Add(Me.label7)
		Me.pnl1.Location = New System.Drawing.Point(13, 141)
		Me.pnl1.Name = "pnl1"
		Me.pnl1.Size = New System.Drawing.Size(321, 187)
		Me.pnl1.TabIndex = 28
		Me.pnl1.Visible = false
		'
		'txtPro
		'
		Me.txtPro.Location = New System.Drawing.Point(172, 11)
		Me.txtPro.Name = "txtPro"
		Me.txtPro.Size = New System.Drawing.Size(132, 20)
		Me.txtPro.TabIndex = 36
		'
		'btnVerificar
		'
		Me.btnVerificar.Location = New System.Drawing.Point(172, 152)
		Me.btnVerificar.Name = "btnVerificar"
		Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
		Me.btnVerificar.TabIndex = 35
		Me.btnVerificar.Text = "Verificar"
		Me.btnVerificar.UseVisualStyleBackColor = true
		'
		'btnModificar
		'
		Me.btnModificar.Location = New System.Drawing.Point(64, 153)
		Me.btnModificar.Name = "btnModificar"
		Me.btnModificar.Size = New System.Drawing.Size(75, 23)
		Me.btnModificar.TabIndex = 34
		Me.btnModificar.Text = "Modificar"
		Me.btnModificar.UseVisualStyleBackColor = true
		AddHandler Me.btnModificar.Click, AddressOf Me.BtnModificarClick
		'
		'txtPrecio
		'
		Me.txtPrecio.Location = New System.Drawing.Point(172, 63)
		Me.txtPrecio.Name = "txtPrecio"
		Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
		Me.txtPrecio.TabIndex = 32
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(48, 66)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 23)
		Me.label5.TabIndex = 31
		Me.label5.Text = "Precio:"
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(48, 11)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(100, 23)
		Me.label7.TabIndex = 30
		Me.label7.Text = "Elegir mercancia:"
		'
		'MovimientoProUpdate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(346, 349)
		Me.Controls.Add(Me.pnl1)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.txtIDPro)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label4)
		Me.Name = "MovimientoProUpdate"
		Me.Text = "MovimientoProUpdate"
		AddHandler Load, AddressOf Me.MovimientoProUpdateLoad
		Me.pnl1.ResumeLayout(false)
		Me.pnl1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtPro As System.Windows.Forms.TextBox
	Private pnl1 As System.Windows.Forms.Panel
	Private label4 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private txtIDPro As System.Windows.Forms.TextBox
	Private txtPrecio As System.Windows.Forms.TextBox
	Private btnBuscar As System.Windows.Forms.Button
	Private btnModificar As System.Windows.Forms.Button
	Private btnVerificar As System.Windows.Forms.Button
End Class
