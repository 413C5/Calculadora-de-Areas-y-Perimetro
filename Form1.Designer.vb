<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.cmbFiguras = New System.Windows.Forms.ComboBox()
        Me.picFigura = New System.Windows.Forms.PictureBox()
        Me.labDato1 = New System.Windows.Forms.Label()
        Me.labDato2 = New System.Windows.Forms.Label()
        Me.txtDato1 = New System.Windows.Forms.TextBox()
        Me.txtDato2 = New System.Windows.Forms.TextBox()
        Me.labDato3 = New System.Windows.Forms.Label()
        Me.txtDato3 = New System.Windows.Forms.TextBox()
        Me.labPerimetro = New System.Windows.Forms.Label()
        Me.labArea = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtDato4 = New System.Windows.Forms.TextBox()
        Me.labDato4 = New System.Windows.Forms.Label()
        CType(Me.picFigura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbFiguras
        '
        Me.cmbFiguras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiguras.FormattingEnabled = True
        Me.cmbFiguras.Items.AddRange(New Object() {"Cuadrado", "Rectangulo", "Triangulo", "Rombo", "Pentagono", "Hexagono", "Circulo", "Trapecio", "Paralelogramo"})
        Me.cmbFiguras.Location = New System.Drawing.Point(143, 12)
        Me.cmbFiguras.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFiguras.Name = "cmbFiguras"
        Me.cmbFiguras.Size = New System.Drawing.Size(160, 24)
        Me.cmbFiguras.TabIndex = 0
        '
        'picFigura
        '
        Me.picFigura.Location = New System.Drawing.Point(123, 46)
        Me.picFigura.Margin = New System.Windows.Forms.Padding(4)
        Me.picFigura.Name = "picFigura"
        Me.picFigura.Size = New System.Drawing.Size(212, 159)
        Me.picFigura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFigura.TabIndex = 1
        Me.picFigura.TabStop = False
        '
        'labDato1
        '
        Me.labDato1.Location = New System.Drawing.Point(101, 212)
        Me.labDato1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDato1.Name = "labDato1"
        Me.labDato1.Size = New System.Drawing.Size(120, 25)
        Me.labDato1.TabIndex = 1
        Me.labDato1.Text = "Label1"
        Me.labDato1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labDato2
        '
        Me.labDato2.Location = New System.Drawing.Point(101, 247)
        Me.labDato2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDato2.Name = "labDato2"
        Me.labDato2.Size = New System.Drawing.Size(120, 25)
        Me.labDato2.TabIndex = 3
        Me.labDato2.Text = "Label2"
        Me.labDato2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDato1
        '
        Me.txtDato1.Location = New System.Drawing.Point(229, 213)
        Me.txtDato1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDato1.Name = "txtDato1"
        Me.txtDato1.Size = New System.Drawing.Size(132, 22)
        Me.txtDato1.TabIndex = 2
        '
        'txtDato2
        '
        Me.txtDato2.Location = New System.Drawing.Point(229, 249)
        Me.txtDato2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDato2.Name = "txtDato2"
        Me.txtDato2.Size = New System.Drawing.Size(132, 22)
        Me.txtDato2.TabIndex = 4
        '
        'labDato3
        '
        Me.labDato3.Location = New System.Drawing.Point(101, 288)
        Me.labDato3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDato3.Name = "labDato3"
        Me.labDato3.Size = New System.Drawing.Size(120, 25)
        Me.labDato3.TabIndex = 5
        Me.labDato3.Text = "Label3"
        Me.labDato3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDato3
        '
        Me.txtDato3.Location = New System.Drawing.Point(229, 289)
        Me.txtDato3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDato3.Name = "txtDato3"
        Me.txtDato3.Size = New System.Drawing.Size(132, 22)
        Me.txtDato3.TabIndex = 6
        '
        'labPerimetro
        '
        Me.labPerimetro.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.labPerimetro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labPerimetro.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPerimetro.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labPerimetro.Location = New System.Drawing.Point(39, 375)
        Me.labPerimetro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPerimetro.Name = "labPerimetro"
        Me.labPerimetro.Size = New System.Drawing.Size(427, 45)
        Me.labPerimetro.TabIndex = 9
        Me.labPerimetro.Text = "Label5"
        Me.labPerimetro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labArea
        '
        Me.labArea.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.labArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labArea.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labArea.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labArea.Location = New System.Drawing.Point(39, 432)
        Me.labArea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labArea.Name = "labArea"
        Me.labArea.Size = New System.Drawing.Size(427, 45)
        Me.labArea.TabIndex = 10
        Me.labArea.Text = "Label6"
        Me.labArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(52, 495)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 28)
        Me.btnCalcular.TabIndex = 11
        Me.btnCalcular.Text = "&Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(196, 495)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 28)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(327, 495)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtDato4
        '
        Me.txtDato4.Location = New System.Drawing.Point(229, 335)
        Me.txtDato4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDato4.Name = "txtDato4"
        Me.txtDato4.Size = New System.Drawing.Size(132, 22)
        Me.txtDato4.TabIndex = 8
        '
        'labDato4
        '
        Me.labDato4.Location = New System.Drawing.Point(101, 334)
        Me.labDato4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDato4.Name = "labDato4"
        Me.labDato4.Size = New System.Drawing.Size(120, 25)
        Me.labDato4.TabIndex = 7
        Me.labDato4.Text = "Label4"
        Me.labDato4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(487, 580)
        Me.Controls.Add(Me.txtDato4)
        Me.Controls.Add(Me.labDato4)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.labArea)
        Me.Controls.Add(Me.labPerimetro)
        Me.Controls.Add(Me.txtDato3)
        Me.Controls.Add(Me.labDato3)
        Me.Controls.Add(Me.txtDato2)
        Me.Controls.Add(Me.txtDato1)
        Me.Controls.Add(Me.labDato2)
        Me.Controls.Add(Me.labDato1)
        Me.Controls.Add(Me.picFigura)
        Me.Controls.Add(Me.cmbFiguras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculo de Areas y Perimetros"
        CType(Me.picFigura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbFiguras As ComboBox
    Friend WithEvents picFigura As PictureBox
    Friend WithEvents labDato1 As Label
    Friend WithEvents labDato2 As Label
    Friend WithEvents txtDato1 As TextBox
    Friend WithEvents txtDato2 As TextBox
    Friend WithEvents labDato3 As Label
    Friend WithEvents txtDato3 As TextBox
    Friend WithEvents labPerimetro As Label
    Friend WithEvents labArea As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtDato4 As TextBox
    Friend WithEvents labDato4 As Label
End Class
