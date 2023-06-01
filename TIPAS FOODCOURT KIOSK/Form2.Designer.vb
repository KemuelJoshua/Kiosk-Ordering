<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QUANTITY
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.minus_btn = New System.Windows.Forms.Button()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.lblStorename = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.TP = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.lblstore = New System.Windows.Forms.Label()
        Me.lblhide = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(179, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 26)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'minus_btn
        '
        Me.minus_btn.BackColor = System.Drawing.Color.Red
        Me.minus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.minus_btn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minus_btn.ForeColor = System.Drawing.Color.White
        Me.minus_btn.Location = New System.Drawing.Point(109, 141)
        Me.minus_btn.Name = "minus_btn"
        Me.minus_btn.Size = New System.Drawing.Size(64, 27)
        Me.minus_btn.TabIndex = 1
        Me.minus_btn.Text = "-"
        Me.minus_btn.UseVisualStyleBackColor = False
        '
        'Add_btn
        '
        Me.Add_btn.BackColor = System.Drawing.Color.Red
        Me.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Add_btn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_btn.ForeColor = System.Drawing.Color.White
        Me.Add_btn.Location = New System.Drawing.Point(309, 143)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(63, 25)
        Me.Add_btn.TabIndex = 2
        Me.Add_btn.Text = "+"
        Me.Add_btn.UseVisualStyleBackColor = False
        '
        'lblStorename
        '
        Me.lblStorename.AutoSize = True
        Me.lblStorename.BackColor = System.Drawing.Color.Yellow
        Me.lblStorename.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStorename.Location = New System.Drawing.Point(146, 79)
        Me.lblStorename.Name = "lblStorename"
        Me.lblStorename.Size = New System.Drawing.Size(124, 22)
        Me.lblStorename.TabIndex = 4
        Me.lblStorename.Text = "STORE NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(172, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Price : "
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(229, 110)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(82, 25)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "lblPrice"
        '
        'TP
        '
        Me.TP.AutoSize = True
        Me.TP.BackColor = System.Drawing.Color.Transparent
        Me.TP.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TP.Location = New System.Drawing.Point(249, 186)
        Me.TP.Name = "TP"
        Me.TP.Size = New System.Drawing.Size(56, 19)
        Me.TP.TabIndex = 8
        Me.TP.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Price :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(109, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(263, 40)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "ADD"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'lblstore
        '
        Me.lblstore.AutoSize = True
        Me.lblstore.Location = New System.Drawing.Point(319, 44)
        Me.lblstore.Name = "lblstore"
        Me.lblstore.Size = New System.Drawing.Size(0, 13)
        Me.lblstore.TabIndex = 11
        Me.lblstore.Visible = False
        '
        'lblhide
        '
        Me.lblhide.AutoSize = True
        Me.lblhide.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhide.Location = New System.Drawing.Point(383, 79)
        Me.lblhide.Name = "lblhide"
        Me.lblhide.Size = New System.Drawing.Size(78, 17)
        Me.lblhide.TabIndex = 12
        Me.lblhide.Text = "Store name"
        '
        'QUANTITY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = Global.TIPAS_FOODCOURT_KIOSK.My.Resources.Resources.QUAN1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 293)
        Me.Controls.Add(Me.lblhide)
        Me.Controls.Add(Me.lblstore)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStorename)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.minus_btn)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QUANTITY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Description"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents minus_btn As Button
    Friend WithEvents Add_btn As Button
    Friend WithEvents lblStorename As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents TP As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents lblstore As Label
    Friend WithEvents lblhide As Label
End Class
