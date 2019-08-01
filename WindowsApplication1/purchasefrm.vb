Imports MySql.Data.MySqlClient
Public Class purchasefrm
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub load_table()

        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * FROM jisdb.purchased"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            reader = cmd.ExecuteReader

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
    Private Sub load_table2()

        Dim conn As New MySqlConnection

        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim sda As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select * FROM jisdb.add_stocks"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            sda.Update(dbdataset)
            reader = cmd.ExecuteReader

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Menufrm.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        updatefrm.Show()
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
    Private Sub purchasefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JisdbDataSet.products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.JisdbDataSet.products)
        load_table()


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

            DataGridView1.Dock = DockStyle.Fill
            BunifuImageButton1.Location = New System.Drawing.Point(10, 14)
            Panel1.Width = 50
            BunifuTransition1.ShowSync(Panel1)


        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

        Dim result = MessageBox.Show(" Are you sure you want to logout", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Login.Show()
            Me.Hide()
        End If
    End Sub





    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

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
            query = "SELECT * FROM jisdb.purchased where purchasedid like '%" & BunifuTextbox1.text & "%'"
            cmd = New MySqlCommand(query, conn)
            sda.SelectCommand = cmd
            sda.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
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





    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click
        load_table()
        load_table2()

    End Sub

    Private Sub BunifuCustomLabel2_MouseMove(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel2.MouseMove
        BunifuCustomLabel2.ForeColor = Color.Blue
    End Sub

    Private Sub BunifuCustomLabel2_MouseWheel(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel2.MouseWheel

    End Sub

    Private Sub BunifuCustomLabel2_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.MouseLeave
        BunifuCustomLabel2.ForeColor = Color.White
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        Dim result = MessageBox.Show(" Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim conn As New MySqlConnection

            conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
            Dim reader As MySqlDataReader

            Try
                conn.Open()
                Dim query As String
                query = " delete from jisdb.purchased where purchasedid='" & TextBox5.Text & "'"
                cmd = New MySqlCommand(query, conn)
                reader = cmd.ExecuteReader

                conn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conn.Dispose()
            End Try

        End If

        load_table()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        salesfrm.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs) Handles BunifuThinButton26.Click

        load_table2()

    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click

        load_table()
        BunifuCustomLabel2.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuCustomLabel9.Text = Date.Now.ToString("hh:mm:ss tt")
        BunifuCustomLabel10.Text = Date.Now.Date
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub account_Click(sender As Object, e As EventArgs) Handles account.Click
        Form2.Show()
    End Sub
End Class