Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private mybindingSource As New BindingSource
    Private dataAdapter As New SqlDataAdapter()


    Private myReader As SqlDataReader
    Private connectionString As String = "Data Source=.;Initial Catalog=TestDB;Integrated Security=SSPI;"

    ' -------- ACTION ON FORM LOAD : COMBOBOX AND GRID FILL-----
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillComboBox()
            ShowGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' -------- DATA GRID FILL RECORDS FROM SQL TABLE -----

    Private Sub ShowGrid()
        Using myConn As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM table1"
            Dim dataAdapter As New SqlDataAdapter(query, myConn)
            Dim dataTable As New DataTable
            dataAdapter.Fill(dataTable)
            DataGrid1.DataSource = dataTable
        End Using
    End Sub

    ' -------- COMBO BOX : ADD USERNAMES FROM SQL TABLE -----
    Private Sub FillComboBox()
        Using myConn As New SqlConnection(connectionString)
            Dim query As String = "SELECT fname, lname, address, username, password, photo FROM table1"
            Dim cmd As New SqlCommand(query, myConn)
            myConn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbFname.Items.Add(reader("fname").ToString())
                cmbLname.Items.Add(reader("lname").ToString())
                cmbAddress.Items.Add(reader("address").ToString())
                cmbUser.Items.Add(reader("username").ToString())
                cmbPass.Items.Add(reader("password").ToString())
                cmbPhoto.Items.Add(reader("photo").ToString())
            End While
            reader.Close()
        End Using
    End Sub


    ' -------- SUBMIT BUTTOM : SUBMIT DATA RECORD INTO SQL TABLE -----
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(txtFName.Text) OrElse String.IsNullOrEmpty(txtLName.Text) OrElse
            String.IsNullOrEmpty(txtUser.Text) OrElse String.IsNullOrEmpty(txtPass.Text) OrElse
            (Not rdbtnMale.Checked AndAlso Not rdbtnFemale.Checked) Then
            MessageBox.Show("Please fill all required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using myConn As New SqlConnection(connectionString)
                Dim query As String = "SELECT username FROM table1 WHERE username=@username"
                Dim cmd As New SqlCommand(query, myConn)
                cmd.Parameters.AddWithValue("@username", txtUser.Text)
                myConn.Open()
                Dim existingUsername As Object = cmd.ExecuteScalar()
                If existingUsername IsNot Nothing Then
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error")
                    Return
                End If

                query = "INSERT INTO table1 (fname, lname, address, gender, DoB, username, password, photo) " &
                        "VALUES (@fname, @lname, @address, @gender, @DoB, @username, @password, @photo)"
                cmd.CommandText = query
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@fname", txtFName.Text)
                cmd.Parameters.AddWithValue("@lname", txtLName.Text)
                cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@gender", If(rdbtnMale.Checked, 1, 0))
                cmd.Parameters.AddWithValue("@DoB", date_birth.Value)
                cmd.Parameters.AddWithValue("@username", txtUser.Text)
                cmd.Parameters.AddWithValue("@password", txtPass.Text)
                cmd.Parameters.AddWithValue("@photo", txtImage.Text)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Entry inserted successfully")
            ShowGrid() ' Refresh grid after insertion
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '----- MIRROR DATA -----
    Private Sub txtFName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFName.KeyUp
        txtFull.Text = txtFName.Text & " " & txtLName.Text
    End Sub

    '----- FOR HIDDEN PASSWORD -----
    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    '----- FOR IMAGE FILE PATH And IMAGE UPOAD -----
    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtImage.Text = Path.GetDirectoryName(OpenFileDialog1.FileName) & "\" & Path.GetFileName(OpenFileDialog1.FileName)
            PictureBox1.Image = Image.FromFile(txtImage.Text)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub


    Private Sub cmbUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUser.SelectedIndexChanged
        'Making Sql connection
        Dim myConn As New SqlConnection("Data Source = .;Initial Catalog=TestDB;Integrated Security=SSPI;")
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        '-----reset all fields -----
        txtUser.Text = cmbUser.Text
        txtFName.Text = ""
        txtLName.Text = ""
        txtAddress.Text = ""
        txtPass.Text = ""
        txtImage.Text = ""
        rdbtnMale.Checked = False
        rdbtnFemale.Checked = False
        date_birth.ResetText()
        PictureBox1.Image = Nothing

        Try
            myCmd = New SqlCommand("SELECT fname, lname,gender,address,password,DoB,photo From table1 WHERE username='" & cmbUser.Text & "'", myConn)
            myReader = myCmd.ExecuteReader()
            While myReader.Read
                txtFName.Text = myReader.Item("fname")
                txtLName.Text = myReader.Item("lname")
                txtAddress.Text = myReader.Item("address")

                If myReader.Item("gender") = 0 Then
                    rdbtnFemale.Checked = True
                Else
                    rdbtnMale.Checked = True
                End If

                txtPass.Text = myReader.Item("password")
                date_birth.Value = myReader.Item("DoB")
                txtImage.Text = myReader.Item("photo")

                If txtImage.Text = "" Then 'Do Nothing
                Else
                    PictureBox1.Image = Image.FromFile(txtImage.Text)
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' -------- RESET BUTTOM : CLEAR ALL FIELDS And REFRESH DATA In SQL TABLE -----

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ShowGrid()
        '      -----reset all fields -----
        txtUser.Text = ""
        txtFName.Text = ""
        txtLName.Text = ""
        txtAddress.Text = ""
        txtPass.Text = ""
        txtImage.Text = ""
        rdbtnMale.Checked = False
        rdbtnFemale.Checked = False
        date_birth.ResetText()
        PictureBox1.Image = Nothing
        cmbUser.Items.Clear()
        cmbUser.ResetText()
        FillComboBox()
    End Sub

    ' -------- DELETE BUTTOM : DELETE DATA RECORD FROM SQL TABLE -----

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim myConn As New SqlConnection("Data Source = .;Initial Catalog=TestDB;Integrated Security=SSPI;")
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            Dim deleteCmd As New SqlCommand("DELETE FROM table1 WHERE username=@username", myConn)
            deleteCmd.Parameters.AddWithValue("@username", txtUser.Text)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                ' Proceed with deletion 
                deleteCmd.ExecuteNonQuery()
                MessageBox.Show("Record deleted successfully!")
            Else
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmbUser.Items.Clear()
            FillComboBox()
        End Try
    End Sub

    ' -------- UPDATE BUTTOM : UPDATE ENTRY In SQL TABLE -----

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim myConn As New SqlConnection("Data Source = .;Initial Catalog=TestDB;Integrated Security=SSPI;")
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            Dim genderValue As Integer
            If rdbtnMale.Checked Then
                genderValue = 1
            ElseIf rdbtnFemale.Checked Then
                genderValue = 0
            End If
            Dim updateCmd As New SqlCommand("UPDATE table1 SET fname='" & txtFName.Text & "', lname='" & txtLName.Text & "', gender='" & genderValue & "', DoB='" & date_birth.Text & "', password='" & txtPass.Text & "', address='" & txtAddress.Text & "', photo='" & txtImage.Text & "'WHERE username='" & cmbUser.Text & "'", myConn)
            updateCmd.ExecuteNonQuery()
            MessageBox.Show("Record updated successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cmbUser.Items.Clear()
            FillComboBox()
        End Try
    End Sub

End Class
