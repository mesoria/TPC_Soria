<%@ Page Title="Alumnos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TPC_Soria.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Lista de Alumnos.</h3>
             
<div class="table-responsive">
    <table class="table">
    <thead>
        <tr>
            <th style="width: 5%; background-color: #8ac8b6">
              # </th>
            <th style="width: 10%; background-color: #13d229">
              Apellidos </th>
            <th style="width: 10%; background-color: #64bf64">
              Nombres </th>
            <% =Dias() %>
        </tr>
        
    </thead>
         <% var j = 1; foreach (var item in Personas)
        { %>
        <tbody>
        <tr>
                <th style="width: 5%"><% = j%></th>
                <th style="width: 15%"><% = item.Apellido %></th>
                <th style="width: 15%"><% = item.Name %></th>
            <% DateTime d = DateTime.Now; for (var i = 1; i < d.Day; i++)
                {
            %>
                <td>
                  <div class="custom-control custom-checkbox">
                      <input type="checkbox" class="custom-control-input" id=<%=j %> <%= Asistio(i,item.ID)%> disabled="disabled">
                      <label class="custom-control-label" for=<%=i %>></label>
                  </div>
                </td>
            <%} %>
        <%j++;} %>
        </tr>

    </tbody>
  </table>
</div>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
