'
' Created by SharpDevelop.
' User: Daniel
' Date: 15/06/2020
' Time: 02:26 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Movimiento
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
		Me.dgvDatos = New System.Windows.Forms.DataGridView()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtBus = New System.Windows.Forms.TextBox()
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'dgvDatos
		'
		Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDatos.Location = New System.Drawing.Point(24, 127)
		Me.dgvDatos.Name = "dgvDatos"
		Me.dgvDatos.Size = New System.Drawing.Size(719, 204)
		Me.dgvDatos.TabIndex = 0
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(196, 29)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 1
		Me.label1.Text = "INVENTARIO"
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(136, 60)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Codigo de cliente:"
		'
		'txtBus
		'
		Me.txtBus.Location = New System.Drawing.Point(229, 58)
		Me.txtBus.Name = "txtBus"
		Me.txtBus.Size = New System.Drawing.Size(54, 20)
		Me.txtBus.TabIndex = 3
		AddHandler Me.txtBus.TextChanged, AddressOf Me.TxtBusTextChanged
		'
		'Movimiento
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Honeydew
		Me.ClientSize = New System.Drawing.Size(764, 393)
		Me.Controls.Add(Me.txtBus)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.dgvDatos)
		Me.Name = "Movimiento"
		Me.Text = "MovimientoSearch"
		AddHandler Load, AddressOf Me.MovimientoLoad
		CType(Me.dgvDatos,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private dgvDatos As System.Windows.Forms.DataGridView
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private txtBus As System.Windows.Forms.TextBox
End Class
