<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/CustomerMaster.Master" CodeBehind="CustProfile.aspx.vb" Inherits="UdupiElectricityBoard.CustProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">
    <title>AdminProfile</title>
    <style>
        body {
            background: url(/assets/images/AdminProfile.jpg);
            background-position: center,center;
            background-size: cover;
        }

        form {
            margin-bottom: 30px;
            margin:auto;
            width: 500px;
        }

        .headerP {
            font-size: 3rem;
            width: 300px;
            margin: 30px auto 40px auto;
            color: black;
            text-decoration: underline;
        }

        .form-group {

            margin: 10px auto;
            padding: 8px;
            margin:auto;
        }

            .form-group label {
                display: inline-block;
                width: 140px;
                font-size: 1.5rem;
                color: black;
                vertical-align: top;
                text-decoration:underline;
            }

            .form-group input {
                padding: 8px;
                border-radius: 5px;
                outline: none;
                width: 300px;
                border: none;
                border-bottom: 4px solid black;
            }

        .fa-pencil-square-o {
            color: black;
            cursor: pointer;
            vertical-align:middle;
        }

        .btn{
            width:200px !important;
            margin: 20px auto;
            display: block;
            background-color:orangered;
        }

        .btn:hover{
            background-color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 class="headerP">Your Profile</h1>
    <div class="form">
        <form runat="server" method="post">
            <div class="form-group">
                <label runat="server" for="Name">Name</label>
                <input runat="server" type="text" placeholder="Enter Your Name" id="Name" disabled required="">
                <a runat="server" onserverclick="EditN"><i runat="server" class="fa fa-pencil-square-o fa-lg"></i></a>
            </div>

            <div class="form-group">
                <label runat="server" for="Mobile">Mobile No.</label>
                <input runat="server" type="text" placeholder="Enter Mobile No." id="Mobile" disabled required="">
                <a runat="server" onserverclick="EditM"><i runat="server" class="fa fa-pencil-square-o fa-lg"></i></a>
            </div>
            <div class="form-group">
                <label runat="server" for="Email">Email ID</label>
                <input runat="server" type="text" placeholder="Enter your email id" id="Email" disabled required="">
                <a runat="server" onserverclick="EditE"><i runat="server" class="fa fa-pencil-square-o fa-lg"></i></a>
            </div>
            <div class="form-group">
                <label runat="server" for="Address">Address</label>
                <textarea style="border-bottom:4px solid black; border-radius:5px; resize:none;" runat="server" cols="28" type="text" placeholder="Enter your Address" id="Address" disabled required=""></textarea>
                <a runat="server" onserverclick="EditA"><i runat="server" class="fa fa-pencil-square-o fa-lg"></i></a>
            </div>
            <div class="form-group">
                <label runat="server" for="Aadhar">Aadhar No.</label>
                <input runat="server" type="text" placeholder="Enter your Aadhar Number" id="Aadhar" disabled required="">
            </div>
            <div class="form-group">
                <label runat="server" for="Username">Username</label>
                <input runat="server" type="text" placeholder="Enter Username" id="Username" disabled required="">
                <a runat="server" onserverclick="EditU"><i runat="server" class="fa fa-pencil-square-o fa-lg"></i></a>
            </div>
            <div class="form-group">
                <label runat="server" for="Password">Password</label>
                <input runat="server" type="text" placeholder="Enter Password" id="Password" disabled required="">
                <a runat="server" onserverclick="EditP"><i runat="server" class="fa fa-pencil-square-o fa-lg"></i></a>
            </div>
            <div class="form-group">
                <input runat="server" type="submit" class="btn btn-primary" value="Update" onserverclick="Update" />
            </div>
        </form>
    </div>
</asp:Content>
