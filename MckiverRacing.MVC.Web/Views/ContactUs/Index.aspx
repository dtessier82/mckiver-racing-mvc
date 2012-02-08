<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<MckiverRacing.MVC.Web.Models.ContactViewModel>" %>
<%@ Import Namespace="MckiverRacing.MVC.Web.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">

    <div class="pageContent">
    <h2>Contact Us</h2>
    <p>
        Should you have any questions or comments please feel free to contact the McKiver Racing Team using the form below.
    </p>
    <div class="table_row">
        <div class="table_col_left_350x">
        <%using(Html.BeginForm()){ %>
        <%: Html.ValidationSummary(true) %>
        
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Name) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Name, new { @class = "textfield_effect" })%>
                <%: Html.ValidationMessageFor(model => model.Name) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Email) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Email, new { @class = "textfield_effect" })%>
                <%: Html.ValidationMessageFor(model => model.Email) %>
            </div>

            <div class="editor-label">
                <%: Html.LabelFor(model => model.Type) %>
            </div>
            <div>

            <%: Html.DropDownListFor(model=>model.Type, (SelectList)ViewData["ContactTypes"])%>


            </div>
          <%--  <div class="editor-label">
                <%: Html.LabelFor(model => model.Subject) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Subject) %>
                <%: Html.ValidationMessageFor(model => model.Subject) %>
            </div>--%>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Comment) %>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.Comment, new { cols = "40%", rows = "10%", @class = "textfield_effect" })%>
                <%: Html.ValidationMessageFor(model => model.Comment) %>
            </div>
            
          
                <input type="submit" value="Send" /><br /><br />
                <div class="message">
                 <%:ViewData["Message"] %> 
                </div>
                 
        
    <% } %>

        </div>
        <div class="table_col_left_350x">
               
        <img src="../../Content/images/bike_400X33.png"/>
        </div>
    </div>
    
    <div>
     <br style="clear:both;" />
     </div>
    </div>
</asp:Content>


