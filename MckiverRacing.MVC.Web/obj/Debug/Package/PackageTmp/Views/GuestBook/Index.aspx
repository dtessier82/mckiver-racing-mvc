<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="MckiverRacing.MVC.Web.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
    <div class="pageContent">
    <h2>GuestBook</h2>
    <p>
  Below are some comments left by other visitors to McKiver Racing.
  </p>
  <div class="table_row">
        <div class="table_col_left_450">
  
 <%foreach(GuestBookViewModel model in ViewData.Model){ %>

                <%Html.RenderPartial("GuestBookListControl", model); %>

  <%}%>
 
  <%: Html.ActionLink("< Sign the GuestBook >", "Sign", null, null) %><br /><br />
  </div>
  <div class="table_col_left_350x">
               
        <img src="../../Content/images/bike_400X33.png"/>
        </div>

        <br style="clear:both"/>
   </div>

</asp:Content>

