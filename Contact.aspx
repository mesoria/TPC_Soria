<%@ Page Title="Alumnos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TPC_Soria.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Lista de Alumnos.</h3>

    <asp:GridView ID="grid" runat="server" CssClass=""  ></asp:GridView>
    <div class="custom-control custom-switch">
        <input type="checkbox" class="custom-control-input" id="customSwitch1">
        <label class="custom-control-label" for="customSwitch1">Toggle this switch element</label>
    </div>
    
    <div class="Container">
        <div class="row">
            <div class="col-6">
                <table class="table table-striped">
      <thead>
        <tr>
          <th scope="col"  >#</th>
          <th scope="col">Nombre</th>
          <th scope="col">Apellido</th>
          <th scope="col">DNI</th>
          <th scope="col">Nacimiento</th>
        </tr>
      </thead>
        <% var i = 1; foreach (var item in Personas)
           { %>
              <tbody>
                <tr>
                  <th scope="row"><% = i%></th>
                  <td><% = item.Name %></td>
                  <td><% = item.Apellido %></td>
                  <td><% = item.DNI %></td>
                  <td><% = item.Nacimiento %></td>
                  <td class="custom-control custom-switch"><input type="checkbox" class="custom-control-input" id="Switch1"></td>
                </tr>
                  <%i++;} %>
              </tbody>
    </table>
            </div>
        </div>
    </div>
    <div class="table-responsive">
  <table class="table">
    <thead>
      <tr>
        <th style="width: 10.344827586207%; background-color: #8ac8b6">
          uno </th>
        <th style="width: 17.241379310345%; background-color: #64bf64">
          dos </th>
        <th style="width: 6.8965517241379%; background-color: #13d229">
          tres </th>
        <th style="width: 24.137931034483%; background-color: #708928">
          cuatro </th>
        <th style="width: 13.793103448276%; background-color: #678121">
          cinco </th>
        <th style="width: 27.586206896552%; background-color: #d7ed7a">
          seis </th>
      </tr>
    </thead>
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
