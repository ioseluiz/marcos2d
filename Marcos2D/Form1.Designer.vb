<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNudos = New System.Windows.Forms.Label()
        Me.txtNudos = New System.Windows.Forms.TextBox()
        Me.lblElementos = New System.Windows.Forms.Label()
        Me.txtElementos = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.dgvNodos = New System.Windows.Forms.DataGridView()
        Me.Nodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoorX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoorY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvElementos = New System.Windows.Forms.DataGridView()
        Me.Elemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inercia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnApoyos = New System.Windows.Forms.Button()
        Me.btnCargasNodos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optSI = New System.Windows.Forms.RadioButton()
        Me.optES = New System.Windows.Forms.RadioButton()
        Me.btnResultados = New System.Windows.Forms.Button()
        Me.btnCargasElem = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.dgvNodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNudos
        '
        Me.lblNudos.AutoSize = True
        Me.lblNudos.Location = New System.Drawing.Point(9, 61)
        Me.lblNudos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNudos.Name = "lblNudos"
        Me.lblNudos.Size = New System.Drawing.Size(66, 13)
        Me.lblNudos.TabIndex = 0
        Me.lblNudos.Text = "Cant. Nudos"
        '
        'txtNudos
        '
        Me.txtNudos.Location = New System.Drawing.Point(98, 58)
        Me.txtNudos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNudos.Name = "txtNudos"
        Me.txtNudos.Size = New System.Drawing.Size(88, 20)
        Me.txtNudos.TabIndex = 1
        '
        'lblElementos
        '
        Me.lblElementos.AutoSize = True
        Me.lblElementos.Location = New System.Drawing.Point(9, 86)
        Me.lblElementos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblElementos.Name = "lblElementos"
        Me.lblElementos.Size = New System.Drawing.Size(84, 13)
        Me.lblElementos.TabIndex = 2
        Me.lblElementos.Text = "Cant. Elementos"
        '
        'txtElementos
        '
        Me.txtElementos.Location = New System.Drawing.Point(98, 84)
        Me.txtElementos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtElementos.Name = "txtElementos"
        Me.txtElementos.Size = New System.Drawing.Size(88, 20)
        Me.txtElementos.TabIndex = 3
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(11, 116)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(173, 27)
        Me.btnIngresar.TabIndex = 4
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'dgvNodos
        '
        Me.dgvNodos.AllowUserToAddRows = False
        Me.dgvNodos.AllowUserToDeleteRows = False
        Me.dgvNodos.AllowUserToResizeColumns = False
        Me.dgvNodos.AllowUserToResizeRows = False
        Me.dgvNodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nodo, Me.CoorX, Me.CoorY})
        Me.dgvNodos.Enabled = False
        Me.dgvNodos.Location = New System.Drawing.Point(12, 227)
        Me.dgvNodos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvNodos.Name = "dgvNodos"
        Me.dgvNodos.RowHeadersVisible = False
        Me.dgvNodos.RowHeadersWidth = 51
        Me.dgvNodos.RowTemplate.Height = 24
        Me.dgvNodos.Size = New System.Drawing.Size(307, 274)
        Me.dgvNodos.TabIndex = 5
        '
        'Nodo
        '
        Me.Nodo.HeaderText = "Nodo"
        Me.Nodo.MinimumWidth = 6
        Me.Nodo.Name = "Nodo"
        Me.Nodo.Width = 80
        '
        'CoorX
        '
        Me.CoorX.HeaderText = "Coor. X"
        Me.CoorX.MinimumWidth = 6
        Me.CoorX.Name = "CoorX"
        Me.CoorX.Width = 110
        '
        'CoorY
        '
        Me.CoorY.HeaderText = "Coor. Y"
        Me.CoorY.MinimumWidth = 6
        Me.CoorY.Name = "CoorY"
        Me.CoorY.Width = 110
        '
        'dgvElementos
        '
        Me.dgvElementos.AllowUserToAddRows = False
        Me.dgvElementos.AllowUserToDeleteRows = False
        Me.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElementos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elemento, Me.Ni, Me.Nj, Me.E, Me.Area, Me.Inercia})
        Me.dgvElementos.Enabled = False
        Me.dgvElementos.Location = New System.Drawing.Point(358, 227)
        Me.dgvElementos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvElementos.Name = "dgvElementos"
        Me.dgvElementos.RowHeadersVisible = False
        Me.dgvElementos.RowHeadersWidth = 51
        Me.dgvElementos.RowTemplate.Height = 24
        Me.dgvElementos.Size = New System.Drawing.Size(606, 274)
        Me.dgvElementos.TabIndex = 6
        '
        'Elemento
        '
        Me.Elemento.HeaderText = "Elemento"
        Me.Elemento.MinimumWidth = 6
        Me.Elemento.Name = "Elemento"
        Me.Elemento.Width = 125
        '
        'Ni
        '
        Me.Ni.HeaderText = "Nodo Inicial"
        Me.Ni.MinimumWidth = 6
        Me.Ni.Name = "Ni"
        Me.Ni.Width = 110
        '
        'Nj
        '
        Me.Nj.HeaderText = "Nodo Final"
        Me.Nj.MinimumWidth = 6
        Me.Nj.Name = "Nj"
        Me.Nj.Width = 110
        '
        'E
        '
        Me.E.HeaderText = "E"
        Me.E.MinimumWidth = 6
        Me.E.Name = "E"
        Me.E.Width = 80
        '
        'Area
        '
        Me.Area.HeaderText = "A"
        Me.Area.MinimumWidth = 6
        Me.Area.Name = "Area"
        Me.Area.Width = 80
        '
        'Inercia
        '
        Me.Inercia.HeaderText = "Ine."
        Me.Inercia.MinimumWidth = 6
        Me.Inercia.Name = "Inercia"
        Me.Inercia.Width = 80
        '
        'btnCalcular
        '
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.Location = New System.Drawing.Point(219, 137)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(107, 27)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnApoyos
        '
        Me.btnApoyos.Enabled = False
        Me.btnApoyos.Location = New System.Drawing.Point(219, 19)
        Me.btnApoyos.Name = "btnApoyos"
        Me.btnApoyos.Size = New System.Drawing.Size(107, 27)
        Me.btnApoyos.TabIndex = 10
        Me.btnApoyos.Text = "Apoyos"
        Me.btnApoyos.UseVisualStyleBackColor = True
        '
        'btnCargasNodos
        '
        Me.btnCargasNodos.Enabled = False
        Me.btnCargasNodos.Location = New System.Drawing.Point(219, 54)
        Me.btnCargasNodos.Name = "btnCargasNodos"
        Me.btnCargasNodos.Size = New System.Drawing.Size(107, 35)
        Me.btnCargasNodos.TabIndex = 11
        Me.btnCargasNodos.Text = "Cargas Nodos"
        Me.btnCargasNodos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optSI)
        Me.GroupBox1.Controls.Add(Me.optES)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 48)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidades"
        '
        'optSI
        '
        Me.optSI.AutoSize = True
        Me.optSI.Location = New System.Drawing.Point(70, 20)
        Me.optSI.Name = "optSI"
        Me.optSI.Size = New System.Drawing.Size(35, 17)
        Me.optSI.TabIndex = 1
        Me.optSI.TabStop = True
        Me.optSI.Text = "SI"
        Me.optSI.UseVisualStyleBackColor = True
        '
        'optES
        '
        Me.optES.AutoSize = True
        Me.optES.Location = New System.Drawing.Point(16, 20)
        Me.optES.Name = "optES"
        Me.optES.Size = New System.Drawing.Size(39, 17)
        Me.optES.TabIndex = 0
        Me.optES.TabStop = True
        Me.optES.Text = "ES"
        Me.optES.UseVisualStyleBackColor = True
        '
        'btnResultados
        '
        Me.btnResultados.Enabled = False
        Me.btnResultados.Location = New System.Drawing.Point(219, 172)
        Me.btnResultados.Name = "btnResultados"
        Me.btnResultados.Size = New System.Drawing.Size(107, 26)
        Me.btnResultados.TabIndex = 14
        Me.btnResultados.Text = "Resultados"
        Me.btnResultados.UseVisualStyleBackColor = True
        '
        'btnCargasElem
        '
        Me.btnCargasElem.Enabled = False
        Me.btnCargasElem.Location = New System.Drawing.Point(219, 95)
        Me.btnCargasElem.Name = "btnCargasElem"
        Me.btnCargasElem.Size = New System.Drawing.Size(107, 35)
        Me.btnCargasElem.TabIndex = 15
        Me.btnCargasElem.Text = "Cargas Elementos"
        Me.btnCargasElem.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(13, 160)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(171, 27)
        Me.btnLimpiar.TabIndex = 16
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 527)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCargasElem)
        Me.Controls.Add(Me.btnResultados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCargasNodos)
        Me.Controls.Add(Me.btnApoyos)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dgvElementos)
        Me.Controls.Add(Me.dgvNodos)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtElementos)
        Me.Controls.Add(Me.lblElementos)
        Me.Controls.Add(Me.txtNudos)
        Me.Controls.Add(Me.lblNudos)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvNodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNudos As Label
    Friend WithEvents txtNudos As TextBox
    Friend WithEvents lblElementos As Label
    Friend WithEvents txtElementos As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents dgvNodos As DataGridView
    Friend WithEvents dgvElementos As DataGridView
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnApoyos As Button
    Friend WithEvents btnCargasNodos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optSI As RadioButton
    Friend WithEvents optES As RadioButton
    Friend WithEvents btnResultados As Button
    Friend WithEvents btnCargasElem As Button
    Friend WithEvents Nodo As DataGridViewTextBoxColumn
    Friend WithEvents CoorX As DataGridViewTextBoxColumn
    Friend WithEvents CoorY As DataGridViewTextBoxColumn
    Friend WithEvents Elemento As DataGridViewTextBoxColumn
    Friend WithEvents Ni As DataGridViewTextBoxColumn
    Friend WithEvents Nj As DataGridViewTextBoxColumn
    Friend WithEvents E As DataGridViewTextBoxColumn
    Friend WithEvents Area As DataGridViewTextBoxColumn
    Friend WithEvents Inercia As DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiar As Button
End Class
