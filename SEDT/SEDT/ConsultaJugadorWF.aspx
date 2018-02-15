<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ConsultaJugadorWF.aspx.cs" Inherits="SEDT.ConsultaJugadorWF" %>

<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Consulta Jugador</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-users"></i>Consultar Jugador <small>Complete al menos uno de los campos de búsqueda para obtener jugadores.</small></h2>
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
                            <div class="col-sm-12">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_ConsultaJugadorWF_DNI">DNI:</label>
                                            <input type="text" class="form-control" id="txt_ConsultaJugadorWF_DNI">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_ConsultaJugadorWF_Nombre">Nombre:</label>
                                            <input type="text" class="form-control" id="txt_ConsultaJugadorWF_Nombre">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_ConsultaJugadorWF_Apellido">Apellido:</label>
                                            <input type="text" class="form-control" id="txt_ConsultaJugadorWF_Apellido">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_ConsultaJugadorWF_Apodo">Apodo:</label>
                                            <input type="text" class="form-control" id="txt_ConsultaJugadorWF_Apodo">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div runat="server" id="ConsultaJugador_ComboEquipo" class="form-group">
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

                            <button id="btn_ConsultaJugador_Nuevo" class="btn btn-primary" style="display: none;" onclick="ConsultaJugador_Nuevo()" type="button">Nuevo</button>
                            <button id="btn_ConsultaJugador_Imprimir" class="btn btn-primary" style="display: none;" onclick="ConsultaJugador_Imprimir()" type="button">Imprimir</button>
                            <button id="btn_ConsultaJugador_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="ConsultaJugador_Consultar()" type="button">Consultar</button>
                            <button id="btn_ConsultaJugador_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="ConsultaJugador_Limpiar()" type="button">Limpiar</button>

                        </div>
                    </div>
                </div>
            </div>
        </div>


        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="x_panel">
                <div class="x_title">
                    <h2>Resultado de la búsqueda <small>...</small></h2>
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

                    <div class="table-responsive">
                        <table class="table table-striped jambo_table bulk_action">
                            <thead>
                                <tr class="headings">
                                    <th>
                                        <input type="checkbox" id="check-all" class="flat">
                                    </th>
                                    <th class="column-title">Nombre </th>
                                    <th class="column-title">Apellido </th>
                                    <th class="column-title">Apodo </th>
                                    <th class="column-title">Posición </th>
                                    <th class="column-title">Altura </th>
                                    <th class="column-title">Peso </th>
                                    <th class="column-title no-link last"><span class="nobr">Acción</span>
                                    </th>
                                    <th class="bulk-actions" colspan="7">
                                        <a class="antoo" style="color: #fff; font-weight: 500;">Bulk Actions ( <span class="action-cnt"></span>) <i class="fa fa-chevron-down"></i></a>
                                    </th>
                                </tr>
                            </thead>

                            <tbody id="ConsultaJugador_TablaResultado">

                            </tbody>
                        </table>
                    </div>


                </div>
            </div>
        </div>

    </div>
</asp:Content>

