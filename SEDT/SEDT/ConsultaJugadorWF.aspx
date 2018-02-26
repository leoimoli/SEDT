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

        <div id="Div_Ver" class="col-md-12 col-sm-12 col-xs-12 DivVer">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-users"></i>Editar Jugador <small>Complete los campos para editar un jugador.</small></h2>
                     <div class="clearfix"></div>
                    </div>

                    <div class="x_content">

                        <div id="kv-avatar-errors-2" class="center-block" style="width: 800px; display: none"></div>

                        <div class="row">
                            <div class="col-sm-3">
                                <div class="kv-avatar center-block text-center" style="width: 200px">
                                    <input id="avatar-2" name="avatar-2" type="file" class="file-loading" required>
                                </div>
                            </div>

                            <div class="col-sm-9">
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Nombre">Nombre:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Nombre">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Apellido">Apellido:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Apellido">
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Apodo">Apodo:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Apodo">
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_DNI">DNI:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_DNI">
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_FechaNacimiento">Fecha de Nacimiento:<span class="kv-reqd"> (*)</span></label>
                                            <div class="row calendar-exibit">
                                                <div class="control-group">
                                                    <div class="controls">
                                                        <div class="col-md-12 xdisplay_inputx form-group has-feedback">
                                                            <input type="text" class="form-control has-feedback-left" id="single_cal2" aria-describedby="inputSuccess2Status2">
                                                            <span class="fa fa-calendar-o form-control-feedback left" aria-hidden="true"></span>
                                                            <span id="inputSuccess2Status2" class="sr-only">(success)</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_AltaJugadorWF_Peso">Telefono:<span class="kv-reqd"> (*)</span></label>
                                            <input type="text" class="form-control" id="txt_AltaJugadorWF_Telefono">
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
                            <button id="btn_AltaJugador_Siguiente" class="btn btn-success" style="display: none;" onclick="AltaJugador_Siguiente()" type="button">Ficha Tecnica</button>
                            <button id="btn_AltaJugador_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaJugador_Guardar()" type="button">Guardar</button>
                            <button id="btn_AltaJugador_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaJugador_Limpiar()" type="button">Limpiar</button>
                            <button id="btn_Volver_Fade" class="btn btn-primary pull-right" style="display: inline-block;" onclick="MostrarGrilla()" type="button">Volver</button>
                        </div>
                    </div>
                </div>
            </div>
            
        </div>

        <div id="Div_Consulta"class="col-md-12 col-sm-12 col-xs-12 ConsultaJugadores">
            <div class="x_panel ">
                <div class="x_title">
                    <h2>Resultado de la búsqueda</h2>
                    <button id="btn_Ver_Show" class="btn btn-primary" style="display: inline-block;" onclick="MostrarVer()" type="button">asdasd</button>
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
                                    <th class="column-title no-link"><span class="nobr">Ver</span>
                                        <th class="column-title no-link"><span class="nobr">Editar</span>
                                            <th class="column-title no-link last"><span class="nobr">Eliminar</span>
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

    <script type="text/javascript">

        setEstiloDefault("Div_Ver");
        setEstiloDefault("Div_Consulta");

        function MostrarVer(id) {
            document.getElementById("Div_Ver").style.position = "inherit";
            document.getElementById("Div_Ver").style.visibility = "visible";
            document.getElementById("Div_Ver").style.opacity = "1";
            document.getElementById("Div_Ver").style.zIndex = "1000";
            document.getElementById("Div_Consulta").style.position = "relative";
            document.getElementById("Div_Consulta").style.visibility = "hidden";
            document.getElementById("Div_Consulta").style.opacity = "0";
            document.getElementById("Div_Consulta").style.zIndex = "0";
            
        }


        function MostrarGrilla(id) {
            document.getElementById("Div_Ver").style.position = "absolute";
            document.getElementById("Div_Ver").style.visibility = "hidden";
            document.getElementById("Div_Ver").style.opacity = "0";
            document.getElementById("Div_Ver").style.zIndex = "0";
            document.getElementById("Div_Consulta").style.position = "inherit";
            document.getElementById("Div_Consulta").style.visibility = "visible";
            document.getElementById("Div_Consulta").style.opacity = "1";
            document.getElementById("Div_Consulta").style.zIndex = "1000";
            
        }

    </script>
</asp:Content>

