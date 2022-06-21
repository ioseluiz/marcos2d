<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResultados
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
        Me.dgvDesplaz = New System.Windows.Forms.DataGridView()
        Me.GdLib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.dgvReaccion = New System.Windows.Forms.DataGridView()
        Me.Reacciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvFuerzas = New System.Windows.Forms.DataGridView()
        Me.Elemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fxi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fyi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fxj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fyj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mj = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvDesplaz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReaccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFuerzas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDesplaz
        '
        Me.dgvDesplaz.AllowUserToAddRows = False
        Me.dgvDesplaz.AllowUserToDeleteRows = False
        Me.dgvDesplaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDesplaz.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GdLib, Me.Resultado})
        Me.dgvDesplaz.Location = New System.Drawing.Point(9, 29)
        Me.dgvDesplaz.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDesplaz.Name = "dgvDesplaz"
        Me.dgvDesplaz.RowHeadersVisible = False
        Me.dgvDesplaz.RowHeadersWidth = 51
        Me.dgvDesplaz.RowTemplate.Height = 24
        Me.dgvDesplaz.Size = New System.Drawing.Size(233, 269)
        Me.dgvDesplaz.TabIndex = 0
        '
        'GdLib
        '
        Me.GdLib.HeaderText = "Grado Libertad"
        Me.GdLib.MinimumWidth = 6
        Me.GdLib.Name = "GdLib"
        Me.GdLib.Width = 125
        '
        'Resultado
        '
        Me.Resultado.HeaderText = "Valor"
        Me.Resultado.MinimumWidth = 6
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Width = 125
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(10, 319)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(56, 24)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'dgvReaccion
        '
        Me.dgvReaccion.AllowUserToAddRows = False
        Me.dgvReaccion.AllowUserToDeleteRows = False
        Me.dgvReaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReaccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Reacciones, Me.Valor})
        Me.dgvReaccion.Location = New System.Drawing.Point(267, 29)
        Me.dgvReaccion.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvReaccion.Name = "dgvReaccion"
        Me.dgvReaccion.RowHeadersVisible = False
        Me.dgvReaccion.RowHeadersWidth = 51
        Me.dgvReaccion.RowTemplate.Height = 24
        Me.dgvReaccion.Size = New System.Drawing.Size(250, 269)
        Me.dgvReaccion.TabIndex = 2
        '
        'Reacciones
        '
        Me.Reacciones.HeaderText = "Reacciones"
        Me.Reacciones.MinimumWidth = 6
        Me.Reacciones.Name = "Reacciones"
        Me.Reacciones.Width = 125
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.MinimumWidth = 6
        Me.Valor.Name = "Valor"
        Me.Valor.Width = 125
        '
        'dgvFuerzas
        '
        Me.dgvFuerzas.AllowUserToAddRows = False
        Me.dgvFuerzas.AllowUserToDeleteRows = False
        Me.dgvFuerzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuerzas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Elemento, Me.Fxi, Me.Fyi, Me.Mi, Me.Fxj, Me.Fyj, Me.Mj})
        Me.dgvFuerzas.Location = New System.Drawing.Point(542, 29)
        Me.dgvFuerzas.Name = "dgvFuerzas"
        Me.dgvFuerzas.RowHeadersVisible = False
        Me.dgvFuerzas.Size = New System.Drawing.Size(612, 269)
        Me.dgvFuerzas.TabIndex = 3
        '
        'Elemento
        '
        Me.Elemento.HeaderText = "Elemento"
        Me.Elemento.Name = "Elemento"
        '
        'Fxi
        '
        Me.Fxi.HeaderText = "Pi"
        Me.Fxi.Name = "Fxi"
        '
        'Fyi
        '
        Me.Fyi.HeaderText = "Vi"
        Me.Fyi.Name = "Fyi"
        '
        'Mi
        '
        Me.Mi.HeaderText = "Mi"
        Me.Mi.Name = "Mi"
        '
        'Fxj
        '
        Me.Fxj.HeaderText = "Pj"
        Me.Fxj.Name = "Fxj"
        '
        'Fyj
        '
        Me.Fyj.HeaderText = "Vj"
        Me.Fyj.Name = "Fyj"
        '
        'Mj
        '
        Me.Mj.HeaderText = "Mj"
        Me.Mj.Name = "Mj"
        '
        'frmResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 362)
        Me.Controls.Add(Me.dgvFuerzas)
        Me.Controls.Add(Me.dgvReaccion)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.dgvDesplaz)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmResultados"
        Me.Text = "frmResultados"
        CType(Me.dgvDesplaz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReaccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFuerzas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDesplaz As DataGridView
    Friend WithEvents GdLib As DataGridViewTextBoxColumn
    Friend WithEvents Resultado As DataGridViewTextBoxColumn
    Friend WithEvents btnRegresar As Button
    Friend WithEvents dgvReaccion As DataGridView
    Friend WithEvents Reacciones As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents dgvFuerzas As DataGridView
    Friend WithEvents Elemento As DataGridViewTextBoxColumn
    Friend WithEvents Fxi As DataGridViewTextBoxColumn
    Friend WithEvents Fyi As DataGridViewTextBoxColumn
    Friend WithEvents Mi As DataGridViewTextBoxColumn
    Friend WithEvents Fxj As DataGridViewTextBoxColumn
    Friend WithEvents Fyj As DataGridViewTextBoxColumn
    Friend WithEvents Mj As DataGridViewTextBoxColumn
End Class
