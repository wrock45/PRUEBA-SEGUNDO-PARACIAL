<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.REGISTRAR = New System.Windows.Forms.Button()
        Me.TXTSEG = New System.Windows.Forms.TextBox()
        Me.TP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVCLIENTES = New System.Windows.Forms.DataGridView()
        Me.C1 = New System.Windows.Forms.ComboBox()
        Me.CD1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TM = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CD1)
        Me.GroupBox1.Controls.Add(Me.C1)
        Me.GroupBox1.Controls.Add(Me.REGISTRAR)
        Me.GroupBox1.Controls.Add(Me.TXTSEG)
        Me.GroupBox1.Controls.Add(Me.TP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 355)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO"
        '
        'REGISTRAR
        '
        Me.REGISTRAR.Location = New System.Drawing.Point(239, 298)
        Me.REGISTRAR.Name = "REGISTRAR"
        Me.REGISTRAR.Size = New System.Drawing.Size(75, 36)
        Me.REGISTRAR.TabIndex = 12
        Me.REGISTRAR.Text = "PUSH"
        Me.REGISTRAR.UseVisualStyleBackColor = True
        '
        'TXTSEG
        '
        Me.TXTSEG.Location = New System.Drawing.Point(123, 228)
        Me.TXTSEG.Name = "TXTSEG"
        Me.TXTSEG.Size = New System.Drawing.Size(155, 20)
        Me.TXTSEG.TabIndex = 8
        '
        'TP
        '
        Me.TP.Location = New System.Drawing.Point(123, 110)
        Me.TP.Name = "TP"
        Me.TP.Size = New System.Drawing.Size(155, 20)
        Me.TP.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "N.- SEGURO S:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "APELLIDO P:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEXO:"
        '
        'DGVCLIENTES
        '
        Me.DGVCLIENTES.AllowUserToAddRows = False
        Me.DGVCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCLIENTES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIPO, Me.NOMBRES, Me.APELLIDOM, Me.APELLIDOS, Me.DOCUMENTO})
        Me.DGVCLIENTES.Location = New System.Drawing.Point(462, 12)
        Me.DGVCLIENTES.Name = "DGVCLIENTES"
        Me.DGVCLIENTES.Size = New System.Drawing.Size(480, 355)
        Me.DGVCLIENTES.TabIndex = 1
        '
        'C1
        '
        Me.C1.FormattingEnabled = True
        Me.C1.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.C1.Location = New System.Drawing.Point(123, 64)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(121, 21)
        Me.C1.TabIndex = 13
        '
        'CD1
        '
        Me.CD1.Location = New System.Drawing.Point(123, 179)
        Me.CD1.Name = "CD1"
        Me.CD1.Size = New System.Drawing.Size(155, 20)
        Me.CD1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "CODIGO:"
        '
        'TIPO
        '
        Me.TIPO.HeaderText = "SEXO"
        Me.TIPO.Name = "TIPO"
        '
        'NOMBRES
        '
        Me.NOMBRES.HeaderText = "APELLIDO P"
        Me.NOMBRES.Name = "NOMBRES"
        '
        'APELLIDOM
        '
        Me.APELLIDOM.HeaderText = "APELLIDO M"
        Me.APELLIDOM.Name = "APELLIDOM"
        '
        'APELLIDOS
        '
        Me.APELLIDOS.HeaderText = "SEGURO S"
        Me.APELLIDOS.Name = "APELLIDOS"
        '
        'DOCUMENTO
        '
        Me.DOCUMENTO.HeaderText = "CODIGO"
        Me.DOCUMENTO.Name = "DOCUMENTO"
        '
        'TM
        '
        Me.TM.Location = New System.Drawing.Point(123, 136)
        Me.TM.Name = "TM"
        Me.TM.Size = New System.Drawing.Size(155, 20)
        Me.TM.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "APELLIDO M:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 450)
        Me.Controls.Add(Me.DGVCLIENTES)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVCLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGVCLIENTES As DataGridView
    Friend WithEvents REGISTRAR As Button
    Friend WithEvents TXTSEG As TextBox
    Friend WithEvents TP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents C1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CD1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TM As TextBox
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRES As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOM As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENTO As DataGridViewTextBoxColumn
End Class
