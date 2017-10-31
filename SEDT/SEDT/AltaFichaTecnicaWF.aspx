<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaFichaTecnicaWF.aspx.cs" Inherits="SEDT.AltaFichaTecnicaWF" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Alta Ficha Técnica</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-users"></i>Nueva Ficha Técnica <small>Complete los campos para agregar un nuevo jugador.</small></h2>
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
                            <div class="col-md-4 col-sm-4 col-xs-12 profile_details">
                                <div class="well profile_view" style="margin-bottom: 0px !important;">

                                    <div class="col-xs-12 bottom text-center">
                                        <div class="col-xs-12 col-sm-6 emphasis">
                                            <h2>Nicole Pearson</h2>
                                        </div>

                                    </div>
                                    <div class="col-sm-12">
                                        <div class="left col-xs-7">
                                            <div class="row">
                                                <div class="col-xs-2 col-sm-2">
                                                    <i class="fa fa-bolt"></i>
                                                </div>
                                                <div class="col-xs-10 col-sm-10">
                                                    <p><strong>Apodo: </strong></p>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-xs-2 col-sm-2">
                                                    <i class="fa fa-credit-card"></i>
                                                </div>
                                                <div class="col-xs-10 col-sm-10">
                                                    <p><strong>DNI: </strong></p>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-xs-2 col-sm-2">
                                                    <i class="fa fa-arrows-h"></i>
                                                </div>
                                                <div class="col-xs-10 col-sm-10">
                                                    <p><strong>Altura: </strong></p>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-xs-2 col-sm-2">
                                                    <i class="fa fa-arrows-v"></i>
                                                </div>
                                                <div class="col-xs-10 col-sm-10">
                                                    <p><strong>Peso: </strong></p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="right col-xs-5 text-center">
                                            <img src="Template/production/images/user.png" alt="" class="img-circle img-responsive">
                                        </div>
                                    </div>
                                </div>
                                <%-- Canchita--%>
                                <div class="row" style="background-image: url(Template/src/img/field.png); margin-left: 0px !important; margin-right: 0px !important; border-right: 1px solid #e3e3e3;">
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox" style="visibility: hidden; height: 12px !important; min-height: 15px !important;">
                                                <label>
                                                    <input id="campo-1" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="LI" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="mi" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="ei" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="DCI" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="mci" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="AR" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="mp" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="cd" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="DCD" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="mcd" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="LD" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="md" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox">
                                                <label>
                                                    <input id="ed" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkbox" style="visibility: hidden;">
                                                <label>
                                                    <input id="campo-14" type="checkbox" class="flat">
                                                </label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-9 col-sm-9 col-xs-12">
                                    <label>Pierna Habil:</label>
                                    <p>
                                        Derecha:
                        <input type="radio" class="flat" name="gender" id="piernaD" value="D" checked="" required />
                                        &nbsp;&nbsp;&nbsp;&nbsp; Izquierda:
                        <input type="radio" class="flat" name="gender" id="piernaI" value="I" />
                                    </p>
                                </div>

                                <div class="row grid_slider">
                                    <div class="col-md-10 col-sm-10 col-xs-12">
                                        <div class="form-group">
                                            <label>Altura:</label>
                                        </div>
                                        <input type="text" id="range_A16" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-10 col-sm-10 col-xs-12">
                                        <div class="form-group">
                                            <label>peso:</label>
                                        </div>
                                        <input type="text" id="range_A17" value="" name="range" />
                                    </div>
                                </div>

                            </div>
                            <%--Atributos--%>
                            <div class="col-md-8 col-sm-8 col-xs-12">
                                <h2><i class="fa fa-users"></i>&nbsp;&nbsp;Atributos Físicos <small></small></h2>
                            </div>
                            <div class="col-md-8 col-sm-8 col-xs-12">
                                <%--Atributos Fisicos--%>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Velocidad:</label>
                                        </div>
                                        <input name="PiernaHabil" type="text" id="range_A1" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Resistencia:</label>
                                        </div>
                                        <input type="text" id="range_A2" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Salto:</label>
                                        </div>
                                        <input type="text" id="range_A3" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Fuerza:</label>
                                        </div>
                                        <input type="text" id="range_A4" value="" name="range" />
                                    </div>
                                </div>
                                <div class="col-md-8 col-sm-8 col-xs-12">
                                    <h2><i class="fa fa-futbol-o"></i>&nbsp;&nbsp;Atributos Técnicos <small></small></h2>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Control:</label>
                                        </div>
                                        <input type="text" id="range_A5" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Regates:</label>
                                        </div>
                                        <input type="text" id="range_A6" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Pase Corto:</label>
                                        </div>
                                        <input type="text" id="range_A7" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Pase Largo:</label>
                                        </div>
                                        <input type="text" id="range_A8" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Definición:</label>
                                        </div>
                                        <input type="text" id="range_A9" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Remates:</label>
                                        </div>
                                        <input type="text" id="range_A10" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Lanzamiento pelota parada:</label>
                                        </div>
                                        <input type="text" id="range_A14" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Marcaje:</label>
                                        </div>
                                        <input type="text" id="range_A15" value="" name="range" />
                                    </div>
                                </div>
                                <div class="col-md-8 col-sm-8 col-xs-12">
                                    <h2><i class="fa fa-users"></i>&nbsp;&nbsp;Atributos Tácticos <small></small></h2>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Disciplina Táctica:</label>
                                        </div>
                                        <input type="text" id="range_A11" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Nivel Defensivo:</label>
                                        </div>
                                        <input type="text" id="range_A12" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Nivel Ofensivo:</label>
                                        </div>
                                        <input type="text" id="range_A13" value="" name="range" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <div class="col-md-12 col-sm-12 col-xs-12">
                                <div class="ln_solid"></div>

                                <button id="btn_AltaFichaJugador_Nuevo" class="btn btn-primary" style="display: none;" onclick="AltaFichaTecnica_Nuevo()" type="button">Nuevo</button>
                                <button id="btn_AltaFichaJugador_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaFichaTecnica_Guardar()" type="button">Guardar</button>
                                <button id="btn_AltaFichaJugador_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaFichaTecnica_Limpiar()" type="button">Limpiar</button>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

