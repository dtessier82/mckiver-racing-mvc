<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MckiverRacing.MVC.Web.Models.GuestBookViewModel>" %>
       <p><font class='bold'><%: Html.Encode(Model.Contact_Name) %></font> <font class="italic"> (<%: Html.Encode(string.Format("{0:dddd, MMMM d, yyyy}",Model.Date_Entered)) %>)</font></p>
           <p> <%: Model.Comment %> <br />
       </p>




