<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtinicio = New TextBox()
        txtfin = New TextBox()
        btnsuma = New Button()
        lblresultado = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(131, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 0
        Label1.Text = "Valor inicial"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(131, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 1
        Label2.Text = "Valor final"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(142, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 2
        Label3.Text = "Resultado"
        ' 
        ' txtinicio
        ' 
        txtinicio.Location = New Point(274, 66)
        txtinicio.Name = "txtinicio"
        txtinicio.Size = New Size(125, 27)
        txtinicio.TabIndex = 3
        ' 
        ' txtfin
        ' 
        txtfin.Location = New Point(274, 113)
        txtfin.Name = "txtfin"
        txtfin.Size = New Size(125, 27)
        txtfin.TabIndex = 4
        ' 
        ' btnsuma
        ' 
        btnsuma.BackColor = Color.Snow
        btnsuma.ForeColor = SystemColors.ActiveCaptionText
        btnsuma.Location = New Point(174, 245)
        btnsuma.Name = "btnsuma"
        btnsuma.Size = New Size(153, 72)
        btnsuma.TabIndex = 5
        btnsuma.Text = "Calcular"
        btnsuma.UseVisualStyleBackColor = False
        ' 
        ' lblresultado
        ' 
        lblresultado.AutoSize = True
        lblresultado.Location = New Point(274, 182)
        lblresultado.Name = "lblresultado"
        lblresultado.Size = New Size(53, 20)
        lblresultado.TabIndex = 6
        lblresultado.Text = "Label4"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(554, 450)
        Controls.Add(lblresultado)
        Controls.Add(btnsuma)
        Controls.Add(txtfin)
        Controls.Add(txtinicio)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtinicio As TextBox
    Friend WithEvents txtfin As TextBox
    Friend WithEvents btnsuma As Button
    Friend WithEvents lblresultado As Label

End Class
