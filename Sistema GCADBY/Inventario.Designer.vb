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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDSistemaGCADBYDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(53, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(377, 183)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(41, 220)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(545, 146)
        Me.DataGridView2.TabIndex = 1
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
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CursosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDSistemaGCADBYDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents BDSistemaGCADBYDataSetBindingSource As BindingSource
    Friend WithEvents CursosBindingSource As BindingSource
    Friend WithEvents CursosTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.CursosTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
End Class
