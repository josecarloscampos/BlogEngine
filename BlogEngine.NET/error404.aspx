<%@ Page Language="C#" AutoEventWireup="true" Inherits="error404" Codebehind="error404.aspx.cs" %>

<asp:content id="Content1" contentplaceholderid="cphBody" runat="Server">
  <div class="post error404 page-global">
    <h2 class="page-global-title">Ooops! No puedo encontrar la página que estás buscando</h2>
    <div id="divSearchEngine" runat="server" visible="False" class="search">
      <p>
        Usted hizo una búsqueda en <strong><a href="<%=Server.HtmlEncode(Request.UrlReferrer.ToString()) %>"><%=Server.HtmlEncode(Request.UrlReferrer.Host)%></a></strong>
        para <strong><%=SearchTerm %></strong>. Sin embargo, su índice parece estar fuera de fecha.
      </p>
      <h2>No todo está perdido!</h2>
      <p>Creo que las siguientes páginas en mi sitio web podrán ayudarle:</p>
      <div id="divSearchResult" runat="server" class="searchresults" />
    </div>
        <div id="divExternalReferrer" runat="server" visible="False">
      <p>
        Has sido referido incorrectamente a esta página a través de: 
        <a href="javascript:history.go(-1)"><%=Server.HtmlEncode(Request.UrlReferrer.Host)%></a> 
      </p>
            <p>Le sugiero que pruebe uno de los siguientes enlaces:</p>
      <ul>
        <li><a href="archive<%= BlogEngine.Core.BlogConfig.FileExtension %>"><%=Resources.labels.archive %></a></li>
        <li><a href="<%=BlogEngine.Core.Utils.RelativeWebRoot %>">Home page</a></li>
      </ul>
            <p>También puede tratar de <strong>buscar la página que estabas buscando</strong>:</p>
      <blog:SearchBox runat="server" />
            <p>Lo siento por las molestias</p>
    </div>
        <div id="divInternalReferrer" runat="server" visible="False">
      <p>
        Por favor, acepte mis disculpas por esto. Espere un momento e intente recargar nuevamente la página.
        Parece que el link esta caído.
      </p>
            <p>También puede tratar de <strong>buscar la página que estabas buscando</strong>:</p>
      <blog:SearchBox ID="SearchBox2" runat="server" /><br /><br />
    </div>
        <div id="divDirectHit" runat="server" visible="False">
      <p>Usted puede encontrar uno de los siguientes enlaces útiles:</p>
      <ul>
        <asp:placeholder runat="server" id="phSearchResult" />
        <li><a href="archive<%= BlogEngine.Core.BlogConfig.FileExtension %>"><%=Resources.labels.archive %></a></li>
        <li><a href="<%=BlogEngine.Core.Utils.RelativeWebRoot %>">Home page</a></li>
      </ul>
           p>También puede tratar de <strong>buscar la página que estabas buscando</strong>:</p>
      <blog:SearchBox ID="SearchBox1" runat="server" />
            <hr />
            <p><strong>Puede que no sea capaz de encontrar la página que estabas después debido a:</strong></p>
      <ol type="a">
        <li>An <strong>out-of-date bookmark/favorite</strong></li>
        <li>A search engine that has an <strong>out-of-date listing for us</strong></li>
        <li>A <strong>miss-typed address</strong></li>
      </ol>
    </div>
  </div>
</asp:content>
