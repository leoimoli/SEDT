<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaJugadorCarteraWF.aspx.cs" Inherits="SEDT.AltaJugadorCarteraWF" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Alta Jugador Preseleccionado</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-users"></i>Nuevo Jugador Preseleccionado <small>Complete los campos para agregar un nuevo jugador Preseleccionado.</small></h2>
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
                            <%--  <div class="col-sm-3">
                                <div class="kv-avatar center-block text-center" style="width: 200px">
                                    <input id="avatar-2" name="avatar-2" type="file" class="file-loading" required>
                                </div>
                            </div>--%>

                            <div class="col-sm-9">
                                <div class="row">
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Apellido">Apellido:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Apellido">
                                        </div>
                                    </div>
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Nombre">Nombre:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Nombre">
                                        </div>
                                    </div>
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Apodo">Apodo:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Apodo">
                                        </div>
                                    </div>
                                </div>
                                 <div class="row">
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Telefono">Telefono de Contacto:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Telefono">
                                        </div>
                                    </div>
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Email">Email:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Email">
                                        </div>
                                    </div>
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_RedSocial">Facebook:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_RedSocial">
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_EquipoObservado">Equipo Observado:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_EquipoObservado">
                                        </div>
                                    </div>
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_EquipoRival">Equipo Rival:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_EquipoRival">
                                        </div>
                                    </div>
                                    <div class="col-sm-4">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Apodo">Fecha Partido:<span class="kv-reqd"> (*)</span></label>
                                            <div class="row calendar-exibit">
                                                <div class="control-group">
                                                    <div class="controls">
                                                        <div class="col-md-11 xdisplay_inputx form-group has-feedback">
                                                            <input type="text" class="form-control has-feedback-left" id="single_cal2" aria-describedby="inputSuccess2Status2">
                                                            <span class="fa fa-calendar-o form-control-feedback left" aria-hidden="true"></span>
                                                            <span id="inputSuccess2Status2" class="sr-only">(success)</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
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

                            <button id="btn_AltaJugador_Nuevo" class="btn btn-primary" style="display: none;" onclick="AltaJugador_Nuevo()" type="button">Nuevo</button>
                            <button id="btn_AltaJugador_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaJugador_Guardar()" type="button">Guardar</button>
                            <button id="btn_AltaJugador_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaJugador_Limpiar()" type="button">Limpiar</button>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

