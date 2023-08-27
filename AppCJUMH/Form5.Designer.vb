<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        lblnombreusuario = New Label()
        lblnumerocelular = New Label()
        ComboBox1 = New ComboBox()
        txtnumerocelular = New TextBox()
        lblcorreoelectronico = New Label()
        lblnombredemandado = New Label()
        txtcorreoelectronico = New TextBox()
        txtdemandado = New TextBox()
        txtdemandante = New TextBox()
        lblnombredemandante = New Label()
        lbltipodecaso = New Label()
        txttipocaso = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        lblestado = New Label()
        lblcategoria = New Label()
        lblnumeroexpediente = New Label()
        lbljuez = New Label()
        txtnumeroexpediente = New TextBox()
        txtjuez = New TextBox()
        lblprocuradorquedelegó = New Label()
        lblcarnetprocuradorquedelegó = New Label()
        lblprocuradordelegado = New Label()
        lblcarnetprocuradordelegado = New Label()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        txtcarnetquedelega = New TextBox()
        txtcarnetdelegado = New TextBox()
        lblfechaprimeraatencion = New Label()
        Label10 = New Label()
        Label11 = New Label()
        lblzonaconsultorio = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        ComboBox6 = New ComboBox()
        ComboBox7 = New ComboBox()
        Label3 = New Label()
        txtdescripcion = New TextBox()
        btnnuevo = New Button()
        btnguardar = New Button()
        btnsalir = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(452, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(108, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(331, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 31)
        Label1.TabIndex = 1
        Label1.Text = "CARRERA DE DERECHO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(339, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(331, 31)
        Label2.TabIndex = 2
        Label2.Text = "CASOS JUDICIALES PPS"
        ' 
        ' lblnombreusuario
        ' 
        lblnombreusuario.AutoSize = True
        lblnombreusuario.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblnombreusuario.Location = New Point(33, 263)
        lblnombreusuario.Name = "lblnombreusuario"
        lblnombreusuario.Size = New Size(133, 19)
        lblnombreusuario.TabIndex = 3
        lblnombreusuario.Text = "Nombre de usuario: "
        ' 
        ' lblnumerocelular
        ' 
        lblnumerocelular.AutoSize = True
        lblnumerocelular.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblnumerocelular.Location = New Point(583, 264)
        lblnumerocelular.Name = "lblnumerocelular"
        lblnumerocelular.Size = New Size(124, 19)
        lblnumerocelular.TabIndex = 4
        lblnumerocelular.Text = "Número de celular:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(164, 260)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(419, 27)
        ComboBox1.TabIndex = 5
        ComboBox1.Text = "Seleccione"
        ' 
        ' txtnumerocelular
        ' 
        txtnumerocelular.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtnumerocelular.Location = New Point(704, 262)
        txtnumerocelular.Name = "txtnumerocelular"
        txtnumerocelular.Size = New Size(224, 26)
        txtnumerocelular.TabIndex = 6
        ' 
        ' lblcorreoelectronico
        ' 
        lblcorreoelectronico.AutoSize = True
        lblcorreoelectronico.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblcorreoelectronico.Location = New Point(32, 299)
        lblcorreoelectronico.Name = "lblcorreoelectronico"
        lblcorreoelectronico.Size = New Size(126, 19)
        lblcorreoelectronico.TabIndex = 7
        lblcorreoelectronico.Text = "Correo electrónico:"
        ' 
        ' lblnombredemandado
        ' 
        lblnombredemandado.AutoSize = True
        lblnombredemandado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblnombredemandado.Location = New Point(401, 300)
        lblnombredemandado.Name = "lblnombredemandado"
        lblnombredemandado.Size = New Size(142, 19)
        lblnombredemandado.TabIndex = 8
        lblnombredemandado.Text = "Nombre demandado: "
        ' 
        ' txtcorreoelectronico
        ' 
        txtcorreoelectronico.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtcorreoelectronico.Location = New Point(164, 296)
        txtcorreoelectronico.Name = "txtcorreoelectronico"
        txtcorreoelectronico.Size = New Size(225, 26)
        txtcorreoelectronico.TabIndex = 9
        ' 
        ' txtdemandado
        ' 
        txtdemandado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtdemandado.Location = New Point(542, 296)
        txtdemandado.Name = "txtdemandado"
        txtdemandado.Size = New Size(386, 26)
        txtdemandado.TabIndex = 10
        ' 
        ' txtdemandante
        ' 
        txtdemandante.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtdemandante.Location = New Point(179, 335)
        txtdemandante.Name = "txtdemandante"
        txtdemandante.Size = New Size(381, 26)
        txtdemandante.TabIndex = 11
        ' 
        ' lblnombredemandante
        ' 
        lblnombredemandante.AutoSize = True
        lblnombredemandante.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblnombredemandante.Location = New Point(33, 338)
        lblnombredemandante.Name = "lblnombredemandante"
        lblnombredemandante.Size = New Size(140, 19)
        lblnombredemandante.TabIndex = 12
        lblnombredemandante.Text = "Nombre demandante:"
        ' 
        ' lbltipodecaso
        ' 
        lbltipodecaso.AutoSize = True
        lbltipodecaso.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbltipodecaso.Location = New Point(560, 338)
        lbltipodecaso.Name = "lbltipodecaso"
        lbltipodecaso.Size = New Size(90, 19)
        lbltipodecaso.TabIndex = 13
        lbltipodecaso.Text = "Tipo de caso:"
        ' 
        ' txttipocaso
        ' 
        txttipocaso.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txttipocaso.Location = New Point(656, 335)
        txttipocaso.Name = "txttipocaso"
        txttipocaso.Size = New Size(272, 26)
        txttipocaso.TabIndex = 14
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Familia", "Civil", "Administrativo", "Judicial", "Laboral "})
        ComboBox2.Location = New Point(110, 371)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(159, 27)
        ComboBox2.TabIndex = 15
        ComboBox2.Text = "Seleccione"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Activo", "Inactivo", "Finalizado"})
        ComboBox3.Location = New Point(339, 371)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(144, 27)
        ComboBox3.TabIndex = 16
        ComboBox3.Text = "Seleccione"
        ' 
        ' lblestado
        ' 
        lblestado.AutoSize = True
        lblestado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblestado.Location = New Point(279, 374)
        lblestado.Name = "lblestado"
        lblestado.Size = New Size(54, 19)
        lblestado.TabIndex = 17
        lblestado.Text = "Estado:"
        ' 
        ' lblcategoria
        ' 
        lblcategoria.AutoSize = True
        lblcategoria.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblcategoria.Location = New Point(33, 374)
        lblcategoria.Name = "lblcategoria"
        lblcategoria.Size = New Size(71, 19)
        lblcategoria.TabIndex = 18
        lblcategoria.Text = "Categoria:"
        ' 
        ' lblnumeroexpediente
        ' 
        lblnumeroexpediente.AutoSize = True
        lblnumeroexpediente.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblnumeroexpediente.Location = New Point(489, 377)
        lblnumeroexpediente.Name = "lblnumeroexpediente"
        lblnumeroexpediente.Size = New Size(150, 19)
        lblnumeroexpediente.TabIndex = 19
        lblnumeroexpediente.Text = "Número de expediente:"
        ' 
        ' lbljuez
        ' 
        lbljuez.AutoSize = True
        lbljuez.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbljuez.Location = New Point(791, 379)
        lbljuez.Name = "lbljuez"
        lbljuez.Size = New Size(38, 19)
        lbljuez.TabIndex = 20
        lbljuez.Text = "Juez:"
        ' 
        ' txtnumeroexpediente
        ' 
        txtnumeroexpediente.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtnumeroexpediente.Location = New Point(645, 374)
        txtnumeroexpediente.Name = "txtnumeroexpediente"
        txtnumeroexpediente.Size = New Size(144, 26)
        txtnumeroexpediente.TabIndex = 21
        ' 
        ' txtjuez
        ' 
        txtjuez.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtjuez.Location = New Point(828, 377)
        txtjuez.Name = "txtjuez"
        txtjuez.Size = New Size(100, 26)
        txtjuez.TabIndex = 22
        ' 
        ' lblprocuradorquedelegó
        ' 
        lblprocuradorquedelegó.AutoSize = True
        lblprocuradorquedelegó.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblprocuradorquedelegó.Location = New Point(33, 415)
        lblprocuradorquedelegó.Name = "lblprocuradorquedelegó"
        lblprocuradorquedelegó.Size = New Size(205, 19)
        lblprocuradorquedelegó.TabIndex = 23
        lblprocuradorquedelegó.Text = "Nombre procurador que delegó:"
        ' 
        ' lblcarnetprocuradorquedelegó
        ' 
        lblcarnetprocuradorquedelegó.AutoSize = True
        lblcarnetprocuradorquedelegó.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblcarnetprocuradorquedelegó.Location = New Point(699, 415)
        lblcarnetprocuradorquedelegó.Name = "lblcarnetprocuradorquedelegó"
        lblcarnetprocuradorquedelegó.Size = New Size(53, 19)
        lblcarnetprocuradorquedelegó.TabIndex = 24
        lblcarnetprocuradorquedelegó.Text = "Carnet:"
        ' 
        ' lblprocuradordelegado
        ' 
        lblprocuradordelegado.AutoSize = True
        lblprocuradordelegado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblprocuradordelegado.Location = New Point(33, 446)
        lblprocuradordelegado.Name = "lblprocuradordelegado"
        lblprocuradordelegado.Size = New Size(194, 19)
        lblprocuradordelegado.TabIndex = 25
        lblprocuradordelegado.Text = "Nombre procurador delegado:"
        ' 
        ' lblcarnetprocuradordelegado
        ' 
        lblcarnetprocuradordelegado.AutoSize = True
        lblcarnetprocuradordelegado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblcarnetprocuradordelegado.Location = New Point(700, 449)
        lblcarnetprocuradordelegado.Name = "lblcarnetprocuradordelegado"
        lblcarnetprocuradordelegado.Size = New Size(53, 19)
        lblcarnetprocuradordelegado.TabIndex = 26
        lblcarnetprocuradordelegado.Text = "Carnet:"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(240, 413)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(453, 27)
        ComboBox4.TabIndex = 27
        ComboBox4.Text = "Seleccione"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(233, 446)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(461, 27)
        ComboBox5.TabIndex = 28
        ComboBox5.Text = "Seleccione"
        ' 
        ' txtcarnetquedelega
        ' 
        txtcarnetquedelega.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtcarnetquedelega.Location = New Point(758, 413)
        txtcarnetquedelega.Name = "txtcarnetquedelega"
        txtcarnetquedelega.Size = New Size(170, 26)
        txtcarnetquedelega.TabIndex = 29
        ' 
        ' txtcarnetdelegado
        ' 
        txtcarnetdelegado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtcarnetdelegado.Location = New Point(763, 449)
        txtcarnetdelegado.Name = "txtcarnetdelegado"
        txtcarnetdelegado.Size = New Size(165, 26)
        txtcarnetdelegado.TabIndex = 30
        ' 
        ' lblfechaprimeraatencion
        ' 
        lblfechaprimeraatencion.AutoSize = True
        lblfechaprimeraatencion.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblfechaprimeraatencion.Location = New Point(36, 485)
        lblfechaprimeraatencion.Name = "lblfechaprimeraatencion"
        lblfechaprimeraatencion.Size = New Size(153, 19)
        lblfechaprimeraatencion.TabIndex = 31
        lblfechaprimeraatencion.Text = "Fecha primera atención:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(36, 518)
        Label10.Name = "Label10"
        Label10.Size = New Size(91, 19)
        Label10.TabIndex = 32
        Label10.Text = "Delegar caso:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(316, 489)
        Label11.Name = "Label11"
        Label11.Size = New Size(142, 19)
        Label11.TabIndex = 33
        Label11.Text = "Fecha última atención:"
        ' 
        ' lblzonaconsultorio
        ' 
        lblzonaconsultorio.AutoSize = True
        lblzonaconsultorio.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblzonaconsultorio.Location = New Point(583, 489)
        lblzonaconsultorio.Name = "lblzonaconsultorio"
        lblzonaconsultorio.Size = New Size(132, 19)
        lblzonaconsultorio.TabIndex = 34
        lblzonaconsultorio.Text = "Zona de consultorio:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(464, 485)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(110, 26)
        DateTimePicker1.TabIndex = 35
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(195, 483)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(115, 26)
        DateTimePicker2.TabIndex = 36
        ' 
        ' ComboBox6
        ' 
        ComboBox6.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox6.FormattingEnabled = True
        ComboBox6.Items.AddRange(New Object() {"Tocoa", "Santa Rosa", "Choluteca", "Tegucigalpa", "Juticalpa"})
        ComboBox6.Location = New Point(715, 486)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(213, 27)
        ComboBox6.TabIndex = 37
        ComboBox6.Text = "Seleccione"
        ' 
        ' ComboBox7
        ' 
        ComboBox7.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox7.FormattingEnabled = True
        ComboBox7.Items.AddRange(New Object() {"Delegar", "No delegar"})
        ComboBox7.Location = New Point(133, 515)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New Size(121, 27)
        ComboBox7.TabIndex = 38
        ComboBox7.Text = "Seleccione"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(233, 557)
        Label3.Name = "Label3"
        Label3.Size = New Size(541, 19)
        Label3.TabIndex = 39
        Label3.Text = "Descripción del caso, información relevante, últimas actuaciones y lo que restaría realizar"
        ' 
        ' txtdescripcion
        ' 
        txtdescripcion.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtdescripcion.Location = New Point(47, 581)
        txtdescripcion.Multiline = True
        txtdescripcion.Name = "txtdescripcion"
        txtdescripcion.Size = New Size(892, 136)
        txtdescripcion.TabIndex = 40
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnnuevo.Location = New Point(339, 733)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(75, 31)
        btnnuevo.TabIndex = 41
        btnnuevo.Text = "Nuevo"
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnguardar.Location = New Point(452, 733)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(75, 31)
        btnguardar.TabIndex = 42
        btnguardar.Text = "Guardar"
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnsalir
        ' 
        btnsalir.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnsalir.Location = New Point(564, 733)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(75, 31)
        btnsalir.TabIndex = 43
        btnsalir.Text = "Salir"
        btnsalir.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(971, 792)
        Controls.Add(btnsalir)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(txtdescripcion)
        Controls.Add(Label3)
        Controls.Add(ComboBox7)
        Controls.Add(ComboBox6)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblzonaconsultorio)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(lblfechaprimeraatencion)
        Controls.Add(txtcarnetdelegado)
        Controls.Add(txtcarnetquedelega)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox4)
        Controls.Add(lblcarnetprocuradordelegado)
        Controls.Add(lblprocuradordelegado)
        Controls.Add(lblcarnetprocuradorquedelegó)
        Controls.Add(lblprocuradorquedelegó)
        Controls.Add(txtjuez)
        Controls.Add(txtnumeroexpediente)
        Controls.Add(lbljuez)
        Controls.Add(lblnumeroexpediente)
        Controls.Add(lblcategoria)
        Controls.Add(lblestado)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(txttipocaso)
        Controls.Add(lbltipodecaso)
        Controls.Add(lblnombredemandante)
        Controls.Add(txtdemandante)
        Controls.Add(txtdemandado)
        Controls.Add(txtcorreoelectronico)
        Controls.Add(lblnombredemandado)
        Controls.Add(lblcorreoelectronico)
        Controls.Add(txtnumerocelular)
        Controls.Add(ComboBox1)
        Controls.Add(lblnumerocelular)
        Controls.Add(lblnombreusuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblnombreusuario As Label
    Friend WithEvents lblnumerocelular As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtnumerocelular As TextBox
    Friend WithEvents lblcorreoelectronico As Label
    Friend WithEvents lblnombredemandado As Label
    Friend WithEvents txtcorreoelectronico As TextBox
    Friend WithEvents txtdemandado As TextBox
    Friend WithEvents txtdemandante As TextBox
    Friend WithEvents lblnombredemandante As Label
    Friend WithEvents lbltipodecaso As Label
    Friend WithEvents txttipocaso As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents lblestado As Label
    Friend WithEvents lblcategoria As Label
    Friend WithEvents lblnumeroexpediente As Label
    Friend WithEvents lbljuez As Label
    Friend WithEvents txtnumeroexpediente As TextBox
    Friend WithEvents txtjuez As TextBox
    Friend WithEvents lblprocuradorquedelegó As Label
    Friend WithEvents lblcarnetprocuradorquedelegó As Label
    Friend WithEvents lblprocuradordelegado As Label
    Friend WithEvents lblcarnetprocuradordelegado As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents txtcarnetquedelega As TextBox
    Friend WithEvents txtcarnetdelegado As TextBox
    Friend WithEvents lblfechaprimeraatencion As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblzonaconsultorio As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnsalir As Button
End Class
