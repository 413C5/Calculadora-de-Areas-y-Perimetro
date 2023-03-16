Public Class frmPrincipal
    'Metodos
    Private Sub mostrarDatos(ByVal n As Integer)
        Limpiar()
        If n >= 2 Then
            labDato2.Visible = True
            txtDato2.Visible = True
        Else
            labDato2.Visible = False
            txtDato2.Visible = False
        End If
        If n >= 3 Then
            labDato3.Visible = True
            txtDato3.Visible = True
        Else
            labDato3.Visible = False
            txtDato3.Visible = False
        End If
        If n >= 4 Then
            labDato4.Visible = True
            txtDato4.Visible = True
        Else
            labDato4.Visible = False
            txtDato4.Visible = False
        End If
    End Sub

    Private Sub mostrarFiguras(ByVal indice As Integer)
        Select Case indice
            'Cuadrado
            Case 0
                picFigura.Image = My.Resources.cuadrado
                labDato1.Text = "Lado:"
                mostrarDatos(1)

            'Rectangulo
            Case 1
                picFigura.Image = My.Resources.rectangulo
                labDato1.Text = "Base:"
                labDato2.Text = "Altura:"
                mostrarDatos(2)

            'Triangulo
            Case 2
                picFigura.Image = My.Resources.triangulo
                labDato1.Text = "Base:"
                labDato2.Text = "Altura:"
                mostrarDatos(2)

            'Rombo
            Case 3
                picFigura.Image = My.Resources.rombo
                labDato1.Text = "Lado:"
                labDato2.Text = "Diagonal mayor:"
                labDato3.Text = "Diagonal menor:"
                mostrarDatos(3)

            'Pentagono
            Case 4
                picFigura.Image = My.Resources.pentagono
                labDato1.Text = "Lado:"
                labDato2.Text = "Apotema:"
                mostrarDatos(2)

            'Hexagono
            Case 5
                picFigura.Image = My.Resources.hexagono
                labDato1.Text = "Lado:"
                labDato2.Text = "Apotema:"
                mostrarDatos(2)

            'Circulo
            Case 6
                picFigura.Image = My.Resources.circulo
                labDato1.Text = "Radio:"
                mostrarDatos(1)

            'Trapecio
            Case 7
                picFigura.Image = My.Resources.trapecio
                labDato1.Text = "Lado:"
                labDato2.Text = "Base mayor:"
                labDato3.Text = "Base menor:"
                labDato4.Text = "Altura:"
                mostrarDatos(4)

            'Paralelogramo
            Case 8
                picFigura.Image = My.Resources.paralelogramo
                labDato1.Text = "Lado:"
                labDato2.Text = "Base:"
                labDato3.Text = "Altura:"
                mostrarDatos(3)
        End Select
    End Sub

    Private Sub Calcular(ByVal indice As Integer)
        Dim lado, base, altura, diagonalMayor, diagonalMenor, apotema, radio, baseMayor,
            ladoA, ladoB, baseMenor, perimetro, area As Double
        Try
            Select Case indice
                'Cuadrado
                Case 0
                    lado = Double.Parse(txtDato1.Text)
                    perimetro = lado * 4
                    area = lado * lado

                'Rectangulo
                Case 1
                    base = Double.Parse(txtDato1.Text)
                    altura = Double.Parse(txtDato2.Text)
                    perimetro = (base * 2) + (altura * 2)
                    area = base * altura

                'Triangulo
                Case 2
                    base = Double.Parse(txtDato1.Text)
                    altura = Double.Parse(txtDato2.Text)
                    perimetro = (base * 3)
                    area = (base * altura) / 2

                'Rombo
                Case 3
                    lado = Double.Parse(txtDato1.Text)
                    diagonalMayor = Double.Parse(txtDato2.Text)
                    diagonalMenor = Double.Parse(txtDato3.Text)
                    perimetro = lado * 4
                    area = (diagonalMayor * diagonalMenor) / 2

                'Pentagono
                Case 4
                    lado = Double.Parse(txtDato1.Text)
                    apotema = Double.Parse(txtDato2.Text)
                    perimetro = lado * 5
                    area = (perimetro * apotema) / 2


                'Hexagono
                Case 5
                    lado = Double.Parse(txtDato1.Text)
                    apotema = Double.Parse(txtDato2.Text)
                    perimetro = lado * 6
                    area = (perimetro * apotema) / 2

                'Circulo
                Case 6
                    radio = Double.Parse(txtDato1.Text)
                    perimetro = (Math.Pow(radio, 2)) * Math.PI
                    area = (2 * Math.PI) * radio

                'Trapecio
                Case 7
                    lado = Double.Parse(txtDato1.Text)
                    baseMayor = Double.Parse(txtDato2.Text)
                    baseMenor = Double.Parse(txtDato3.Text)
                    altura = Double.Parse(txtDato4.Text)
                    perimetro = baseMayor + baseMenor + (lado * 2)
                    area = ((baseMayor + baseMenor) * altura) / 2

                'Paralelogramo
                Case 8
                    ladoA = Double.Parse(txtDato1.Text)
                    ladoB = Double.Parse(txtDato2.Text)
                    altura = Double.Parse(txtDato3.Text)
                    perimetro = 2 * (ladoA + ladoB)
                    area = ladoB * altura
            End Select
            labPerimetro.Text = "Perimetro = " + perimetro.ToString("N")
            labArea.Text = "Area = " + area.ToString("N")
        Catch ex As Exception
            MsgBox("Datos de entrada invalidos!!. Corrijalos", Title:="Figuras")
        End Try
    End Sub

    Private Sub Limpiar()
        txtDato1.Clear()
        txtDato2.Clear()
        txtDato3.Clear()
        txtDato4.Clear()
        labPerimetro.Text = ""
        labArea.Text = ""
        txtDato1.Select()
    End Sub

    'Eventos
    Private Sub cmbFiguras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiguras.SelectedIndexChanged
        mostrarFiguras(cmbFiguras.SelectedIndex)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFiguras.SelectedIndex = 0
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Calcular(cmbFiguras.SelectedIndex)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
End Class
