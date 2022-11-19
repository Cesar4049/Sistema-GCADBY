<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaGCADBYDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.ReservaCursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservacionDeCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter()
        Me.CursosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter()
        Me.ReservaCursosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.ReservaCursosTableAdapter()
        Me.Reservacion_de_CitasTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.Reservacion_de_CitasTableAdapter()
        Me.InventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.InventarioTableAdapter()
        Me.TableAdapterManager = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InventarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaGCADBYDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservaCursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservacionDeCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'BDSistemaGCADBYDataSetBindingSource
        '
        Me.BDSistemaGCADBYDataSetBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        Me.BDSistemaGCADBYDataSetBindingSource.Position = 0
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservaCursosBindingSource
        '
        Me.ReservaCursosBindingSource.DataMember = "ReservaCursos"
        Me.ReservaCursosBindingSource.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'ReservacionDeCitasBindingSource
        '
        Me.ReservacionDeCitasBindingSource.DataMember = "Reservacion de Citas"
        Me.ReservacionDeCitasBindingSource.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'ServiciosBindingSource1
        '
        Me.ServiciosBindingSource1.DataMember = "Servicios"
        Me.ServiciosBindingSource1.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBack
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(952, 432)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(59, 59)
        Me.IconButton1.TabIndex = 21
        Me.IconButton1.UseVisualStyleBackColor = False
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
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'ReservaCursosTableAdapter
        '
        Me.ReservaCursosTableAdapter.ClearBeforeFill = True
        '
        'Reservacion_de_CitasTableAdapter
        '
        Me.Reservacion_de_CitasTableAdapter.ClearBeforeFill = True
        '
        'InventarioBindingSource
        '
        Me.InventarioBindingSource.DataMember = "Inventario"
        Me.InventarioBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(403, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 42)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Inventario"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_GCADBY.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(246, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(101, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(81, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 41)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Dar de Alta productos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InventarioBindingSource1
        '
        Me.InventarioBindingSource1.DataMember = "Inventario"
        Me.InventarioBindingSource1.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'InventarioBindingSource2
        '
        Me.InventarioBindingSource2.DataMember = "Inventario"
        Me.InventarioBindingSource2.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'InventarioBindingSource3
        '
        Me.InventarioBindingSource3.DataMember = "Inventario"
        Me.InventarioBindingSource3.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'InventarioBindingSource4
        '
        Me.InventarioBindingSource4.DataMember = "Inventario"
        Me.InventarioBindingSource4.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1035, 511)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconButton1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaGCADBYDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservaCursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservacionDeCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents BDSistemaGCADBYDataSetBindingSource As BindingSource
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents ReservaCursosBindingSource As BindingSource
    Friend WithEvents ReservaCursosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.ReservaCursosTableAdapter
    Friend WithEvents ReservacionDeCitasBindingSource As BindingSource
    Friend WithEvents Reservacion_de_CitasTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.Reservacion_de_CitasTableAdapter
    Friend WithEvents ServiciosBindingSource1 As BindingSource
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents InventarioBindingSource As BindingSource
    Friend WithEvents InventarioTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.InventarioTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents InventarioBindingSource1 As BindingSource
    Friend WithEvents InventarioBindingSource2 As BindingSource
    Friend WithEvents InventarioBindingSource3 As BindingSource
    Friend WithEvents InventarioBindingSource4 As BindingSource
End Class
