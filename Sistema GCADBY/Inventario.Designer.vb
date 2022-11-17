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
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.ServiciosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter()
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDSistemaGCADBYDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservaCursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservaCursosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.ReservaCursosTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeCursoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HorarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservacionDeCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reservacion_de_CitasTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.Reservacion_de_CitasTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ServiciosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomSerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServSerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioSerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DispSerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaGCADBYDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservaCursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservacionDeCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
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
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TipoDeCursoDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HorarioDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservaCursosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(856, 199)
        Me.DataGridView1.TabIndex = 0
        '
        'ReservaCursosBindingSource
        '
        Me.ReservaCursosBindingSource.DataMember = "ReservaCursos"
        Me.ReservaCursosBindingSource.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'ReservaCursosTableAdapter
        '
        Me.ReservaCursosTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'TipoDeCursoDataGridViewTextBoxColumn
        '
        Me.TipoDeCursoDataGridViewTextBoxColumn.DataPropertyName = "Tipo de Curso"
        Me.TipoDeCursoDataGridViewTextBoxColumn.HeaderText = "Tipo de Curso"
        Me.TipoDeCursoDataGridViewTextBoxColumn.Name = "TipoDeCursoDataGridViewTextBoxColumn"
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "Costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'HorarioDataGridViewTextBoxColumn
        '
        Me.HorarioDataGridViewTextBoxColumn.DataPropertyName = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.HeaderText = "Horario"
        Me.HorarioDataGridViewTextBoxColumn.Name = "HorarioDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'ReservacionDeCitasBindingSource
        '
        Me.ReservacionDeCitasBindingSource.DataMember = "Reservacion de Citas"
        Me.ReservacionDeCitasBindingSource.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'Reservacion_de_CitasTableAdapter
        '
        Me.Reservacion_de_CitasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomSerDataGridViewTextBoxColumn, Me.ServSerDataGridViewTextBoxColumn, Me.PrecioSerDataGridViewTextBoxColumn, Me.DispSerDataGridViewCheckBoxColumn})
        Me.DataGridView2.DataSource = Me.ServiciosBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(-1, 205)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(856, 154)
        Me.DataGridView2.TabIndex = 1
        '
        'ServiciosBindingSource1
        '
        Me.ServiciosBindingSource1.DataMember = "Servicios"
        Me.ServiciosBindingSource1.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'NomSerDataGridViewTextBoxColumn
        '
        Me.NomSerDataGridViewTextBoxColumn.DataPropertyName = "Nom_Ser"
        Me.NomSerDataGridViewTextBoxColumn.HeaderText = "Nom_Ser"
        Me.NomSerDataGridViewTextBoxColumn.Name = "NomSerDataGridViewTextBoxColumn"
        '
        'ServSerDataGridViewTextBoxColumn
        '
        Me.ServSerDataGridViewTextBoxColumn.DataPropertyName = "Serv_Ser"
        Me.ServSerDataGridViewTextBoxColumn.HeaderText = "Serv_Ser"
        Me.ServSerDataGridViewTextBoxColumn.Name = "ServSerDataGridViewTextBoxColumn"
        '
        'PrecioSerDataGridViewTextBoxColumn
        '
        Me.PrecioSerDataGridViewTextBoxColumn.DataPropertyName = "Precio_Ser"
        Me.PrecioSerDataGridViewTextBoxColumn.HeaderText = "Precio_Ser"
        Me.PrecioSerDataGridViewTextBoxColumn.Name = "PrecioSerDataGridViewTextBoxColumn"
        '
        'DispSerDataGridViewCheckBoxColumn
        '
        Me.DispSerDataGridViewCheckBoxColumn.DataPropertyName = "Disp_Ser"
        Me.DispSerDataGridViewCheckBoxColumn.HeaderText = "Disp_Ser"
        Me.DispSerDataGridViewCheckBoxColumn.Name = "DispSerDataGridViewCheckBoxColumn"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(376, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(855, 473)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaGCADBYDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservaCursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservacionDeCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents BDSistemaGCADBYDataSetBindingSource As BindingSource
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReservaCursosBindingSource As BindingSource
    Friend WithEvents ReservaCursosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.ReservaCursosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDeCursoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HorarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservacionDeCitasBindingSource As BindingSource
    Friend WithEvents Reservacion_de_CitasTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.Reservacion_de_CitasTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents NomSerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServSerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioSerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DispSerDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ServiciosBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
End Class
