<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="MckiverRacing.MVC.Web.Models" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
    <div class="pageContent">
     <br />
           <h2><font class='bold'>
            Schedule & Results For <%:ViewData["SelectedYear"] %></font></h2>
           
             <div class="table_row">
             <br />
                <div class="sidebar">
                
                    <%: Html.ActionLink("2011 Season", "Details", "Schedule", new { id = 2011 }, new { @class = "schedLinks" })%><br /><br />
                    <%: Html.ActionLink("2010 Season", "Details", "Schedule", new { id = 2010 }, new { @class = "schedLinks" })%><br /><br />
                
                </div>
                <div class="rightPanel">
            Here you will find the 2011 R.A.C.E Schedule for #684 David McKiver. Check out how he qualified and finished for each individual class per race weekend. Please check back regularly for updated results!

            You may use the navigation links on the left to view previous season results.

            <p><i>NOTE: Please note anything marked with a N/A either was cancelled or did not take place.</i></p>
                <br />
            <%foreach (ScheduleViewModel Sched in ViewData.Model)
              { %>

                <%Html.RenderPartial("ScheduleDisplayControl", Sched); %>
                <%Html.RenderPartial("ScheduleResultsDisplayControl", Sched); %>

            <%} %>

            <br />
                </div>
             </div>
          <br style="clear:both;" />
    </div>
   
</asp:Content>

