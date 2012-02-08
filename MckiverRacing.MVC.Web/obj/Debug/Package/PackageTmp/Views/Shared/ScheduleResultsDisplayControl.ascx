<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<MckiverRacing.MVC.Web.Models.ScheduleViewModel>" %>

<table border='1' style='border-color:yellow;font-family: Verdana, Arial, Helvetica, sans-serif; font-size:12px;'>
	<tr><th>Class</th>
        <th>Qualify Pos</th>
        <th>Qualify Time</th>
        <th>Finish Pos</th>
        <th>Finish Time</th>
     </tr>
            <% 
                foreach(MckiverRacing.MVC.Data.Race_ScheduleResult r in ViewData.Model.Results)
               { %>


                    <tr>
                        <td>
                            <%: Html.Encode( r.Class.Class_Name) %>
                        </td>
                        <td>
                            <%: Html.Encode( r.Qualify_Position.ToString()) %>
                        </td>
                        <td>
                            <%: Html.Encode( r.Qualify_Time.ToString()) %>
                        </td>
                        <td>
                            <%: Html.Encode( r.Finish_Position.ToString()) %>
                        </td>
                        <td>
                            <%: Html.Encode( r.Finish_Time.ToString()) %>
                        </td>
                    </tr>


            <%} %>
</table>