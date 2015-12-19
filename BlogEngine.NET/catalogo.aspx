<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Custom/Themes/Standard/site.master" %>
<%@ Import Namespace="BlogEngine.Core" %>
<script language="c#" runat="server">
  protected static string world;
  protected void Page_Load(object sender, EventArgs e)
    {
      world = "world!";
    }
</script>
<asp:content id="Content1" contentplaceholderid="cphBody" runat="Server">
  <div>
    Hello <%=world %>
  </div>
</asp:content>