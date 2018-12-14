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
        Me.lstAffichTypeEngin = New System.Windows.Forms.ListView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lblCaserne
        '
        Me.lblCaserne.AutoSize = True
        Me.lblCaserne.Location = New System.Drawing.Point(35, 43)
        Me.lblCaserne.Name = "lblCaserne"
        Me.lblCaserne.Size = New System.Drawing.Size(46, 13)
        Me.lblCaserne.TabIndex = 0
        Me.lblCaserne.Text = "Caserne"
        '
        'lbIdentifiant
        '
        Me.lbIdentifiant.AutoSize = True
        Me.lbIdentifiant.Location = New System.Drawing.Point(35, 162)
        Me.lbIdentifiant.Name = "lbIdentifiant"
        Me.lbIdentifiant.Size = New System.Drawing.Size(53, 13)
        Me.lbIdentifiant.TabIndex = 1
        Me.lbIdentifiant.Text = "Identifiant"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(35, 115)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 2
        Me.lblType.Text = "Type"
        '
        'lblImmatriculation
        '
        Me.lblImmatriculation.AutoSize = True
        Me.lblImmatriculation.Location = New System.Drawing.Point(35, 203)
        Me.lblImmatriculation.Name = "lblImmatriculation"
        Me.lblImmatriculation.Size = New System.Drawing.Size(77, 13)
        Me.lblImmatriculation.TabIndex = 3
        Me.lblImmatriculation.Text = "Immatriculation"
        '
        'txtBoxIdentifiant
        '
        Me.txtBoxIdentifiant.Location = New System.Drawing.Point(134, 155)
        Me.txtBoxIdentifiant.Name = "txtBoxIdentifiant"
        Me.txtBoxIdentifiant.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxIdentifiant.TabIndex = 4
        Me.txtBoxIdentifiant.Text = "01"
        '
        'txtBoxImmatriculation
        '
        Me.txtBoxImmatriculation.Location = New System.Drawing.Point(133, 196)
        Me.txtBoxImmatriculation.Name = "txtBoxImmatriculation"
        Me.txtBoxImmatriculation.Size = New System.Drawing.Size(120, 20)
        Me.txtBoxImmatriculation.TabIndex = 5
        Me.txtBoxImmatriculation.Text = "YHG - 536 - HUK"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(40, 254)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Location = New System.Drawing.Point(177, 254)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnuler.TabIndex = 9
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'lstAffichTypeEngin
        '
        Me.lstAffichTypeEngin.CheckBoxes = True
        Me.lstAffichTypeEngin.Location = New System.Drawing.Point(131, 96)
        Me.lstAffichTypeEngin.Name = "lstAffichTypeEngin"
        Me.lstAffichTypeEngin.Size = New System.Drawing.Size(121, 41)
        Me.lstAffichTypeEngin.TabIndex = 10
        Me.lstAffichTypeEngin.UseCompatibleStateImageBehavior = False
        Me.lstAffichTypeEngin.View = System.Windows.Forms.View.SmallIcon
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(131, 30)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 41)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'gest_engins_ajout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 340)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lstAffichTypeEngin)
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
    Friend WithEvents lstAffichTypeEngin As System.Windows.Forms.ListView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
