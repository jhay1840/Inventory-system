Imports MySql.Data.MySqlClient
Public Class updatefrm
    Dim cmd As New MySqlCommand
    Private Sub updatefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JisdbDataSet.categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me.JisdbDataSet.categories)
        'TODO: This line of code loads data into the 'JisdbDataSet.products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.JisdbDataSet.products)
        BunifuFlatButton3.Enabled = False
        ProductsBindingSource.AddNew()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If (Panel1.Width = 50) Then

            Panel1.Visible = False
            Panel1.Width = 236
            BunifuImageButton1.Location = New System.Drawing.Point(192, 14)


            BunifuTransition1.ShowSync(Panel1)
            BunifuTransition2.ShowSync(PictureBox1)

        Else
            Panel1.Visible = False
            PictureBox1.Visible = False


            BunifuImageButton1.Location = New System.Drawing.Point(10, 14)
            Panel1.Width = 50
            BunifuTransition1.ShowSync(Panel1)


        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Menufrm.Show()
        Me.Hide()
    End Sub


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click



        ProductsBindingSource.EndEdit()
        ProductsTableAdapter.Update(JisdbDataSet.products)
        ProductsBindingSource.AddNew()


        Dim wew = MessageBox.Show(" Saved Succesfully", "Prompt", MessageBoxButtons.OK)
SaveErr:
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        purchasefrm.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

        Dim result = MessageBox.Show(" Are you sure you want to logout", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub add_panel_Paint(sender As Object, e As PaintEventArgs) Handles add_panel.Paint

    End Sub
    Private Sub gettext()
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim sda As New MySqlDataAdapter

        Dim bsource As New BindingSource
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM jisdb.products where ProductName like '%" & TextBox7.Text & "%'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read
                TextBox9.Text = reader.GetInt32("productid")
                TextBox6.Text = reader.GetInt32("Stocks")
            End While

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        gettext()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click


        Dim quantity As Integer
            Dim available As Integer
            Dim result As Integer

            quantity = TextBox5.Text
            available = TextBox6.Text
            result = available + quantity
            TextBox8.Text = result
            Dim conn As New MySqlConnection

            conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
            Dim reader As MySqlDataReader

            Try
                conn.Open()
                Dim query As String
                query = "update  jisdb.products set stocks='" & TextBox8.Text & "' where productid='" & TextBox9.Text & "' "
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader

            conn.Close()
            conn.Open()

            query = "insert into jisdb.add_stocks (productname,stocks_added,date) values ('" & TextBox7.Text & "','" & TextBox5.Text & "','" & BunifuCustomLabel23.Text & "')"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            conn.Close()
            Dim wew = MessageBox.Show(" Saved Succesfully", "Prompt", MessageBoxButtons.OK)
        Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try

        TextBox5.Clear()
            TextBox6.Clear()
            TextBox8.Clear()
            TextBox7.Clear()

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        Panel3.Visible = False
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        Panel3.Visible = True
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        gettextp()
        TextBox12.Enabled = True
        DateTimePicker1.Enabled = True

    End Sub
    Private Sub gettextp()
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim sda As New MySqlDataAdapter

        Dim bsource As New BindingSource
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM jisdb.products where ProductName like '%" & TextBox10.Text & "%'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read
                TextBox14.Text = reader.GetInt32("productid")
                TextBox11.Text = reader.GetInt32("Stocks")
                TextBox16.Text = reader.GetInt32("retailprice")
                TextBox17.Text = reader.GetInt32("originalprice")

            End While

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        calcu()
            End Sub
    Private Sub calcu()
        Try
            Dim quantity As Integer
            Dim available As Integer
            Dim result As Integer
            Dim rp As Integer
            Dim amount As Integer
            Dim op As Integer

            Dim amount2 As Integer



            quantity = TextBox12.Text
            available = TextBox11.Text
            result = available - quantity
            TextBox15.Text = result

            rp = TextBox16.Text
            op = TextBox17.Text
            amount = quantity * rp
            amount2 = quantity * op
            TextBox18.Text = amount2

            TextBox13.Text = amount

        Catch ex As Exception
            MessageBox.Show("Please input a valid number")
        End Try
    End Sub
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim a As Integer
        Dim b As Integer
        a = TextBox12.Text
        b = TextBox11.Text
        If (a > b) Then
            GoTo Err
        Else
            Dim conn As New MySqlConnection

            conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
            Dim sda As New MySqlDataAdapter
            Dim p As Integer
            Dim bsource As New BindingSource
            Dim reader As MySqlDataReader
            Dim amount As Integer
            Dim amount2 As Integer
            Try
                conn.Open()
                amount2 = TextBox18.Text
                amount = TextBox13.Text
                p = amount - amount2
                TextBox19.Text = p
                Dim query As String
                query = "insert into jisdb.purchased (productid,quantity,amount,profit,date) values ('" & TextBox14.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox19.Text & "','" & DateTimePicker1.Text & "')"
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader
                sda.SelectCommand = cmd

                MessageBox.Show("Saved Succesfully")
                conn.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try


            updatestock()
            TextBox10.Clear()
            TextBox11.Clear()
            TextBox12.Text = "1"
            TextBox13.Text = "1"
            TextBox14.Text = "1"
            TextBox15.Text = "1"
            TextBox16.Text = "1"
            TextBox12.Enabled = False
            DateTimePicker1.Enabled = False
        End If
        GoTo tapos
Err:
            MessageBox.Show("Insufficient Stocks")
tapos:
    End Sub
    Private Sub updatestock()
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "update jisdb.products set stocks='" & TextBox15.Text & "' where productid='" & TextBox14.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        salesfrm.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox12_GotFocus(sender As Object, e As EventArgs) Handles TextBox12.GotFocus

    End Sub

    Private Sub TextBox12_LostFocus(sender As Object, e As EventArgs) Handles TextBox12.LostFocus

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuCustomLabel24.Text = Date.Now.ToString("hh:mm:ss tt")
        BunifuCustomLabel23.Text = Date.Now.Date
    End Sub

    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 52 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub account_Click(sender As Object, e As EventArgs) Handles account.Click
        Form2.Show()
    End Sub
End Class