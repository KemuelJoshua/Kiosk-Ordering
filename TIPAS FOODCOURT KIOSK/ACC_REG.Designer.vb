<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ACC_REG
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.storeCode = New System.Windows.Forms.TextBox()
        Me.browse = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.storeName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.password1 = New System.Windows.Forms.TextBox()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usr1 = New System.Windows.Forms.TextBox()
        Me.cls = New System.Windows.Forms.Label()
        Me.imagepath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.imagepath)
        Me.GroupBox1.Controls.Add(Me.storeCode)
        Me.GroupBox1.Controls.Add(Me.browse)
        Me.GroupBox1.Controls.Add(Me.deletebtn)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.updatebtn)
        Me.GroupBox1.Controls.Add(Me.storeName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.password1)
        Me.GroupBox1.Controls.Add(Me.addbtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.usr1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(697, 364)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACCOUNT REGISTRATION"
        '
        'storeCode
        '
        Me.storeCode.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storeCode.Location = New System.Drawing.Point(343, 71)
        Me.storeCode.Multiline = True
        Me.storeCode.Name = "storeCode"
        Me.storeCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.storeCode.Size = New System.Drawing.Size(325, 26)
        Me.storeCode.TabIndex = 8
        '
        'browse
        '
        Me.browse.BackColor = System.Drawing.Color.Green
        Me.browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.browse.Font = New System.Drawing.Font("Cambria", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse.ForeColor = System.Drawing.Color.White
        Me.browse.Location = New System.Drawing.Point(35, 237)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(273, 43)
        Me.browse.TabIndex = 2
        Me.browse.Text = "BROWSE IMAGE"
        Me.browse.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.Red
        Me.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.deletebtn.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.White
        Me.deletebtn.Location = New System.Drawing.Point(458, 298)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(210, 39)
        Me.deletebtn.TabIndex = 13
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(35, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(337, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "STORE CODE"
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.Yellow
        Me.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.updatebtn.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.Black
        Me.updatebtn.Location = New System.Drawing.Point(241, 298)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(211, 39)
        Me.updatebtn.TabIndex = 15
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'storeName
        '
        Me.storeName.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storeName.Location = New System.Drawing.Point(339, 249)
        Me.storeName.Multiline = True
        Me.storeName.Name = "storeName"
        Me.storeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.storeName.Size = New System.Drawing.Size(329, 26)
        Me.storeName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(339, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "STORE NAME"
        '
        'password1
        '
        Me.password1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password1.Location = New System.Drawing.Point(339, 186)
        Me.password1.Multiline = True
        Me.password1.Name = "password1"
        Me.password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.password1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.password1.Size = New System.Drawing.Size(329, 26)
        Me.password1.TabIndex = 4
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.Yellow
        Me.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addbtn.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.Black
        Me.addbtn.Location = New System.Drawing.Point(35, 298)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(200, 39)
        Me.addbtn.TabIndex = 13
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(341, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PASSWORD"
        '
        'usr1
        '
        Me.usr1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usr1.Location = New System.Drawing.Point(340, 127)
        Me.usr1.Multiline = True
        Me.usr1.Name = "usr1"
        Me.usr1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.usr1.Size = New System.Drawing.Size(328, 26)
        Me.usr1.TabIndex = 2
        '
        'cls
        '
        Me.cls.AutoSize = True
        Me.cls.BackColor = System.Drawing.Color.Transparent
        Me.cls.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cls.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cls.ForeColor = System.Drawing.Color.Red
        Me.cls.Location = New System.Drawing.Point(682, 5)
        Me.cls.Name = "cls"
        Me.cls.Size = New System.Drawing.Size(27, 28)
        Me.cls.TabIndex = 16
        Me.cls.Text = "X"
        '
        'imagepath
        '
        Me.imagepath.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imagepath.Location = New System.Drawing.Point(499, 29)
        Me.imagepath.Multiline = True
        Me.imagepath.Name = "imagepath"
        Me.imagepath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.imagepath.Size = New System.Drawing.Size(179, 33)
        Me.imagepath.TabIndex = 16
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ACC_REG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 421)
        Me.Controls.Add(Me.cls)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ACC_REG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "zzzzz"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents browse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents storeName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents password1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents usr1 As TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STORENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IMAGEPATHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents IMAGEPATHDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents storeCode As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents cls As Label
    Friend WithEvents imagepath As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
