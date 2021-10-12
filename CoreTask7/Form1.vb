Option Explicit On
Option Strict On


Public Class Form1
    Private db As New NorthwindEntities()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dim cus = From c In db.Customers
                  Select New With
                      {
                        c.CustomerID,
                        c.CompanyName,
                        c.ContactName,
                        c.ContactTitle,
                        c.Address,
                        c.City,
                        c.Country,
                        c.Phone,
                        c.Fax
                      }

        If cus.Count() > 0 Then
            DataGridView1.DataSource = cus.ToList()



        Else
            DataGridView1.DataSource = Nothing
            MessageBox.Show("Sorry, no records found.", "sql server entity framework 6: iBassKung", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




    End Sub
End Class
