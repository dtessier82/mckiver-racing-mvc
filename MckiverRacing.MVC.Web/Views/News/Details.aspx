<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<MckiverRacing.MVC.Data.News>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
<div class="pageContent">
    <h2><font class='bold'><%: Html.Encode(Model.News_Title) %></font></h2>
    <p>
       <font class='bold'> <%: Html.Encode(string.Format("{0:dddd, MMMM d, yyyy}",Model.Created_Date)) %></font><br />

    </p>
   <p class="news"> <%: Model.Description %> </p>
    <p>
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
    </div>
</asp:Content>


