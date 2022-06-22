

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNudos.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblElementos.Click

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim nodos As Integer, elementos As Integer
        nodos = CInt(txtNudos.Text)
        elementos = CInt(txtElementos.Text)

        'MessageBox.Show(Str(nodos))

        'Formato de Data Grid View dgvNodos

        dgvNodos.RowCount = nodos

        'Enumerar los nudos
        For i = 1 To nodos
            dgvNodos.Rows(i - 1).Cells(0).Value = i
        Next

        'Manejo de unidades
        If optES.Checked = True Then
            dgvNodos.Columns(1).HeaderText = "X (ft)"
            dgvNodos.Columns(2).HeaderText = "Y (ft)"
        End If

        If optSI.Checked = True Then
            dgvNodos.Columns(1).HeaderText = "X (m)"
            dgvNodos.Columns(2).HeaderText = "Y (m)"
        End If

        'Formato de Data Grid View dgvElementos

        dgvElementos.RowCount = elementos

        If optES.Checked = True Then
            dgvElementos.Columns(3).HeaderText = "E (ksi)"
            dgvElementos.Columns(4).HeaderText = "A (in2)"
            dgvElementos.Columns(5).HeaderText = "Ine (in4)"
        End If

        If optSI.Checked = True Then
            dgvElementos.Columns(3).HeaderText = "E (GPa)"
            dgvElementos.Columns(4).HeaderText = "A (m2)"
            dgvElementos.Columns(5).HeaderText = "Ine (m4)"
        End If


        'Enumerar los nudos
        For i = 1 To elementos
            dgvElementos.Rows(i - 1).Cells(0).Value = i
        Next

        'Formato de Data Grid View para ingresar los apoyos
        Apoyos.dgvApoyos.RowCount = nodos


        'Loop en cada fila
        For Each row As DataGridViewRow In Apoyos.dgvApoyos.Rows
            'Referenciar la celda con combobox
            Dim comboBoxCell As DataGridViewComboBoxCell = CType(row.Cells(1), DataGridViewComboBoxCell)
            'Insertar el item por default del ComboBoxCell
            comboBoxCell.Items.Add("SI")
            comboBoxCell.Items.Add("NO")

            Dim comboBoxCell1 As DataGridViewComboBoxCell = CType(row.Cells(2), DataGridViewComboBoxCell)
            'Insertar el item por default del ComboBoxCell
            comboBoxCell1.Items.Add("SI")
            comboBoxCell1.Items.Add("NO")

            Dim comboBoxCell2 As DataGridViewComboBoxCell = CType(row.Cells(3), DataGridViewComboBoxCell)
            'Insertar el item por default del ComboBoxCell
            comboBoxCell2.Items.Add("SI")
            comboBoxCell2.Items.Add("NO")

        Next

        For i = 1 To nodos
            Apoyos.dgvApoyos.Rows(i - 1).Cells(0).Value = i
        Next

        If optES.Checked = True Then
            frmCargasNodos.dgvCargasNodos.Columns(1).HeaderText = "Px (kips)"
            frmCargasNodos.dgvCargasNodos.Columns(2).HeaderText = "Py (kips)"
            frmCargasNodos.dgvCargasNodos.Columns(3).HeaderText = "M (kips-ft)"
        End If

        If optSI.Checked = True Then
            frmCargasNodos.dgvCargasNodos.Columns(1).HeaderText = "Px (KN)"
            frmCargasNodos.dgvCargasNodos.Columns(2).HeaderText = "Py (kKN)"
            frmCargasNodos.dgvCargasNodos.Columns(3).HeaderText = "M (KN-m)"
        End If

        'Formato de DataGridView en formulario Cargas Puntuales
        frmCargasNodos.dgvCargasNodos.RowCount = nodos
        'Enumerar los nodos
        For i = 1 To nodos
            frmCargasNodos.dgvCargasNodos.Rows(i - 1).Cells(0).Value = i
        Next

        'Formato de DataGridView en formulario Cargas en Elementos
        frmCargasElementos.dgvCargasElem.RowCount = elementos
        'Enumerar los elementos
        For i = 1 To elementos
            frmCargasElementos.dgvCargasElem.Rows(i - 1).Cells(0).Value = i
        Next

        If optES.Checked = True Then
            frmCargasElementos.dgvCargasElem.Columns(1).HeaderText = "w (kips/ft)"
            frmCargasElementos.dgvCargasElem.Columns(2).HeaderText = "P (kips)"
            frmCargasElementos.dgvCargasElem.Columns(3).HeaderText = "a (ft)"
            frmCargasElementos.dgvCargasElem.Columns(4).HeaderText = "b (ft)"

        End If

        If optSI.Checked = True Then
            frmCargasElementos.dgvCargasElem.Columns(1).HeaderText = "w (KN/m)"
            frmCargasElementos.dgvCargasElem.Columns(2).HeaderText = "P (KN)"
            frmCargasElementos.dgvCargasElem.Columns(3).HeaderText = "a (m)"
            frmCargasElementos.dgvCargasElem.Columns(4).HeaderText = "b (m)"

        End If


        'Encender los elementos del formulario que estaban apagados inicialmente
        btnCalcular.Enabled = True
        btnApoyos.Enabled = True
        btnCargasNodos.Enabled = True
        btnCargasElem.Enabled = True
        dgvElementos.Enabled = True
        dgvNodos.Enabled = True




    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Lectura de datos de Nudos
        Dim nodos As Integer, elementos As Integer, modE() As Double
        Dim X() As Double, Y() As Double
        Dim Ni() As Integer, Nj() As Integer, A() As Double, Ine() As Double
        Dim L() As Double, C() As Double, S() As Double
        Dim F() As Object, D() As Object, SP() As Object
        Dim P() As Double, K(,) As Double
        Dim i As Integer, factor As Double
        nodos = CInt(txtNudos.Text)
        elementos = CInt(txtElementos.Text)
        ReDim X(nodos), Y(nodos)
        For i = 1 To nodos
            If optES.Checked = True Then
                factor = 12
            End If
            If optSI.Checked = True Then
                factor = 1
            End If
            X(i) = dgvNodos.Rows(i - 1).Cells(1).Value * factor
            Y(i) = dgvNodos.Rows(i - 1).Cells(2).Value * factor
        Next
        ReDim Ni(elementos), Nj(elementos), A(elementos), Ine(elementos), modE(elementos)
        For i = 1 To elementos
            Ni(i) = dgvElementos.Rows(i - 1).Cells(1).Value
            Nj(i) = dgvElementos.Rows(i - 1).Cells(2).Value
            If optES.Checked = True Then
                modE(i) = dgvElementos.Rows(i - 1).Cells(3).Value
            End If
            If optSI.Checked = True Then
                modE(i) = dgvElementos.Rows(i - 1).Cells(3).Value * 1000000000 / 1000
            End If
            'modE(i) = dgvElementos.Rows(i - 1).Cells(3).Value
            A(i) = dgvElementos.Rows(i - 1).Cells(4).Value
            Ine(i) = dgvElementos.Rows(i - 1).Cells(5).Value
        Next

        'Calcular Longitud, Coseno y Seno de los Elementos
        ReDim L(elementos), C(elementos), S(elementos)
        For i = 1 To elementos
            L(i) = ((Y(Nj(i)) - Y(Ni(i))) ^ 2 + (X(Nj(i)) - X(Ni(i))) ^ 2) ^ 0.5
            Console.WriteLine("L" + Str(i) + "= " + Str(L(i)))
            S(i) = (Y(Nj(i)) - Y(Ni(i))) / ((Y(Nj(i)) - Y(Ni(i))) ^ 2 + (X(Nj(i)) - X(Ni(i))) ^ 2) ^ 0.5
            C(i) = (X(Nj(i)) - X(Ni(i))) / ((Y(Nj(i)) - Y(Ni(i))) ^ 2 + (X(Nj(i)) - X(Ni(i))) ^ 2) ^ 0.5
        Next


        'Impresion en Consola de L, C y S
        For i = 1 To elementos
            Console.WriteLine("L(" + Str(i) + ") =" + Str(L(i)))
            Console.WriteLine("C(" + Str(i) + ") =" + Str(C(i)))
            Console.WriteLine("S(" + Str(i) + ") =" + Str(S(i)))
        Next

        'Calcular Matriz de Rigidez Global de la Estructura
        ReDim K(3 * nodos, 3 * nodos)
        For i = 1 To elementos
            Console.WriteLine("ELEMENTO " + Str(i))
            'Fila 1
            K(3 * Ni(i) - 2, 3 * Ni(i) - 2) += A(i) * modE(i) / L(i) * C(i) ^ 2 + 12 * modE(i) * Ine(i) / L(i) ^ 3 * S(i) ^ 2
            K(3 * Ni(i) - 2, 3 * Ni(i) - 1) += (A(i) * modE(i) / L(i) - 12 * modE(i) * Ine(i) / L(i) ^ 3) * C(i) * S(i)
            K(3 * Ni(i) - 2, 3 * Ni(i)) += -6 * modE(i) * Ine(i) / L(i) ^ 2 * S(i)
            Console.WriteLine("linea 1,3")
            Console.WriteLine(Str(K(3 * Ni(i) - 2, 3 * Ni(i))))
            K(3 * Ni(i) - 2, 3 * Nj(i) - 2) += -(A(i) * modE(i) / L(i) * C(i) ^ 2 + 12 * modE(i) * Ine(i) / L(i) ^ 3 * S(i) ^ 2)
            K(3 * Ni(i) - 2, 3 * Nj(i) - 1) += -(A(i) * modE(i) / L(i) - 12 * modE(i) * Ine(i) / L(i) ^ 3) * C(i) * S(i)
            K(3 * Ni(i) - 2, 3 * Nj(i)) += -6 * modE(i) * Ine(i) / L(i) ^ 2 * S(i)
            'Fila 2
            K(3 * Ni(i) - 1, 3 * Ni(i) - 2) += (A(i) * modE(i) / L(i) - 12 * modE(i) * Ine(i) / L(i) ^ 3) * S(i) * C(i)
            K(3 * Ni(i) - 1, 3 * Ni(i) - 1) += A(i) * modE(i) / L(i) * S(i) ^ 2 + 12 * modE(i) * Ine(i) / L(i) ^ 3 * C(i) ^ 2
            K(3 * Ni(i) - 1, 3 * Ni(i)) += 6 * modE(i) * Ine(i) / L(i) ^ 2 * C(i)
            K(3 * Ni(i) - 1, 3 * Nj(i) - 2) += -(A(i) * modE(i) / L(i) - 12 * modE(i) * Ine(i) / L(i) ^ 3) * C(i) * S(i)
            K(3 * Ni(i) - 1, 3 * Nj(i) - 1) += -(A(i) * modE(i) / L(i) * S(i) ^ 2 + 12 * modE(i) * Ine(i) / L(i) ^ 3 * C(i) ^ 2)
            K(3 * Ni(i) - 1, 3 * Nj(i)) += 6 * modE(i) * Ine(i) / L(i) ^ 2 * C(i)
            ' Fila 3
            K(3 * Ni(i), 3 * Ni(i) - 2) += -6 * modE(i) * Ine(i) / L(i) ^ 2 * S(i)
            K(3 * Ni(i), 3 * Ni(i) - 1) += 6 * modE(i) * Ine(i) / L(i) ^ 2 * C(i)
            K(3 * Ni(i), 3 * Ni(i)) += 4 * modE(i) * Ine(i) / L(i)
            K(3 * Ni(i), 3 * Nj(i) - 2) += 6 * modE(i) * Ine(i) / L(i) ^ 2 * S(i)
            K(3 * Ni(i), 3 * Nj(i) - 1) += -6 * modE(i) * Ine(i) / L(i) ^ 2 * C(i)
            K(3 * Ni(i), 3 * Nj(i)) += 2 * modE(i) * Ine(i) / L(i)
            'Fila 4
            K(3 * Nj(i) - 2, 3 * Ni(i) - 2) += -(modE(i) * A(i) / L(i) * C(i) ^ 2 + 12 * modE(i) * Ine(i) / L(i) ^ 3 * S(i) ^ 2)
            K(3 * Nj(i) - 2, 3 * Ni(i) - 1) += -(modE(i) * A(i) / L(i) - 12 * modE(i) * Ine(i) / L(i) ^ 3) * C(i) * S(i)
            K(3 * Nj(i) - 2, 3 * Ni(i)) += 6 * modE(i) * Ine(i) / L(i) ^ 2 * S(i)
            K(3 * Nj(i) - 2, 3 * Nj(i) - 2) += modE(i) * A(i) / L(i) * C(i) ^ 2 + 12 * modE(i) * Ine(i) / L(i) ^ 3 * S(i) ^ 2
            K(3 * Nj(i) - 2, 3 * Nj(i) - 1) += (modE(i) * A(i) / L(i) - 12 * modE(i) * Ine(i) / L(i) ^ 3) * C(i) * S(i)
            K(3 * Nj(i) - 2, 3 * Nj(i)) += 6 * modE(i) * Ine(i) / L(i) ^ 2 * S(i)
            Console.WriteLine("linea 4,6")
            Console.WriteLine(Str(K(3 * Nj(i) - 2, 3 * Nj(i))))
            'Fila 5
            K(3 * Nj(i) - 1, 3 * Ni(i) - 2) += -(modE(i) * A(i) / L(i) - 12 * modE(i) * Ine(i) / L(i) ^ 3) * C(i) * S(i)

            K(3 * Nj(i) - 1, 3 * Ni(i) - 1) += -(modE(i) * A(i) / L(i) * S(i) ^ 2 + 12 * modE(i) * Ine(i) / L(i) ^ 3 * C(i) ^ 2)
            K(3 * Nj(i) - 1, 3 * Ni(i)) += -6 * modE(i) * Ine(i) / L(i) ^ 2 * C(i)
            K(3 * Nj(i) - 1, 3 * Nj(i) - 2) += (modE(i) * A(i) / L(i) - 12 * modE(i) * Ine(i) / L(i) ^ 3) * C(i) * S(i)
            K(3 * Nj(i) - 1, 3 * Nj(i) - 1) += modE(i) * A(i) / L(i) * S(i) ^ 2 + 12 * modE(i) * Ine(i) / L(i) ^ 3 * C(i) ^ 2
            K(3 * Nj(i) - 1, 3 * Nj(i)) += -6 * modE(i) * Ine(i) / L(i) ^ 2 * C(i)
            'Fila 6
            K(3 * Nj(i), 3 * Ni(i) - 2) += -6 * modE(i) * Ine(i) / L(i) ^ 2 * S(i)
            K(3 * Nj(i), 3 * Ni(i) - 1) += 6 * modE(i) * Ine(i) / L(i) ^ 2 * C(i)
            K(3 * Nj(i), 3 * Ni(i)) += 2 * modE(i) * Ine(i) / L(i)
            K(3 * Nj(i), 3 * Nj(i) - 2) += 6 * modE(i) * Ine(i) / L(i) ^ 2 * S(i)
            K(3 * Nj(i), 3 * Nj(i) - 1) += -6 * modE(i) * Ine(i) / L(i) ^ 2 * C(i)
            K(3 * Nj(i), 3 * Nj(i)) += 4 * modE(i) * Ine(i) / L(i)

        Next

        'Impresion en Consola de la Matriz de Rigidez Global de la Estructura
        For i = 1 To 3 * nodos
            For j = 1 To 3 * nodos
                If IsNothing(K(i, j)) = False Then
                    Console.WriteLine("K(" + Str(i) + "," + Str(j) + " = " + Str(K(i, j)))
                End If

            Next
        Next

        'End


        'Construccion de los Vectores Fuerza {F} y Desplazamientos {D}
        ReDim F(3 * nodos), D(3 * nodos)
        For i = 1 To nodos
            'Grado de Libertad en X
            If Apoyos.dgvApoyos.Rows(i - 1).Cells(1).Value = "SI" Then
                F(3 * i - 2) = "Rx" & Str(i)
                D(3 * i - 2) = 0
            Else
                F(3 * i - 2) = 0
                D(3 * i - 2) = "UX" & Str(i)
            End If
            ' Grado de Libertad en Y
            If Apoyos.dgvApoyos.Rows(i - 1).Cells(2).Value = "SI" Then
                F(3 * i - 1) = "Ry" & Str(i)
                D(3 * i - 1) = 0
            Else
                F(3 * i - 1) = 0
                D(3 * i - 1) = "UY" & Str(i)
            End If
            ' Grado de Libertad de Rotacion
            If Apoyos.dgvApoyos.Rows(i - 1).Cells(3).Value = "SI" Then
                F(3 * i) = "M" & Str(i)
                D(3 * i) = 0
            Else
                F(3 * i) = 0
                D(3 * i) = "rot" & Str(i)
            End If
        Next

        'Impresion en Consola de los Vectores Fuerza y Desplazamiento
        For i = 1 To 3 * nodos
            If IsNumeric(F(i)) Then
                Console.WriteLine("F(" + Str(i) + ") =" + Str(F(i)))

            Else
                Console.WriteLine("F(" + Str(i) + ") =" + F(i))

            End If
            If IsNumeric(D(i)) Then
                Console.WriteLine("D(" + Str(i) + ") =" + Str(D(i)))
            Else
                Console.WriteLine("D(" + Str(i) + ") =" + D(i))
            End If

        Next

        'Cargas Aplicadas en los Nodos (Coordenadas Globales)
        ReDim P(3 * nodos)
        For i = 1 To nodos
            'Carga en X
            P(3 * i - 2) = CDbl(frmCargasNodos.dgvCargasNodos.Rows(i - 1).Cells(1).Value)
            'Carga en Y
            P(3 * i - 1) = CDbl(frmCargasNodos.dgvCargasNodos.Rows(i - 1).Cells(2).Value)
            'Momento
            P(3 * i) = CDbl(frmCargasNodos.dgvCargasNodos.Rows(i - 1).Cells(3).Value)
        Next

        'Impresion en Consola de las Cargas Aplicadas en los Nodos
        For i = 1 To 3 * nodos
            Console.WriteLine("P(" + Str(i) + ") =" + Str(P(i)))

        Next

        'Cargas Aplicadas en los Elementos
        ReDim SP(3 * nodos)

        Dim w As Double, cpunt As Double, distA As Double, distB As Double
        Dim VLocal(6) As Double, VGlobal(6) As Double, MTr(,) As Double
        For i = 1 To elementos
            ReDim VLocal(6), VGlobal(6), MTr(6, 6)
            If optES.Checked = True Then
                factor = 12
            End If
            If optSI.Checked = True Then
                factor = 1
            End If
            w = CDbl(frmCargasElementos.dgvCargasElem.Rows(i - 1).Cells(1).Value) / factor
            cpunt = CDbl(frmCargasElementos.dgvCargasElem.Rows(i - 1).Cells(2).Value)
            distA = CDbl(frmCargasElementos.dgvCargasElem.Rows(i - 1).Cells(3).Value) * factor
            distB = CDbl(frmCargasElementos.dgvCargasElem.Rows(i - 1).Cells(4).Value) * factor

            'Carga Distribuida
            'Valores en coordenadas locales
            'Nudo Inicial
            VLocal(1) += 0
            VLocal(2) += w * L(i) / 2
            VLocal(3) += w * L(i) ^ 2 / 12
            'Nudo Final
            VLocal(4) += 0
            VLocal(5) += w * L(i) / 2
            VLocal(6) += -w * L(i) ^ 2 / 12

            'Carga Puntual
            'Valores en coordenadas locales
            'Nudo Inicial
            VLocal(1) += 0
            VLocal(2) += cpunt * distB ^ 2 / L(i) ^ 2 * (3 - 2 * distB / L(i))
            VLocal(3) += cpunt * distA * distB ^ 2 / L(i) ^ 2
            'Nudo Final
            VLocal(4) += 0
            VLocal(5) += cpunt * distA ^ 2 / L(i) ^ 2 * (3 - 2 * distA / L(i))
            VLocal(6) += -cpunt * distA ^ 2 * distB / L(i) ^ 2

            'Transformar a coordenadas Globales
            'Fila 1
            MTr(1, 1) = C(i)
            MTr(1, 2) = -S(i)
            MTr(1, 3) = 0
            MTr(1, 4) = 0
            MTr(1, 5) = 0
            MTr(1, 6) = 0
            'Fila 2
            MTr(2, 1) = S(i)
            MTr(2, 2) = C(i)
            MTr(2, 3) = 0
            MTr(2, 4) = 0
            MTr(2, 5) = 0
            MTr(2, 6) = 0
            'Fila 3
            MTr(3, 1) = 0
            MTr(3, 2) = 0
            MTr(3, 3) = 1
            MTr(3, 4) = 0
            MTr(3, 5) = 0
            MTr(3, 6) = 0
            'Fila 4
            MTr(4, 1) = 0
            MTr(4, 2) = 0
            MTr(4, 3) = 0
            MTr(4, 4) = C(i)
            MTr(4, 5) = -S(i)
            MTr(4, 6) = 0
            'Fila 5
            MTr(5, 1) = 0
            MTr(5, 2) = 0
            MTr(5, 3) = 0
            MTr(5, 4) = S(i)
            MTr(5, 5) = C(i)
            MTr(5, 6) = 0
            'Fila 6
            MTr(6, 1) = 0
            MTr(6, 2) = 0
            MTr(6, 3) = 0
            MTr(6, 4) = 0
            MTr(6, 5) = 0
            MTr(6, 6) = 1
            VGlobal = MultMatriz(MTr, VLocal)

            'Agregar los valores en coordenadas globales al vector Soluacion Particular
            SP(3 * Ni(i) - 2) += VGlobal(1)
            SP(3 * Ni(i) - 1) += VGlobal(2)
            SP(3 * Ni(i)) += VGlobal(3)
            SP(3 * Nj(i) - 2) += VGlobal(4)
            SP(3 * Nj(i) - 1) += VGlobal(5)
            SP(3 * Nj(i)) += VGlobal(6)

        Next

        'Impresion en Consola del Vector de la Sol. Particular
        For i = 1 To 3 * nodos
            Console.WriteLine("SP(" + Str(i) + ") =" + Str(SP(i)))

        Next


        'Solucion del Metodo de Rigidez
        'Cantidad incognitas en el vector desplazamientos
        incognitasDesp = cantIncognitas(D, nodos)
        incognitasFuerza = cantIncognitas(F, nodos)
        Console.WriteLine(incognitasDesp)

        Dim Pos As Integer() = posIncognitas(D, nodos, incognitasDesp)
        Dim Posf As Integer() = posIncognitas(F, nodos, incognitasFuerza)

        'Prueba de valores de incognitas
        Console.WriteLine("Prueba de posiciones de incognitas")
        For i = 1 To incognitasDesp
            Console.WriteLine(Pos(i))
        Next

        'Subdividir el sistema matricial en submatrices para resolver las ecuaciones
        'Submatriz [KFF]
        Dim KFF(incognitasDesp, incognitasDesp) As Double
        For i = 1 To incognitasDesp
            For j = 1 To incognitasDesp
                KFF(i, j) = K(Pos(i), Pos(j))

            Next
        Next

        'Imprimir en consola la submatriz KFF
        For i = 1 To incognitasDesp
            For j = 1 To incognitasDesp
                Console.WriteLine("KFF")
                Console.WriteLine(Str(i) + "," + Str(j) + "= " + Str(KFF(i, j)))
            Next
        Next

        'Submatriz [KSF]
        Dim KSF(incognitasFuerza, incognitasDesp) As Double
        For i = 1 To incognitasFuerza
            For j = 1 To incognitasDesp
                KSF(i, j) = K(Posf(i), Pos(j))
            Next
        Next

        'Imprimir en consola submatriz KSF
        For i = 1 To incognitasFuerza
            For j = 1 To incognitasDesp
                Console.WriteLine("KsF")
                Console.WriteLine(Str(i) + "," + Str(j) + "= " + Str(KSF(i, j)))
            Next
        Next

        'Subvectores {FF}, {PF} Y {SPF}
        Dim FF(incognitasDesp) As Double, SPF(incognitasDesp) As Double, PF(incognitasDesp) As Double
        For i = 1 To incognitasDesp
            FF(i) = F(Pos(i))
            PF(i) = P(Pos(i))
            SPF(i) = SP(Pos(i))
        Next

        'Subvectores {FS}, {PS}, y {SPS}
        Dim FS(incognitasFuerza) As Double, SPS(incognitasFuerza) As Double, PS(incognitasFuerza)
        For i = 1 To incognitasFuerza
            'FS(i) = F(Posf(i))
            PS(i) = P(Posf(i))
            SPS(i) = SP(Posf(i))
        Next

        'Solucion del Sistema de Ecuaciones para determinar los desplazamientos desconocidos
        Dim FC(incognitasDesp) As Double
        Console.WriteLine("Vector FC")
        For i = 1 To incognitasDesp
            FC(i) = FF(i) + PF(i) - SPF(i)
            Console.WriteLine(Str(FC(i)))
        Next

        'Matriz Aumentada para metodo de GAUSS
        ReDim aa(incognitasDesp, incognitasDesp + 1)

        For i = 1 To incognitasDesp
            For j = 1 To incognitasDesp
                aa(i, j) = KFF(i, j)
            Next
            aa(i, incognitasDesp + 1) = FC(i)
        Next

        For i = 1 To incognitasDesp
            For j = 1 To incognitasDesp + 1

                Console.WriteLine(Str(i) + "," + Str(j) + "= " + Str(aa(i, j)))
            Next
        Next
        Dim Q() As Double, SOLUCION As String
        ReDim Q(incognitasDesp)
        Call GAUSS(incognitasDesp, aa, Q, SOLUCION)

        For i = 1 To incognitasDesp
            Console.WriteLine("SOLUCION = " + SOLUCION)
            Console.WriteLine(Q(i))
        Next

        'Impresion de los desplazamientos calculados
        frmResultados.dgvDesplaz.RowCount = incognitasDesp

        'Encabezados
        Dim singleChar As Char
        For i = 1 To incognitasDesp
            frmResultados.dgvDesplaz.Rows(i - 1).Cells(0).Value = D(Pos(i))
            singleChar = D(Pos(i)).Chars(0)
            Console.WriteLine(singleChar)
            If singleChar = "U" Then
                If optES.Checked = True Then
                    frmResultados.dgvDesplaz.Rows(i - 1).Cells(1).Value = Str(System.Math.Round(Q(i), 5)) + " in"
                End If
                If optSI.Checked = True Then
                    frmResultados.dgvDesplaz.Rows(i - 1).Cells(1).Value = Str(System.Math.Round(Q(i) * 1000, 5)) + " mm"
                End If

            End If
            If singleChar = "r" Then
                frmResultados.dgvDesplaz.Rows(i - 1).Cells(1).Value = Str(System.Math.Round(Q(i), 5)) + " rad"
            End If


        Next

        'Calculo de las Reacciones a partir de los desplazamientos
        Dim FT(incognitasFuerza) As Double
        Console.WriteLine(Q.GetLength(0))
        Console.WriteLine(KSF.Length)
        FT = MultMatriz(KSF, Q)

        For i = 1 To incognitasFuerza
            FS(i) = FT(i) + SPS(i) - PS(i)
        Next
        'Impresion de las reacciones calculadas
        frmResultados.dgvReaccion.RowCount = incognitasFuerza
        Dim primerChar As Char
        For i = 1 To incognitasFuerza
            'Impresion con las unidades para cada tipo de reaccion
            frmResultados.dgvReaccion.Rows(i - 1).Cells(0).Value = F(Posf(i))
            primerChar = F(Posf(i)).Chars(0)
            If primerChar = "R" Then
                If optSI.Checked = True Then
                    frmResultados.dgvReaccion.Rows(i - 1).Cells(1).Value = Str(Math.Round(FS(i), 2)) + " KN"
                End If
                If optES.Checked = True Then
                    frmResultados.dgvReaccion.Rows(i - 1).Cells(1).Value = Str(Math.Round(FS(i), 2)) + "kips"
                End If
            End If
            If primerChar = "M" Then
                If optSI.Checked = True Then
                    frmResultados.dgvReaccion.Rows(i - 1).Cells(1).Value = Str(Math.Round(FS(i), 2)) + " KN-m"
                End If
                If optES.Checked = True Then
                    frmResultados.dgvReaccion.Rows(i - 1).Cells(1).Value = Str(Math.Round(FS(i) / 12, 2)) + "kips-ft"
                End If
            End If


        Next

        'Reemplazar las incognitas en un nuevo vector de desplazamientos
        Dim DN(3 * nodos) As Double
        For i = 1 To incognitasDesp
            DN(Pos(i)) = Q(i)
        Next

        'Reemplazar las reacciones calculadas en el vector de fuerzas
        Dim FN(3 * nodos) As Double
        For i = 1 To incognitasFuerza
            FN(Posf(i)) = FS(i)
        Next

        'Calcular las fuerzas en los extremos de los elementos en coordenadas locales
        Dim TGL(,) As Double, DG() As Double, DL() As Double
        Dim KL(,) As Double, FL() As Double
        frmResultados.dgvFuerzas.RowCount = elementos
        For elem = 1 To elementos
            ReDim TGL(6, 6)
            For i = 1 To 6
                For j = 1 To 6
                    TGL(i, j) = 0
                Next
            Next

            'Nudo Inicial
            TGL(1, 1) = C(elem)
            TGL(1, 2) = S(elem)
            TGL(2, 1) = -S(elem)
            TGL(2, 2) = C(elem)
            TGL(3, 3) = 1
            'Nudo Final
            TGL(4, 4) = C(elem)
            TGL(4, 5) = S(elem)
            TGL(5, 4) = -S(elem)
            TGL(5, 5) = C(elem)
            TGL(6, 6) = 1

            'Transformar los desplazamientos en fuerzas en los extremos
            ReDim DG(6)
            'Nudo Inicial
            DG(1) = DN(3 * Ni(elem) - 2)
            DG(2) = DN(3 * Ni(elem) - 1)
            DG(3) = DN(3 * Ni(elem))
            'Nudo Final
            DG(4) = DN(3 * Nj(elem) - 2)
            DG(5) = DN(3 * Nj(elem) - 1)
            DG(6) = DN(3 * Nj(elem))

            ReDim DL(6)
            DL = MultMatriz(TGL, DG)
            Console.WriteLine("Vector DL")
            Console.WriteLine(Str(DL.GetLength(0)))

            'Matriz de Rigidez de cada elemento en coordenadas locales
            ReDim KL(6, 6)
            'Fila 1
            KL(1, 1) = modE(elem) * A(elem) / L(elem)
            KL(1, 2) = 0
            KL(1, 3) = 0
            KL(1, 4) = -modE(elem) * A(elem) / L(elem)
            KL(1, 5) = 0
            KL(1, 6) = 0
            'Fila 2
            KL(2, 1) = 0
            KL(2, 2) = 12 * modE(elem) * Ine(elem) / L(elem)
            KL(2, 3) = 6 * modE(elem) * Ine(elem) / L(elem) ^ 2
            KL(2, 4) = 0
            KL(2, 5) = -12 * modE(elem) * Ine(elem) / L(elem)
            KL(2, 6) = 6 * modE(elem) * Ine(elem) / L(elem) ^ 2
            'Fila 3
            KL(3, 1) = 0
            KL(3, 2) = 6 * modE(elem) * Ine(elem) / L(elem) ^ 2
            KL(3, 3) = 4 * modE(elem) * Ine(elem) / L(elem)
            KL(3, 4) = 0
            KL(3, 5) = -6 * modE(elem) * Ine(elem) / L(elem) ^ 2
            KL(3, 6) = 2 * modE(elem) * Ine(elem) / L(elem)
            'Fila 4
            KL(4, 1) = -modE(elem) * A(elem) / L(elem)
            KL(4, 2) = 0
            KL(4, 3) = 0
            KL(4, 4) = modE(elem) * A(elem) / L(elem)
            KL(4, 5) = 0
            KL(4, 6) = 0
            'Fila 5
            KL(5, 1) = 0
            KL(5, 2) = -12 * modE(elem) * Ine(elem) / L(elem)
            KL(5, 3) = -6 * modE(elem) * Ine(elem) / L(elem) ^ 2
            KL(5, 4) = 0
            KL(5, 5) = 12 * modE(elem) * Ine(elem) / L(elem)
            KL(5, 6) = -6 * modE(elem) * Ine(elem) / L(elem) ^ 2
            'Fila 6
            KL(6, 1) = 0
            KL(6, 2) = 6 * modE(elem) * Ine(elem) / L(elem) ^ 2
            KL(6, 3) = 2 * modE(elem) * Ine(elem) / L(elem)
            KL(6, 4) = 0
            KL(6, 5) = -6 * modE(elem) * Ine(elem) / L(elem) ^ 2
            KL(6, 6) = 4 * modE(elem) * Ine(elem) / L(elem)

            'Multiplicacion
            FL = MultMatriz(KL, DL)

            'Agregar efecto de la solucion particular en coordenadas globales
            ReDim VLocal(6), VGlobal(6)
            If optES.Checked = True Then
                factor = 12
            End If
            If optSI.Checked = True Then
                factor = 1
            End If
            w = CDbl(frmCargasElementos.dgvCargasElem.Rows(elem - 1).Cells(1).Value) / factor
            cpunt = CDbl(frmCargasElementos.dgvCargasElem.Rows(elem - 1).Cells(2).Value)
            distA = CDbl(frmCargasElementos.dgvCargasElem.Rows(elem - 1).Cells(3).Value) * factor
            distB = CDbl(frmCargasElementos.dgvCargasElem.Rows(elem - 1).Cells(4).Value) * factor

            'Carga Distribuida
            'Valores en coordenadas locales
            'Nudo Inicial
            VLocal(1) += 0
            VLocal(2) += w * L(elem) / 2
            VLocal(3) += w * L(elem) ^ 2 / 12
            'Nudo Final
            VLocal(4) += 0
            VLocal(5) += w * L(elem) / 2
            VLocal(6) += -w * L(elem) ^ 2 / 12

            'Carga Puntual
            'Valores en coordenadas locales
            'Nudo Inicial
            VLocal(1) += 0
            VLocal(2) += cpunt * distB ^ 2 / L(elem) ^ 2 * (3 - 2 * distB / L(elem))
            VLocal(3) += cpunt * distA * distB ^ 2 / L(elem) ^ 2
            'Nudo Final
            VLocal(4) += 0
            VLocal(5) += cpunt * distA ^ 2 / L(elem) ^ 2 * (3 - 2 * distA / L(elem))
            VLocal(6) += -cpunt * distA ^ 2 * distB / L(elem) ^ 2

            'Impresion de las Fuerzas en Coordenadas Locales
            For h = 1 To 6
                FL(h) += VLocal(h)
            Next

            frmResultados.dgvFuerzas.Rows(elem - 1).Cells(0).Value = Str(elem)
            If optSI.Checked = True Then
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(1).Value = Str(Math.Round(FL(1), 2)) + " KN"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(2).Value = Str(Math.Round(FL(2), 2)) + " KN"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(3).Value = Str(Math.Round(FL(3), 2)) + " KN-m"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(4).Value = Str(Math.Round(FL(4), 2)) + " KN"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(5).Value = Str(Math.Round(FL(5), 2)) + " KN"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(6).Value = Str(Math.Round(FL(6), 2)) + " KN-m"
            End If

            If optES.Checked = True Then
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(1).Value = Str(Math.Round(FL(1), 2)) + " kips"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(2).Value = Str(Math.Round(FL(2), 2)) + " kips"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(3).Value = Str(Math.Round(FL(3) / 12, 2)) + " kip-ft"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(4).Value = Str(Math.Round(FL(4), 2)) + " kips"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(5).Value = Str(Math.Round(FL(5), 2)) + " kips"
                frmResultados.dgvFuerzas.Rows(elem - 1).Cells(6).Value = Str(Math.Round(FL(6) / 12, 2)) + " kip-ft"
            End If









        Next




        'Activar boton de Resultados
        btnResultados.Enabled = True



    End Sub
    Private Function MultMatriz(T(,) As Double, G() As Double) As Double()
        Dim sumf As Double
        Dim Result() As Double
        ReDim Result(T.GetLength(0) - 1)
        For h = 1 To T.GetLength(0) - 1
            sumf = 0
            For j = 1 To G.GetLength(0) - 1
                Console.WriteLine(Str(h) + "," + Str(j))
                Console.WriteLine(Str(G(j)))
                sumf += T(h, j) * G(j)
            Next
            Result(h) = sumf
        Next
        Return Result
    End Function


    Private Function cantIncognitas(ByRef V() As Object, nn As Integer) As Integer
        Dim xi As Integer
        xi = 0
        For i = 1 To 3 * nn
            If IsNumeric(V(i)) = False Then
                xi += 1
            End If
        Next
        Return xi

    End Function

    Private Function posIncognitas(ByRef V() As Object, nn As Integer, incog As Integer) As Integer()
        Dim Positions(incog) As Integer
        Dim xo As Integer
        xo = 0
        For i = 1 To 3 * nn
            If IsNumeric(V(i)) = False Then
                xo = xo + 1
                Positions(xo) = i
            End If
        Next
        Return Positions


    End Function


    Sub GAUSS(n As Integer, ByVal a(,) As Double, ByVal xxx() As Double, solucion As String)
        Dim K As Integer, j As Integer, i As Integer, M As Integer, L As Integer
        Dim JK As Integer, DIV As Double, MAX As Double, TEMP As Double
        Dim S As Double
        Console.WriteLine("GAUSS")
        Console.WriteLine("Matriz Aumentada")
        For i = 1 To n
            For j = 1 To n + 1
                Console.WriteLine(Str(a(i, j)))
            Next
        Next

        '********CICLO DE ELIMINACION********************************************
        For K = 1 To n - 1
            JK = 0
            MAX = Math.Abs(a(K, K))
            'Ciclo para buscar el mayor elemento por debajo del elemento pivote
            For M = K + 1 To n
                If Math.Abs(a(M, K)) > MAX Then
                    MAX = Math.Abs(a(M, K))
                    JK = 1
                    L = M
                End If
            Next
            'Si hay un mayor elemento por debajo del pivote se realiza un intercambio de filas
            If JK = 1 Then
                For M = K To n + 1
                    TEMP = a(K, M)
                    a(K, M) = a(L, M)
                    a(L, M) = TEMP
                Next
            End If
            'Verificar si el sistema tiene solucion
            If a(K, K) = 0 Then
                MsgBox("EL SISTEMA TIENE INFINITAS SOLUCIONES")
                solucion = "NO"
                Exit Sub
            End If
            For i = K + 1 To n
                DIV = a(i, K) / a(K, K)
                a(i, K) = 0
                For j = K + 1 To n + 1
                    a(i, j) = a(i, j) - DIV * a(K, j)
                Next
            Next
        Next
        'Verificar si el sistema tiene solucion
        If (a(n, n) = 0) And (a(n, n + 1) <> 0) Then
            MsgBox("EL SISTEMA NO TIENE SOLUCION")
            solucion = "NO"
            Exit Sub
        End If
        'Verificar si el sistema tiene solucion
        If (a(n, n) = 0) And (a(n, n + 1) <> 0) Then
            MsgBox("EL SISTEMA TIENE INFINTAS SOLUCIONES")
            solucion = "NO"
            Exit Sub
        End If
        'ReDim xxx(n)
        solucion = "SI"
        Console.WriteLine(solucion)
        'Sustitucion hacia atras
        xxx(n) = a(n, n + 1) / a(n, n)
        For i = n - 1 To 1 Step -1
            S = 0
            For j = i + 1 To n
                S += a(i, j) * xxx(j)
            Next
            xxx(i) = (a(i, n + 1) - S) / a(i, i)
            Console.WriteLine("xxx(" + Str(i) + ")= " + Str(xxx(i)))
        Next



    End Sub



    Private Sub btnApoyos_Click(sender As Object, e As EventArgs) Handles btnApoyos.Click
        Apoyos.Show()
    End Sub

    Private Sub btnResultados_Click(sender As Object, e As EventArgs) Handles btnResultados.Click
        frmResultados.Show()
    End Sub

    Private Sub btnCargas_Click(sender As Object, e As EventArgs) Handles btnCargasNodos.Click
        frmCargasNodos.Show()
    End Sub

    Private Sub btnCargasElem_Click(sender As Object, e As EventArgs) Handles btnCargasElem.Click
        frmCargasElementos.Show()
    End Sub
End Class
