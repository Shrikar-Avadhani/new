Public Class CustReg
    Inherits System.Web.UI.Page

    ReadOnly cc As New connectionClass

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Register()
        Dim n As String
        n = "No"
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblNewConnection VALUES ('" + Name.Value + "', '" + Address.Value + "','" + Email.Value + "', " + Phone.Value + "," + Aadhar.Value + ", '" + n + "' )"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()

        If (MsgBox("You have registred successfully")) Then
            Response.Redirect("Home.aspx")
        End If
    End Sub
End Class