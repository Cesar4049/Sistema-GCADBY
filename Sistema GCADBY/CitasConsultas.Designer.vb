<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CitasConsultas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.ReservacionDeCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservacion_de_CitasTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.Reservacion_de_CitasTableAdapter()
        Me.TableAdapterManager = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager()
        Me.Reservacion_de_CitasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservacionDeCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reservacion_de_CitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(326, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consulta de Citas"
        Me.Label1.UseMnemonic = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_GCADBY.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(150, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservacionDeCitasBindingSource
        '
        Me.ReservacionDeCitasBindingSource.DataMember = "Reservacion de Citas"
        Me.ReservacionDeCitasBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'Reservacion_de_CitasTableAdapter
        '
        Me.Reservacion_de_CitasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agenda_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.Horario_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.Reservacion_de_CitasTableAdapter = Me.Reservacion_de_CitasTableAdapter
        Me.TableAdapterManager.ReservaCursosTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.TipoServicioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'Reservacion_de_CitasDataGridView
        '
        Me.Reservacion_de_CitasDataGridView.AutoGenerateColumns = False
        Me.Reservacion_de_CitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Reservacion_de_CitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Reservacion_de_CitasDataGridView.DataSource = Me.ReservacionDeCitasBindingSource
        Me.Reservacion_de_CitasDataGridView.Location = New System.Drawing.Point(42, 182)
        Me.Reservacion_de_CitasDataGridView.Name = "Reservacion_de_CitasDataGridView"
        Me.Reservacion_de_CitasDataGridView.Size = New System.Drawing.Size(846, 297)
        Me.Reservacion_de_CitasDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Servicio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Servicio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Estilista"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Estilista"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(894, 465)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(59, 59)
        Me.IconButton1.TabIndex = 22
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'CitasConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 536)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Reservacion_de_CitasDataGridView)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CitasConsultas"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservacionDeCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reservacion_de_CitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents ReservacionDeCitasBindingSource As BindingSource
    Friend WithEvents Reservacion_de_CitasTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.Reservacion_de_CitasTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Reservacion_de_CitasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
