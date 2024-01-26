<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.lbl_numero1 = New System.Windows.Forms.Label
        Me.lbl_numero2 = New System.Windows.Forms.Label
        Me.txt_password = New System.Windows.Forms.TextBox
        Me.btn_ingresar = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.lbl_error_mail = New System.Windows.Forms.Label
        Me.lbl_error_cont = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_numero1
        '
        Me.lbl_numero1.AutoSize = True
        Me.lbl_numero1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero1.Location = New System.Drawing.Point(43, 68)
        Me.lbl_numero1.Name = "lbl_numero1"
        Me.lbl_numero1.Size = New System.Drawing.Size(49, 16)
        Me.lbl_numero1.TabIndex = 1
        Me.lbl_numero1.Text = "Correo"
        '
        'lbl_numero2
        '
        Me.lbl_numero2.AutoSize = True
        Me.lbl_numero2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_numero2.Location = New System.Drawing.Point(27, 105)
        Me.lbl_numero2.Name = "lbl_numero2"
        Me.lbl_numero2.Size = New System.Drawing.Size(77, 16)
        Me.lbl_numero2.TabIndex = 3
        Me.lbl_numero2.Text = "Contraseña"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(110, 104)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(202, 20)
        Me.txt_password.TabIndex = 2
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Location = New System.Drawing.Point(127, 139)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(121, 30)
        Me.btn_ingresar.TabIndex = 4
        Me.btn_ingresar.Text = "Ingresar"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PrimeraPrueba.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(254, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ingreso Cargue power Bi"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(110, 68)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(202, 20)
        Me.txt_email.TabIndex = 8
        '
        'lbl_error_mail
        '
        Me.lbl_error_mail.AutoSize = True
        Me.lbl_error_mail.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_mail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_error_mail.Location = New System.Drawing.Point(107, 50)
        Me.lbl_error_mail.Name = "lbl_error_mail"
        Me.lbl_error_mail.Size = New System.Drawing.Size(0, 15)
        Me.lbl_error_mail.TabIndex = 9
        '
        'lbl_error_cont
        '
        Me.lbl_error_cont.AutoSize = True
        Me.lbl_error_cont.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error_cont.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_error_cont.Location = New System.Drawing.Point(94, 91)
        Me.lbl_error_cont.Name = "lbl_error_cont"
        Me.lbl_error_cont.Size = New System.Drawing.Size(0, 15)
        Me.lbl_error_cont.TabIndex = 10
        '
        'form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(392, 273)
        Me.Controls.Add(Me.lbl_error_cont)
        Me.Controls.Add(Me.lbl_error_mail)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.lbl_numero2)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_numero1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_numero1 As System.Windows.Forms.Label
    Friend WithEvents lbl_numero2 As System.Windows.Forms.Label
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents btn_ingresar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbl_error_mail As System.Windows.Forms.Label
    Friend WithEvents lbl_error_cont As System.Windows.Forms.Label

End Class
