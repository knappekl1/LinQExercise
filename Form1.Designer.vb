<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbA = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbABC = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbF = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A Students"
        '
        'lbA
        '
        Me.lbA.FormattingEnabled = True
        Me.lbA.ItemHeight = 25
        Me.lbA.Location = New System.Drawing.Point(59, 68)
        Me.lbA.Name = "lbA"
        Me.lbA.ScrollAlwaysVisible = True
        Me.lbA.Size = New System.Drawing.Size(642, 229)
        Me.lbA.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 326)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "A,B, C Students"
        '
        'lbABC
        '
        Me.lbABC.FormattingEnabled = True
        Me.lbABC.ItemHeight = 25
        Me.lbABC.Location = New System.Drawing.Point(59, 354)
        Me.lbABC.Name = "lbABC"
        Me.lbABC.ScrollAlwaysVisible = True
        Me.lbABC.Size = New System.Drawing.Size(642, 254)
        Me.lbABC.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 634)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "F Students"
        '
        'lbF
        '
        Me.lbF.FormattingEnabled = True
        Me.lbF.ItemHeight = 25
        Me.lbF.Location = New System.Drawing.Point(59, 662)
        Me.lbF.Name = "lbF"
        Me.lbF.Size = New System.Drawing.Size(642, 154)
        Me.lbF.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 910)
        Me.Controls.Add(Me.lbF)
        Me.Controls.Add(Me.lbABC)
        Me.Controls.Add(Me.lbA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Undertanding LINQ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbA As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbABC As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbF As ListBox
End Class
