<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaDeCitas
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ReservacionDeCitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.Reservacion_de_CitasTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.Reservacion_de_CitasTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservacionDeCitasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstilistaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ReservacionDeCitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservacionDeCitasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_GCADBY.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(77, 36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 123)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(325, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 42)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Consulta de Citas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(56, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(999, 405)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'ReservacionDeCitasBindingSource
        '
        Me.ReservacionDeCitasBindingSource.DataMember = "Reservacion de Citas"
        Me.ReservacionDeCitasBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reservacion_de_CitasTableAdapter
        '
        Me.Reservacion_de_CitasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.ServicioDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn, Me.EstilistaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservacionDeCitasBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(83, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(853, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'ReservacionDeCitasBindingSource1
        '
        Me.ReservacionDeCitasBindingSource1.DataMember = "Reservacion de Citas"
        Me.ReservacionDeCitasBindingSource1.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'ServicioDataGridViewTextBoxColumn
        '
        Me.ServicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.HeaderText = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.Name = "ServicioDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        '
        'EstilistaDataGridViewTextBoxColumn
        '
        Me.EstilistaDataGridViewTextBoxColumn.DataPropertyName = "Estilista"
        Me.EstilistaDataGridViewTextBoxColumn.HeaderText = "Estilista"
        Me.EstilistaDataGridViewTextBoxColumn.Name = "EstilistaDataGridViewTextBoxColumn"
        '
        'ConsultaDeCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1135, 686)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "ConsultaDeCitas"
        Me.Text = "ConsultaDeCitas"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ReservacionDeCitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservacionDeCitasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents ReservacionDeCitasBindingSource As BindingSource
    Friend WithEvents Reservacion_de_CitasTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.Reservacion_de_CitasTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstilistaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservacionDeCitasBindingSource1 As BindingSource
End Class
