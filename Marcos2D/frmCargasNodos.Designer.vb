<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargasNodos
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
        Me.dgvCargasNodos = New System.Windows.Forms.DataGridView()
        Me.Nodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargaX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargaY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FuerzaM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.dgvCargasNodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCargasNodos
        '
        Me.dgvCargasNodos.AllowUserToAddRows = False
        Me.dgvCargasNodos.AllowUserToDeleteRows = False
        Me.dgvCargasNodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargasNodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nodo, Me.CargaX, Me.CargaY, Me.FuerzaM})
        Me.dgvCargasNodos.Location = New System.Drawing.Point(76, 44)
        Me.dgvCargasNodos.Name = "dgvCargasNodos"
        Me.dgvCargasNodos.RowHeadersVisible = False
        Me.dgvCargasNodos.Size = New System.Drawing.Size(404, 340)
        Me.dgvCargasNodos.TabIndex = 0
        '
        'Nodo
        '
        Me.Nodo.HeaderText = "Nodo"
        Me.Nodo.Name = "Nodo"
        '
        'CargaX
        '
        Me.CargaX.HeaderText = "Fx"
        Me.CargaX.Name = "CargaX"
        '
        'CargaY
        '
        Me.CargaY.HeaderText = "Fy"
        Me.CargaY.Name = "CargaY"
        '
        'FuerzaM
        '
        Me.FuerzaM.HeaderText = "M"
        Me.FuerzaM.Name = "FuerzaM"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(76, 412)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'frmCargasNodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 450)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.dgvCargasNodos)
        Me.Name = "frmCargasNodos"
        Me.Text = "frmCargasNodos"
        CType(Me.dgvCargasNodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCargasNodos As DataGridView
    Friend WithEvents Nodo As DataGridViewTextBoxColumn
    Friend WithEvents CargaX As DataGridViewTextBoxColumn
    Friend WithEvents CargaY As DataGridViewTextBoxColumn
    Friend WithEvents FuerzaM As DataGridViewTextBoxColumn
    Friend WithEvents btnRegresar As Button
End Class
