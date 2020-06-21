'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 08:53 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MovimientoClDelete
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
		Me.txtIDCl = New System.Windows.Forms.TextBox()
		Me.lblIdClie = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'txtIDCl
		'
		Me.txtIDCl.Location = New System.Drawing.Point(175, 61)
		Me.txtIDCl.Name = "txtIDCl"
		Me.txtIDCl.Size = New System.Drawing.Size(43, 20)
		Me.txtIDCl.TabIndex = 51
		'
		'lblIdClie
		'
		Me.lblIdClie.Location = New System.Drawing.Point(51, 63)
		Me.lblIdClie.Name = "lblIdClie"
		Me.lblIdClie.Size = New System.Drawing.Size(100, 23)
		Me.lblIdClie.TabIndex = 49
		Me.lblIdClie.Text = "ID de cliente:"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(73, 18)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(135, 23)
		Me.label3.TabIndex = 48
		Me.label3.Text = "ELIMINAR CLIENTE"
		'
		'btnEliminar
		'
		Me.btnEliminar.Location = New System.Drawing.Point(88, 117)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
		Me.btnEliminar.TabIndex = 52
		Me.btnEliminar.Text = "Eliminar"
		Me.btnEliminar.UseVisualStyleBackColor = true
		AddHandler Me.btnEliminar.Click, AddressOf Me.BtnEliminarClick
		'
		'MovimientoClDelete
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 261)
		Me.Controls.Add(Me.btnEliminar)
		Me.Controls.Add(Me.txtIDCl)
		Me.Controls.Add(Me.lblIdClie)
		Me.Controls.Add(Me.label3)
		Me.Name = "MovimientoClDelete"
		Me.Text = "MovimientoClDelete"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private btnEliminar As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private lblIdClie As System.Windows.Forms.Label
	Private txtIDCl As System.Windows.Forms.TextBox
End Class
