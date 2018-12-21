<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.lstAffichCaserne = New System.Windows.Forms.ListView()
        Me.lstAffichTypeEngin = New System.Windows.Forms.ListView()
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
        Me.lbIdentifiant.Location = New System.Drawing.Point(35, 168)
        Me.lbIdentifiant.Name = "lbIdentifiant"
        Me.lbIdentifiant.Size = New System.Drawing.Size(53, 13)
        Me.lbIdentifiant.TabIndex = 1
        Me.lbIdentifiant.Text = "Identifiant"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(35, 113)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 2
        Me.lblType.Text = "Type"
        '
        'lblImmatriculation
        '
        Me.lblImmatriculation.AutoSize = True
        Me.lblImmatriculation.Location = New System.Drawing.Point(37, 205)
        Me.lblImmatriculation.Name = "lblImmatriculation"
        Me.lblImmatriculation.Size = New System.Drawing.Size(77, 13)
        Me.lblImmatriculation.TabIndex = 3
        Me.lblImmatriculation.Text = "Immatriculation"
        '
        'txtBoxIdentifiant
        '
        Me.txtBoxIdentifiant.Location = New System.Drawing.Point(130, 161)
        Me.txtBoxIdentifiant.Name = "txtBoxIdentifiant"
        Me.txtBoxIdentifiant.Size = New System.Drawing.Size(153, 20)
        Me.txtBoxIdentifiant.TabIndex = 4
        Me.txtBoxIdentifiant.Text = "01"
        Me.txtBoxIdentifiant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxImmatriculation
        '
        Me.txtBoxImmatriculation.Location = New System.Drawing.Point(130, 202)
        Me.txtBoxImmatriculation.Name = "txtBoxImmatriculation"
        Me.txtBoxImmatriculation.Size = New System.Drawing.Size(153, 20)
        Me.txtBoxImmatriculation.TabIndex = 5
        Me.txtBoxImmatriculation.Text = "YHG - 536 - HUK"
        Me.txtBoxImmatriculation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(40, 258)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(175, 258)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 9
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'lstAffichCaserne
        '
        Me.lstAffichCaserne.CheckBoxes = True
        Me.lstAffichCaserne.Location = New System.Drawing.Point(129, 15)
        Me.lstAffichCaserne.Name = "lstAffichCaserne"
        Me.lstAffichCaserne.Size = New System.Drawing.Size(154, 67)
        Me.lstAffichCaserne.TabIndex = 10
        Me.lstAffichCaserne.UseCompatibleStateImageBehavior = False
        Me.lstAffichCaserne.View = System.Windows.Forms.View.SmallIcon
        '
        'lstAffichTypeEngin
        '
        Me.lstAffichTypeEngin.CheckBoxes = True
        Me.lstAffichTypeEngin.Location = New System.Drawing.Point(128, 88)
        Me.lstAffichTypeEngin.Name = "lstAffichTypeEngin"
        Me.lstAffichTypeEngin.Size = New System.Drawing.Size(155, 60)
        Me.lstAffichTypeEngin.TabIndex = 11
        Me.lstAffichTypeEngin.UseCompatibleStateImageBehavior = False
        Me.lstAffichTypeEngin.View = System.Windows.Forms.View.SmallIcon
        '
        'gest_engins_ajout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 322)
        Me.Controls.Add(Me.lstAffichTypeEngin)
        Me.Controls.Add(Me.lstAffichCaserne)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
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
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents lstAffichCaserne As System.Windows.Forms.ListView
    Friend WithEvents lstAffichTypeEngin As System.Windows.Forms.ListView
End Class
