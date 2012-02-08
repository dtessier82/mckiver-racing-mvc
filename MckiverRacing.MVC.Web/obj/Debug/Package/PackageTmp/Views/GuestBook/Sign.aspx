<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Main.Master" Inherits="System.Web.Mvc.ViewPage<MckiverRacing.MVC.Web.Models.GuestBookViewModel>" %>
<%@ Import Namespace="MvcReCaptcha.Helpers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
<div class="pageContent">
    <h2>GuestBook</h2>
    <p>
        Please feel free to sign the McKiver Racing Team Guestbook by using the form below.
You may also <a href="/GuestBook">view</a> what others have said about McKiver Racing.
    </p>
    <div class="table_row">
        <div class="table_col_left_350x">
        <%using(Html.BeginForm()){ %>
        <%: Html.ValidationSummary(true) %>
        
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Contact_Name)%>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Contact_Name,new {@class="textfield_effect"})%>
                <%: Html.ValidationMessageFor(model => model.Contact_Name) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Contact_Email) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Contact_Email, new { @class = "textfield_effect" })%>
                <%: Html.ValidationMessageFor(model => model.Contact_Email) %>
            </div>

            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Comment) %>
            </div>
            <div class="editor-field">
                <%: Html.TextAreaFor(model => model.Comment, new { cols = "40%", rows = "10%", @class = "textfield_effect" })%>
                <%: Html.ValidationMessageFor(model => model.Comment) %>
            </div>
            <div class="editor-field">
               <%= Html.GenerateCaptcha() %>
            </div>
                <input type="submit" value="Send" /><br /><br />
                <div class="message">
                 <%:ViewData["ErrorMessage"] %> 
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