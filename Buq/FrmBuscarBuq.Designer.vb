<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarBuq
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
        Me.grpMat = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpMano = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.grpBuque = New System.Windows.Forms.GroupBox()
        Me.lblBuq = New System.Windows.Forms.Label()
        Me.grpMat.SuspendLayout()
        Me.grpMano.SuspendLayout()
        Me.grpBuque.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMat
        '
        Me.grpMat.Controls.Add(Me.TextBox1)
        Me.grpMat.ForeColor = System.Drawing.Color.Navy
        Me.grpMat.Location = New System.Drawing.Point(25, 12)
        Me.grpMat.Name = "grpMat"
        Me.grpMat.Size = New System.Drawing.Size(75, 52)
        Me.grpMat.TabIndex = 0
        Me.grpMat.TabStop = False
        Me.grpMat.Text = "Mat"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(55, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpMano
        '
        Me.grpMano.Controls.Add(Me.TextBox2)
        Me.grpMano.ForeColor = System.Drawing.Color.Navy
        Me.grpMano.Location = New System.Drawing.Point(25, 70)
        Me.grpMano.Name = "grpMano"
        Me.grpMano.Size = New System.Drawing.Size(75, 55)
        Me.grpMano.TabIndex = 1
        Me.grpMano.TabStop = False
        Me.grpMano.Text = "Mano"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(55, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "0"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpBuque
        '
        Me.grpBuque.Controls.Add(Me.lblBuq)
        Me.grpBuque.ForeColor = System.Drawing.Color.Navy
        Me.grpBuque.Location = New System.Drawing.Point(25, 131)
        Me.grpBuque.Name = "grpBuque"
        Me.grpBuque.Size = New System.Drawing.Size(100, 58)
        Me.grpBuque.TabIndex = 2
        Me.grpBuque.TabStop = False
        Me.grpBuque.Text = "Buq"
        Me.grpBuque.Visible = False
        '
        'lblBuq
        '
        Me.lblBuq.AutoSize = True
        Me.lblBuq.ForeColor = System.Drawing.Color.Black
        Me.lblBuq.Location = New System.Drawing.Point(21, 30)
        Me.lblBuq.Name = "lblBuq"
        Me.lblBuq.Size = New System.Drawing.Size(0, 13)
        Me.lblBuq.TabIndex = 0
        Me.lblBuq.Visible = False
        '
        'FrmBuscarBuq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 207)
        Me.Controls.Add(Me.grpBuque)
        Me.Controls.Add(Me.grpMat)
        Me.Controls.Add(Me.grpMano)
        Me.Name = "FrmBuscarBuq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Buscar"
        Me.grpMat.ResumeLayout(False)
        Me.grpMat.PerformLayout()
        Me.grpMano.ResumeLayout(False)
        Me.grpMano.PerformLayout()
        Me.grpBuque.ResumeLayout(False)
        Me.grpBuque.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpMat As GroupBox
    Friend WithEvents grpMano As GroupBox
    Friend WithEvents grpBuque As GroupBox
    Friend WithEvents lblBuq As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
