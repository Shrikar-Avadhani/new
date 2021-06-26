Public Class AdminReg
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Register()
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblAdmin VALUES ('" + Name.Value + "', " + Phone.Value + ", '" + Email.Value + "', '" + Address.Value + "', '" + Username.Value + "', '" + Password.Value + "', " + Aadhar.Value + ")"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        If (MsgBox("Record Inserted Successfully")) Then
            Response.Redirect("AdminHome.aspx")
        End If
    End Sub
End Class