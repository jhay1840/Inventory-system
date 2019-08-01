Imports MySql.Data.MySqlClient
Public Class salesfrm
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


            BunifuImageButton1.Location = New System.Drawing.Point(10, 14)
            Panel1.Width = 50
            BunifuTransition1.ShowSync(Panel1)


        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Menufrm.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        purchasefrm.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        updatefrm.Show()
        Me.Hide()
    End Sub


    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click

        Dim result = MessageBox.Show(" Are you sure you want to logout", "Prompt", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then

            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub salesfrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        combo()
    End Sub
    Private Sub combo()
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"

        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query As String
            query = "select distinct date FROM jisdb.purchased"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                Dim sname = reader.GetString("date")
                ComboBox1.Items.Add(sname)


            End While

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim sda As New MySqlDataAdapter

        Dim bsource As New BindingSource
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT sum(amount),sum(quantity),sum(profit) FROM jisdb.purchased where date='" & ComboBox1.Text & "'
"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read
                BunifuCustomLabel4.Text = reader.GetInt32("sum(amount)")
                BunifuCustomLabel5.Text = reader.GetInt32("sum(quantity)")
                BunifuCustomLabel8.Text = reader.GetInt32("sum(profit)")



            End While


            conn.Close()
            conn.Open()

            query = "SELECT productid,quantity FROM jisdb.purchased where date='" & ComboBox1.Text & "' order by quantity desc limit 1"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read

                BunifuCustomLabel9.Text = reader.GetInt32("productid")


            End While

            conn.Close()
            conn.Open()

            query = "SELECT productname FROM jisdb.products where productid ='" & BunifuCustomLabel9.Text & "' "
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read

                BunifuCustomLabel9.Text = reader.GetString("productname")


            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
        RichTextBox1.Text = "JIS School Supply and Merchandise    " & vbNewLine & vbNewLine & "Daily Sales Report" & vbNewLine & vbNewLine & " Date:                       " & ComboBox1.Text & "" & vbNewLine & vbNewLine & "Total Amount Sold: " & BunifuCustomLabel4.Text & "" & vbNewLine & vbNewLine & "Quantity Sold:         " & BunifuCustomLabel5.Text & "" & vbNewLine & vbNewLine & "Profit:                        " & BunifuCustomLabel8.Text & "" & vbNewLine & vbNewLine & "Best Seller:                " & BunifuCustomLabel9.Text & "" & vbNewLine & vbNewLine & "" & vbNewLine & vbNewLine & "" & vbNewLine & vbNewLine & "" & vbNewLine & vbNewLine & "" & BunifuCustomLabel23.Text & "  " & BunifuCustomLabel24.Text & ""

    End Sub

    Private Sub salesfrm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        combo()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub ComboBox1_GotFocus(sender As Object, e As EventArgs) Handles ComboBox1.GotFocus
        ComboBox1.Items.Clear()
        combo()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged


    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Panel5.Visible = True
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Panel5.Visible = False
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        conn.ConnectionString = "server=localhost;user id=root;password = toor;database=jisdb"
        Dim sda As New MySqlDataAdapter

        Dim bsource As New BindingSource
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT sum(amount),sum(quantity),sum(profit) FROM jisdb.purchased where date like '" & ComboBox2.Text & "%' and date like  '%" & ComboBox3.Text & "'"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read
                BunifuCustomLabel17.Text = reader.GetInt32("sum(amount)")
                BunifuCustomLabel16.Text = reader.GetInt32("sum(quantity)")
                BunifuCustomLabel13.Text = reader.GetInt32("sum(profit)")



            End While


            conn.Close()
            conn.Open()

            query = "SELECT productid,quantity FROM jisdb.purchased where date like '" & ComboBox2.Text & "%' and date like  '%" & ComboBox3.Text & "' order by quantity desc limit 1"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read

                BunifuCustomLabel11.Text = reader.GetInt32("productid")


            End While

            conn.Close()
            conn.Open()

            query = "SELECT productname FROM jisdb.products where productid ='" & BunifuCustomLabel11.Text & "' "
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader

            sda.SelectCommand = cmd

            While reader.Read

                BunifuCustomLabel11.Text = reader.GetString("productname")


            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("No data found")
        Finally
            conn.Dispose()
        End Try
        RichTextBox1.Text = "JIS School Supply and Merchandise    " & vbNewLine & vbNewLine & "Monthly Sales Report" & vbNewLine & vbNewLine & " Date:                       " & ComboBox2.Text & "  " & ComboBox3.Text & "" & vbNewLine & vbNewLine & "Total Amount Sold: " & BunifuCustomLabel17.Text & "" & vbNewLine & vbNewLine & "Quantity Sold:         " & BunifuCustomLabel16.Text & "" & vbNewLine & vbNewLine & "Profit:                        " & BunifuCustomLabel13.Text & "" & vbNewLine & vbNewLine & "Best Seller:                " & BunifuCustomLabel11.Text & "" & vbNewLine & vbNewLine & "" & vbNewLine & vbNewLine & "" & vbNewLine & vbNewLine & "" & vbNewLine & vbNewLine & "" & BunifuCustomLabel23.Text & "  " & BunifuCustomLabel24.Text & ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuCustomLabel24.Text = Date.Now.ToString("hh:mm:ss tt")
        BunifuCustomLabel23.Text = Date.Now.Date
    End Sub

    Private Sub BunifuCustomLabel24_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel24.Click

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Century Gothic", 24, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font, Brushes.Black, 100, 100)
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub account_Click(sender As Object, e As EventArgs) Handles account.Click
        Form2.Show()
    End Sub
End Class