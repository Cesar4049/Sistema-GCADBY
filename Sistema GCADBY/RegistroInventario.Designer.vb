<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroInventario
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
        Me.components = New System.ComponentModel.Container()
        Dim Nombre_ProductoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Tratamiento__o_ServicioLabel As System.Windows.Forms.Label
        Dim DescontinuadoLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim Precio_unitarioLabel As System.Windows.Forms.Label
        Dim Precio_ventaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroInventario))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nombre_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.Tratamiento__o_ServicioTextBox = New System.Windows.Forms.TextBox()
        Me.DescontinuadoTextBox = New System.Windows.Forms.TextBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_unitarioTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.InventarioTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.InventarioTableAdapter()
        Me.TableAdapterManager = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager()
        Me.InventarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InventarioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Nombre_ProductoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Tratamiento__o_ServicioLabel = New System.Windows.Forms.Label()
        DescontinuadoLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        Precio_unitarioLabel = New System.Windows.Forms.Label()
        Precio_ventaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventarioBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nombre_ProductoLabel
        '
        Nombre_ProductoLabel.AutoSize = True
        Nombre_ProductoLabel.Location = New System.Drawing.Point(64, 54)
        Nombre_ProductoLabel.Name = "Nombre_ProductoLabel"
        Nombre_ProductoLabel.Size = New System.Drawing.Size(233, 32)
        Nombre_ProductoLabel.TabIndex = 2
        Nombre_ProductoLabel.Text = "Nombre Producto:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(64, 99)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(165, 32)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'Tratamiento__o_ServicioLabel
        '
        Tratamiento__o_ServicioLabel.AutoSize = True
        Tratamiento__o_ServicioLabel.Location = New System.Drawing.Point(64, 144)
        Tratamiento__o_ServicioLabel.Name = "Tratamiento__o_ServicioLabel"
        Tratamiento__o_ServicioLabel.Size = New System.Drawing.Size(300, 32)
        Tratamiento__o_ServicioLabel.TabIndex = 6
        Tratamiento__o_ServicioLabel.Text = "Tratamiento  o Servicio:"
        '
        'DescontinuadoLabel
        '
        DescontinuadoLabel.AutoSize = True
        DescontinuadoLabel.Location = New System.Drawing.Point(64, 189)
        DescontinuadoLabel.Name = "DescontinuadoLabel"
        DescontinuadoLabel.Size = New System.Drawing.Size(204, 32)
        DescontinuadoLabel.TabIndex = 8
        DescontinuadoLabel.Text = "Descontinuado:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(64, 234)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(91, 32)
        StockLabel.TabIndex = 10
        StockLabel.Text = "Stock:"
        '
        'Precio_unitarioLabel
        '
        Precio_unitarioLabel.AutoSize = True
        Precio_unitarioLabel.Location = New System.Drawing.Point(64, 279)
        Precio_unitarioLabel.Name = "Precio_unitarioLabel"
        Precio_unitarioLabel.Size = New System.Drawing.Size(195, 32)
        Precio_unitarioLabel.TabIndex = 12
        Precio_unitarioLabel.Text = "Precio unitario:"
        '
        'Precio_ventaLabel
        '
        Precio_ventaLabel.AutoSize = True
        Precio_ventaLabel.Location = New System.Drawing.Point(64, 324)
        Precio_ventaLabel.Name = "Precio_ventaLabel"
        Precio_ventaLabel.Size = New System.Drawing.Size(172, 32)
        Precio_ventaLabel.TabIndex = 14
        Precio_ventaLabel.Text = "Precio venta:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_GCADBY.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(142, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 113)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(315, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 42)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Registro de Inventario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IconButton1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Nombre_ProductoLabel)
        Me.GroupBox1.Controls.Add(Me.Nombre_ProductoTextBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(Tratamiento__o_ServicioLabel)
        Me.GroupBox1.Controls.Add(Me.Tratamiento__o_ServicioTextBox)
        Me.GroupBox1.Controls.Add(DescontinuadoLabel)
        Me.GroupBox1.Controls.Add(Me.DescontinuadoTextBox)
        Me.GroupBox1.Controls.Add(StockLabel)
        Me.GroupBox1.Controls.Add(Me.StockTextBox)
        Me.GroupBox1.Controls.Add(Precio_unitarioLabel)
        Me.GroupBox1.Controls.Add(Me.Precio_unitarioTextBox)
        Me.GroupBox1.Controls.Add(Precio_ventaLabel)
        Me.GroupBox1.Controls.Add(Me.Precio_ventaTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(72, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(895, 465)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(805, 393)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(59, 59)
        Me.IconButton1.TabIndex = 22
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(635, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 38)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Nombre_ProductoTextBox
        '
        Me.Nombre_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Nombre Producto", True))
        Me.Nombre_ProductoTextBox.Location = New System.Drawing.Point(370, 51)
        Me.Nombre_ProductoTextBox.Name = "Nombre_ProductoTextBox"
        Me.Nombre_ProductoTextBox.Size = New System.Drawing.Size(389, 39)
        Me.Nombre_ProductoTextBox.TabIndex = 3
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        Me.InventarioBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(370, 96)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(389, 39)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'Tratamiento__o_ServicioTextBox
        '
        Me.Tratamiento__o_ServicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Tratamiento  o Servicio", True))
        Me.Tratamiento__o_ServicioTextBox.Location = New System.Drawing.Point(370, 141)
        Me.Tratamiento__o_ServicioTextBox.Name = "Tratamiento__o_ServicioTextBox"
        Me.Tratamiento__o_ServicioTextBox.Size = New System.Drawing.Size(389, 39)
        Me.Tratamiento__o_ServicioTextBox.TabIndex = 7
        '
        'DescontinuadoTextBox
        '
        Me.DescontinuadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Descontinuado", True))
        Me.DescontinuadoTextBox.Location = New System.Drawing.Point(370, 186)
        Me.DescontinuadoTextBox.Name = "DescontinuadoTextBox"
        Me.DescontinuadoTextBox.Size = New System.Drawing.Size(389, 39)
        Me.DescontinuadoTextBox.TabIndex = 9
        '
        'StockTextBox
        '
        Me.StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Stock", True))
        Me.StockTextBox.Location = New System.Drawing.Point(370, 231)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(389, 39)
        Me.StockTextBox.TabIndex = 11
        '
        'Precio_unitarioTextBox
        '
        Me.Precio_unitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Precio unitario", True))
        Me.Precio_unitarioTextBox.Location = New System.Drawing.Point(370, 276)
        Me.Precio_unitarioTextBox.Name = "Precio_unitarioTextBox"
        Me.Precio_unitarioTextBox.Size = New System.Drawing.Size(389, 39)
        Me.Precio_unitarioTextBox.TabIndex = 13
        '
        'Precio_ventaTextBox
        '
        Me.Precio_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventarioBindingSource, "Precio venta", True))
        Me.Precio_ventaTextBox.Location = New System.Drawing.Point(370, 321)
        Me.Precio_ventaTextBox.Name = "Precio_ventaTextBox"
        Me.Precio_ventaTextBox.Size = New System.Drawing.Size(389, 39)
        Me.Precio_ventaTextBox.TabIndex = 15
        '
        'InventarioTableAdapter
        '
        Me.InventarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agenda_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.Horario_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.InventarioTableAdapter = Me.InventarioTableAdapter
        Me.TableAdapterManager.Reservacion_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.ReservaCursosTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.TipoServicioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'InventarioBindingNavigator
        '
        Me.InventarioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InventarioBindingNavigator.BindingSource = Me.InventarioBindingSource
        Me.InventarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventarioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InventarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InventarioBindingNavigatorSaveItem})
        Me.InventarioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InventarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventarioBindingNavigator.Name = "InventarioBindingNavigator"
        Me.InventarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventarioBindingNavigator.Size = New System.Drawing.Size(1003, 25)
        Me.InventarioBindingNavigator.TabIndex = 25
        Me.InventarioBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InventarioBindingNavigatorSaveItem
        '
        Me.InventarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventarioBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventarioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventarioBindingNavigatorSaveItem.Name = "InventarioBindingNavigatorSaveItem"
        Me.InventarioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InventarioBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'RegistroInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1003, 666)
        Me.Controls.Add(Me.InventarioBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "RegistroInventario"
        Me.Text = "RegistroInventario"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventarioBindingNavigator.ResumeLayout(False)
        Me.InventarioBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents InventarioTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventarioBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents InventarioBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Nombre_ProductoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents Tratamiento__o_ServicioTextBox As TextBox
    Friend WithEvents DescontinuadoTextBox As TextBox
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents Precio_unitarioTextBox As TextBox
    Friend WithEvents Precio_ventaTextBox As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
