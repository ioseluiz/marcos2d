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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargasElementos))
        Me.dgvCargasElem = New System.Windows.Forms.DataGridView()
        Me.elemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargaDist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CargaPuntual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.distB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvCargasElem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCargasElem
        '
        Me.dgvCargasElem.AllowUserToAddRows = False
        Me.dgvCargasElem.AllowUserToDeleteRows = False
        Me.dgvCargasElem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCargasElem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.elemento, Me.cargaDist, Me.CargaPuntual, Me.distA, Me.distB})
        Me.dgvCargasElem.Location = New System.Drawing.Point(100, 158)
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
        Me.btnRegresar.Location = New System.Drawing.Point(100, 423)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(121, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(395, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(247, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'frmCargasElementos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(798, 469)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.dgvCargasElem)
        Me.Name = "frmCargasElementos"
        Me.Text = "frmCargasElementos"
        CType(Me.dgvCargasElem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCargasElem As DataGridView
    Friend WithEvents elemento As DataGridViewTextBoxColumn
    Friend WithEvents cargaDist As DataGridViewTextBoxColumn
    Friend WithEvents CargaPuntual As DataGridViewTextBoxColumn
    Friend WithEvents distA As DataGridViewTextBoxColumn
    Friend WithEvents distB As DataGridViewTextBoxColumn
    Friend WithEvents btnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
