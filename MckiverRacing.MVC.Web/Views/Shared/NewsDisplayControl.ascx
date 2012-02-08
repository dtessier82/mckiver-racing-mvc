<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MckiverRacing.MVC.Data.News>" %>

           <p><font class='bold'><%: Html.Encode(Model.News_Title) %></font> <font class="italic"><br /> (<%: Html.Encode(string.Format("{0:dddd, MMMM d, yyyy}",Model.Created_Date)) %>)</font></p>
           <p> <%: Model.News_Schort_Description %> ...<br />
           <%: Html.ActionLink("Read more...", "Details", "News", new { id = Model.ID }, null) %>
           </p>
    