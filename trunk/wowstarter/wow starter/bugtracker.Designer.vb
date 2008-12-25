<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bugtracker
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
        Me.Servertyp = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.fehlerart = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.fehlername = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.beschreibung = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Morpheus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(41, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server:"
        '
        'Servertyp
        '
        Me.Servertyp.FormattingEnabled = True
        Me.Servertyp.Items.AddRange(New Object() {"Cerberus", "Poseidon", "Alle Realms"})
        Me.Servertyp.Location = New System.Drawing.Point(41, 90)
        Me.Servertyp.Name = "Servertyp"
        Me.Servertyp.Size = New System.Drawing.Size(151, 21)
        Me.Servertyp.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Morpheus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(41, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fehlerart:"
        '
        'fehlerart
        '
        Me.fehlerart.FormattingEnabled = True
        Me.fehlerart.Items.AddRange(New Object() {"Quest", "Item", "Portal", "World", "Character", "Account", "WoW Starter"})
        Me.fehlerart.Location = New System.Drawing.Point(41, 137)
        Me.fehlerart.Name = "fehlerart"
        Me.fehlerart.Size = New System.Drawing.Size(151, 21)
        Me.fehlerart.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Morpheus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(41, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name:"
        '
        'fehlername
        '
        Me.fehlername.Location = New System.Drawing.Point(41, 184)
        Me.fehlername.Name = "fehlername"
        Me.fehlername.Size = New System.Drawing.Size(151, 20)
        Me.fehlername.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Morpheus", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(41, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Beschreibung:"
        '
        'beschreibung
        '
        Me.beschreibung.Location = New System.Drawing.Point(45, 230)
        Me.beschreibung.Name = "beschreibung"
        Me.beschreibung.Size = New System.Drawing.Size(241, 142)
        Me.beschreibung.TabIndex = 9
        Me.beschreibung.Text = ""
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.back
        Me.Button1.Location = New System.Drawing.Point(73, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Absenden"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label5.Location = New System.Drawing.Point(233, 388)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(81, 13)
        Me.label5.TabIndex = 11
        Me.label5.Text = "Version: 0.0.0.1"
        '
        'bugtracker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.bg2
        Me.ClientSize = New System.Drawing.Size(326, 413)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.beschreibung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fehlername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fehlerart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Servertyp)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "bugtracker"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bugtracker"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Servertyp As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fehlerart As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fehlername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents beschreibung As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents label5 As System.Windows.Forms.Label
End Class
