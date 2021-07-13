Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Close()

    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteData()

    End Sub
    Sub DeleteData()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("delete from Table_1 where id=" & lblID.Text & "", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            con.Close()
            MessageBox.Show("تم الحذف بنجاح")
            GetData()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub GetData()

        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT        id,
                                                name,
                                                work_adress,
                                                home_adress,
                                                city,
                                                number1,
                                                number2,
                                                title,
                                                job_id,
                                                email,
                                                notice
                                                FROM            Table_1", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgV.Rows.Clear()
            While (rdr.Read() = True)
                dgV.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10))
            End While
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Reset()
        txtName.Text = ""
        txtWorkAdress.Text = ""
        txtHomeAdress.Text = ""
        txtCity.Text = ""
        txtNumber1.Text = ""
        txtNumber2.Text = ""
        txtTitle.Text = ""
        txtTitleID.Text = ""
        txtEmail.Text = ""
        txtNotice.Text = ""
    End Sub
    'Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    'End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    'Private Sub Button1_Click_1(sender As Object, e As EventArgs)
    '    'Reset()
    'End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Reset()
        txtName.Focus()
    End Sub

    Private Sub dgV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgV.CellContentClick

    End Sub
    Sub GetDataSelected()
        Dim dr As DataGridViewRow = dgV.SelectedRows(0)
        txtName.Text = dr.Cells(1).Value.ToString
        txtWorkAdress.Text = dr.Cells(2).Value.ToString
        txtHomeAdress.Text = dr.Cells(3).Value.ToString
        txtCity.Text = dr.Cells(4).Value.ToString
        txtNumber1.Text = dr.Cells(5).Value.ToString
        txtNumber2.Text = dr.Cells(6).Value.ToString
        txtTitle.Text = dr.Cells(7).Value.ToString
        txtTitleID.Text = dr.Cells(8).Value.ToString
        txtEmail.Text = dr.Cells(9).Value.ToString
        txtNotice.Text = dr.Cells(10).Value.ToString
        lblID.Text = dr.Cells(0).Value.ToString
    End Sub
    Sub GetDataSearch()
        Try
            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("SELECT        id,
                                                name,
                                                work_adress,
                                                home_adress,
                                                city,
                                                number1,
                                                number2,
                                                title,
                                                job_id,
                                                email,
                                                notice
                                                FROM            Table_1
                                  WHERE        (name LIKE '%" & txtSearch.Text & "%') ", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgV.Rows.Clear()

            While (rdr.Read() = True)
                dgV.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10))
            End While

            con.Close()
            GetDataSelected()


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgV.CellClick
        GetDataSelected()
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GetDataSearch()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            GetData()

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        Form2.lblSet.Text = "add"
        Form2.Reset()
        Form2.ShowDialog()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim dr As DataGridViewRow = dgV.SelectedRows(0)
        Form2.txtName.Text = dr.Cells(1).Value.ToString
        Form2.txtWorkAdress.Text = dr.Cells(2).Value.ToString
        Form2.txtHomeAdress.Text = dr.Cells(3).Value.ToString
        Form2.txtCity.Text = dr.Cells(4).Value.ToString
        Form2.txtNumber1.Text = dr.Cells(5).Value.ToString
        form2.txtNumber2.Text = dr.Cells(6).Value.ToString
        Form2.txtTitle.Text = dr.Cells(7).Value.ToString
        Form2.txtTitleID.Text = dr.Cells(8).Value.ToString
        Form2.txtEmail.Text = dr.Cells(9).Value.ToString
        Form2.txtNotice.Text = dr.Cells(10).Value.ToString
        'Form2.lblID.Text = dr.Cells(0).Value.ToString
        Form2.lblSet.Text = "update"
        Form2.ShowDialog()

    End Sub
End Class
