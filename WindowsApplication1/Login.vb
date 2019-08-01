Imports MySql.Data.MySqlClient

Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim READER As MySqlDataReader















    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=toor;database=jisdb"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from jisdb.accounts where binary username='" & BunifuMaterialTextbox2.Text & "'and binary password='" & BunifuMaterialTextbox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read

                count = count + 1

            End While

            If count = 1 Then
                MessageBox.Show("Username and password are correct")

                Menufrm.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are incorrect")


            End If
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BunifuMaterialTextbox1.Text = ""
        BunifuMaterialTextbox2.Text = ""

    End Sub



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        BunifuMaterialTextbox1.isPassword = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Panel4.Show()
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        Label1.ForeColor = Color.Orange
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Login_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Panel4.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        Dim ew As String
        ew = "admin"
        Dim cmd As New MySqlCommand
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim reader As MySqlDataReader
        GoTo 1
Update:

        Try
            conn.Open()
            Dim query As String
            query = " update accounts set password=""1234"""
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            reader.Read()

            conn.Close()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            MessageBox.Show("Paswword has been reset to 1234")
            Panel4.Hide()
            GoTo tapos
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
1:
        Try
            conn.Open()
            Dim query As String
            query = " select * from accounts where Username='" & ew & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            reader.Read()

            If TextBox3.Text = reader.GetString("sec_ans1") Then
                If TextBox4.Text = reader.GetString("sec_ans2") Then
                    If TextBox5.Text = reader.GetString("sec_ans3") Then
                        GoTo update

                    Else
                        GoTo Err
                    End If
                End If
            End If
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

Err:
        MessageBox.Show("Wrong Answers")
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
tapos:
    End Sub
End Class