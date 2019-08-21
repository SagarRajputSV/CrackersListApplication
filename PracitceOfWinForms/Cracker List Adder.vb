Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.ListBox
Imports System.Data
Imports System.IO



Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()

        Dim str As String = ConfigurationManager.ConnectionStrings("CrudConnection").ConnectionString
        Dim con = New SqlConnection(str)

        Dim cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandText = "SpFetchAll"
        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        Dim dt = New DataTable()
        Dim adap = New SqlDataAdapter(cmd)

        adap.Fill(dt)

        ListBox2.DisplayMember = "CrackerName"
        ListBox2.DataSource = dt


        con.Close()

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtCrackerName.Text = "" Then
            MessageBox.Show("Enter the caracker Name")
        Else
            ListBox1.Items.Add(TxtCrackerName.Text)
            TxtCrackerName.Clear()
        End If

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Try
            'To use ConfigurationManager Make Sure that the System.Data.Configuration is added as the reference to the project Directory in Solution Explorer

            Dim str As String = ConfigurationManager.ConnectionStrings("CrudConnection").ConnectionString
            Dim Con As New SqlConnection(str)


            Con.Open()

            Dim cmd As New SqlCommand()
            cmd.Connection = Con
            cmd.CommandText = "SpInsert"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@CrackerListTable", ObtainData())

            cmd.ExecuteNonQuery()

            Con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ListBox1.Items.Clear()
        End Try
    End Sub

    Private Function ObtainData() As DataTable
        Dim dt As DataTable
        dt = New DataTable()
        dt.Columns.Add("CrackerName")

        For Each items As Object In ListBox1.Items
            dt.Rows.Add(items)
        Next
        Return dt
    End Function

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click

        Dim str As String = ConfigurationManager.ConnectionStrings("CrudConnection").ConnectionString
        Dim con = New SqlConnection(str)

        Dim cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandText = "SpFetchAll"
        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        Dim dt = New DataTable()
        Dim adap = New SqlDataAdapter(cmd)

        adap.Fill(dt)

        ListBox2.DisplayMember = "CrackerName"
        ListBox2.DataSource = dt


        con.Close()

    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        Dim str As String = ConfigurationManager.ConnectionStrings("CrudConnection").ConnectionString
        Dim con = New SqlConnection(str)

        Dim cmd = New SqlCommand()
        cmd.Connection = con
        cmd.CommandText = "SpFetchAll"
        cmd.CommandType = CommandType.StoredProcedure

        con.Open()

        Dim dt = New DataTable()
        Dim adap = New SqlDataAdapter(cmd)

        adap.Fill(dt)

        ListBox2.DisplayMember = "CrackerName"
        ListBox2.DataSource = dt

        'The Below method demonstrates the way to loop through each record in datatable and obtain a single datarow from the datatable

        'Dim i As Byte
        'For i = 0 To dt.Rows.Count
        '    If dt.Rows.Item(i).ItemArray(1) = TxtLstSearch.Text Then
        '        dt = dt.Select("CrackerName ='" & TxtLstSearch.Text & "'").CopyToDataTable
        '        ListBox2.DataSource = dt
        '        Exit For
        '    End If
        'Next

        'The datatable can be converted to a IEnumberable which allows us to use linq on it
        'But as it returns a datarow and datarow cannot be used as a DataSource to an element it should be 
        'added explicitly as a row to a table
        'but before adding the row all the older rows should be removed

        Dim Cracker As DataRow = dt.AsEnumerable().Where(Function(x) x.Field(Of String)("CrackerName") = TxtLstSearch.Text).Single()
        Dim dr As DataRow

        dr("CrackerName") = Cracker.ItemArray()
        dt.Clear() 'Removing all the existing DataRows
        dt.ImportRow(Cracker)
        dt.Rows.Add(dr)
        ListBox2.DataSource = dt

        'DataTable.Select Will return an array of a datarow which contains a text in a particular column the value of the text
        'should be within a single quote for example we find a record which contains sagar in a column Name then it should be
        'dt.Select("Name='Sagar'")
        'This returns an array of datarow 
        'Thus Dim row() As DataRow = dt.Select("Name='Sagar'")
        'If it should be copied to a datatable use .CopyToDataTable

        'dt = dt.Select("CrackerName='" & TxtLstSearch.Text & "'").CopyToDataTable
        'ListBox2.DataSource = dt

        con.Close()
    End Sub
End Class
