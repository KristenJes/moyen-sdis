﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gest_engins_ajout
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
        Me.lbIdentifiant = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblImmatriculation = New System.Windows.Forms.Label()
        Me.txtBoxIdentifiant = New System.Windows.Forms.TextBox()
        Me.txtBoxImmatriculation = New System.Windows.Forms.TextBox()
        Me.listBoxCaserne = New System.Windows.Forms.ListBox()
        Me.ListBoxType = New System.Windows.Forms.ListBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCaserne
        '
        Me.lblCaserne.AutoSize = True
        Me.lblCaserne.Location = New System.Drawing.Point(35, 40)
        Me.lblCaserne.Name = "lblCaserne"
        Me.lblCaserne.Size = New System.Drawing.Size(46, 13)
        Me.lblCaserne.TabIndex = 0
        Me.lblCaserne.Text = "Caserne"
        '
        'lbIdentifiant
        '
        Me.lbIdentifiant.AutoSize = True
        Me.lbIdentifiant.Location = New System.Drawing.Point(34, 120)
        Me.lbIdentifiant.Name = "lbIdentifiant"
        Me.lbIdentifiant.Size = New System.Drawing.Size(53, 13)
        Me.lbIdentifiant.TabIndex = 1
        Me.lbIdentifiant.Text = "Identifiant"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(37, 80)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 2
        Me.lblType.Text = "Type"
        '
        'lblImmatriculation
        '
        Me.lblImmatriculation.AutoSize = True
        Me.lblImmatriculation.Location = New System.Drawing.Point(35, 157)
        Me.lblImmatriculation.Name = "lblImmatriculation"
        Me.lblImmatriculation.Size = New System.Drawing.Size(77, 13)
        Me.lblImmatriculation.TabIndex = 3
        Me.lblImmatriculation.Text = "Immatriculation"
        '
        'txtBoxIdentifiant
        '
        Me.txtBoxIdentifiant.Location = New System.Drawing.Point(130, 116)
        Me.txtBoxIdentifiant.Name = "txtBoxIdentifiant"
        Me.txtBoxIdentifiant.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxIdentifiant.TabIndex = 4
        Me.txtBoxIdentifiant.Text = "01"
        '
        'txtBoxImmatriculation
        '
        Me.txtBoxImmatriculation.Location = New System.Drawing.Point(130, 151)
        Me.txtBoxImmatriculation.Name = "txtBoxImmatriculation"
        Me.txtBoxImmatriculation.Size = New System.Drawing.Size(120, 20)
        Me.txtBoxImmatriculation.TabIndex = 5
        Me.txtBoxImmatriculation.Text = "YHG - 536 - HUK"
        '
        'listBoxCaserne
        '
        Me.listBoxCaserne.FormattingEnabled = True
        Me.listBoxCaserne.Location = New System.Drawing.Point(132, 30)
        Me.listBoxCaserne.Name = "listBoxCaserne"
        Me.listBoxCaserne.Size = New System.Drawing.Size(120, 30)
        Me.listBoxCaserne.TabIndex = 6
        '
        'ListBoxType
        '
        Me.ListBoxType.FormattingEnabled = True
        Me.ListBoxType.Location = New System.Drawing.Point(132, 72)
        Me.ListBoxType.Name = "ListBoxType"
        Me.ListBoxType.Size = New System.Drawing.Size(120, 30)
        Me.ListBoxType.TabIndex = 7
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(58, 204)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(177, 204)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 9
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'gest_engins_ajout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 261)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.ListBoxType)
        Me.Controls.Add(Me.listBoxCaserne)
        Me.Controls.Add(Me.txtBoxImmatriculation)
        Me.Controls.Add(Me.txtBoxIdentifiant)
        Me.Controls.Add(Me.lblImmatriculation)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lbIdentifiant)
        Me.Controls.Add(Me.lblCaserne)
        Me.Name = "gest_engins_ajout"
        Me.Text = "MODIFICATION D'ENGINS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCaserne As System.Windows.Forms.Label
    Friend WithEvents lbIdentifiant As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblImmatriculation As System.Windows.Forms.Label
    Friend WithEvents txtBoxIdentifiant As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxImmatriculation As System.Windows.Forms.TextBox
    Friend WithEvents listBoxCaserne As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxType As System.Windows.Forms.ListBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
End Class