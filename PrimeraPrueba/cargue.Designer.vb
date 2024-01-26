<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cargue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cargue))
        Me.lbl_bienvendio = New System.Windows.Forms.Label
        Me.btn_openF = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Comb_mes = New System.Windows.Forms.ComboBox
        Me.Comb_anio = New System.Windows.Forms.ComboBox
        Me.lbl_year = New System.Windows.Forms.Label
        Me.lbl_mounth = New System.Windows.Forms.Label
        Me.lbl_error_mes = New System.Windows.Forms.Label
        Me.lbl_error_anio = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_bienvendio
        '
        Me.lbl_bienvendio.AutoSize = True
        Me.lbl_bienvendio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bienvendio.Location = New System.Drawing.Point(165, 29)
        Me.lbl_bienvendio.Name = "lbl_bienvendio"
        Me.lbl_bienvendio.Size = New System.Drawing.Size(158, 31)
        Me.lbl_bienvendio.TabIndex = 0
        Me.lbl_bienvendio.Text = "Bienvenido"
        '
        'btn_openF
        '
        Me.btn_openF.Location = New System.Drawing.Point(155, 146)
        Me.btn_openF.Name = "btn_openF"
        Me.btn_openF.Size = New System.Drawing.Size(169, 36)
        Me.btn_openF.TabIndex = 2
        Me.btn_openF.Text = "Cargar Archivo"
        Me.btn_openF.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Elegir Archivo"
        Me.OpenFileDialog1.InitialDirectory = "C:\Users\Desarrollador\Desktop\pruebas"
        '
        'Comb_mes
        '
        Me.Comb_mes.FormattingEnabled = True
        Me.Comb_mes.Location = New System.Drawing.Point(57, 106)
        Me.Comb_mes.Name = "Comb_mes"
        Me.Comb_mes.Size = New System.Drawing.Size(144, 21)
        Me.Comb_mes.TabIndex = 3
        '
        'Comb_anio
        '
        Me.Comb_anio.FormattingEnabled = True
        Me.Comb_anio.Location = New System.Drawing.Point(269, 106)
        Me.Comb_anio.Name = "Comb_anio"
        Me.Comb_anio.Size = New System.Drawing.Size(144, 21)
        Me.Comb_anio.TabIndex = 4
        '
        'lbl_year
        '
        Me.lbl_year.AutoSize = True
        Me.lbl_year.Location = New System.Drawing.Point(328, 90)
        Me.lbl_year.Name = "lbl_year"
        Me.lbl_year.Size = New System.Drawing.Size(26, 13)
        Me.lbl_year.TabIndex = 5
        Me.lbl_year.Text = "Año"
        '
        'lbl_mounth
        '
        Me.lbl_mounth.AutoSize = True
        Me.lbl_mounth.Location = New System.Drawing.Point(111, 90)
        Me.lbl_mounth.Name = "lbl_mounth"
        Me.lbl_mounth.Size = New System.Drawing.Size(27, 13)
        Me.lbl_mounth.TabIndex = 6
        Me.lbl_mounth.Text = "Mes"
        '
        'lbl_error_mes
        '
        Me.lbl_error_mes.AutoSize = True
        Me.lbl_error_mes.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_mes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_error_mes.Location = New System.Drawing.Point(25, 75)
        Me.lbl_error_mes.Name = "lbl_error_mes"
        Me.lbl_error_mes.Size = New System.Drawing.Size(0, 15)
        Me.lbl_error_mes.TabIndex = 10
        '
        'lbl_error_anio
        '
        Me.lbl_error_anio.AutoSize = True
        Me.lbl_error_anio.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_anio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_error_anio.Location = New System.Drawing.Point(255, 75)
        Me.lbl_error_anio.Name = "lbl_error_anio"
        Me.lbl_error_anio.Size = New System.Drawing.Size(0, 15)
        Me.lbl_error_anio.TabIndex = 11
        '
        'cargue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 206)
        Me.Controls.Add(Me.lbl_error_anio)
        Me.Controls.Add(Me.lbl_error_mes)
        Me.Controls.Add(Me.lbl_mounth)
        Me.Controls.Add(Me.lbl_year)
        Me.Controls.Add(Me.Comb_anio)
        Me.Controls.Add(Me.Comb_mes)
        Me.Controls.Add(Me.btn_openF)
        Me.Controls.Add(Me.lbl_bienvendio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "cargue"
        Me.Text = "cargue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_bienvendio As System.Windows.Forms.Label
    Friend WithEvents btn_openF As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Comb_mes As System.Windows.Forms.ComboBox
    Friend WithEvents Comb_anio As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_year As System.Windows.Forms.Label
    Friend WithEvents lbl_mounth As System.Windows.Forms.Label
    Friend WithEvents lbl_error_mes As System.Windows.Forms.Label
    Friend WithEvents lbl_error_anio As System.Windows.Forms.Label
End Class
