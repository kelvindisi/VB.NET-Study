Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
        'Handle the click events for each combo box
        AddHandler cmbSpeed.SelectedIndexChanged, AddressOf Speed
        AddHandler cmbLen.SelectedIndexChanged, AddressOf DataLen
        AddHandler cmbParity.SelectedIndexChanged, AddressOf Parity
        AddHandler cmdClose.Click, AddressOf CloseMe
        cmbSpeed.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSpeed.Items.Add("9,600")
        cmbSpeed.Items.Add("4,800")
        cmbSpeed.Items.Add("2,400")
        cmbSpeed.SelectedIndex = 0
        cmbFlow.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFlow.Items.Add("NONE")
        cmbFlow.Items.Add("XON/XOFF")
        cmbFlow.Items.Add("HARDWARE")
        cmbFlow.SelectedIndex = 0

    End Sub
    Private Sub Speed(ByVal Sender As Object, ByVal e As EventArgs)
        Select Case (cmbSpeed.Text)
            Case "9,600"
                cmbLen.Items.Clear()
                cmbLen.Items.Add("7 Bits")
                cmbLen.Items.Add("8 Bits")
            Case "4,800"
                cmbLen.Items.Clear()
                cmbLen.Items.Add("6 Bits")
                cmbLen.Items.Add("7 Bits")
            Case "2,400"
                cmbLen.Items.Clear()
                cmbLen.Items.Add("5 Bits")
                cmbLen.Items.Add("6 Bits")
            Case "1,200"
                cmbLen.Items.Clear()
                cmbLen.Items.Add("8 Bits")
        End Select
        cmbLen.SelectedIndex = 0
    End Sub
    Private Sub DataLen(ByVal Sender As Object, ByVal e As EventArgs)
        Select Case (cmbLen.Text)
            Case "5 Bits"
                If cmbSpeed.Text = "2,400" Then
                    cmbParity.Items.Clear()
                    cmbParity.Items.Add("ODD")
                    cmbParity.Items.Add("EVEN")
                End If
            Case "6 Bits"
                If cmbSpeed.Text = "4,800" Then
                    cmbParity.Items.Clear()
                    cmbParity.Items.Add("MARK")
                End If
                If cmbSpeed.Text = "2,400" Then
                    cmbParity.Items.Clear()
                    cmbParity.Items.Add("ODD")
                End If
            Case "7 Bits"
                If cmbSpeed.Text = "9,600" Then
                    cmbParity.Items.Clear()
                    cmbParity.Items.Add("ODD")
                    cmbParity.Items.Add("EVEN")
                End If
                If cmbSpeed.Text = "4,800" Then
                    cmbParity.Items.Clear()
                    cmbParity.Items.Add("SPACE")
                End If
            Case "8 Bits"
                If cmbSpeed.Text = "9,600" Then
                    cmbParity.Items.Clear()
                    cmbParity.Items.Add("NONE")
                End If
        End Select
        cmbParity.SelectedIndex = 0
    End Sub
    Private Sub Parity(ByVal Sender As Object, ByVal e As EventArgs)
        Select Case (cmbParity.Text)
            Case "NONE"
                If cmbLen.Text = "8 Bits" Then
                    cmbStop.Items.Clear()
                    cmbStop.Items.Add("1")
                End If
            Case "ODD"
                If cmbLen.Text = "5 Bits" Then
                    cmbStop.Items.Clear()
                    cmbStop.Items.Add("1")
                End If
                If cmbLen.Text = "6 Bits" Then
                    cmbStop.Items.Clear()
                    cmbStop.Items.Add("1")
                End If
                If cmbLen.Text = "7 Bits" Then
                    cmbStop.Items.Clear()
                    cmbStop.Items.Add("1")
                End If
            Case "EVEN"
                If cmbLen.Text = "5 Bits" Then
                    cmbStop.Items.Clear()
                    cmbStop.Items.Add("1")
                    cmbStop.Items.Add("1.5")
                End If
                If cmbLen.Text = "7 Bits" Then
                    cmbStop.Items.Clear()
                    cmbStop.Items.Add("2")
                End If
            Case "SPACE"
                If cmbLen.Text = "7 Bits" Then
                    cmbStop.Items.Clear()
                    cmbStop.Items.Add("1")
                    cmbStop.Items.Add("2")
                End If
            Case "MARK"
                If cmbLen.Text = "6 Bits" Then
                    cmbStop.Items.Clear()
                    cmbStop.Items.Add("1")
                End If
        End Select
        cmbStop.SelectedIndex = 0
    End Sub
    Private Sub CloseMe(ByVal Sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
