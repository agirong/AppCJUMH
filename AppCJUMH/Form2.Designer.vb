<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbltitulo1 = New System.Windows.Forms.Label()
        Me.lbltitulo2 = New System.Windows.Forms.Label()
        Me.lblnombreprocurador = New System.Windows.Forms.Label()
        Me.lblcuenta = New System.Windows.Forms.Label()
        Me.txtnumerocuenta = New System.Windows.Forms.TextBox()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.lblmodalidad = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.txttelefonoprocurador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtinstitucion = New System.Windows.Forms.TextBox()
        Me.lbltelefonoinstitucion = New System.Windows.Forms.Label()
        Me.lblcorreoinstitucion = New System.Windows.Forms.Label()
        Me.txttelefonoinstitucion = New System.Windows.Forms.TextBox()
        Me.txtcorreoelectronico = New System.Windows.Forms.TextBox()
        Me.lblnombreencargado = New System.Windows.Forms.Label()
        Me.lbltelefonoencargado = New System.Windows.Forms.Label()
        Me.lblcargoencargado = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtnombrencargado = New System.Windows.Forms.TextBox()
        Me.txttelefonoencargado = New System.Windows.Forms.TextBox()
        Me.txtcargoqueostenta = New System.Windows.Forms.TextBox()
        Me.txtnombreprocurador = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(480, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lbltitulo1
        '
        Me.lbltitulo1.AutoSize = True
        Me.lbltitulo1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltitulo1.Location = New System.Drawing.Point(375, 172)
        Me.lbltitulo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitulo1.Name = "lbltitulo1"
        Me.lbltitulo1.Size = New System.Drawing.Size(425, 38)
        Me.lbltitulo1.TabIndex = 1
        Me.lbltitulo1.Text = "CARRERA DE DERECHO"
        '
        'lbltitulo2
        '
        Me.lbltitulo2.AutoSize = True
        Me.lbltitulo2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltitulo2.Location = New System.Drawing.Point(152, 214)
        Me.lbltitulo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltitulo2.Name = "lbltitulo2"
        Me.lbltitulo2.Size = New System.Drawing.Size(983, 38)
        Me.lbltitulo2.TabIndex = 2
        Me.lbltitulo2.Text = "SEGUIMIENTO PPS EN SU MODALIDAD PRIVADA Y MIXTA"
        '
        'lblnombreprocurador
        '
        Me.lblnombreprocurador.AutoSize = True
        Me.lblnombreprocurador.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblnombreprocurador.Location = New System.Drawing.Point(24, 265)
        Me.lblnombreprocurador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnombreprocurador.Name = "lblnombreprocurador"
        Me.lblnombreprocurador.Size = New System.Drawing.Size(226, 22)
        Me.lblnombreprocurador.TabIndex = 3
        Me.lblnombreprocurador.Text = "Nombre del procurador(a):"
        '
        'lblcuenta
        '
        Me.lblcuenta.AutoSize = True
        Me.lblcuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblcuenta.Location = New System.Drawing.Point(751, 260)
        Me.lblcuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcuenta.Name = "lblcuenta"
        Me.lblcuenta.Size = New System.Drawing.Size(159, 22)
        Me.lblcuenta.TabIndex = 4
        Me.lblcuenta.Text = "Número de cuenta:"
        '
        'txtnumerocuenta
        '
        Me.txtnumerocuenta.Location = New System.Drawing.Point(875, 258)
        Me.txtnumerocuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumerocuenta.Name = "txtnumerocuenta"
        Me.txtnumerocuenta.Size = New System.Drawing.Size(219, 30)
        Me.txtnumerocuenta.TabIndex = 6
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Location = New System.Drawing.Point(24, 303)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(179, 22)
        Me.lbltelefono.TabIndex = 7
        Me.lbltelefono.Text = "Teléfono procurador:"
        '
        'lblmodalidad
        '
        Me.lblmodalidad.AutoSize = True
        Me.lblmodalidad.Location = New System.Drawing.Point(416, 303)
        Me.lblmodalidad.Name = "lblmodalidad"
        Me.lblmodalidad.Size = New System.Drawing.Size(234, 22)
        Me.lblmodalidad.TabIndex = 8
        Me.lblmodalidad.Text = "Modalidad de la institución:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Mixta", "Privada"})
        Me.ComboBox2.Location = New System.Drawing.Point(596, 300)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(234, 30)
        Me.ComboBox2.TabIndex = 9
        Me.ComboBox2.Text = "Seleccione"
        '
        'txttelefonoprocurador
        '
        Me.txttelefonoprocurador.Location = New System.Drawing.Point(166, 300)
        Me.txttelefonoprocurador.Name = "txttelefonoprocurador"
        Me.txttelefonoprocurador.Size = New System.Drawing.Size(244, 30)
        Me.txttelefonoprocurador.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Institución donde realiza la practica:"
        '
        'txtinstitucion
        '
        Me.txtinstitucion.Location = New System.Drawing.Point(251, 340)
        Me.txtinstitucion.Name = "txtinstitucion"
        Me.txtinstitucion.Size = New System.Drawing.Size(840, 30)
        Me.txtinstitucion.TabIndex = 12
        '
        'lbltelefonoinstitucion
        '
        Me.lbltelefonoinstitucion.AutoSize = True
        Me.lbltelefonoinstitucion.Location = New System.Drawing.Point(24, 378)
        Me.lbltelefonoinstitucion.Name = "lbltelefonoinstitucion"
        Me.lbltelefonoinstitucion.Size = New System.Drawing.Size(217, 22)
        Me.lbltelefonoinstitucion.TabIndex = 13
        Me.lbltelefonoinstitucion.Text = "Teléfono de la institución:"
        '
        'lblcorreoinstitucion
        '
        Me.lblcorreoinstitucion.AutoSize = True
        Me.lblcorreoinstitucion.Location = New System.Drawing.Point(494, 378)
        Me.lblcorreoinstitucion.Name = "lblcorreoinstitucion"
        Me.lblcorreoinstitucion.Size = New System.Drawing.Size(166, 22)
        Me.lblcorreoinstitucion.TabIndex = 14
        Me.lblcorreoinstitucion.Text = "Correo electrónico:"
        '
        'txttelefonoinstitucion
        '
        Me.txttelefonoinstitucion.Location = New System.Drawing.Point(190, 375)
        Me.txttelefonoinstitucion.Name = "txttelefonoinstitucion"
        Me.txttelefonoinstitucion.Size = New System.Drawing.Size(298, 30)
        Me.txttelefonoinstitucion.TabIndex = 15
        '
        'txtcorreoelectronico
        '
        Me.txtcorreoelectronico.Location = New System.Drawing.Point(626, 375)
        Me.txtcorreoelectronico.Name = "txtcorreoelectronico"
        Me.txtcorreoelectronico.Size = New System.Drawing.Size(364, 30)
        Me.txtcorreoelectronico.TabIndex = 16
        '
        'lblnombreencargado
        '
        Me.lblnombreencargado.AutoSize = True
        Me.lblnombreencargado.Location = New System.Drawing.Point(24, 416)
        Me.lblnombreencargado.Name = "lblnombreencargado"
        Me.lblnombreencargado.Size = New System.Drawing.Size(399, 22)
        Me.lblnombreencargado.TabIndex = 17
        Me.lblnombreencargado.Text = "Nombre de la persona encargada del procurador:"
        '
        'lbltelefonoencargado
        '
        Me.lbltelefonoencargado.AutoSize = True
        Me.lbltelefonoencargado.Location = New System.Drawing.Point(24, 456)
        Me.lbltelefonoencargado.Name = "lbltelefonoencargado"
        Me.lbltelefonoencargado.Size = New System.Drawing.Size(282, 22)
        Me.lbltelefonoencargado.TabIndex = 18
        Me.lbltelefonoencargado.Text = "Teléfono de la persona encargada:"
        '
        'lblcargoencargado
        '
        Me.lblcargoencargado.AutoSize = True
        Me.lblcargoencargado.Location = New System.Drawing.Point(512, 456)
        Me.lblcargoencargado.Name = "lblcargoencargado"
        Me.lblcargoencargado.Size = New System.Drawing.Size(157, 22)
        Me.lblcargoencargado.TabIndex = 19
        Me.lblcargoencargado.Text = "Cargo que ostenta:"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(416, 528)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(99, 38)
        Me.btnguardar.TabIndex = 20
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(534, 528)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(101, 38)
        Me.btnnuevo.TabIndex = 21
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(650, 528)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(91, 38)
        Me.btnsalir.TabIndex = 22
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'txtnombrencargado
        '
        Me.txtnombrencargado.Location = New System.Drawing.Point(338, 413)
        Me.txtnombrencargado.Name = "txtnombrencargado"
        Me.txtnombrencargado.Size = New System.Drawing.Size(753, 30)
        Me.txtnombrencargado.TabIndex = 23
        '
        'txttelefonoencargado
        '
        Me.txttelefonoencargado.Location = New System.Drawing.Point(244, 453)
        Me.txttelefonoencargado.Name = "txttelefonoencargado"
        Me.txttelefonoencargado.Size = New System.Drawing.Size(246, 30)
        Me.txttelefonoencargado.TabIndex = 24
        '
        'txtcargoqueostenta
        '
        Me.txtcargoqueostenta.Location = New System.Drawing.Point(641, 453)
        Me.txtcargoqueostenta.Name = "txtcargoqueostenta"
        Me.txtcargoqueostenta.Size = New System.Drawing.Size(450, 30)
        Me.txtcargoqueostenta.TabIndex = 25
        '
        'txtnombreprocurador
        '
        Me.txtnombreprocurador.Location = New System.Drawing.Point(199, 262)
        Me.txtnombreprocurador.Name = "txtnombreprocurador"
        Me.txtnombreprocurador.Size = New System.Drawing.Size(552, 30)
        Me.txtnombreprocurador.TabIndex = 26
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 589)
        Me.Controls.Add(Me.txtnombreprocurador)
        Me.Controls.Add(Me.txtcargoqueostenta)
        Me.Controls.Add(Me.txttelefonoencargado)
        Me.Controls.Add(Me.txtnombrencargado)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.lblcargoencargado)
        Me.Controls.Add(Me.lbltelefonoencargado)
        Me.Controls.Add(Me.lblnombreencargado)
        Me.Controls.Add(Me.txtcorreoelectronico)
        Me.Controls.Add(Me.txttelefonoinstitucion)
        Me.Controls.Add(Me.lblcorreoinstitucion)
        Me.Controls.Add(Me.lbltelefonoinstitucion)
        Me.Controls.Add(Me.txtinstitucion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttelefonoprocurador)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lblmodalidad)
        Me.Controls.Add(Me.lbltelefono)
        Me.Controls.Add(Me.txtnumerocuenta)
        Me.Controls.Add(Me.lblcuenta)
        Me.Controls.Add(Me.lblnombreprocurador)
        Me.Controls.Add(Me.lbltitulo2)
        Me.Controls.Add(Me.lbltitulo1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltitulo1 As Label
    Friend WithEvents lbltitulo2 As Label
    Friend WithEvents lblnombreprocurador As Label
    Friend WithEvents lblcuenta As Label
    Friend WithEvents txtnumerocuenta As TextBox
    Friend WithEvents lbltelefono As Label
    Friend WithEvents lblmodalidad As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents txttelefonoprocurador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtinstitucion As TextBox
    Friend WithEvents lbltelefonoinstitucion As Label
    Friend WithEvents lblcorreoinstitucion As Label
    Friend WithEvents txttelefonoinstitucion As TextBox
    Friend WithEvents txtcorreoelectronico As TextBox
    Friend WithEvents lblnombreencargado As Label
    Friend WithEvents lbltelefonoencargado As Label
    Friend WithEvents lblcargoencargado As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtnombrencargado As TextBox
    Friend WithEvents txttelefonoencargado As TextBox
    Friend WithEvents txtcargoqueostenta As TextBox
    Friend WithEvents txtnombreprocurador As TextBox
End Class
