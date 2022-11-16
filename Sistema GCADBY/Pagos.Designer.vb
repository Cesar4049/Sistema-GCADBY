<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagos))
        Dim Nom_SerLabel As System.Windows.Forms.Label
        Dim Serv_SerLabel As System.Windows.Forms.Label
        Dim Precio_SerLabel As System.Windows.Forms.Label
        Dim Disp_SerLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.CompraTableAdapter()
        Me.TableAdapterManager = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager()
        Me.CompraBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CompraBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.VentaTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter()
        Me.Nom_SerTextBox = New System.Windows.Forms.TextBox()
        Me.Serv_SerTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_SerTextBox = New System.Windows.Forms.TextBox()
        Me.Disp_SerCheckBox = New System.Windows.Forms.CheckBox()
        Nom_SerLabel = New System.Windows.Forms.Label()
        Serv_SerLabel = New System.Windows.Forms.Label()
        Precio_SerLabel = New System.Windows.Forms.Label()
        Disp_SerLabel = New System.Windows.Forms.Label()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CompraBindingNavigator.SuspendLayout()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(376, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pago"
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompraBindingSource
        '
        Me.CompraBindingSource.DataMember = "Compra"
        Me.CompraBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'CompraTableAdapter
        '
        Me.CompraTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agenda_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraTableAdapter = Me.CompraTableAdapter
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Me.ServiciosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Me.VentaTableAdapter
        '
        'CompraBindingNavigator
        '
        Me.CompraBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CompraBindingNavigator.BindingSource = Me.CompraBindingSource
        Me.CompraBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CompraBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CompraBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CompraBindingNavigatorSaveItem})
        Me.CompraBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CompraBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CompraBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CompraBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CompraBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CompraBindingNavigator.Name = "CompraBindingNavigator"
        Me.CompraBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CompraBindingNavigator.Size = New System.Drawing.Size(824, 25)
        Me.CompraBindingNavigator.TabIndex = 1
        Me.CompraBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'CompraBindingNavigatorSaveItem
        '
        Me.CompraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CompraBindingNavigatorSaveItem.Image = CType(resources.GetObject("CompraBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CompraBindingNavigatorSaveItem.Name = "CompraBindingNavigatorSaveItem"
        Me.CompraBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CompraBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(260, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 32)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(467, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 32)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'Nom_SerLabel
        '
        Nom_SerLabel.AutoSize = True
        Nom_SerLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_SerLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Nom_SerLabel.Location = New System.Drawing.Point(295, 145)
        Nom_SerLabel.Name = "Nom_SerLabel"
        Nom_SerLabel.Size = New System.Drawing.Size(81, 18)
        Nom_SerLabel.TabIndex = 19
        Nom_SerLabel.Text = "Nom Ser:"
        '
        'Nom_SerTextBox
        '
        Me.Nom_SerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "Nom_Ser", True))
        Me.Nom_SerTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_SerTextBox.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Nom_SerTextBox.Location = New System.Drawing.Point(382, 142)
        Me.Nom_SerTextBox.Name = "Nom_SerTextBox"
        Me.Nom_SerTextBox.Size = New System.Drawing.Size(104, 26)
        Me.Nom_SerTextBox.TabIndex = 20
        '
        'Serv_SerLabel
        '
        Serv_SerLabel.AutoSize = True
        Serv_SerLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Serv_SerLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Serv_SerLabel.Location = New System.Drawing.Point(294, 182)
        Serv_SerLabel.Name = "Serv_SerLabel"
        Serv_SerLabel.Size = New System.Drawing.Size(82, 18)
        Serv_SerLabel.TabIndex = 21
        Serv_SerLabel.Text = "Serv Ser:"
        '
        'Serv_SerTextBox
        '
        Me.Serv_SerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "Serv_Ser", True))
        Me.Serv_SerTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Serv_SerTextBox.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Serv_SerTextBox.Location = New System.Drawing.Point(382, 179)
        Me.Serv_SerTextBox.Name = "Serv_SerTextBox"
        Me.Serv_SerTextBox.Size = New System.Drawing.Size(104, 26)
        Me.Serv_SerTextBox.TabIndex = 22
        '
        'Precio_SerLabel
        '
        Precio_SerLabel.AutoSize = True
        Precio_SerLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Precio_SerLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Precio_SerLabel.Location = New System.Drawing.Point(279, 219)
        Precio_SerLabel.Name = "Precio_SerLabel"
        Precio_SerLabel.Size = New System.Drawing.Size(97, 18)
        Precio_SerLabel.TabIndex = 23
        Precio_SerLabel.Text = "Precio Ser:"
        '
        'Precio_SerTextBox
        '
        Me.Precio_SerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "Precio_Ser", True))
        Me.Precio_SerTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_SerTextBox.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Precio_SerTextBox.Location = New System.Drawing.Point(382, 216)
        Me.Precio_SerTextBox.Name = "Precio_SerTextBox"
        Me.Precio_SerTextBox.Size = New System.Drawing.Size(104, 26)
        Me.Precio_SerTextBox.TabIndex = 24
        '
        'Disp_SerLabel
        '
        Disp_SerLabel.AutoSize = True
        Disp_SerLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Disp_SerLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Disp_SerLabel.Location = New System.Drawing.Point(294, 260)
        Disp_SerLabel.Name = "Disp_SerLabel"
        Disp_SerLabel.Size = New System.Drawing.Size(80, 18)
        Disp_SerLabel.TabIndex = 25
        Disp_SerLabel.Text = "Disp Ser:"
        '
        'Disp_SerCheckBox
        '
        Me.Disp_SerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ServiciosBindingSource, "Disp_Ser", True))
        Me.Disp_SerCheckBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Disp_SerCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Disp_SerCheckBox.Location = New System.Drawing.Point(382, 258)
        Me.Disp_SerCheckBox.Name = "Disp_SerCheckBox"
        Me.Disp_SerCheckBox.Size = New System.Drawing.Size(134, 24)
        Me.Disp_SerCheckBox.TabIndex = 26
        Me.Disp_SerCheckBox.Text = "CheckBox1"
        Me.Disp_SerCheckBox.UseVisualStyleBackColor = True
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(824, 450)
        Me.Controls.Add(Nom_SerLabel)
        Me.Controls.Add(Me.Nom_SerTextBox)
        Me.Controls.Add(Serv_SerLabel)
        Me.Controls.Add(Me.Serv_SerTextBox)
        Me.Controls.Add(Precio_SerLabel)
        Me.Controls.Add(Me.Precio_SerTextBox)
        Me.Controls.Add(Disp_SerLabel)
        Me.Controls.Add(Me.Disp_SerCheckBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CompraBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pagos"
        Me.Text = "Pagos"
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CompraBindingNavigator.ResumeLayout(False)
        Me.CompraBindingNavigator.PerformLayout()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents CompraBindingSource As BindingSource
    Friend WithEvents CompraTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.CompraTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CompraBindingNavigator As BindingNavigator
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
    Friend WithEvents CompraBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VentaTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.VentaTableAdapter
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ServiciosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents Nom_SerTextBox As TextBox
    Friend WithEvents Serv_SerTextBox As TextBox
    Friend WithEvents Precio_SerTextBox As TextBox
    Friend WithEvents Disp_SerCheckBox As CheckBox
End Class
