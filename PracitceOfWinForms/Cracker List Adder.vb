Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO



Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()
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
            Dim str As String = ConfigurationManager.ConnectionStrings("CrudConnection").ConnectionString
            'To use ConfigurationManager Make Sure that the System.Data.Configuration is added as the reference to the project Directory in Solution Explorer
            Dim Con As New SqlConnection(str)
            'Dim DBConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("My_ConnectionString").ConnectionString)

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

        Dim adap As SqlDataAdapter
        adap = New SqlDataAdapter(cmd)
        Dim ds = New DataSet()

        adap.Fill(ds, "Listtable")


        For Each items In ds
    End Sub
End Class
