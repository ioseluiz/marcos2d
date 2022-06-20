<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Apoyos
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
        Me.dgvApoyos = New System.Windows.Forms.DataGridView()
        Me.btnApoyos = New System.Windows.Forms.Button()
        Me.nodoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoX = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GradoY = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GradoM = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dgvApoyos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvApoyos
        '
        Me.dgvApoyos.AllowUserToAddRows = False
        Me.dgvApoyos.AllowUserToDeleteRows = False
        Me.dgvApoyos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvApoyos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nodoId, Me.GradoX, Me.GradoY, Me.GradoM})
        Me.dgvApoyos.Location = New System.Drawing.Point(64, 96)
        Me.dgvApoyos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvApoyos.Name = "dgvApoyos"
        Me.dgvApoyos.RowHeadersVisible = False
        Me.dgvApoyos.RowHeadersWidth = 51
        Me.dgvApoyos.Size = New System.Drawing.Size(580, 379)
        Me.dgvApoyos.TabIndex = 0
        '
        'btnApoyos
        '
        Me.btnApoyos.Location = New System.Drawing.Point(64, 495)
        Me.btnApoyos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnApoyos.Name = "btnApoyos"
        Me.btnApoyos.Size = New System.Drawing.Size(100, 28)
        Me.btnApoyos.TabIndex = 1
        Me.btnApoyos.Text = "Regresar"
        Me.btnApoyos.UseVisualStyleBackColor = True
        '
        'nodoId
        '
        Me.nodoId.HeaderText = "Nodo"
        Me.nodoId.MinimumWidth = 6
        Me.nodoId.Name = "nodoId"
        Me.nodoId.Width = 90
        '
        'GradoX
        '
        Me.GradoX.HeaderText = "Rx"
        Me.GradoX.MinimumWidth = 6
        Me.GradoX.Name = "GradoX"
        Me.GradoX.Width = 90
        '
        'GradoY
        '
        Me.GradoY.HeaderText = "Ry"
        Me.GradoY.MinimumWidth = 6
        Me.GradoY.Name = "GradoY"
        Me.GradoY.Width = 90
        '
        'GradoM
        '
        Me.GradoM.HeaderText = "M"
        Me.GradoM.MinimumWidth = 6
        Me.GradoM.Name = "GradoM"
        Me.GradoM.Width = 90
        '
        'Apoyos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 554)
        Me.Controls.Add(Me.btnApoyos)
        Me.Controls.Add(Me.dgvApoyos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Apoyos"
        Me.Text = "Apoyos"
        CType(Me.dgvApoyos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvApoyos As DataGridView
    Friend WithEvents btnApoyos As Button
    Friend WithEvents nodoId As DataGridViewTextBoxColumn
    Friend WithEvents GradoX As DataGridViewComboBoxColumn
    Friend WithEvents GradoY As DataGridViewComboBoxColumn
    Friend WithEvents GradoM As DataGridViewComboBoxColumn
End Class
