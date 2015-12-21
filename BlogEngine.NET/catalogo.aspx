<%@ Page Language="C#" AutoEventWireup="true" Inherits="catalogo" EnableViewState="false" Codebehid="catalogo.aspx.cs"%>
<%@ Import Namespace="BlogEngine.Core" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphBody" Runat="Server">
     <script type="text/javascript">
         $(document).on("ready", function () {
             $("#catalogo").addClass("active");

         });

    </script>
    <script src="js/jquery.responsivetable.min.js" type="text/javascript"></script>
   <%-- <script type="text/javascript">
        $(document).ready(function () {
            setupResponsiveTables();
          
        });

        function setupResponsiveTables() {
      
            $('.responsiveTable1').responsiveTable({
                staticColumns: 2,
                scrollRight: false,
                scrollHintEnabled: true,
                scrollHintDuration: 3000
            });
        }

    </script>--%>
<style type="text/css">
    .auto-style1 {
        height: 44px;
    }
</style>

    <table  >

    <tr>
        <td >
          <h1>
Catalógo de Cursos
          </h1>	 <br />


        </td>
     <td id="td_Buscar">
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese un dato *" ForeColor="Red" ValidationGroup="buscar" ControlToValidate="txtBuscar"></asp:RequiredFieldValidator><asp:Textbox id="txtBuscar" runat="server"></asp:Textbox>
       <asp:button id="bttBuscar" ValidationGroup="buscar" class="button blue" runat="server" text="Buscar" OnClick="bttBuscar_Click" />
     </td>
       

    </tr>
  <%--  la logica de cada letra para poder buscar el catalogo --%>
     <tr >
          <td  colspan="2" height="25">

          </td>

      </tr>
     <tr>
          <td  style="width:100%;height:auto; text-align:center;"  class="textos a" colspan="2" >
               <asp:linkbutton ID="lbtt_A" runat="server" OnClick="lbtt_A_Click">A</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_B" runat="server" OnClick="lbtt_B_Click">B</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_C" runat="server" OnClick="lbtt_C_Click">C</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_D" runat="server" OnClick="lbtt_D_Click">D</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_E" runat="server" OnClick="lbtt_E_Click">E</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_F" runat="server" OnClick="lbtt_F_Click">F</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_G" runat="server" OnClick="lbtt_G_Click">G</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_H" runat="server" OnClick="lbtt_H_Click">H</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_I" runat="server" OnClick="lbtt_I_Click">I</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_J" runat="server" OnClick="lbtt_J_Click">J</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_K" runat="server" OnClick="lbtt_K_Click">K</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_L" runat="server" OnClick="lbtt_L_Click">L</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_M" runat="server" OnClick="lbtt_M_Click">M</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_N" runat="server" OnClick="lbtt_N_Click">N</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_Ñ" runat="server" OnClick="lbtt_Ñ_Click">Ñ</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_O" runat="server" OnClick="lbtt_O_Click">O</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_P" runat="server" OnClick="lbtt_P_Click">P</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_Q" runat="server" OnClick="lbtt_Q_Click">Q</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_R" runat="server" OnClick="lbtt_R_Click">R</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_S" runat="server" OnClick="lbtt_S_Click">S</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_T" runat="server" OnClick="lbtt_T_Click">T</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_U" runat="server" OnClick="lbtt_U_Click">U</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_V" runat="server" OnClick="lbtt_V_Click">V</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_W" runat="server" OnClick="lbtt_W_Click">W</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_X" runat="server" OnClick="lbtt_X_Click">X</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_Y" runat="server" OnClick="lbtt_Y_Click">Y</asp:linkbutton><span>-</span>
               <asp:linkbutton ID="lbtt_Z" runat="server" OnClick="lbtt_Z_Click">Z</asp:linkbutton>
          </td>

      </tr>

     <tr>
         <td align="left" class="textos" colspan="1" height="25">
         <asp:Label  ID="lbl_Find" runat="server" Text="Label" Visible="false"></asp:Label>
             </td>
          <td  colspan="1"  height="25">
              
              <asp:Label ID="lbl_keyword" runat="server" Text="a" Visible="False"></asp:Label>

          </td>

      </tr>
   <tr>
       <td colspan="2" style="height:20px;">

       </td>
   </tr>
    <tr>

        <td colspan="2" >
           
             <asp:GridView ID="gv_Catalogo" runat="server" RowStyle-Wrap="false"   AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="6"  AllowPaging="True" DataKeyNames="ID" PageSize="15"   OnPageIndexChanging="gv_Catalogo_PageIndexChanging" EnableModelValidation="True" CellSpacing="30">
                        <Columns>
                            <asp:TemplateField HeaderText="Codigo">
                                <ItemTemplate>
                                    <%# (DataBinder.Eval(Container.DataItem, "Cod_Asig"))%>
                                </ItemTemplate>
                  
                            </asp:TemplateField>
                            <asp:TemplateField  HeaderText="Curso">
                                <ItemTemplate >
                                   <a href='<%# (DataBinder.Eval(Container.DataItem, "link"))%>' target="_blank" class="textos a"> <%# (DataBinder.Eval(Container.DataItem, "curso"))%></a> 
                                </ItemTemplate>
                           
                            </asp:TemplateField>
                         
                             <asp:TemplateField HeaderText="&nbsp;Año&nbsp;del&nbsp;curso&nbsp;">
                                <ItemTemplate>
                                    <%# (DataBinder.Eval(Container.DataItem, "fecha"))%>
                                </ItemTemplate>
                                 <ItemStyle  HorizontalAlign="Center"/>
                           
                            </asp:TemplateField>
                             <asp:TemplateField  HeaderText="Cuatrimestre">
                                <ItemTemplate >
                                    <%# (DataBinder.Eval(Container.DataItem, "cuatri"))%>
                                </ItemTemplate>
                           
                            </asp:TemplateField>

                           
                        
                        </Columns>
                        <FooterStyle BackColor="White" ForeColor="#000066" />
                        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                        <RowStyle BorderColor="#E0E0E0" BorderStyle="Solid" BorderWidth="1px" Font-Size="13px" ForeColor="#000066" />
                        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" Font-Size="13px" HorizontalAlign="Center" />
                        <AlternatingRowStyle BorderColor="#d1d1d1" BorderStyle="Solid" BorderWidth="1px" />
                        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <PagerSettings FirstPageText="primera página" LastPageText="última pagina" 
            Mode="NextPreviousFirstLast" NextPageText=" >> " PreviousPageText=" << " />
                    </asp:GridView>
                  
        </td>
    </tr>
    <tr>

        <td class="textos a">
            <asp:Label ID="lbl_Message" runat="server" Text="Label" ForeColor="Red"></asp:Label>


        </td>
    </tr>

</table>
       
   

</asp:Content>

