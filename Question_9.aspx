//9.Given the following ASPX file, which method can be used to read the
//JavaScript random number in the server-side code in the page: (10 points)
//<%@ Page Language = "C#" %>
//<%
//    // How to read number here?
//%>
//< html xmlns="http://www.w3.org/1999/xhtml" >
//<head runat="server">
//    <script type="text/javascript">
//        var number = (Math.random() *1000);
//    </ script >
//</ head >
//< body >
//    < form id = "form1" runat = "server" >

//       </ form >
//   </ body >
//   </ html >


<%@ Page Language = "C#" %>
<%
   var num = Request.Form["HiddenField1"];
%>

< html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <script type="text/javascript">
        var number = (Math.random() *1000);
    </ script >
</ head >
< body >
    < form id = "form1" runat = "server" >

option=>     <asp:HiddenFieldID="HiddenField1" runat="server" value=<%= number %>/>

       </ form >
   </ body >
</ html >


Ansewr:

    Changeing the code in the page:
        4) all above

    if whitout any change in <body>...</body> it is not possible
        5) not possible

