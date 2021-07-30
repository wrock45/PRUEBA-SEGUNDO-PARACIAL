<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGVEMPLEADO = New System.Windows.Forms.DataGridView()
        Me.TIPOC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUELDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.REGISTRAR1 = New System.Windows.Forms.Button()
        CType(Me.DGVEMPLEADO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVEMPLEADO
        '
        Me.DGVEMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEMPLEADO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPOC, Me.SUELDO})
        Me.DGVEMPLEADO.Location = New System.Drawing.Point(425, 70)
        Me.DGVEMPLEADO.Name = "DGVEMPLEADO"
        Me.DGVEMPLEADO.Size = New System.Drawing.Size(248, 229)
        Me.DGVEMPLEADO.TabIndex = 10
        '
        'TIPOC
        '
        Me.TIPOC.HeaderText = "TIPOC"
        Me.TIPOC.Name = "TIPOC"
        '
        'SUELDO
        '
        Me.SUELDO.HeaderText = "SUELDO"
        Me.SUELDO.Name = "SUELDO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.REGISTRAR1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 319)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMPLEADO"
        '
        'CB1
        '
        Me.CB1.FormattingEnabled = True
        Me.CB1.Items.AddRange(New Object() {"C", "N"})
        Me.CB1.Location = New System.Drawing.Point(106, 111)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(121, 21)
        Me.CB1.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-36, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-17, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "L"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "CONTRATO:"
        '
        'REGISTRAR1
        '
        Me.REGISTRAR1.Location = New System.Drawing.Point(208, 215)
        Me.REGISTRAR1.Name = "REGISTRAR1"
        Me.REGISTRAR1.Size = New System.Drawing.Size(75, 62)
        Me.REGISTRAR1.TabIndex = 10
        Me.REGISTRAR1.Text = "PUSH"
        Me.REGISTRAR1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 363)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVEMPLEADO)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DGVEMPLEADO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVEMPLEADO As DataGridView
    Friend WithEvents TIPOC As DataGridViewTextBoxColumn
    Friend WithEvents SUELDO As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents REGISTRAR1 As Button
End Class
