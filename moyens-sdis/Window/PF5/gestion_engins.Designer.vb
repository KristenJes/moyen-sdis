﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblCaserne = New System.Windows.Forms.Label()
        Me.CbCaserne = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lstAffichEngins
        '
        Me.lstAffichEngins.FullRowSelect = True
        Me.lstAffichEngins.Location = New System.Drawing.Point(12, 12)
        Me.lstAffichEngins.MultiSelect = False
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
        'lblCaserne
        '
        Me.lblCaserne.AutoSize = True
        Me.lblCaserne.Location = New System.Drawing.Point(536, 180)
        Me.lblCaserne.Name = "lblCaserne"
        Me.lblCaserne.Size = New System.Drawing.Size(46, 13)
        Me.lblCaserne.TabIndex = 5
        Me.lblCaserne.Text = "Caserne"
        '
        'CbCaserne
        '
        Me.CbCaserne.FormattingEnabled = True
        Me.CbCaserne.Location = New System.Drawing.Point(535, 217)
        Me.CbCaserne.Name = "CbCaserne"
        Me.CbCaserne.Size = New System.Drawing.Size(121, 21)
        Me.CbCaserne.TabIndex = 6
        '
        'gestion_engins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 335)
        Me.Controls.Add(Me.CbCaserne)
        Me.Controls.Add(Me.lblCaserne)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.lstAffichEngins)
        Me.Name = "gestion_engins"
        Me.Text = "GESTIONS DES ENGINS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAffichEngins As System.Windows.Forms.ListView
    Friend WithEvents btnAjouter As System.Windows.Forms.Button
    Friend WithEvents btnModifier As System.Windows.Forms.Button
    Friend WithEvents btnSupprimer As System.Windows.Forms.Button
    Friend WithEvents lblCaserne As System.Windows.Forms.Label
    Friend WithEvents CbCaserne As System.Windows.Forms.ComboBox
End Class
