<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        PictureBox1 = New PictureBox()
        lbltitulo1 = New Label()
        lbltitulo2 = New Label()
        lblprocuradorquedelega = New Label()
        lbljuez = New Label()
        lblexpediente = New Label()
        lblcaso = New Label()
        txtnumerojuez = New TextBox()
        txtcaso = New TextBox()
        txtnumeroexpediente = New TextBox()
        ComboBox1 = New ComboBox()
        lblmateria = New Label()
        lblusuario = New Label()
        lbltelefono = New Label()
        lblestadoactual = New Label()
        rbtnnuevo = New RadioButton()
        rbtniniciado = New RadioButton()
        lblobservacion = New Label()
        lblnuevoprocurador = New Label()
        txttelefono = New TextBox()
        txtestadoactual = New TextBox()
        txtobservacion = New TextBox()
        txtnuevoprocurador = New TextBox()
        btnnuevo = New Button()
        btnguardar = New Button()
        btnsalir = New Button()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(389, 25)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(114, 119)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lbltitulo1
        ' 
        lbltitulo1.AutoSize = True
        lbltitulo1.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbltitulo1.Location = New Point(320, 170)
        lbltitulo1.Name = "lbltitulo1"
        lbltitulo1.Size = New Size(295, 26)
        lbltitulo1.TabIndex = 1
        lbltitulo1.Text = "CARRERA DE DERECHO"
        ' 
        ' lbltitulo2
        ' 
        lbltitulo2.AutoSize = True
        lbltitulo2.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbltitulo2.Location = New Point(160, 210)
        lbltitulo2.Name = "lbltitulo2"
        lbltitulo2.Size = New Size(613, 26)
        lbltitulo2.TabIndex = 2
        lbltitulo2.Text = "DELEGACIONES PROCURADORES 2DA PROMOCÓN"
        ' 
        ' lblprocuradorquedelega
        ' 
        lblprocuradorquedelega.AutoSize = True
        lblprocuradorquedelega.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblprocuradorquedelega.Location = New Point(33, 270)
        lblprocuradorquedelega.Name = "lblprocuradorquedelega"
        lblprocuradorquedelega.Size = New Size(243, 19)
        lblprocuradorquedelega.TabIndex = 3
        lblprocuradorquedelega.Text = "Nombre del procurador(a) que delega:"
        ' 
        ' lbljuez
        ' 
        lbljuez.AutoSize = True
        lbljuez.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbljuez.Location = New Point(599, 271)
        lbljuez.Name = "lbljuez"
        lbljuez.Size = New Size(109, 19)
        lbljuez.TabIndex = 4
        lbljuez.Text = "Número de juez:"
        ' 
        ' lblexpediente
        ' 
        lblexpediente.AutoSize = True
        lblexpediente.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblexpediente.Location = New Point(33, 313)
        lblexpediente.Name = "lblexpediente"
        lblexpediente.Size = New Size(150, 19)
        lblexpediente.TabIndex = 5
        lblexpediente.Text = "Número de expediente:"
        ' 
        ' lblcaso
        ' 
        lblcaso.AutoSize = True
        lblcaso.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblcaso.Location = New Point(389, 317)
        lblcaso.Name = "lblcaso"
        lblcaso.Size = New Size(44, 19)
        lblcaso.TabIndex = 6
        lblcaso.Text = "Caso:"
        ' 
        ' txtnumerojuez
        ' 
        txtnumerojuez.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtnumerojuez.Location = New Point(714, 266)
        txtnumerojuez.Name = "txtnumerojuez"
        txtnumerojuez.Size = New Size(162, 26)
        txtnumerojuez.TabIndex = 7
        ' 
        ' txtcaso
        ' 
        txtcaso.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtcaso.Location = New Point(439, 313)
        txtcaso.Name = "txtcaso"
        txtcaso.Size = New Size(437, 26)
        txtcaso.TabIndex = 8
        ' 
        ' txtnumeroexpediente
        ' 
        txtnumeroexpediente.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtnumeroexpediente.Location = New Point(189, 313)
        txtnumeroexpediente.Name = "txtnumeroexpediente"
        txtnumeroexpediente.Size = New Size(185, 26)
        txtnumeroexpediente.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(279, 268)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(311, 27)
        ComboBox1.TabIndex = 10
        ComboBox1.Text = "Seleccione"
        ' 
        ' lblmateria
        ' 
        lblmateria.AutoSize = True
        lblmateria.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblmateria.Location = New Point(34, 358)
        lblmateria.Name = "lblmateria"
        lblmateria.Size = New Size(59, 19)
        lblmateria.TabIndex = 11
        lblmateria.Text = "Materia:"
        ' 
        ' lblusuario
        ' 
        lblusuario.AutoSize = True
        lblusuario.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblusuario.Location = New Point(246, 357)
        lblusuario.Name = "lblusuario"
        lblusuario.Size = New Size(59, 19)
        lblusuario.TabIndex = 12
        lblusuario.Text = "Usuario:"
        ' 
        ' lbltelefono
        ' 
        lbltelefono.AutoSize = True
        lbltelefono.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbltelefono.Location = New Point(667, 359)
        lbltelefono.Name = "lbltelefono"
        lbltelefono.Size = New Size(64, 19)
        lbltelefono.TabIndex = 13
        lbltelefono.Text = "Teléfono:"
        ' 
        ' lblestadoactual
        ' 
        lblestadoactual.AutoSize = True
        lblestadoactual.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblestadoactual.Location = New Point(35, 412)
        lblestadoactual.Name = "lblestadoactual"
        lblestadoactual.Size = New Size(93, 19)
        lblestadoactual.TabIndex = 14
        lblestadoactual.Text = "Estado actual:"
        ' 
        ' rbtnnuevo
        ' 
        rbtnnuevo.AutoSize = True
        rbtnnuevo.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rbtnnuevo.Location = New Point(538, 412)
        rbtnnuevo.Name = "rbtnnuevo"
        rbtnnuevo.Size = New Size(68, 23)
        rbtnnuevo.TabIndex = 15
        rbtnnuevo.TabStop = True
        rbtnnuevo.Text = "Nuevo"
        rbtnnuevo.UseVisualStyleBackColor = True
        ' 
        ' rbtniniciado
        ' 
        rbtniniciado.AutoSize = True
        rbtniniciado.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rbtniniciado.Location = New Point(633, 412)
        rbtniniciado.Name = "rbtniniciado"
        rbtniniciado.Size = New Size(75, 23)
        rbtniniciado.TabIndex = 16
        rbtniniciado.TabStop = True
        rbtniniciado.Text = "Iniciado"
        rbtniniciado.UseVisualStyleBackColor = True
        ' 
        ' lblobservacion
        ' 
        lblobservacion.AutoSize = True
        lblobservacion.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblobservacion.Location = New Point(33, 461)
        lblobservacion.Name = "lblobservacion"
        lblobservacion.Size = New Size(80, 19)
        lblobservacion.TabIndex = 17
        lblobservacion.Text = "Obervación"
        ' 
        ' lblnuevoprocurador
        ' 
        lblnuevoprocurador.AutoSize = True
        lblnuevoprocurador.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblnuevoprocurador.Location = New Point(33, 592)
        lblnuevoprocurador.Name = "lblnuevoprocurador"
        lblnuevoprocurador.Size = New Size(125, 19)
        lblnuevoprocurador.TabIndex = 18
        lblnuevoprocurador.Text = "Nuevo procurador:"
        ' 
        ' txttelefono
        ' 
        txttelefono.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txttelefono.Location = New Point(728, 354)
        txttelefono.Name = "txttelefono"
        txttelefono.Size = New Size(148, 26)
        txttelefono.TabIndex = 19
        ' 
        ' txtestadoactual
        ' 
        txtestadoactual.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtestadoactual.Location = New Point(131, 409)
        txtestadoactual.Name = "txtestadoactual"
        txtestadoactual.Size = New Size(381, 26)
        txtestadoactual.TabIndex = 20
        ' 
        ' txtobservacion
        ' 
        txtobservacion.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtobservacion.Location = New Point(116, 461)
        txtobservacion.Multiline = True
        txtobservacion.Name = "txtobservacion"
        txtobservacion.Size = New Size(760, 112)
        txtobservacion.TabIndex = 21
        ' 
        ' txtnuevoprocurador
        ' 
        txtnuevoprocurador.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtnuevoprocurador.Location = New Point(160, 589)
        txtnuevoprocurador.Name = "txtnuevoprocurador"
        txtnuevoprocurador.Size = New Size(716, 26)
        txtnuevoprocurador.TabIndex = 22
        ' 
        ' btnnuevo
        ' 
        btnnuevo.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnnuevo.Location = New Point(306, 655)
        btnnuevo.Name = "btnnuevo"
        btnnuevo.Size = New Size(84, 37)
        btnnuevo.TabIndex = 23
        btnnuevo.Text = "Nuevo"
        btnnuevo.UseVisualStyleBackColor = True
        ' 
        ' btnguardar
        ' 
        btnguardar.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnguardar.Location = New Point(411, 655)
        btnguardar.Name = "btnguardar"
        btnguardar.Size = New Size(78, 37)
        btnguardar.TabIndex = 24
        btnguardar.Text = "Guardar"
        btnguardar.UseVisualStyleBackColor = True
        ' 
        ' btnsalir
        ' 
        btnsalir.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnsalir.Location = New Point(517, 655)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(89, 37)
        btnsalir.TabIndex = 25
        btnsalir.Text = "Salir"
        btnsalir.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Familia", "Civil", "Administrativo"})
        ComboBox2.Location = New Point(95, 355)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(149, 27)
        ComboBox2.TabIndex = 26
        ComboBox2.Text = "Seleccione"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(306, 355)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(361, 27)
        ComboBox3.TabIndex = 27
        ComboBox3.Text = "Seleccione"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(899, 736)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(btnsalir)
        Controls.Add(btnguardar)
        Controls.Add(btnnuevo)
        Controls.Add(txtnuevoprocurador)
        Controls.Add(txtobservacion)
        Controls.Add(txtestadoactual)
        Controls.Add(txttelefono)
        Controls.Add(lblnuevoprocurador)
        Controls.Add(lblobservacion)
        Controls.Add(rbtniniciado)
        Controls.Add(rbtnnuevo)
        Controls.Add(lblestadoactual)
        Controls.Add(lbltelefono)
        Controls.Add(lblusuario)
        Controls.Add(lblmateria)
        Controls.Add(ComboBox1)
        Controls.Add(txtnumeroexpediente)
        Controls.Add(txtcaso)
        Controls.Add(txtnumerojuez)
        Controls.Add(lblcaso)
        Controls.Add(lblexpediente)
        Controls.Add(lbljuez)
        Controls.Add(lblprocuradorquedelega)
        Controls.Add(lbltitulo2)
        Controls.Add(lbltitulo1)
        Controls.Add(PictureBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbltitulo1 As Label
    Friend WithEvents lbltitulo2 As Label
    Friend WithEvents lblprocuradorquedelega As Label
    Friend WithEvents lbljuez As Label
    Friend WithEvents lblexpediente As Label
    Friend WithEvents lblcaso As Label
    Friend WithEvents txtnumerojuez As TextBox
    Friend WithEvents txtcaso As TextBox
    Friend WithEvents txtnumeroexpediente As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblmateria As Label
    Friend WithEvents lblusuario As Label
    Friend WithEvents lbltelefono As Label
    Friend WithEvents lblestadoactual As Label
    Friend WithEvents rbtnnuevo As RadioButton
    Friend WithEvents rbtniniciado As RadioButton
    Friend WithEvents lblobservacion As Label
    Friend WithEvents lblnuevoprocurador As Label
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtestadoactual As TextBox
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents txtnuevoprocurador As TextBox
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
End Class
