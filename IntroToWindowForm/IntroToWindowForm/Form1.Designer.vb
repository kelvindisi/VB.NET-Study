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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSchool = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSem = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCat1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCat2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCat3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAssignment1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAssignment2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtExam = New System.Windows.Forms.TextBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(99, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(242, 29)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(347, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Registration No:"
        '
        'txtRegNo
        '
        Me.txtRegNo.Location = New System.Drawing.Point(519, 42)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(204, 29)
        Me.txtRegNo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "School:"
        '
        'cboCourse
        '
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.Location = New System.Drawing.Point(305, 93)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(121, 29)
        Me.cboCourse.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 21)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Course:"
        '
        'cboSchool
        '
        Me.cboSchool.FormattingEnabled = True
        Me.cboSchool.Location = New System.Drawing.Point(99, 93)
        Me.cboSchool.Name = "cboSchool"
        Me.cboSchool.Size = New System.Drawing.Size(121, 29)
        Me.cboSchool.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(432, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Year:"
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Location = New System.Drawing.Point(495, 93)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(73, 29)
        Me.cboYear.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(574, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sem:"
        '
        'cboSem
        '
        Me.cboSem.FormattingEnabled = True
        Me.cboSem.Location = New System.Drawing.Point(632, 93)
        Me.cboSem.Name = "cboSem"
        Me.cboSem.Size = New System.Drawing.Size(73, 29)
        Me.cboSem.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.cboSchool)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboSem)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboYear)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboCourse)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRegNo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 173)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtCat3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCat2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtAssignment2)
        Me.GroupBox2.Controls.Add(Me.txtExam)
        Me.GroupBox2.Controls.Add(Me.txtAssignment1)
        Me.GroupBox2.Controls.Add(Me.txtCat1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(745, 156)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 21)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cat 1"
        '
        'txtCat1
        '
        Me.txtCat1.Location = New System.Drawing.Point(99, 30)
        Me.txtCat1.Name = "txtCat1"
        Me.txtCat1.Size = New System.Drawing.Size(121, 29)
        Me.txtCat1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cat 2"
        '
        'txtCat2
        '
        Me.txtCat2.Location = New System.Drawing.Point(99, 65)
        Me.txtCat2.Name = "txtCat2"
        Me.txtCat2.Size = New System.Drawing.Size(121, 29)
        Me.txtCat2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Cat 3"
        '
        'txtCat3
        '
        Me.txtCat3.Location = New System.Drawing.Point(99, 100)
        Me.txtCat3.Name = "txtCat3"
        Me.txtCat3.Size = New System.Drawing.Size(121, 29)
        Me.txtCat3.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(233, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 21)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Assignmet 1"
        '
        'txtAssignment1
        '
        Me.txtAssignment1.Location = New System.Drawing.Point(397, 28)
        Me.txtAssignment1.Name = "txtAssignment1"
        Me.txtAssignment1.Size = New System.Drawing.Size(121, 29)
        Me.txtAssignment1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(233, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Assignment 2"
        '
        'txtAssignment2
        '
        Me.txtAssignment2.Location = New System.Drawing.Point(397, 63)
        Me.txtAssignment2.Name = "txtAssignment2"
        Me.txtAssignment2.Size = New System.Drawing.Size(121, 29)
        Me.txtAssignment2.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(524, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 21)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Exam"
        '
        'txtExam
        '
        Me.txtExam.Location = New System.Drawing.Point(602, 43)
        Me.txtExam.Name = "txtExam"
        Me.txtExam.Size = New System.Drawing.Size(121, 29)
        Me.txtExam.TabIndex = 1
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 21
        Me.lstOutput.Location = New System.Drawing.Point(317, 363)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(439, 130)
        Me.lstOutput.TabIndex = 5
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(97, 382)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(79, 39)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(97, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(770, 499)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Student Score"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRegNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboSchool As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboYear As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboSem As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCat3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCat2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAssignment2 As TextBox
    Friend WithEvents txtExam As TextBox
    Friend WithEvents txtAssignment1 As TextBox
    Friend WithEvents txtCat1 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents Button1 As Button
End Class
