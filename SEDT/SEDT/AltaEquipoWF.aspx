<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaEquipoWF.aspx.cs" Inherits="SEDT.AltaEquipoWF" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Alta Equipo</h3>
                </div>
            </div>
            <div class="clearfix"></div>
            <%--<div class="row">--%>
            <div class="col-md-12 col-sm-12 col-xs-12">
                        <form runat="server" class="form-horizontal form-label-left">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2><i class="fa fa-shield"></i> Nuevo Equipo <small>Complete los campos para agregar un nuevo equipo.</small></h2>
                            <ul class="nav navbar-right panel_toolbox">
                                <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                                </li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false"><i class="fa fa-wrench"></i></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="#">Settings 1</a>
                                        </li>
                                        <li><a href="#">Settings 2</a>
                                        </li>
                                    </ul>
                                </li>
                                <li><a class="close-link"><i class="fa fa-close"></i></a>
                                </li>
                            </ul>
                            <div class="clearfix"></div>
                        </div>

                        <div class="x_content">

                            <div id="kv-avatar-errors-2" class="center-block" style="width:800px;display:none"></div>

                            <div class="row">
                                <div class="col-sm-3">
                                    <div class="kv-avatar center-block text-center" style="width:200px">
                                        <input id="avatar-2" name="avatar-2" type="file" class="file-loading" required>
                                    </div>
                                </div>
                                <div class="col-sm-9">
                                          <div class="row">
                                    <div class="col-sm-6">
                                      <div class="form-group">
                                        <label for="email">Nombre<span class="kv-reqd"> (*)</span></label>
                                        <asp:TextBox runat="server" cssClass="form-control" ID="txAgregar_Equipo_Nombre"></asp:TextBox>
                                      </div>
                                    </div>
                                    <div class="col-sm-6">
                                      <div class="form-group">
                                        <label for="pwd">Siglas</label>
                                        <asp:TextBox runat="server" cssClass="form-control" ID="txAgregar_Equipo_Siglas"></asp:TextBox>
                                      </div>
                                    </div>
                                  </div>
                                  <div class="row">
                                    <div class="col-sm-6">
                                      <div class="form-group">
                                        <label for="fname">Sitio Web:</label>
                                        <asp:TextBox runat="server" cssClass="form-control" ID="txAgregar_Equipo_SitioWeb"></asp:TextBox>
                                      </div>
                                    </div>
                                    <div class="col-sm-6">
                                      <div class="form-group">
                                        <label for="lname">Teléfono / Contacto:</label>
                                        <asp:TextBox runat="server" cssClass="form-control" ID="txAgregar_Equipo_Telefono"></asp:TextBox>
                                      </div>
                                    </div>
                                  </div>
                                </div>
                            </div>
                        </div>
                            
                        <br />

                        <div class="form-group">
                            <div class="col-md-12 col-sm-12 col-xs-12">
                        <div class="ln_solid"></div>
                                <button class="btn btn-primary" type="button">Cancelar</button>
                                <button class="btn btn-primary" type="reset">Limpiar</button>
                                <asp:Button type="submit" runat="server" ID="btnAgregarGeneral" class="btn btn-primary"
                                AutoPostBack="True" Text="Guardar" OnClick="btnGuardar_OnClick"></asp:Button>
                            </div>
                        </div>
                        </div>
                        </form>
                    </div>
        </div>
    </div>
</asp:Content>
