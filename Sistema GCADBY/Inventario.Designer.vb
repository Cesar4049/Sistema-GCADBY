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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter()
        Me.NomSerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServSerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioSerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DispSerDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BDSistemaGCADBYDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CursosTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter()
        Me.NomCurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CursosCurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraCurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoCurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalCurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaGCADBYDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomSerDataGridViewTextBoxColumn, Me.ServSerDataGridViewTextBoxColumn, Me.PrecioSerDataGridViewTextBoxColumn, Me.DispSerDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.ServiciosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 224)
        Me.DataGridView1.TabIndex = 0
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomCurDataGridViewTextBoxColumn, Me.CursosCurDataGridViewTextBoxColumn, Me.FechaCurDataGridViewTextBoxColumn, Me.HoraCurDataGridViewTextBoxColumn, Me.CostoCurDataGridViewTextBoxColumn, Me.LocalCurDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CursosBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(0, 230)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(800, 221)
        Me.DataGridView2.TabIndex = 1
        '
        'BDSistemaGCADBYDataSetBindingSource
        '
        Me.BDSistemaGCADBYDataSetBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        Me.BDSistemaGCADBYDataSetBindingSource.Position = 0
        '
        'CursosBindingSource
        '
        Me.CursosBindingSource.DataMember = "Cursos"
        Me.CursosBindingSource.DataSource = Me.BDSistemaGCADBYDataSetBindingSource
        '
        'CursosTableAdapter
        '
        Me.CursosTableAdapter.ClearBeforeFill = True
        '
        'NomCurDataGridViewTextBoxColumn
        '
        Me.NomCurDataGridViewTextBoxColumn.DataPropertyName = "Nom_Cur"
        Me.NomCurDataGridViewTextBoxColumn.HeaderText = "Nom_Cur"
        Me.NomCurDataGridViewTextBoxColumn.Name = "NomCurDataGridViewTextBoxColumn"
        '
        'CursosCurDataGridViewTextBoxColumn
        '
        Me.CursosCurDataGridViewTextBoxColumn.DataPropertyName = "Cursos_Cur"
        Me.CursosCurDataGridViewTextBoxColumn.HeaderText = "Cursos_Cur"
        Me.CursosCurDataGridViewTextBoxColumn.Name = "CursosCurDataGridViewTextBoxColumn"
        '
        'FechaCurDataGridViewTextBoxColumn
        '
        Me.FechaCurDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Cur"
        Me.FechaCurDataGridViewTextBoxColumn.HeaderText = "Fecha_Cur"
        Me.FechaCurDataGridViewTextBoxColumn.Name = "FechaCurDataGridViewTextBoxColumn"
        '
        'HoraCurDataGridViewTextBoxColumn
        '
        Me.HoraCurDataGridViewTextBoxColumn.DataPropertyName = "Hora_Cur"
        Me.HoraCurDataGridViewTextBoxColumn.HeaderText = "Hora_Cur"
        Me.HoraCurDataGridViewTextBoxColumn.Name = "HoraCurDataGridViewTextBoxColumn"
        '
        'CostoCurDataGridViewTextBoxColumn
        '
        Me.CostoCurDataGridViewTextBoxColumn.DataPropertyName = "Costo_Cur"
        Me.CostoCurDataGridViewTextBoxColumn.HeaderText = "Costo_Cur"
        Me.CostoCurDataGridViewTextBoxColumn.Name = "CostoCurDataGridViewTextBoxColumn"
        '
        'LocalCurDataGridViewTextBoxColumn
        '
        Me.LocalCurDataGridViewTextBoxColumn.DataPropertyName = "Local_Cur"
        Me.LocalCurDataGridViewTextBoxColumn.HeaderText = "Local_Cur"
        Me.LocalCurDataGridViewTextBoxColumn.Name = "LocalCurDataGridViewTextBoxColumn"
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaGCADBYDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents NomSerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServSerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioSerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DispSerDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BDSistemaGCADBYDataSetBindingSource As BindingSource
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents NomCurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CursosCurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaCurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraCurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoCurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocalCurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
