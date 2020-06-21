'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 09:24 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MovimientoProDelete
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
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.txtProducto = New System.Windows.Forms.TextBox()
		Me.SuspendLayout
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(119, 110)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 31
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = true
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(40, 75)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(114, 32)
		Me.label8.TabIndex = 29
		Me.label8.Text = "Codigo de producto:"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(83, 55)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(135, 23)
		Me.label4.TabIndex = 28
		Me.label4.Text = "ELIMINAR PRODUCTO"
		'
		'txtProducto
		'
		Me.txtProducto.Location = New System.Drawing.Point(151, 75)
		Me.txtProducto.Name = "txtProducto"
		Me.txtProducto.Size = New System.Drawing.Size(100, 20)
		Me.txtProducto.TabIndex = 32
		'
		'MovimientoProDelete
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.txtProducto)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label4)
		Me.Name = "MovimientoProDelete"
		Me.Text = "MovimientoProDelete"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private txtProducto As System.Windows.Forms.TextBox
	Private label4 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private btnEliminar As System.Windows.Forms.Button
End Class
