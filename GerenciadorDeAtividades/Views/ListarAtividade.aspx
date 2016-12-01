<%@ Page Title="Listagem de Atividades"  MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ListarAtividade.aspx.cs" Inherits="GerenciadorDeAtividades.Views.ListarAtividade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %></h2>
   

    <div class="form-horizontal">
        <h4>Listar todas atividades</h4>
        <hr />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Id" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" AllowSorting="True" DataSourceID="SqlDataSource1">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="titulo" HeaderText="titulo" SortExpression="titulo" />
                    <asp:BoundField DataField="descricao" HeaderText="descricao" SortExpression="descricao" />
                    <asp:BoundField DataField="data" HeaderText="data" SortExpression="data" />
                    <asp:BoundField DataField="hora" HeaderText="hora" SortExpression="hora" />
                    <asp:BoundField DataField="periodicidade" HeaderText="periodicidade" SortExpression="periodicidade" />
                    <asp:CheckBoxField DataField="status" HeaderText="status" SortExpression="status" />
                    <asp:TemplateField>  
                        <ItemTemplate>  
                            <asp:Button ID="btnEdit" runat="server" Width="60" Text="Editar" CommandName="EditButton" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />  
                        </ItemTemplate>  
                    </asp:TemplateField>  
                </Columns>
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:agendasConnectionString %>" SelectCommand="SELECT * FROM [tbl_atividades]"></asp:SqlDataSource>
        
        <div class="form-group">
            
        </div>
        
    </div>
</asp:Content>