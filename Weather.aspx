<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weather.aspx.cs" Inherits="Chapt2.RoutePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <table>
                <tr>
                    <td>Route:</td>
                    <td><%=RouteData.Route !=null?RouteData.Route.GetType().FullName:"" %></td>
                </tr>
                 <tr>
                    <td>RouteHandler:</td>
                    <td><%=RouteData.RouteHandler !=null?RouteData.RouteHandler.GetType().FullName:"" %></td>
                </tr>
                 <tr>
                    <td>Values:</td>
                    <td>
                        <ul>
                        <% foreach (var val in RouteData.Values)
                           {
                        %>
                                <li> <%=val.Key %>=<%=val.Value %></li>
                        <%
                           } %>
                            </ul>
                    </td>
                </tr>
                    <tr>
                    <td>DataTokens:</td>
                    <td> <ul>
                        <% foreach (var val in RouteData.DataTokens)
                           {
                        %>
                                <li> <%=val.Key %>=<%=val.Value %></li>
                        <%
                           } %>
                            </ul></td>
                </tr>
            </table>
    </div>
    </form>
</body>
</html>
