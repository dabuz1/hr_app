<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html dir="rtl" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <title>إدارة الموارد البشرية - تسجيل الدخول</title>     
    <link href="css/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="loginbox">
            <asp:Image runat="server" src="images/profilelogo.png" class="avatar"></asp:Image>
            <h1>تسجيل الدخول</h1>
            <p>إسم المستخدم</p>
            <asp:TextBox runat="server" ID="username"></asp:TextBox>
            <p>كلمة المرور</p>
            <asp:TextBox runat="server" TextMode="Password" ID="password"></asp:TextBox>
            <asp:Button runat="server" ID="loginbtn" class="btn btn-light btn-block" Text="دخول" OnClick="loginbtn_Click"></asp:Button>
            <asp:HyperLink ID="forgot" NavigateUrl="#" Text="هل نسيت كلمة المرور؟" runat="server" />
            <asp:HyperLink ID="newaccount" NavigateUrl="#" Text="لا يوجد لديك حساب؟" runat="server" />
        </div>
    </form>
</body>
</html>
