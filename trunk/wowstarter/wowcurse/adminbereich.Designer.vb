<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminbereich
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.bugtext = New System.Windows.Forms.RichTextBox
        Me.ladenreport = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Willkommen im Adminbereich von WoWCurse"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bugreport:"
        '
        'bugtext
        '
        Me.bugtext.BackColor = System.Drawing.SystemColors.Control
        Me.bugtext.Location = New System.Drawing.Point(16, 73)
        Me.bugtext.Name = "bugtext"
        Me.bugtext.Size = New System.Drawing.Size(458, 115)
        Me.bugtext.TabIndex = 2
        Me.bugtext.Text = ""
        '
        'ladenreport
        '
        Me.ladenreport.Location = New System.Drawing.Point(16, 204)
        Me.ladenreport.Name = "ladenreport"
        Me.ladenreport.Size = New System.Drawing.Size(96, 23)
        Me.ladenreport.TabIndex = 3
        Me.ladenreport.Text = "neu laden"
        Me.ladenreport.UseVisualStyleBackColor = True
        '
        'adminbereich
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 420)
        Me.Controls.Add(Me.ladenreport)
        Me.Controls.Add(Me.bugtext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminbereich"
        Me.Text = "adminbereich"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bugtext As System.Windows.Forms.RichTextBox
    Friend WithEvents ladenreport As System.Windows.Forms.Button
End Class
