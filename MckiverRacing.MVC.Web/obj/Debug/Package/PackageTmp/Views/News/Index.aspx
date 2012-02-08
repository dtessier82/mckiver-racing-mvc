<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="MckiverRacing.MVC.Data" %>


<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">

          <div class="pageContent"> 	
            <h2><font class='bold'>Latest News</font></h2>
            <br />

            <p>Below you will find the latest postings done by the McKiver Racing Team.</p>
            <br />
            <%foreach(News news in ViewData.Model){ %>

                <%Html.RenderPartial("NewsDisplayControl",news); %>

            <%} %>
            </div>
</asp:Content>
