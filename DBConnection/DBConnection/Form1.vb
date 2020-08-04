Imports MySql.Data.MySqlClient

Public Class Form1
    Public conn As MySqlConnection = New MySqlConnection()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen

        cboCourse.Items.AddRange(New String() {"BscIT", "BBC", "DIT", "CIT"})
        cboCourse.SelectedIndex = 0
        connectToDb()
    End Sub
    Public Sub connectToDb()
        conn.ConnectionString = "server=localhost;user id=root;password=;database=BIT2118"
        Try
            conn.Open()
            MsgBox("Connection successful")
        Catch ex As Exception
            MsgBox("Connection not successfull" & vbNewLine & ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Clear()
        txtRegNo.Clear()
        cboCourse.SelectedIndex = 0
    End Sub

    Private Sub closeConnection()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
