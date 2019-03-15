<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestion_engins_ajout
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
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblImmatriculation = New System.Windows.Forms.Label()
        Me.txtBoxNom = New System.Windows.Forms.TextBox()
        Me.txtBoxImmatriculation = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.CbCaserne = New System.Windows.Forms.ComboBox()
        Me.CbType = New System.Windows.Forms.ComboBox()
        Me.lblNom = New System.Windows.Forms.Label()
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
        'txtBoxNom
        '
        Me.txtBoxNom.Location = New System.Drawing.Point(130, 116)
        Me.txtBoxNom.Name = "txtBoxNom"
        Me.txtBoxNom.Size = New System.Drawing.Size(151, 20)
        Me.txtBoxNom.TabIndex = 4
        '
        'txtBoxImmatriculation
        '
        Me.txtBoxImmatriculation.Location = New System.Drawing.Point(130, 151)
        Me.txtBoxImmatriculation.Name = "txtBoxImmatriculation"
        Me.txtBoxImmatriculation.Size = New System.Drawing.Size(151, 20)
        Me.txtBoxImmatriculation.TabIndex = 5
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
        'CbCaserne
        '
        Me.CbCaserne.FormattingEnabled = True
        Me.CbCaserne.Location = New System.Drawing.Point(130, 40)
        Me.CbCaserne.Name = "CbCaserne"
        Me.CbCaserne.Size = New System.Drawing.Size(151, 21)
        Me.CbCaserne.TabIndex = 10
        '
        'CbType
        '
        Me.CbType.FormattingEnabled = True
        Me.CbType.Location = New System.Drawing.Point(130, 80)
        Me.CbType.Name = "CbType"
        Me.CbType.Size = New System.Drawing.Size(151, 21)
        Me.CbType.TabIndex = 11
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(40, 122)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(29, 13)
        Me.lblNom.TabIndex = 12
        Me.lblNom.Text = "Nom"
        '
        'gestion_engins_ajout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 261)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.CbType)
        Me.Controls.Add(Me.CbCaserne)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtBoxImmatriculation)
        Me.Controls.Add(Me.txtBoxNom)
        Me.Controls.Add(Me.lblImmatriculation)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblCaserne)
        Me.Name = "gestion_engins_ajout"
        Me.Text = "AJOUT D'ENGINS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCaserne As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents lblImmatriculation As System.Windows.Forms.Label
    Friend WithEvents txtBoxNom As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxImmatriculation As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents CbCaserne As System.Windows.Forms.ComboBox
    Friend WithEvents CbType As System.Windows.Forms.ComboBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
End Class
