<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript" language="javascript">
            
            function Multiply() {
                var service = new AJAX.MathService();
                service.Multiplication($get("txtOne").value, $get("txtTwo").value, onSuccess, onFailure);
            }
            function onSuccess(result) {
                $get("new").innerHTML = "The multiplication is:"+result;
            }
            function onFailure(result) {
                window.alert(result.get_message());
            }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
        <asp:ServiceReference Path="MathService.svc" />
        </Services>
        </asp:ScriptManager>
    
        <br />
    
    </div>
    <asp:Label ID="Label1" CssClass="label" runat="server" Text="Enter one number:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input 
        id="txtOne" type="text" />&nbsp;
    <br />
    <br />
    <asp:Label ID="Label2" CssClass="label" runat="server" Text="Enter another number:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input id="txtTwo" type="text" /><br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    <input id="btnClick" type="button" class="button" value="Click Me" onclick="return Multiply()" /><br />
    <div class="label" id="new"></div>
    <br />
    </form>
</body>
</html>
