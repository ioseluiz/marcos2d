<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargasElementos
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
        Me.dgvCargasElem = New System.Windows.Forms.DataGridView()
        Me.elemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargaDist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargaPuntual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.dgvCargasElem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCargasElem
        '
        Me.dgvCargasElem.AllowUserToAddRows = False
        Me.dgvCargasElem.AllowUserToDeleteRows = False
        Me.dgvCargasElem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargasElem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.elemento, Me.cargaDist, Me.CargaPuntual, Me.distA, Me.distB})
        Me.dgvCargasElem.Location = New System.Drawing.Point(100, 89)
        Me.dgvCargasElem.Name = "dgvCargasElem"
        Me.dgvCargasElem.RowHeadersVisible = False
        Me.dgvCargasElem.Size = New System.Drawing.Size(589, 250)
        Me.dgvCargasElem.TabIndex = 0
        '
        'elemento
        '
        Me.elemento.HeaderText = "Elemento"
        Me.elemento.Name = "elemento"
        '
        'cargaDist
        '
        Me.cargaDist.HeaderText = "w"
        Me.cargaDist.Name = "cargaDist"
        '
        'CargaPuntual
        '
        Me.CargaPuntual.HeaderText = "P"
        Me.CargaPuntual.Name = "CargaPuntual"
        '
        'distA
        '
        Me.distA.HeaderText = "a"
        Me.distA.Name = "distA"
        '
        'distB
        '
        Me.distB.HeaderText = "b"
        Me.distB.Name = "distB"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(100, 362)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmCargasElementos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 430)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.dgvCargasElem)
        Me.Name = "frmCargasElementos"
        Me.Text = "frmCargasElementos"
        CType(Me.dgvCargasElem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCargasElem As DataGridView
    Friend WithEvents elemento As DataGridViewTextBoxColumn
    Friend WithEvents cargaDist As DataGridViewTextBoxColumn
    Friend WithEvents CargaPuntual As DataGridViewTextBoxColumn
    Friend WithEvents distA As DataGridViewTextBoxColumn
    Friend WithEvents distB As DataGridViewTextBoxColumn
    Friend WithEvents btnRegresar As Button
End Class
