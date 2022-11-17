<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerarCitas
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
        Dim HoraLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim ServicioLabel As System.Windows.Forms.Label
        Dim EstilistaLabel As System.Windows.Forms.Label
        Me.BD_Sistema_GCADBYDataSet = New Sistema_GCADBY.BD_Sistema_GCADBYDataSet()
        Me.Agenda_de_CitasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agenda_de_CitasTableAdapter = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.Agenda_de_CitasTableAdapter()
        Me.TableAdapterManager = New Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EstilistaTextBox = New System.Windows.Forms.TextBox()
        Me.ServicioTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.HoraTextBox = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        ServicioLabel = New System.Windows.Forms.Label()
        EstilistaLabel = New System.Windows.Forms.Label()
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agenda_de_CitasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(34, 245)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(55, 22)
        HoraLabel.TabIndex = 1
        HoraLabel.Text = "Hora:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(424, 82)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(83, 22)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(423, 133)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(84, 22)
        ApellidoLabel.TabIndex = 5
        ApellidoLabel.Text = "Apellido:"
        '
        'ServicioLabel
        '
        ServicioLabel.AutoSize = True
        ServicioLabel.Location = New System.Drawing.Point(423, 218)
        ServicioLabel.Name = "ServicioLabel"
        ServicioLabel.Size = New System.Drawing.Size(152, 22)
        ServicioLabel.TabIndex = 7
        ServicioLabel.Text = "Tipo de Servicio:"
        '
        'EstilistaLabel
        '
        EstilistaLabel.AutoSize = True
        EstilistaLabel.Location = New System.Drawing.Point(423, 263)
        EstilistaLabel.Name = "EstilistaLabel"
        EstilistaLabel.Size = New System.Drawing.Size(164, 22)
        EstilistaLabel.TabIndex = 9
        EstilistaLabel.Text = "Estilista a atender:"
        '
        'BD_Sistema_GCADBYDataSet
        '
        Me.BD_Sistema_GCADBYDataSet.DataSetName = "BD_Sistema_GCADBYDataSet"
        Me.BD_Sistema_GCADBYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Agenda_de_CitasBindingSource
        '
        Me.Agenda_de_CitasBindingSource.DataMember = "Agenda de Citas"
        Me.Agenda_de_CitasBindingSource.DataSource = Me.BD_Sistema_GCADBYDataSet
        '
        'Agenda_de_CitasTableAdapter
        '
        Me.Agenda_de_CitasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agenda_de_CitasTableAdapter = Me.Agenda_de_CitasTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CompraTableAdapter = Nothing
        Me.TableAdapterManager.CuentasTableAdapter = Nothing
        Me.TableAdapterManager.CursosTableAdapter = Nothing
        Me.TableAdapterManager.Horario_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.Reservacion_de_CitasTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.TipoServicioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_GCADBY.BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentaTableAdapter = Nothing
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistema_GCADBY.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(72, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 123)
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
        Me.Label2.Location = New System.Drawing.Point(362, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(367, 42)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Reservacion de Citas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(EstilistaLabel)
        Me.GroupBox1.Controls.Add(Me.EstilistaTextBox)
        Me.GroupBox1.Controls.Add(ServicioLabel)
        Me.GroupBox1.Controls.Add(Me.ServicioTextBox)
        Me.GroupBox1.Controls.Add(ApellidoLabel)
        Me.GroupBox1.Controls.Add(Me.ApellidoTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(HoraLabel)
        Me.GroupBox1.Controls.Add(Me.HoraTextBox)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(72, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(979, 377)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'EstilistaTextBox
        '
        Me.EstilistaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda_de_CitasBindingSource, "Estilista", True))
        Me.EstilistaTextBox.Location = New System.Drawing.Point(597, 260)
        Me.EstilistaTextBox.Name = "EstilistaTextBox"
        Me.EstilistaTextBox.Size = New System.Drawing.Size(195, 29)
        Me.EstilistaTextBox.TabIndex = 10
        '
        'ServicioTextBox
        '
        Me.ServicioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda_de_CitasBindingSource, "Servicio", True))
        Me.ServicioTextBox.Location = New System.Drawing.Point(597, 218)
        Me.ServicioTextBox.Name = "ServicioTextBox"
        Me.ServicioTextBox.Size = New System.Drawing.Size(195, 29)
        Me.ServicioTextBox.TabIndex = 8
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda_de_CitasBindingSource, "Apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(514, 133)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(278, 29)
        Me.ApellidoTextBox.TabIndex = 6
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda_de_CitasBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(513, 79)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(279, 29)
        Me.NombreTextBox.TabIndex = 4
        '
        'HoraTextBox
        '
        Me.HoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Agenda_de_CitasBindingSource, "Hora", True))
        Me.HoraTextBox.Location = New System.Drawing.Point(104, 242)
        Me.HoraTextBox.Name = "HoraTextBox"
        Me.HoraTextBox.Size = New System.Drawing.Size(168, 29)
        Me.HoraTextBox.TabIndex = 2
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(38, 57)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(566, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Datos Cliente"
        '
        'GenerarCitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1121, 559)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "GenerarCitas"
        Me.Text = "Form2"
        CType(Me.BD_Sistema_GCADBYDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agenda_de_CitasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_Sistema_GCADBYDataSet As BD_Sistema_GCADBYDataSet
    Friend WithEvents Agenda_de_CitasBindingSource As BindingSource
    Friend WithEvents Agenda_de_CitasTableAdapter As BD_Sistema_GCADBYDataSetTableAdapters.Agenda_de_CitasTableAdapter
    Friend WithEvents TableAdapterManager As BD_Sistema_GCADBYDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EstilistaTextBox As TextBox
    Friend WithEvents ServicioTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents HoraTextBox As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
End Class
