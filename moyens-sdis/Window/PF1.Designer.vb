<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PF1
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
        Me.lblEngins1 = New System.Windows.Forms.Label()
        Me.lblEngins3 = New System.Windows.Forms.Label()
        Me.lblEngins2 = New System.Windows.Forms.Label()
        Me.lblCIS1 = New System.Windows.Forms.Label()
        Me.lblCIS2 = New System.Windows.Forms.Label()
        Me.lblCIS3 = New System.Windows.Forms.Label()
        Me.lblCentreSecours = New System.Windows.Forms.Label()
        Me.lblEngins = New System.Windows.Forms.Label()
        Me.btnConsulter1 = New System.Windows.Forms.Button()
        Me.btnConsulter2 = New System.Windows.Forms.Button()
        Me.btnConsulter3 = New System.Windows.Forms.Button()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.lblStatut = New System.Windows.Forms.Label()
        Me.lblStatut2 = New System.Windows.Forms.Label()
        Me.lblStatut3 = New System.Windows.Forms.Label()
        Me.lblStatut1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEngins1
        '
        Me.lblEngins1.AutoSize = True
        Me.lblEngins1.BackColor = System.Drawing.SystemColors.Window
        Me.lblEngins1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEngins1.Location = New System.Drawing.Point(208, 13)
        Me.lblEngins1.MinimumSize = New System.Drawing.Size(165, 22)
        Me.lblEngins1.Name = "lblEngins1"
        Me.lblEngins1.Size = New System.Drawing.Size(165, 22)
        Me.lblEngins1.TabIndex = 3
        Me.lblEngins1.Text = "VSAV 02"
        Me.lblEngins1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEngins3
        '
        Me.lblEngins3.AutoSize = True
        Me.lblEngins3.BackColor = System.Drawing.SystemColors.Window
        Me.lblEngins3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEngins3.Location = New System.Drawing.Point(233, 147)
        Me.lblEngins3.MinimumSize = New System.Drawing.Size(165, 22)
        Me.lblEngins3.Name = "lblEngins3"
        Me.lblEngins3.Size = New System.Drawing.Size(165, 22)
        Me.lblEngins3.TabIndex = 4
        Me.lblEngins3.Text = "VLHR"
        Me.lblEngins3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEngins2
        '
        Me.lblEngins2.AutoSize = True
        Me.lblEngins2.BackColor = System.Drawing.SystemColors.Window
        Me.lblEngins2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEngins2.Location = New System.Drawing.Point(233, 94)
        Me.lblEngins2.MinimumSize = New System.Drawing.Size(165, 22)
        Me.lblEngins2.Name = "lblEngins2"
        Me.lblEngins2.Size = New System.Drawing.Size(165, 22)
        Me.lblEngins2.TabIndex = 5
        Me.lblEngins2.Text = "VLU"
        Me.lblEngins2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCIS1
        '
        Me.lblCIS1.BackColor = System.Drawing.SystemColors.Window
        Me.lblCIS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIS1.Location = New System.Drawing.Point(18, 13)
        Me.lblCIS1.Name = "lblCIS1"
        Me.lblCIS1.Size = New System.Drawing.Size(165, 22)
        Me.lblCIS1.TabIndex = 0
        Me.lblCIS1.Text = "BREST"
        Me.lblCIS1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCIS2
        '
        Me.lblCIS2.AutoSize = True
        Me.lblCIS2.BackColor = System.Drawing.SystemColors.Window
        Me.lblCIS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIS2.Location = New System.Drawing.Point(43, 97)
        Me.lblCIS2.MinimumSize = New System.Drawing.Size(165, 22)
        Me.lblCIS2.Name = "lblCIS2"
        Me.lblCIS2.Size = New System.Drawing.Size(165, 22)
        Me.lblCIS2.TabIndex = 1
        Me.lblCIS2.Text = "SAINT-RENAN"
        Me.lblCIS2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCIS3
        '
        Me.lblCIS3.AutoSize = True
        Me.lblCIS3.BackColor = System.Drawing.SystemColors.Window
        Me.lblCIS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIS3.Location = New System.Drawing.Point(43, 147)
        Me.lblCIS3.MinimumSize = New System.Drawing.Size(165, 22)
        Me.lblCIS3.Name = "lblCIS3"
        Me.lblCIS3.Size = New System.Drawing.Size(165, 22)
        Me.lblCIS3.TabIndex = 2
        Me.lblCIS3.Text = "BREST"
        Me.lblCIS3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCentreSecours
        '
        Me.lblCentreSecours.AutoSize = True
        Me.lblCentreSecours.Location = New System.Drawing.Point(43, 21)
        Me.lblCentreSecours.Name = "lblCentreSecours"
        Me.lblCentreSecours.Size = New System.Drawing.Size(93, 13)
        Me.lblCentreSecours.TabIndex = 6
        Me.lblCentreSecours.Text = "Centre de secours"
        '
        'lblEngins
        '
        Me.lblEngins.AutoSize = True
        Me.lblEngins.Location = New System.Drawing.Point(233, 21)
        Me.lblEngins.Name = "lblEngins"
        Me.lblEngins.Size = New System.Drawing.Size(39, 13)
        Me.lblEngins.TabIndex = 7
        Me.lblEngins.Text = "Engins"
        '
        'btnConsulter1
        '
        Me.btnConsulter1.Location = New System.Drawing.Point(627, 47)
        Me.btnConsulter1.Name = "btnConsulter1"
        Me.btnConsulter1.Size = New System.Drawing.Size(75, 23)
        Me.btnConsulter1.TabIndex = 8
        Me.btnConsulter1.Text = "Consulter"
        Me.btnConsulter1.UseVisualStyleBackColor = True
        '
        'btnConsulter2
        '
        Me.btnConsulter2.Location = New System.Drawing.Point(627, 92)
        Me.btnConsulter2.Name = "btnConsulter2"
        Me.btnConsulter2.Size = New System.Drawing.Size(75, 23)
        Me.btnConsulter2.TabIndex = 10
        Me.btnConsulter2.Text = "Consulter"
        Me.btnConsulter2.UseVisualStyleBackColor = True
        '
        'btnConsulter3
        '
        Me.btnConsulter3.Location = New System.Drawing.Point(627, 142)
        Me.btnConsulter3.Name = "btnConsulter3"
        Me.btnConsulter3.Size = New System.Drawing.Size(75, 23)
        Me.btnConsulter3.TabIndex = 12
        Me.btnConsulter3.Text = "Consulter"
        Me.btnConsulter3.UseVisualStyleBackColor = True
        '
        'btnValider
        '
        Me.btnValider.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnValider.Location = New System.Drawing.Point(323, 226)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 13
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'lblStatut
        '
        Me.lblStatut.AutoSize = True
        Me.lblStatut.Location = New System.Drawing.Point(422, 20)
        Me.lblStatut.Name = "lblStatut"
        Me.lblStatut.Size = New System.Drawing.Size(35, 13)
        Me.lblStatut.TabIndex = 17
        Me.lblStatut.Text = "Statut"
        '
        'lblStatut2
        '
        Me.lblStatut2.AutoSize = True
        Me.lblStatut2.BackColor = System.Drawing.SystemColors.Window
        Me.lblStatut2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatut2.Location = New System.Drawing.Point(422, 93)
        Me.lblStatut2.MinimumSize = New System.Drawing.Size(165, 22)
        Me.lblStatut2.Name = "lblStatut2"
        Me.lblStatut2.Size = New System.Drawing.Size(165, 22)
        Me.lblStatut2.TabIndex = 16
        Me.lblStatut2.Text = "RENFORTS"
        Me.lblStatut2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatut3
        '
        Me.lblStatut3.AutoSize = True
        Me.lblStatut3.BackColor = System.Drawing.SystemColors.Window
        Me.lblStatut3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatut3.Location = New System.Drawing.Point(398, 14)
        Me.lblStatut3.MinimumSize = New System.Drawing.Size(165, 22)
        Me.lblStatut3.Name = "lblStatut3"
        Me.lblStatut3.Size = New System.Drawing.Size(165, 22)
        Me.lblStatut3.TabIndex = 15
        Me.lblStatut3.Text = "ASSIGNÉ"
        Me.lblStatut3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatut1
        '
        Me.lblStatut1.AutoSize = True
        Me.lblStatut1.BackColor = System.Drawing.SystemColors.Window
        Me.lblStatut1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatut1.Location = New System.Drawing.Point(422, 48)
        Me.lblStatut1.MinimumSize = New System.Drawing.Size(165, 22)
        Me.lblStatut1.Name = "lblStatut1"
        Me.lblStatut1.Size = New System.Drawing.Size(165, 22)
        Me.lblStatut1.TabIndex = 14
        Me.lblStatut1.Text = "ASSIGNÉ"
        Me.lblStatut1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEngins1)
        Me.GroupBox1.Controls.Add(Me.lblCIS1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 92)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblStatut3)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 50)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'PF1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 261)
        Me.Controls.Add(Me.lblStatut)
        Me.Controls.Add(Me.lblStatut2)
        Me.Controls.Add(Me.lblStatut1)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.btnConsulter3)
        Me.Controls.Add(Me.btnConsulter2)
        Me.Controls.Add(Me.btnConsulter1)
        Me.Controls.Add(Me.lblEngins)
        Me.Controls.Add(Me.lblCentreSecours)
        Me.Controls.Add(Me.lblEngins2)
        Me.Controls.Add(Me.lblCIS3)
        Me.Controls.Add(Me.lblEngins3)
        Me.Controls.Add(Me.lblCIS2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "PF1"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEngins1 As System.Windows.Forms.Label
    Friend WithEvents lblEngins3 As System.Windows.Forms.Label
    Friend WithEvents lblEngins2 As System.Windows.Forms.Label
    Friend WithEvents lblCIS1 As System.Windows.Forms.Label
    Friend WithEvents lblCIS2 As System.Windows.Forms.Label
    Friend WithEvents lblCIS3 As System.Windows.Forms.Label
    Friend WithEvents lblCentreSecours As System.Windows.Forms.Label
    Friend WithEvents lblEngins As System.Windows.Forms.Label
    Friend WithEvents btnConsulter1 As System.Windows.Forms.Button
    Friend WithEvents btnConsulter2 As System.Windows.Forms.Button
    Friend WithEvents btnConsulter3 As System.Windows.Forms.Button
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents lblStatut As System.Windows.Forms.Label
    Friend WithEvents lblStatut2 As System.Windows.Forms.Label
    Friend WithEvents lblStatut3 As System.Windows.Forms.Label
    Friend WithEvents lblStatut1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
