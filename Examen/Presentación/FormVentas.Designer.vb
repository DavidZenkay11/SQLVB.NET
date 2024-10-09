<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.btnEditarVenta = New System.Windows.Forms.Button()
        Me.btnEliminarVenta = New System.Windows.Forms.Button()
        Me.btnGuardarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtTotalGeneral = New System.Windows.Forms.TextBox()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.dgvItemsVenta = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvItemsVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblProducto)
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Controls.Add(Me.cmbCliente)
        Me.Panel1.Controls.Add(Me.btnEditarVenta)
        Me.Panel1.Controls.Add(Me.btnEliminarVenta)
        Me.Panel1.Controls.Add(Me.btnGuardarVenta)
        Me.Panel1.Controls.Add(Me.btnAgregarProducto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.txtPrecioUnitario)
        Me.Panel1.Controls.Add(Me.txtTotalGeneral)
        Me.Panel1.Controls.Add(Me.cmbProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 151)
        Me.Panel1.TabIndex = 0
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(12, 52)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(61, 16)
        Me.lblProducto.TabIndex = 13
        Me.lblProducto.Text = "Producto"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(12, 4)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 16)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente"
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(12, 23)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(121, 24)
        Me.cmbCliente.TabIndex = 11
        '
        'btnEditarVenta
        '
        Me.btnEditarVenta.Image = CType(resources.GetObject("btnEditarVenta.Image"), System.Drawing.Image)
        Me.btnEditarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarVenta.Location = New System.Drawing.Point(190, 100)
        Me.btnEditarVenta.Name = "btnEditarVenta"
        Me.btnEditarVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.btnEditarVenta.Size = New System.Drawing.Size(180, 45)
        Me.btnEditarVenta.TabIndex = 10
        Me.btnEditarVenta.Text = "Editar"
        Me.btnEditarVenta.UseVisualStyleBackColor = True
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.Image = CType(resources.GetObject("btnEliminarVenta.Image"), System.Drawing.Image)
        Me.btnEliminarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarVenta.Location = New System.Drawing.Point(550, 100)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.btnEliminarVenta.Size = New System.Drawing.Size(180, 45)
        Me.btnEliminarVenta.TabIndex = 9
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = True
        '
        'btnGuardarVenta
        '
        Me.btnGuardarVenta.Image = CType(resources.GetObject("btnGuardarVenta.Image"), System.Drawing.Image)
        Me.btnGuardarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarVenta.Location = New System.Drawing.Point(370, 100)
        Me.btnGuardarVenta.Name = "btnGuardarVenta"
        Me.btnGuardarVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.btnGuardarVenta.Size = New System.Drawing.Size(180, 45)
        Me.btnGuardarVenta.TabIndex = 8
        Me.btnGuardarVenta.Text = "Guardar"
        Me.btnGuardarVenta.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Image = CType(resources.GetObject("btnAgregarProducto.Image"), System.Drawing.Image)
        Me.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarProducto.Location = New System.Drawing.Point(10, 100)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAgregarProducto.Size = New System.Drawing.Size(180, 45)
        Me.btnAgregarProducto.TabIndex = 7
        Me.btnAgregarProducto.Text = "Agregar Producto"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(481, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Precio unitario"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(169, 45)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 3
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(275, 45)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(100, 22)
        Me.txtPrecioUnitario.TabIndex = 2
        '
        'txtTotalGeneral
        '
        Me.txtTotalGeneral.Location = New System.Drawing.Point(484, 45)
        Me.txtTotalGeneral.Name = "txtTotalGeneral"
        Me.txtTotalGeneral.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalGeneral.TabIndex = 1
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(12, 70)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(121, 24)
        Me.cmbProducto.TabIndex = 0
        '
        'dgvItemsVenta
        '
        Me.dgvItemsVenta.AllowUserToAddRows = False
        Me.dgvItemsVenta.AllowUserToDeleteRows = False
        Me.dgvItemsVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemsVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvItemsVenta.Location = New System.Drawing.Point(0, 151)
        Me.dgvItemsVenta.Name = "dgvItemsVenta"
        Me.dgvItemsVenta.ReadOnly = True
        Me.dgvItemsVenta.RowHeadersWidth = 51
        Me.dgvItemsVenta.RowTemplate.Height = 24
        Me.dgvItemsVenta.Size = New System.Drawing.Size(800, 299)
        Me.dgvItemsVenta.TabIndex = 1
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvItemsVenta)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormVentas"
        Me.Text = "Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvItemsVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvItemsVenta As DataGridView
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtTotalGeneral As TextBox
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents btnGuardarVenta As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditarVenta As Button
    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents lblCliente As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents lblProducto As Label
End Class
