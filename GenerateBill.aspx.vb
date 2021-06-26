Public Class GenerateBill
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub GenBill()
        cc.connect()
        cc.cmd.CommandText = "SELECT Customer_No FROM tblBill WHERE Customer_No='" + CustNo.Value + "'"
        cc.cmd.Connection = cc.cnn
        cc.dr = cc.cmd.ExecuteReader()
        If cc.dr.HasRows Then
            cc.dr.Close()
            Session("GenBill") = CustNo.Value
            Response.Redirect("GenerateBill1.aspx")
        Else
            cc.dr.Close()
            cc.cmd.CommandText = "INSERT INTO tblBill (Customer_No, RR_No, Location_Code, Meter_No, Sub_Division) SELECT Customer_No, RR_No, Location_Code, Meter_Code, Sub_Division FROM tblSignUp WHERE (Customer_No = '" + CustNo.Value + "')"
            cc.cmd.Connection = cc.cnn
            cc.cmd.ExecuteNonQuery()

            Session("GenBill") = CustNo.Value
            If (MsgBox("Record Inserted in tblBill")) Then
                Response.Redirect("GenerateBill1.aspx")
            End If
        End If
        cc.cnn.Close()
    End Sub

End Class