<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProductos))
        Me.Panel = New System.Windows.Forms.Panel()
        Me.cmbFiltroProducto = New System.Windows.Forms.ComboBox()
        Me.lblBuscarProducto = New System.Windows.Forms.Label()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.lblFiltro)
        Me.Panel.Controls.Add(Me.cmbFiltroProducto)
        Me.Panel.Controls.Add(Me.lblBuscarProducto)
        Me.Panel.Controls.Add(Me.txtBuscarProducto)
        Me.Panel.Controls.Add(Me.btnEditar)
        Me.Panel.Controls.Add(Me.btnEliminar)
        Me.Panel.Controls.Add(Me.btnAgregar)
        Me.Panel.Controls.Add(Me.lblCategoria)
        Me.Panel.Controls.Add(Me.lblPrecio)
        Me.Panel.Controls.Add(Me.lblNombre)
        Me.Panel.Controls.Add(Me.txtCategoria)
        Me.Panel.Controls.Add(Me.txtPrecio)
        Me.Panel.Controls.Add(Me.txtNombre)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(800, 170)
        Me.Panel.TabIndex = 0
        '
        'cmbFiltroProducto
        '
        Me.cmbFiltroProducto.FormattingEnabled = True
        Me.cmbFiltroProducto.Items.AddRange(New Object() {"Nombre", "Categoría"})
        Me.cmbFiltroProducto.Location = New System.Drawing.Point(210, 60)
        Me.cmbFiltroProducto.Name = "cmbFiltroProducto"
        Me.cmbFiltroProducto.Size = New System.Drawing.Size(121, 24)
        Me.cmbFiltroProducto.TabIndex = 12
        '
        'lblBuscarProducto
        '
        Me.lblBuscarProducto.AutoSize = True
        Me.lblBuscarProducto.Location = New System.Drawing.Point(345, 35)
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Size = New System.Drawing.Size(49, 16)
        Me.lblBuscarProducto.TabIndex = 10
        Me.lblBuscarProducto.Text = "Buscar"
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(345, 60)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(100, 22)
        Me.txtBuscarProducto.TabIndex = 9
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(295, 115)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.btnEditar.Size = New System.Drawing.Size(125, 50)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(425, 115)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.btnEliminar.Size = New System.Drawing.Size(125, 50)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(165, 115)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAgregar.Size = New System.Drawing.Size(125, 50)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(12, 112)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(66, 16)
        Me.lblCategoria.TabIndex = 5
        Me.lblCategoria.Text = "Categoría"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(12, 58)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(46, 16)
        Me.lblPrecio.TabIndex = 4
        Me.lblPrecio.Text = "Precio"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 16)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(15, 134)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(100, 22)
        Me.txtCategoria.TabIndex = 2
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(12, 80)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 22)
        Me.txtPrecio.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(12, 31)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 0
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.Location = New System.Drawing.Point(0, 170)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidth = 51
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.Size = New System.Drawing.Size(800, 280)
        Me.dgvProductos.TabIndex = 1
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Location = New System.Drawing.Point(210, 35)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(36, 16)
        Me.lblFiltro.TabIndex = 13
        Me.lblFiltro.Text = "Filtro"
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormProductos"
        Me.Text = "Productos"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblBuscarProducto As Label
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents cmbFiltroProducto As ComboBox
    Friend WithEvents lblFiltro As Label
End Class
