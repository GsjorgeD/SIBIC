'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 07:45 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MantenimientoAC
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
		Me.txtIdPro = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.txtCantidad = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.label10 = New System.Windows.Forms.Label()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.txtTel = New System.Windows.Forms.TextBox()
		Me.txtDirccio = New System.Windows.Forms.TextBox()
		Me.txtCorreo = New System.Windows.Forms.TextBox()
		Me.txtIDCli = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.dgvPro = New System.Windows.Forms.DataGridView()
		CType(Me.dgvPro,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'txtIdPro
		'
		Me.txtIdPro.Location = New System.Drawing.Point(228, 264)
		Me.txtIdPro.Name = "txtIdPro"
		Me.txtIdPro.Size = New System.Drawing.Size(100, 20)
		Me.txtIdPro.TabIndex = 31
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(86, 267)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(119, 23)
		Me.label12.TabIndex = 30
		Me.label12.Text = "IDProducto:"
		'
		'txtCantidad
		'
		Me.txtCantidad.Location = New System.Drawing.Point(228, 298)
		Me.txtCantidad.Name = "txtCantidad"
		Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
		Me.txtCantidad.TabIndex = 29
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(46, 298)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(135, 23)
		Me.label3.TabIndex = 28
		Me.label3.Text = "Cantidad de producto:"
		'
		'btnGuardar
		'
		Me.btnGuardar.Location = New System.Drawing.Point(178, 344)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
		Me.btnGuardar.TabIndex = 17
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.UseVisualStyleBackColor = true
		AddHandler Me.btnGuardar.Click, AddressOf Me.BtnGuardarClick
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(187, 24)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(100, 23)
		Me.label10.TabIndex = 27
		Me.label10.Text = "CLIENTES"
		'
		'txtNombre
		'
		Me.txtNombre.Location = New System.Drawing.Point(228, 85)
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(100, 20)
		Me.txtNombre.TabIndex = 26
		'
		'txtTel
		'
		Me.txtTel.Location = New System.Drawing.Point(228, 225)
		Me.txtTel.Name = "txtTel"
		Me.txtTel.Size = New System.Drawing.Size(100, 20)
		Me.txtTel.TabIndex = 25
		'
		'txtDirccio
		'
		Me.txtDirccio.Location = New System.Drawing.Point(228, 133)
		Me.txtDirccio.Name = "txtDirccio"
		Me.txtDirccio.Size = New System.Drawing.Size(100, 20)
		Me.txtDirccio.TabIndex = 24
		'
		'txtCorreo
		'
		Me.txtCorreo.Location = New System.Drawing.Point(228, 178)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
		Me.txtCorreo.TabIndex = 23
		'
		'txtIDCli
		'
		Me.txtIDCli.Location = New System.Drawing.Point(228, 47)
		Me.txtIDCli.Name = "txtIDCli"
		Me.txtIDCli.Size = New System.Drawing.Size(100, 20)
		Me.txtIDCli.TabIndex = 22
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(105, 228)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(100, 23)
		Me.label9.TabIndex = 21
		Me.label9.Text = "Telefono:"
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(105, 181)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(100, 23)
		Me.label8.TabIndex = 20
		Me.label8.Text = "Correo:"
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(105, 136)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(100, 23)
		Me.label7.TabIndex = 19
		Me.label7.Text = "Direccion:"
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(105, 85)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(100, 23)
		Me.label6.TabIndex = 18
		Me.label6.Text = "Nombre:"
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(105, 47)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(100, 23)
		Me.label5.TabIndex = 16
		Me.label5.Text = "Numeo de cliente:"
		'
		'dgvPro
		'
		Me.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvPro.Location = New System.Drawing.Point(366, 58)
		Me.dgvPro.Name = "dgvPro"
		Me.dgvPro.Size = New System.Drawing.Size(343, 193)
		Me.dgvPro.TabIndex = 32
		AddHandler Me.dgvPro.CellContentClick, AddressOf Me.DataGridView1CellContentClick
		'
		'MantenimientoAC
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(827, 404)
		Me.Controls.Add(Me.dgvPro)
		Me.Controls.Add(Me.txtIdPro)
		Me.Controls.Add(Me.label12)
		Me.Controls.Add(Me.txtCantidad)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.txtNombre)
		Me.Controls.Add(Me.txtTel)
		Me.Controls.Add(Me.txtDirccio)
		Me.Controls.Add(Me.txtCorreo)
		Me.Controls.Add(Me.txtIDCli)
		Me.Controls.Add(Me.label9)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.label5)
		Me.Name = "MantenimientoAC"
		Me.Text = "MantenimientoAC"
		AddHandler Load, AddressOf Me.MantenimientoACLoad
		CType(Me.dgvPro,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private dgvPro As System.Windows.Forms.DataGridView
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private txtIDCli As System.Windows.Forms.TextBox
	Private txtCorreo As System.Windows.Forms.TextBox
	Private txtDirccio As System.Windows.Forms.TextBox
	Private txtTel As System.Windows.Forms.TextBox
	Private txtNombre As System.Windows.Forms.TextBox
	Private label10 As System.Windows.Forms.Label
	Private btnGuardar As System.Windows.Forms.Button
	Private label3 As System.Windows.Forms.Label
	Private txtCantidad As System.Windows.Forms.TextBox
	Private label12 As System.Windows.Forms.Label
	Private txtIdPro As System.Windows.Forms.TextBox
End Class
