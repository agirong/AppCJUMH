<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        lbltitulo1 = New Label()
        lbltitulo2 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtnumeroexpediente = New TextBox()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        txtcarnet = New TextBox()
        ComboBox2 = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtcuenta = New TextBox()
        txttelefonoprocurador = New TextBox()
        Label7 = New Label()
        ComboBox3 = New ComboBox()
        Label8 = New Label()
        txttelefonousuario = New TextBox()
        txtobservacion = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        btnnuevo = New Button()
        btnguardar = New Button()
        btnsalir = New Button()
        txtfechaaudiencia = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(422, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 121)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lbltitulo1
        ' 
        lbltitulo1.AutoSize = True
        lbltitulo1.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbltitulo1.Location = New Point(323, 163)
        lbltitulo1.Name = "lbltitulo1"
        lbltitulo1.Size = New Size(339, 31)
        lbltitulo1.TabIndex = 1
        lbltitulo1.Text = "CARRERA DE DERECHO"
        ' 
        ' lbltitulo2
        ' 
        lbltitulo2.AutoSize = True
        lbltitulo2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbltitulo2.Location = New Point(323, 194)
        lbltitulo2.Name = "lbltitulo2"
        lbltitulo2.Size = New Size(331, 31)
        lbltitulo2.TabIndex = 2
        lbltitulo2.Text = "AUDIENCIAS VIGENTES"
        ' 
        ' Label1
        ' 
        Label1.AccessibleRole = AccessibleRole.None
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(30, 257)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 19)
        Label1.TabIndex = 3
        Label1.Text = "Número de expediente:"
        ' 
        ' Label2
        ' 
        Label2.AccessibleRole = AccessibleRole.None
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(404, 260)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 19)
        Label2.TabIndex = 4
        Label2.Text = "Materia:"
        ' 
        ' txtnumeroexpediente
        ' 
        txtnumeroexpediente.AccessibleRole = AccessibleRole.None
        txtnumeroexpediente.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtnumeroexpediente.Location = New Point(177, 254)
        txtnumeroexpediente.Name = "txtnumeroexpediente"
        txtnumeroexpediente.Size = New Size(221, 26)
        txtnumeroexpediente.TabIndex = 5
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AccessibleRole = AccessibleRole.None
        ComboBox1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Familia", "Civil", "Administrativo"})
        ComboBox1.Location = New Point(460, 257)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(194, 27)
        ComboBox1.TabIndex = 6
        ComboBox1.Text = "Seleccione"
        ' 
        ' Label3
        ' 
        Label3.AccessibleRole = AccessibleRole.None
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(30, 297)
        Label3.Name = "Label3"
        Label3.Size = New Size(231, 19)
        Label3.TabIndex = 7
        Label3.Text = "Nombre del procurador(a) asignado:"
        ' 
        ' txtcarnet
        ' 
        txtcarnet.AccessibleRole = AccessibleRole.None
        txtcarnet.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtcarnet.Location = New Point(709, 295)
        txtcarnet.Name = "txtcarnet"
        txtcarnet.Size = New Size(157, 26)
        txtcarnet.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.AccessibleRole = AccessibleRole.None
        ComboBox2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(260, 295)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(394, 27)
        ComboBox2.TabIndex = 9
        ComboBox2.Text = "Seleccione"
        ' 
        ' Label4
        ' 
        Label4.AccessibleRole = AccessibleRole.None
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(657, 298)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 19)
        Label4.TabIndex = 10
        Label4.Text = "Carnet:"
        ' 
        ' Label5
        ' 
        Label5.AccessibleRole = AccessibleRole.None
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(30, 337)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 19)
        Label5.TabIndex = 11
        Label5.Text = "Cuenta institucional:"
        ' 
        ' Label6
        ' 
        Label6.AccessibleRole = AccessibleRole.None
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(385, 337)
        Label6.Name = "Label6"
        Label6.Size = New Size(133, 19)
        Label6.TabIndex = 12
        Label6.Text = "Número de teléfono:"
        ' 
        ' txtcuenta
        ' 
        txtcuenta.AccessibleRole = AccessibleRole.None
        txtcuenta.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtcuenta.Location = New Point(159, 334)
        txtcuenta.Name = "txtcuenta"
        txtcuenta.Size = New Size(220, 26)
        txtcuenta.TabIndex = 13
        ' 
        ' txttelefonoprocurador
        ' 
        txttelefonoprocurador.AccessibleRole = AccessibleRole.None
        txttelefonoprocurador.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txttelefonoprocurador.Location = New Point(517, 337)
        txttelefonoprocurador.Name = "txttelefonoprocurador"
        txttelefonoprocurador.Size = New Size(204, 26)
        txttelefonoprocurador.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AccessibleRole = AccessibleRole.None
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(32, 378)
        Label7.Name = "Label7"
        Label7.Size = New Size(129, 19)
        Label7.TabIndex = 15
        Label7.Text = "Nombre de usuario:"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.AccessibleRole = AccessibleRole.None
        ComboBox3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(159, 375)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(423, 27)
        ComboBox3.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AccessibleRole = AccessibleRole.None
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(588, 378)
        Label8.Name = "Label8"
        Label8.Size = New Size(133, 19)
        Label8.TabIndex = 17
        Label8.Text = "Número de teléfono:"
        ' 
        ' txttelefonousuario
        ' 
        txttelefonousuario.AccessibleRole = AccessibleRole.None
        txttelefonousuario.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txttelefonousuario.Location = New Point(720, 375)
        txttelefonousuario.Name = "txttelefonousuario"
        txttelefonousuario.Size = New Size(157, 26)
        txttelefonousuario.TabIndex = 18
        ' 
        ' txtobservacion
        ' 
        txtobservacion.AccessibleRole = AccessibleRole.None
        txtobservacion.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtobservacion.Location = New Point(121, 414)
        txtobservacion.Multiline = True
        txtobservacion.Name = "txtobservacion"
        txtobservacion.Size = New Size(750, 147)
        txtobservacion.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AccessibleRole = AccessibleRole.None
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(32, 414)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 19)
        Label9.TabIndex = 20
        Label9.Text = "Observación:"
        ' 
        ' Label10
        ' 
        Label10.AccessibleRole = AccessibleRole.None
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(121, 591)
        Label10.Name = "Label10"
        Label10.Size = New Size(142, 19)
        Label10.TabIndex = 21
        Label10.Text = "Fecha de la audiencia:"
        ' 
        ' btnnuevo
        ' 
        btnnuevo.AccessibleRole = AccessibleRole.None
        btnnuevo.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnnuevo.Location = New Point(335, 672)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(83, 41)
        btnnuevo.TabIndex = 23
        btnnuevo.Text = "Nuevo"
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.AccessibleRole = AccessibleRole.None
        btnguardar.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnguardar.Location = New Point(443, 672)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(84, 41)
        btnguardar.TabIndex = 24
        btnguardar.Text = "Guardar"
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnsalir
        ' 
        btnsalir.AccessibleRole = AccessibleRole.None
        btnsalir.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnsalir.Location = New Point(560, 672)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(94, 41)
        btnsalir.TabIndex = 25
        btnsalir.Text = "Salir"
        btnsalir.UseVisualStyleBackColor = True
        ' 
        ' txtfechaaudiencia
        ' 
        txtfechaaudiencia.Location = New Point(271, 591)
        txtfechaaudiencia.Multiline = True
        txtfechaaudiencia.Name = "txtfechaaudiencia"
        txtfechaaudiencia.Size = New Size(547, 61)
        txtfechaaudiencia.TabIndex = 26
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(889, 740)
        Controls.Add(txtfechaaudiencia)
        Controls.Add(btnsalir)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(txtobservacion)
        Controls.Add(txttelefonousuario)
        Controls.Add(Label8)
        Controls.Add(ComboBox3)
        Controls.Add(Label7)
        Controls.Add(txttelefonoprocurador)
        Controls.Add(txtcuenta)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ComboBox2)
        Controls.Add(txtcarnet)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(txtnumeroexpediente)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbltitulo2)
        Controls.Add(lbltitulo1)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltitulo1 As Label
    Friend WithEvents lbltitulo2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnumeroexpediente As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcarnet As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcuenta As TextBox
    Friend WithEvents txttelefonoprocurador As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txttelefonousuario As TextBox
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtfechaaudiencia As TextBox
End Class
