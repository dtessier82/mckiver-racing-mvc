<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Home_Master.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>
<%@ Import Namespace="MckiverRacing.MVC.Data" %>
<%@ Import Namespace="MckiverRacing.MVC.Web.Models" %>

<asp:Content ID="Content2" ContentPlaceHolderID="main" runat="server">
   <div id="pageContent">
   <table>
    <tr>
        <td>
          <table>
            <tr>
                <td valign="top">
                <div class="headlineheader">
                    <h3>Latest News</h3>
                    
                 </div>
                 <div class="headlinecontent">
                 <%foreach(News news in ViewData.Model.News){ %>

                    <%Html.RenderPartial("NewsDisplayControl", news); %>
                   
                <%} %>
                 </div>
                </td>
                <td>
                    &nbsp;
                </td>
                <td valign="top">
                    <div class="headlineheader">
                    <h3>Latest Results</h3>
                    
                 </div>
                 <div class="headlinecontent">
                 <%foreach (ScheduleViewModel Sched in ViewData.Model.Schedule)
              { %>

                <%Html.RenderPartial("ScheduleDisplayControl", Sched); %>
                <%Html.RenderPartial("ScheduleResultsDisplayControl", Sched); %>

            <%} %>
            <br />
            <%: Html.ActionLink("Read more...", "Details", "Schedule", new { id = DateTime.Now.Year }, null)%>
                 </div>
                
                
                </td>
                 <td>
                    &nbsp;
                </td>
                 <td valign="top">
                    <div class="headlineheader">
                    <h3>Latest Photos</h3>
                    
                 </div>
                  <div class="headlinecontent">
                  <p>Check Back Soon For Upcoming photos!</p>
                  </div>
            </tr>
            
          </table>  
        </td>
    </tr>
   </table>
   </div>
</asp:Content>
