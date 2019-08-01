Imports MySql.Data.MySqlClient
Public Class Menufrm
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand


    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click


        Dim result = MessageBox.Show(" Are you sure you want to logout", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Login.Show()
            Me.Hide()
        End If

    End Sub



    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        updatefrm.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        purchasefrm.Show()
        Me.Hide()
    End Sub

    Private Sub menufrm(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * FROM jisdb.categories"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim sname = reader.GetString("categoryid")
                ComboBox1.Items.Add(sname)
            End While

            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try



        load_table()
        BunifuFlatButton1.Enabled = False
        BunifuFlatButton2.Enabled = True
        BunifuFlatButton3.Enabled = True
        BunifuFlatButton4.Enabled = True
        BunifuFlatButton5.Enabled = True


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
            ProductsDataGridView.Dock = DockStyle.Fill

            BunifuImageButton1.Location = New System.Drawing.Point(10, 14)
            Panel1.Width = 50
            BunifuTransition1.ShowSync(Panel1)


        End If
    End Sub







    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM jisdb.products where CategoryID=1"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            ProductsDataGridView.DataSource = bsource
            sda.Update(dbdataset)


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try


    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub add_panel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM jisdb.products where CategoryID=3"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            ProductsDataGridView.DataSource = bsource
            sda.Update(dbdataset)


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM jisdb.products where CategoryID=2"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            ProductsDataGridView.DataSource = bsource
            sda.Update(dbdataset)


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM jisdb.products where CategoryID=4"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            ProductsDataGridView.DataSource = bsource
            sda.Update(dbdataset)


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub BunifuImageButton8_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox1_GotFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM jisdb.products where ProductName like '%" & BunifuTextbox1.text & "%'"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            ProductsDataGridView.DataSource = bsource
            sda.Update(dbdataset)


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub





    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        BunifuTextbox1.text = ""
        BunifuTextbox1.ForeColor = Color.White
    End Sub
    Private Sub load_table()

        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            conn.Open()
            Dim query As String
            query = "select * FROM jisdb.products"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            ProductsDataGridView.DataSource = bsource
            sda.Update(dbdataset)


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click
        load_table()

    End Sub

    Private Sub BunifuCustomLabel2_MouseMove(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel2.MouseMove
        BunifuCustomLabel2.ForeColor = Color.Blue
    End Sub

    Private Sub BunifuCustomLabel2_MouseWheel(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel2.MouseWheel

    End Sub

    Private Sub BunifuCustomLabel2_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.MouseLeave
        BunifuCustomLabel2.ForeColor = Color.White
    End Sub




    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "update jisdb.products set productname='" & TextBox1.Text & "',categoryid='" & ComboBox1.Text & "',stocks='" & TextBox2.Text & "',originalprice='" & TextBox3.Text & "',retailprice='" & TextBox4.Text & "' where productid='" & TextBox5.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

        Dim wew = MessageBox.Show(" Saved Succesfully", "Prompt", MessageBoxButtons.OK)
        TextBox6.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        BunifuThinButton21.Visible = False
        BunifuThinButton23.Visible = False
        ProductsDataGridView.DataSource = ProductsBindingSource
        load_table()

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If TextBox6.Text = "" Then
            MessageBox.Show("Enter Product Name")
            GoTo Err
        Else

            TextBox1.Enabled = True

            TextBox3.Enabled = True
            TextBox4.Enabled = True
            ComboBox1.Enabled = True
            BunifuThinButton21.Visible = True
            BunifuThinButton23.Visible = True
            TextBox6.Enabled = False
        End If
Err:
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click

        Dim result = MessageBox.Show(" Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim conn As New MySqlConnection

            conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
            Dim reader As MySqlDataReader

            Try
                conn.Open()
                Dim query As String
                query = " delete from jisdb.products where productid='" & TextBox5.Text & "'"
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader

                conn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try

        End If
        TextBox6.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        BunifuThinButton21.Visible = False
        BunifuThinButton23.Visible = False
        load_table()
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
            query = "SELECT * FROM jisdb.products where ProductName like '%" & TextBox6.Text & "%'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read
                TextBox5.Text = reader.GetString("productid")
                TextBox1.Text = reader.GetString("ProductName")
                TextBox2.Text = reader.GetInt32("Stocks")
                TextBox3.Text = reader.GetInt32("OriginalPrice")
                TextBox4.Text = reader.GetInt32("RetailPrice")
                ComboBox1.Text = reader.GetInt32("categoryid")
            End While

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        gettext()
    End Sub



    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        salesfrm.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuCustomLabel9.Text = Date.Now.ToString("hh:mm:ss tt")
        BunifuCustomLabel10.Text = Date.Now.Date
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ProductsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductsDataGridView.CellContentClick

    End Sub

    Private Sub account_Click(sender As Object, e As EventArgs) Handles account.Click
        Form2.Show()
    End Sub
End Class
