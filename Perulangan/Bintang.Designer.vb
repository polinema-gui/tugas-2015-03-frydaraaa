<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bintang
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
        Me.Lbl_pola = New System.Windows.Forms.Label()
        Me.Lbl_baris = New System.Windows.Forms.Label()
        Me.Txbox_Baris = New System.Windows.Forms.TextBox()
        Me.Btn_proses = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_pola
        '
        Me.Lbl_pola.AutoSize = True
        Me.Lbl_pola.Location = New System.Drawing.Point(26, 22)
        Me.Lbl_pola.Name = "Lbl_pola"
        Me.Lbl_pola.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_pola.TabIndex = 0
        Me.Lbl_pola.Text = "Pola :"
        '
        'Lbl_baris
        '
        Me.Lbl_baris.AutoSize = True
        Me.Lbl_baris.Location = New System.Drawing.Point(26, 52)
        Me.Lbl_baris.Name = "Lbl_baris"
        Me.Lbl_baris.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_baris.TabIndex = 1
        Me.Lbl_baris.Text = "Baris : "
        '
        'Txbox_Baris
        '
        Me.Txbox_Baris.Location = New System.Drawing.Point(71, 52)
        Me.Txbox_Baris.Name = "Txbox_Baris"
        Me.Txbox_Baris.Size = New System.Drawing.Size(259, 20)
        Me.Txbox_Baris.TabIndex = 2
        '
        'Btn_proses
        '
        Me.Btn_proses.Location = New System.Drawing.Point(336, 52)
        Me.Btn_proses.Name = "Btn_proses"
        Me.Btn_proses.Size = New System.Drawing.Size(117, 23)
        Me.Btn_proses.TabIndex = 3
        Me.Btn_proses.Text = "Proses"
        Me.Btn_proses.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.ComboBox1.Location = New System.Drawing.Point(71, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(382, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(29, 81)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(424, 332)
        Me.TextBox1.TabIndex = 5
        '
        'Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Btn_proses)
        Me.Controls.Add(Me.Txbox_Baris)
        Me.Controls.Add(Me.Lbl_baris)
        Me.Controls.Add(Me.Lbl_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_pola As System.Windows.Forms.Label
    Friend WithEvents Lbl_baris As System.Windows.Forms.Label
    Friend WithEvents Txbox_Baris As System.Windows.Forms.TextBox
    Friend WithEvents Btn_proses As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
