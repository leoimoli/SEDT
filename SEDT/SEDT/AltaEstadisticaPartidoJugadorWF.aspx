<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaEstadisticaPartidoJugadorWF.aspx.cs" Inherits="SEDT.AltaEstadisticaPartidoJugadorWF" %>

<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Alta Partido</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-users"></i>Alta jugador por partido <small>Complete los campos para agregar la estadistica de un jugador jugador.</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                            <li><a class="close-link"><i class="fa fa-close"></i></a>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <div id="kv-avatar-errors-2" class="center-block" style="width: 800px; display: none"></div>
                        <div class="row">
                            <div class="col-sm-9">
                                <%--1--%>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoJugadorWF_Marcador" style="width: 100px" value="Favor">
                                        </div>
                                    </div>
                                </div>
                                <%--2--%>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <div runat="server" id="cmb_Torneo" class="form-group">
                                            </div>
                                            <div runat="server" id="cmb_ComboEquipoRival" class="form-group">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="form-group">
                                <div class="col-md-12 col-sm-12 col-xs-12">
                                    <div class="ln_solid"></div>
                                    <button id="btn_AltaEstadisticaPartido_Nuevo" class="btn btn-primary" style="display: none;" onclick="AltaEstadisticaPartido_Nuevo()" type="button">Nuevo</button>
                                    <button id="btn_AltaEstadisticaPartido_Siguiente" class="btn btn-success" style="display: none;" onclick="AltaEstadisticaPartido_Siguiente()" type="button">Estadistica Jugador</button>
                                    <button id="btn_AltaEstadisticaPartido_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEstadisticaPartido_Guardar()" type="button">Guardar</button>
                                    <button id="btn_AltaEstadisticaPartido_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEstadisticaPartido_Limpiar()" type="button">Limpiar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

