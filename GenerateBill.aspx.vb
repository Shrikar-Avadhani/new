Public Class GenerateBill

    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim n As String
        n = "No"
        Dim lt As List(Of String) = New List(Of String)()
        Dim dt As Date
        Dim addn As Integer
        addn = 1
        cc.connect()
        cc.cmd.CommandText = "SELECT Due_Date, Customer_No FROM tblBill"
        cc.cmd.Connection = cc.cnn
        cc.dr = cc.cmd.ExecuteReader()
        If cc.dr.HasRows Then
            While (cc.dr.Read())
                dt = cc.dr.Item(0)
                If (dt < Now) Then
                    lt.Add(cc.dr.Item(1))
                End If
            End While
            cc.dr.Close()
            For Each i In lt
                cc.cmd.CommandText = "Update tblSignUp SET Bill = '" + n + "' WHERE( Customer_No = '" + i + "')"
                cc.cmd.Connection = cc.cnn
                cc.cmd.ExecuteNonQuery()
                cc.cmd.CommandText = "Update tblBill SET Bill = '" + n + "' WHERE( Customer_No = '" + i + "')"
                cc.cmd.Connection = cc.cnn
                cc.cmd.ExecuteNonQuery()
            Next



            cc.cnn.Close()

        End If
    End Sub

    Public Sub GenBill()
        cc.connect()
        cc.cmd.CommandText = "SELECT Customer_No FROM tblBill WHERE Customer_No='" + CustNo.Value + "'"
        cc.cmd.Connection = cc.cnn
        cc.dr = cc.cmd.ExecuteReader()
        If cc.dr.HasRows Then
            cc.dr.Close()
            Session("GenBill") = CustNo.Value
            cc.dr.Close()
            cc.cnn.Close()
            Response.Redirect("GenerateBill1.aspx")
        Else
            cc.dr.Close()
            cc.cmd.CommandText = "INSERT INTO tblBill (Name, Customer_No, RR_No, Location_Code, Meter_No, Sub_Division) SELECT Name, Customer_No, RR_No, Location_Code, Meter_Code, Sub_Division FROM tblSignUp WHERE (Customer_No = '" + CustNo.Value + "')"
            cc.cmd.Connection = cc.cnn
            cc.cmd.ExecuteNonQuery()
            cc.cmd.CommandText = "INSERT INTO tblBill(Bill_No) Select ABS(CHECKSUM(NEWID()))%1000 + 1 As Bill_No  FROM tblBill WHERE(Customer_No = '" + CustNo.Value + "') AND Bill_No IS NULL"
            cc.cmd.Connection = cc.cnn
            cc.cmd.ExecuteNonQuery()
            cc.cnn.Close()

            Session("GenBill") = CustNo.Value
            Response.Redirect("GenerateBill1.aspx")
        End If


    End Sub

End Class