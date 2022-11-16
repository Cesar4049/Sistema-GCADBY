<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reserva_de_Cursos
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
        Dim Nom_CurLabel As System.Windows.Forms.Label
        Dim Cursos_CurLabel As System.Windows.Forms.Label
        Dim Fecha_CurLabel As System.Windows.Forms.Label
        Dim Hora_CurLabel As System.Windows.Forms.Label
        Dim Costo_CurLabel As System.Windows.Forms.Label
        Dim Local_CurLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reserva_de_Cursos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter()
        Me.TableAdapterManager = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager()
        Me.CursosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CursosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Nom_CurTextBox = New System.Windows.Forms.TextBox()
        Me.Cursos_CurTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_CurDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Hora_CurDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Costo_CurTextBox = New System.Windows.Forms.TextBox()
        Me.Local_CurTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Nom_CurLabel = New System.Windows.Forms.Label()
        Cursos_CurLabel = New System.Windows.Forms.Label()
        Fecha_CurLabel = New System.Windows.Forms.Label()
        Hora_CurLabel = New System.Windows.Forms.Label()
        Costo_CurLabel = New System.Windows.Forms.Label()
        Local_CurLabel = New System.Windows.Forms.Label()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CursosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nom_CurLabel
        '
        Nom_CurLabel.AutoSize = True
        Nom_CurLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nom_CurLabel.Location = New System.Drawing.Point(65, 168)
        Nom_CurLabel.Name = "Nom_CurLabel"
        Nom_CurLabel.Size = New System.Drawing.Size(82, 18)
        Nom_CurLabel.TabIndex = 2
        Nom_CurLabel.Text = "Nom Cur:"
        '
        'Cursos_CurLabel
        '
        Cursos_CurLabel.AutoSize = True
        Cursos_CurLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cursos_CurLabel.Location = New System.Drawing.Point(44, 209)
        Cursos_CurLabel.Name = "Cursos_CurLabel"
        Cursos_CurLabel.Size = New System.Drawing.Size(103, 18)
        Cursos_CurLabel.TabIndex = 4
        Cursos_CurLabel.Text = "Cursos Cur:"
        '
        'Fecha_CurLabel
        '
        Fecha_CurLabel.AutoSize = True
        Fecha_CurLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_CurLabel.Location = New System.Drawing.Point(51, 254)
        Fecha_CurLabel.Name = "Fecha_CurLabel"
        Fecha_CurLabel.Size = New System.Drawing.Size(96, 18)
        Fecha_CurLabel.TabIndex = 6
        Fecha_CurLabel.Text = "Fecha Cur:"
        '
        'Hora_CurLabel
        '
        Hora_CurLabel.AutoSize = True
        Hora_CurLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Hora_CurLabel.Location = New System.Drawing.Point(62, 295)
        Hora_CurLabel.Name = "Hora_CurLabel"
        Hora_CurLabel.Size = New System.Drawing.Size(85, 18)
        Hora_CurLabel.TabIndex = 8
        Hora_CurLabel.Text = "Hora Cur:"
        '
        'Costo_CurLabel
        '
        Costo_CurLabel.AutoSize = True
        Costo_CurLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Costo_CurLabel.Location = New System.Drawing.Point(436, 163)
        Costo_CurLabel.Name = "Costo_CurLabel"
        Costo_CurLabel.Size = New System.Drawing.Size(93, 18)
        Costo_CurLabel.TabIndex = 10
        Costo_CurLabel.Text = "Costo Cur:"
        '
        'Local_CurLabel
        '
        Local_CurLabel.AutoSize = True
        Local_CurLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Local_CurLabel.Location = New System.Drawing.Point(439, 209)
        Local_CurLabel.Name = "Local_CurLabel"
        Local_CurLabel.Size = New System.Drawing.Size(90, 18)
        Local_CurLabel.TabIndex = 12
        Local_CurLabel.Text = "Local Cur:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservacion de Cursos"
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agenda_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Me.CursosTableAdapter
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'CursosBindingNavigator
        '
        Me.CursosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CursosBindingNavigator.BindingSource = Me.CursosBindingSource
        Me.CursosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CursosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CursosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CursosBindingNavigatorSaveItem})
        Me.CursosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CursosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CursosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CursosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CursosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CursosBindingNavigator.Name = "CursosBindingNavigator"
        Me.CursosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CursosBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CursosBindingNavigator.TabIndex = 1
        Me.CursosBindingNavigator.Text = "BindingNavigator1"
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
        'CursosBindingNavigatorSaveItem
        '
        Me.CursosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CursosBindingNavigatorSaveItem.Image = CType(resources.GetObject("CursosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CursosBindingNavigatorSaveItem.Name = "CursosBindingNavigatorSaveItem"
        Me.CursosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CursosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Nom_CurTextBox
        '
        Me.Nom_CurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "Nom_Cur", True))
        Me.Nom_CurTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nom_CurTextBox.Location = New System.Drawing.Point(153, 165)
        Me.Nom_CurTextBox.Name = "Nom_CurTextBox"
        Me.Nom_CurTextBox.Size = New System.Drawing.Size(244, 26)
        Me.Nom_CurTextBox.TabIndex = 3
        '
        'Cursos_CurTextBox
        '
        Me.Cursos_CurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "Cursos_Cur", True))
        Me.Cursos_CurTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cursos_CurTextBox.Location = New System.Drawing.Point(153, 206)
        Me.Cursos_CurTextBox.Name = "Cursos_CurTextBox"
        Me.Cursos_CurTextBox.Size = New System.Drawing.Size(244, 26)
        Me.Cursos_CurTextBox.TabIndex = 5
        '
        'Fecha_CurDateTimePicker
        '
        Me.Fecha_CurDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CursosBindingSource, "Fecha_Cur", True))
        Me.Fecha_CurDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_CurDateTimePicker.Location = New System.Drawing.Point(153, 248)
        Me.Fecha_CurDateTimePicker.Name = "Fecha_CurDateTimePicker"
        Me.Fecha_CurDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.Fecha_CurDateTimePicker.TabIndex = 7
        '
        'Hora_CurDateTimePicker
        '
        Me.Hora_CurDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CursosBindingSource, "Hora_Cur", True))
        Me.Hora_CurDateTimePicker.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora_CurDateTimePicker.Location = New System.Drawing.Point(153, 289)
        Me.Hora_CurDateTimePicker.Name = "Hora_CurDateTimePicker"
        Me.Hora_CurDateTimePicker.Size = New System.Drawing.Size(331, 26)
        Me.Hora_CurDateTimePicker.TabIndex = 9
        '
        'Costo_CurTextBox
        '
        Me.Costo_CurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "Costo_Cur", True))
        Me.Costo_CurTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Costo_CurTextBox.Location = New System.Drawing.Point(535, 160)
        Me.Costo_CurTextBox.Name = "Costo_CurTextBox"
        Me.Costo_CurTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Costo_CurTextBox.TabIndex = 11
        '
        'Local_CurTextBox
        '
        Me.Local_CurTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CursosBindingSource, "Local_Cur", True))
        Me.Local_CurTextBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Local_CurTextBox.Location = New System.Drawing.Point(535, 206)
        Me.Local_CurTextBox.Name = "Local_CurTextBox"
        Me.Local_CurTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Local_CurTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(221, 362)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Reservar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(483, 362)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Reserva_de_Cursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Nom_CurLabel)
        Me.Controls.Add(Me.Nom_CurTextBox)
        Me.Controls.Add(Cursos_CurLabel)
        Me.Controls.Add(Me.Cursos_CurTextBox)
        Me.Controls.Add(Fecha_CurLabel)
        Me.Controls.Add(Me.Fecha_CurDateTimePicker)
        Me.Controls.Add(Hora_CurLabel)
        Me.Controls.Add(Me.Hora_CurDateTimePicker)
        Me.Controls.Add(Costo_CurLabel)
        Me.Controls.Add(Me.Costo_CurTextBox)
        Me.Controls.Add(Local_CurLabel)
        Me.Controls.Add(Me.Local_CurTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CursosBindingNavigator)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "Reserva_de_Cursos"
        Me.Text = "Reserva_de_Cursos"
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CursosBindingNavigator.ResumeLayout(False)
        Me.CursosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CursosBindingNavigator As BindingNavigator
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
    Friend WithEvents CursosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Nom_CurTextBox As TextBox
    Friend WithEvents Cursos_CurTextBox As TextBox
    Friend WithEvents Fecha_CurDateTimePicker As DateTimePicker
    Friend WithEvents Hora_CurDateTimePicker As DateTimePicker
    Friend WithEvents Costo_CurTextBox As TextBox
    Friend WithEvents Local_CurTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
