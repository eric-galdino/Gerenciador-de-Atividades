<%@ Page Title="Tela de Editar Atividade" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarAtividade.aspx.cs" Inherits="Gerenciador_De_Atividades.EditarAtividade" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %></h2>

    <div class="form-horizontal">
        <h4>Editar atividade</h4>
        <hr />

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Id" CssClass="col-md-2 control-label">Id</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Id" CssClass="form-control" ReadOnly="true"/>                
            </div>
        </div>
       
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Titulo" CssClass="col-md-2 control-label">Título</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Titulo" CssClass="form-control" />                
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Descricao" CssClass="col-md-2 control-label">Descrição</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Descricao" CssClass="form-control" />                
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Data</asp:Label>
            <div class="col-md-10">
                
                <asp:Calendar ID="Calendar"  runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px" OnSelectionChanged="Calendar_SelectionChanged">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar>               
            </div>
        </div>

         <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Hora" CssClass="col-md-2 control-label">Hora</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Hora" CssClass="form-control" />               
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Periodicidade" CssClass="col-md-2 control-label">Periodicidade</asp:Label>
            <div class="col-md-10">
                
                <asp:DropDownList ID="Periodicidade" runat="server">
                    <asp:ListItem Selected="True">Selecione</asp:ListItem>
                    <asp:ListItem>Diário</asp:ListItem>
                    <asp:ListItem>Semanal</asp:ListItem>
                    <asp:ListItem>Mensal</asp:ListItem>
                    <asp:ListItem>Anual</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Status" CssClass="col-md-2 control-label">Status (Concluído)</asp:Label>
            <div class="col-md-10">     
                <asp:CheckBox ID="Status" runat="server" />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" ID="btnUpdate"  Text="Atualizar" CssClass="btn btn-default" OnClick="btnUpdate_Click" />
                &nbsp
                <asp:Button runat="server" ID="btnCancel"  Text="Cancelar" CssClass="btn btn-default" OnClick="btnCancel_Click" />
                &nbsp
                <asp:Button runat="server" ID="btnDelete"  Text="Excluir" CssClass="btn btn-default" OnClick="btnDelete_Click" />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="Mensagem1" runat="server" Text="Label" Font-Size="Large" ForeColor="Blue" Visible="false">Atividade atualizada com sucesso</asp:Label>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="Mensagem2" runat="server" Text="Label" Font-Size="Medium" ForeColor="Blue" Visible="false">Atividade excluída com sucesso</asp:Label>
            </div>
        </div>
        
    </div>

</asp:Content>

