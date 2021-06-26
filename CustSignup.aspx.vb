Public Class CustSignup
    Inherits System.Web.UI.Page

    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Public Sub SignUp()
        Dim b As String
        b = "No"
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblSignUp VALUES ('" + Name.Value + "', '" + Address.Value + "', '" + Email.Value + "', " + Phone.Value + ", '" + RR.Value + "', " + Cno.Value + ", '" + SubDiv.Value + "', " + Lcode.Value + ", '" + Mcode.Value + "', '" + Uname.Value + "', '" + Password.Value + "', '" + Question.Value + "', '" + Answer.Value + "', " + Aadhar.Value + ", '" + b + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        If (MsgBox("You have signed up successfully")) Then
            Response.Redirect("CustomerLogin.aspx")
        End If
    End Sub
End Class

