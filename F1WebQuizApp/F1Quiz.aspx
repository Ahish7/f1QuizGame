<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F1Quiz.aspx.cs" Inherits="F1WebQuizApp.F1Quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>F1 Quiz Beta Game</title>
    <style type="text/css">
        .newStyle1 {
            font-family: arial, Helvetica, sans-serif;
            font-size: xx-large;
            font-weight: bolder;
        }
        .auto-style1 {
            text-align: center;
        }
        .newStyle2 {
            font-family: arial, Helvetica, sans-serif;
            font-size: x-large;
        }
        .auto-style3 {
            width: 644px;
        }
        .auto-style5 {
            width: 189px;
        }
        .auto-style6 {
            width: 189px;
            text-align: center;
            height: 128px;
        }
        .auto-style7 {
            width: 279px;
        }
        .auto-style8 {
            width: 279px;
            text-align: center;
            height: 128px;
        }
        .auto-style9 {
            width: 644px;
            height: 100px;
        }
        .auto-style10 {
            width: 189px;
            text-align: center;
            height: 100px;
        }
        .auto-style11 {
            width: 279px;
            text-align: center;
            height: 100px;
        }
        .auto-style12 {
            height: 100px;
        }
        .auto-style13 {
            width: 100%;
            height: 233px;
        }
        .auto-style14 {
            width: 644px;
            height: 128px;
        }
        .auto-style15 {
            height: 128px;
        }

        #btnSubmit{
            background-color: aqua;
            padding: 10px;
            transition: transform .2s;
            width: 20px;
            height: 200px;
            margin: 0 auto;
        }
        #btnSubmit:hover{
            background-color : limegreen;
            transform: scale(1.5);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblQuiz" runat="server" CssClass="newStyle1" Text="F1 Quiz Game"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <br />
        <div class="question">

        </div>
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1">
                <asp:Label ID="lblQuestion" runat="server" Text="Question" CssClass="newStyle2"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>     
    </table>
        <div class="options">

        </div>
        <table class="auto-style13">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Label ID="lblScore" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10">
                    
                    <asp:RadioButtonList ID="rbtnOptions" runat="server" EnableViewState="true">
                    </asp:RadioButtonList>

                    
                </td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style14">
                    </td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1" colspan="2">
                    
                    
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style1" colspan="2">
                    
                    
                    <asp:Button ID="btnSubmit" runat="server" Height="60px" OnClick="btnSubmit_Click" Text="Submit" Width="172px" />
                    
                    
                    </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    </body>
</html>
