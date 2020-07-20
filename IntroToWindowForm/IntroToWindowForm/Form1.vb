Public Class Form1
    Private stdName, course, regNo, school As String
    Private yos, sem, cat1, cat2, cat3, assign1, assign2, exam As Integer
    Private totalCats, totalAssign, avg As Double

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        getDetails()
        compute()
        printDetails()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private grade As Char

    Public Property PCat1() As Integer
        Get
            Return cat1
        End Get
        Set(ByVal value As Integer)
            If value < 0 Or value > 30 Then
                cat1 = 0
                MsgBox("Cat marks cannot be greater than 30 or less then 0")
            Else
                cat1 = value
            End If
        End Set
    End Property
    Public Property PCat2() As Integer
        Get
            Return cat2
        End Get
        Set(ByVal value As Integer)
            If value < 0 Or value > 30 Then
                cat2 = 0
                MsgBox("Cat marks cannot be greater than 30 or less then 0")
            Else
                cat2 = value
            End If
        End Set
    End Property
    Public Property PCat3() As Integer
        Get
            Return cat3
        End Get
        Set(ByVal value As Integer)
            If value < 0 Or value > 30 Then
                cat3 = 0
                MsgBox("Cat marks cannot be greater than 30 or less then 0")
            Else
                cat3 = value
            End If
        End Set
    End Property

    Public Property PExam() As Integer
        Get
            Return exam
        End Get
        Set(ByVal value As Integer)
            If value < 0 Or value > 70 Then
                exam = 0
                MsgBox("Cat marks cannot be greater than 70 or less then 0")
            Else
                exam = value
            End If
        End Set
    End Property
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtCat1.MaxLength = 2
        txtCat2.MaxLength = 2
        txtCat3.MaxLength = 2
        txtAssignment1.MaxLength = 2
        txtAssignment2.MaxLength = 2
        txtExam.MaxLength = 2
    End Sub

    Public Sub getDetails()
        stdName = txtName.Text
        regNo = txtRegNo.Text
        school = cboSchool.SelectedItem
        course = cboCourse.SelectedItem
        yos = CInt(cboYear.SelectedItem)
        sem = CInt(cboSem.SelectedItem)
        PCat1 = CInt(txtCat1.Text)
        PCat2 = CInt(txtCat2.Text)
        PCat3 = CInt(txtCat3.Text)

        assign1 = CInt(txtAssignment1.Text)
        assign2 = CInt(txtAssignment2.Text)

        PExam = CInt(txtExam.Text)
    End Sub

    Public Sub compute()
        totalCats = PCat1 + PCat2 + PCat3
        totalAssign = assign1 + assign2
        avg = (totalCats / 3) + (totalAssign / 2) + PExam

        If avg <= 39 Then
            grade = CChar("E")
        ElseIf avg <= 49 Then
            grade = CChar("D")
        ElseIf avg <= 59 Then
            grade = CChar("C")
        ElseIf avg <= 69 Then
            grade = CChar("B")
        Else
            grade = CChar("A")
        End If
    End Sub

    Public Sub printDetails()
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Student Name: " & vbTab & stdName)
        lstOutput.Items.Add("Registration No: " & vbTab & regNo)
        lstOutput.Items.Add("School: " & vbTab & school)
        lstOutput.Items.Add("Course: " & vbTab & course)
        lstOutput.Items.Add("Year Of Study: " & vbTab & yos)
        lstOutput.Items.Add("Semester: " & vbTab & sem)
        lstOutput.Items.Add("Grade: " & vbTab & grade)
        lstOutput.Items.Add("Date Printed: " & vbTab & Now())
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim schools() As String = New String() {"SCIT", "SPM", "SAC"}
        cboSchool.Items.AddRange(schools)
        cboSchool.SelectedIndex = 0

        cboYear.Items.AddRange(New String() {"1", "2", "3", "4"})
        cboYear.SelectedIndex = 0
        cboSem.Items.AddRange(New String() {"1", "2"})
        cboYear.SelectedIndex = 0
    End Sub

    Private Sub cboSchool_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSchool.SelectedIndexChanged
        If cboSchool.SelectedIndex = 0 Then
            cboCourse.Items.Clear()
            cboCourse.Items.AddRange(New String() {"BSc IT", "BBC", "DIT", "CIT"})
            cboCourse.SelectedIndex = 1
        ElseIf cboSchool.SelectedIndex = 1 Then
            cboCourse.Items.Clear()
            cboCourse.Items.AddRange(New String() {"BPM", "BAM", "Statistics"})
            cboCourse.SelectedIndex = 1
        ElseIf cboSchool.SelectedIndex = 2 Then
            cboCourse.Items.Clear()
            cboCourse.Items.AddRange(New String() {"Chemistry"})
            cboCourse.SelectedIndex = 0
        End If
    End Sub

    Private Sub txtExam_TextChanged(sender As Object, e As EventArgs) Handles txtExam.TextChanged

    End Sub
End Class
