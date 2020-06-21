'
' Created by SharpDevelop.
' User: Daniel
' Date: 15/06/2020
' Time: 01:47 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class bitacora
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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.mantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.altaProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.altaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.altaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.altaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.movimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.busquedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.cambiosClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.modificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.eliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.cambiosProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.modificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.eliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.panel1.SuspendLayout
		Me.menuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.Honeydew
		Me.panel1.Controls.Add(Me.menuStrip1)
		Me.panel1.Location = New System.Drawing.Point(46, -3)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(217, 280)
		Me.panel1.TabIndex = 0
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mantenimientoToolStripMenuItem, Me.movimientoToolStripMenuItem})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(217, 24)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'mantenimientoToolStripMenuItem
		'
		Me.mantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.altaProductosToolStripMenuItem, Me.altaClienteToolStripMenuItem})
		Me.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem"
		Me.mantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
		Me.mantenimientoToolStripMenuItem.Text = "Mantenimiento"
		'
		'altaProductosToolStripMenuItem
		'
		Me.altaProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.altaToolStripMenuItem})
		Me.altaProductosToolStripMenuItem.Name = "altaProductosToolStripMenuItem"
		Me.altaProductosToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
		Me.altaProductosToolStripMenuItem.Text = "Productos"
		'
		'altaToolStripMenuItem
		'
		Me.altaToolStripMenuItem.Name = "altaToolStripMenuItem"
		Me.altaToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
		Me.altaToolStripMenuItem.Text = "Alta"
		AddHandler Me.altaToolStripMenuItem.Click, AddressOf Me.AltaToolStripMenuItemClick
		'
		'altaClienteToolStripMenuItem
		'
		Me.altaClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.altaToolStripMenuItem1})
		Me.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem"
		Me.altaClienteToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
		Me.altaClienteToolStripMenuItem.Text = "Cliente"
		'
		'altaToolStripMenuItem1
		'
		Me.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1"
		Me.altaToolStripMenuItem1.Size = New System.Drawing.Size(95, 22)
		Me.altaToolStripMenuItem1.Text = "Alta"
		AddHandler Me.altaToolStripMenuItem1.Click, AddressOf Me.AltaToolStripMenuItem1Click
		'
		'movimientoToolStripMenuItem
		'
		Me.movimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.busquedaToolStripMenuItem, Me.cambiosClienteToolStripMenuItem, Me.cambiosProductoToolStripMenuItem})
		Me.movimientoToolStripMenuItem.Name = "movimientoToolStripMenuItem"
		Me.movimientoToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
		Me.movimientoToolStripMenuItem.Text = "Movimiento"
		'
		'busquedaToolStripMenuItem
		'
		Me.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem"
		Me.busquedaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.busquedaToolStripMenuItem.Text = "Busqueda"
		AddHandler Me.busquedaToolStripMenuItem.Click, AddressOf Me.BusquedaToolStripMenuItemClick
		'
		'cambiosClienteToolStripMenuItem
		'
		Me.cambiosClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.modificarToolStripMenuItem, Me.eliminarToolStripMenuItem})
		Me.cambiosClienteToolStripMenuItem.Name = "cambiosClienteToolStripMenuItem"
		Me.cambiosClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.cambiosClienteToolStripMenuItem.Text = "Cliente"
		'
		'modificarToolStripMenuItem
		'
		Me.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem"
		Me.modificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
		Me.modificarToolStripMenuItem.Text = "Modificar"
		AddHandler Me.modificarToolStripMenuItem.Click, AddressOf Me.ModificarToolStripMenuItemClick
		'
		'eliminarToolStripMenuItem
		'
		Me.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem"
		Me.eliminarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
		Me.eliminarToolStripMenuItem.Text = "Eliminar"
		AddHandler Me.eliminarToolStripMenuItem.Click, AddressOf Me.EliminarToolStripMenuItemClick
		'
		'cambiosProductoToolStripMenuItem
		'
		Me.cambiosProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.modificarToolStripMenuItem1, Me.eliminarToolStripMenuItem1})
		Me.cambiosProductoToolStripMenuItem.Name = "cambiosProductoToolStripMenuItem"
		Me.cambiosProductoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.cambiosProductoToolStripMenuItem.Text = "Producto"
		'
		'modificarToolStripMenuItem1
		'
		Me.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1"
		Me.modificarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.modificarToolStripMenuItem1.Text = "Modificar"
		AddHandler Me.modificarToolStripMenuItem1.Click, AddressOf Me.ModificarToolStripMenuItem1Click
		'
		'eliminarToolStripMenuItem1
		'
		Me.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1"
		Me.eliminarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.eliminarToolStripMenuItem1.Text = "Eliminar"
		AddHandler Me.eliminarToolStripMenuItem1.Click, AddressOf Me.EliminarToolStripMenuItem1Click
		'
		'bitacora
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Honeydew
		Me.ClientSize = New System.Drawing.Size(307, 274)
		Me.Controls.Add(Me.panel1)
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "bitacora"
		Me.Text = "bitacora"
		AddHandler Load, AddressOf Me.BitacoraLoad
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private altaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private altaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private eliminarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private modificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private eliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private modificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private cambiosProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private cambiosClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private busquedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private altaClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private altaProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private movimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private mantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private panel1 As System.Windows.Forms.Panel
End Class
