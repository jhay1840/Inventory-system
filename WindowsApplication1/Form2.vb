Imports MySql.Data.MySqlClient
Public Class Form2
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Panel3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel3.Hide()
        Panel4.Hide()
        Dim ew As String
        ew = "admin"
        Dim cmd As New MySqlCommand
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = " select * from accounts where Username='" & ew & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                TextBox3.Text = reader.GetString("sec_ans1")
                TextBox4.Text = reader.GetString("sec_ans2")
                TextBox5.Text = reader.GetString("sec_ans3")
            End While
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Dim ew As String
        ew = "admin"
        Dim cmd As New MySqlCommand
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = " select * from accounts where Username='" & ew & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            reader.Read()

            If TextBox1.Text = reader.GetString("password") Then

                GoTo Update
            Else
                GoTo Err
            End If
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
Update:
        Try
            conn.Open()
            Dim query As String
            query = "update accounts set password='" & TextBox2.Text & "' where username='" & ew & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            conn.Close()
            MessageBox.Show("Saved Succesfully")
            TextBox1.Clear()
            TextBox2.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        GoTo tapos
Err:
        MessageBox.Show("Wrong Password")
        TextBox1.Clear()
        TextBox2.Clear()
tapos:
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Panel4.Show()
    End Sub

    Private Sub Form2_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Panel3.Hide()
        Panel4.Hide()
    End Sub

    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.Click

    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim ew As String
        ew = "admin"
        Dim cmd As New MySqlCommand
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "update accounts set sec_ans1='" & TextBox3.Text & "',sec_ans2='" & TextBox4.Text & "',sec_ans3='" & TextBox5.Text & "' where username='" & ew & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            conn.Close()
            MessageBox.Show("Save succesfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class