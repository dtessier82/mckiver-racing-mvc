<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<table>
    <tr>
        <td>
            <a href="/Home">
                <%if (ViewData["Selected"] != null)
                  {
                      if (ViewData["Selected"] == "Home")
                      { 
                %>
                <img id="home_link" src="../../Content/images/home_selected.png" />
                <%}
                                            else
                                            { %>
                <img id="home_link" src="../../Content/images/home.png" />
                <%}
                  }
                  else
                  { %>
                <img id="home_link" src="../../Content/images/home_selected.png" />
                <%} %>
            </a>
        </td>
        <td>
            <img src="../../Content/images/seperator.png" />
        </td>
        <td>
            <a href="/Bio">
                <%if (ViewData["Selected"] != null)
                  {
                      if (ViewData["Selected"] == "Bio")
                      { 
                %>
                <img id="bio_link" src="../../Content/images/bio_selected.png" />
                <%}
                                            else
                                            {%>
                <img id="bio_link" src="../../Content/images/bio.png" />
                <%}
                  }
                  else
                  { %>
                <img id="bio_link" src="../../Content/images/bio.png" />
                <%} %>
            </a>
        </td>
        <td>
            <img src="../../Content/images/seperator.png" />
        </td>
        <td>
            <a href="/Schedule">
                <% if (ViewData["Selected"] != null)
                   {
                       if (ViewData["Selected"] == "Sched")
                       {%>
                <img id="sched_link" src="../../Content/images/sched_selected.png" />
                <% }
                                            else
                                            {%>
                <img id="sched_link" src="../../Content/images/sched.png" />
                <%}
                   }
                   else
                   { %>
                <img id="sched_link" src="../../Content/images/sched.png" />
                <%} %>
            </a>
        </td>
        <td>
            <img src="../../Content/images/seperator.png" />
        </td>
        <td>
            <a href="/Photos">
                <% if (ViewData["Selected"] != null)
                   {
                       if (ViewData["Selected"] == "Photos")
                       {%>
                <img id="photo_link" src="../../Content/images/photos_selected.png" />
                <% }
                                            else
                                            {%>
                <img id="photo_link" src="../../Content/images/photos.png" />
                <%}
                   }
                   else
                   { %>
                <img id="photo_link" src="../../Content/images/photos.png" />
                <%} %>
            </a>
        </td>
        <td>
            <img src="../../Content/images/seperator.png" />
        </td>
        <td>
            <a href="/Sponsors">
                <% if (ViewData["Selected"] != null)
                   {
                       if (ViewData["Selected"] == "Sponsors")
                       {%>
                <img id="sponsor_link" src="../../Content/images/sponsors_selected.png" />
                <% }
                                            else
                                            {%>
                <img id="sponsor_link" src="../../Content/images/sponsors.png" />
                <%}
                   }
                   else
                   { %>
                <img id="sponsor_link" src="../../Content/images/sponsors.png" />
                <%} %>
            </a>
        </td>
         <td>
            <img src="../../Content/images/seperator.png" />
        </td>
        <td>
            <a href="/ContactUs">
                <% if (ViewData["Selected"] != null)
                   {
                       if (ViewData["Selected"] == "ContactUs")
                       {%>
                <img id="contact_link" src="../../Content/images/contact_selected.png" />
                <% }
                                            else
                                            {%>
                <img id="contact_link" src="../../Content/images/contact.png" />
                <%}
                   }
                   else
                   { %>
                <img id="contact_link" src="../../Content/images/contact.png" />
                <%} %>
            </a>
        </td>
    </tr>
</table>
