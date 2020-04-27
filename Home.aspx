<%@ Page Title="إدارة الموارد البشرية -الصفحة الرئيسية" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta charset="UTF-8"/>
    <link rel="Stylesheet" href="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.10/themes/redmond/jquery-ui.css" />
    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-1.8.0.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.22/jquery-ui.js"></script>
    <link href="css/home.css" rel="stylesheet" /> 
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container"> 
        <asp:image runat="server" src="images/mainlogo.png" class="logo" />
        <h1>إدارة الموارد البشرية</h1>
        <h2>Human Resources Department</h2>
        <asp:Textbox ID ="searchbox" runat="server" CssClass="search" ClientIDMode="Static"></asp:Textbox>
    </div>

<script>  
        $("#searchbox").autocomplete({
            source: function (request, response) {
                var param = { name: $('#searchbox').val() };
                $.ajax({
                    url: "Home.aspx/Getname",
                    data: JSON.stringify(param),
                    dataType: "json",
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    dataFilter: function (data) { return data; },
                    success: function (data) {
                        response($.map(data.d, function (item) {
                            return {
                                value: item
                            }
                        }))
                    },
                });
            },
            minLength: 1
        });
    </script> 
</asp:Content>

