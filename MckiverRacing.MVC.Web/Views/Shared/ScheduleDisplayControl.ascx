<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MckiverRacing.MVC.Web.Models.ScheduleViewModel>" %>

<div>
           <p><font class='schedule_main'><%: Html.Encode(Model.Schedule.Series.Description + " - " + Model.Schedule.Description)%>: <%: Html.Encode(string.Format("{0: MMM d}", Model.Schedule.Start_Date) + " - " + string.Format("{0: MMM d}", Model.Schedule.End_Date))%> - <%:Model.Schedule.Track.Track_Name %></font></p>
           
</div>