<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pf1_2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCaserne = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblCa = New System.Windows.Forms.Label()
        Me.lblNomCa = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCaserne
        '
        Me.lblCaserne.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblCaserne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCaserne.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaserne.Location = New System.Drawing.Point(77, 19)
        Me.lblCaserne.Name = "lblCaserne"
        Me.lblCaserne.Size = New System.Drawing.Size(150, 23)
        Me.lblCaserne.TabIndex = 0
        Me.lblCaserne.Text = "FTP 01"
        Me.lblCaserne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblCa
        '
        Me.lblCa.BackColor = System.Drawing.SystemColors.Window
        Me.lblCa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCa.Location = New System.Drawing.Point(15, 15)
        Me.lblCa.MaximumSize = New System.Drawing.Size(80, 18)
        Me.lblCa.MinimumSize = New System.Drawing.Size(80, 18)
        Me.lblCa.Name = "lblCa"
        Me.lblCa.Size = New System.Drawing.Size(80, 18)
        Me.lblCa.TabIndex = 1
        Me.lblCa.Text = " "
        Me.lblCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNomCa
        '
        Me.lblNomCa.BackColor = System.Drawing.SystemColors.Window
        Me.lblNomCa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNomCa.Location = New System.Drawing.Point(141, 15)
        Me.lblNomCa.MinimumSize = New System.Drawing.Size(149, 18)
        Me.lblNomCa.Name = "lblNomCa"
        Me.lblNomCa.Size = New System.Drawing.Size(149, 18)
        Me.lblNomCa.TabIndex = 7
        Me.lblNomCa.Text = "BUFFFERTRILLE MICHEL"
        Me.lblNomCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNomCa)
        Me.GroupBox1.Controls.Add(Me.lblCa)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 194)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'pf1_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 305)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblCaserne)
        Me.Name = "pf1_2"
        Me.Text = "Départ : Composition"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCaserne As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblCa As System.Windows.Forms.Label
    Friend WithEvents lblNomCa As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
