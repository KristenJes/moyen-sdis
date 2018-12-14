<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestion_engins
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
        Me.lstAffichEngins = New System.Windows.Forms.ListView()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.lstAffichCaserne = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstAffichEngins
        '
        Me.lstAffichEngins.Location = New System.Drawing.Point(12, 12)
        Me.lstAffichEngins.Name = "lstAffichEngins"
        Me.lstAffichEngins.Size = New System.Drawing.Size(504, 289)
        Me.lstAffichEngins.TabIndex = 0
        Me.lstAffichEngins.UseCompatibleStateImageBehavior = False
        Me.lstAffichEngins.View = System.Windows.Forms.View.Details
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(561, 28)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 1
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'btnModifier
        '
        Me.btnModifier.Location = New System.Drawing.Point(561, 79)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(75, 23)
        Me.btnModifier.TabIndex = 2
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = True
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Location = New System.Drawing.Point(561, 131)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.btnSupprimer.TabIndex = 3
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = True
        '
        'lstAffichCaserne
        '
        Me.lstAffichCaserne.Location = New System.Drawing.Point(534, 201)
        Me.lstAffichCaserne.Name = "lstAffichCaserne"
        Me.lstAffichCaserne.Size = New System.Drawing.Size(130, 100)
        Me.lstAffichCaserne.TabIndex = 6
        Me.lstAffichCaserne.UseCompatibleStateImageBehavior = False
        Me.lstAffichCaserne.View = System.Windows.Forms.View.SmallIcon
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Caserne"
        '
        'gestion_engins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 335)
        Me.Controls.Add(Me.lstAffichCaserne)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.lstAffichEngins)
        Me.Name = "gestion_engins"
        Me.Text = "ENGINS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAffichEngins As System.Windows.Forms.ListView
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents lstAffichCaserne As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
