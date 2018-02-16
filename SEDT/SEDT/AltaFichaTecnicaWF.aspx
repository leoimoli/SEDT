﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaFichaTecnicaWF.aspx.cs" Inherits="SEDT.AltaFichaTecnicaWF" %>

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

                            <div class="col-md-4 col-sm-4 col-xs-12 profile_details canchita">
                                <div class="well profile_view" style="margin-bottom: 0px !important;">

                                    <div class="col-xs-12 bottom text-center">
                                        <div class="col-xs-12 col-sm-6 emphasis">
                                            <asp:Label ForeColor="#009933" runat="server" ID="ApeNom_label"></asp:Label>
                                        </div>

                                    </div>
                                    <div class="col-sm-12">
                                        <div class="left col-xs-7">
                                            <div class="row">
                                                <div class="col-xs-2 col-sm-2">
                                                    <i class="fa fa-bolt"></i>
                                                </div>
                                                <div class="col-xs-10 col-sm-10">
                                                    <p>
                                                        <strong>Apodo:
                                                        <asp:Label ForeColor="#009933" runat="server" ID="Apodo_label"></asp:Label>
                                                        </strong>
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-xs-2 col-sm-2">
                                                    <i class="fa fa-credit-card"></i>
                                                </div>
                                                <div class="col-xs-10 col-sm-10">
                                                    <p>
                                                        <strong>DNI:
                                                        <asp:Label ForeColor="#009933" runat="server" ID="DNI_label"></asp:Label>
                                                        </strong>
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-xs-2 col-sm-2">
                                                    <i class="fa fa-arrows-h"></i>
                                                </div>
                                                <div class="col-xs-10 col-sm-10">
                                                    <p>
                                                        <strong>Altura:
                                                        <asp:Label ForeColor="#009933" runat="server" ID="Telefono_label"></asp:Label>
                                                        </strong>
                                                    </p>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-xs-2 col-sm-2">
                                                    <i class="fa fa-arrows-v"></i>
                                                </div>
                                                <div class="col-xs-10 col-sm-10">
                                                    <p>
                                                        <strong>Peso:
                                                        <asp:Label ForeColor="Blue" runat="server" ID="Peso_label"></asp:Label>
                                                        </strong>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="right col-xs-5 text-center">
                                            <img src="Template/production/images/user.png" alt="" class="img-circle img-responsive">
                                        </div>
                                    </div>
                                </div>
                                <div class="row rowCanchita" style="background-image: url(Template/src/img/field2.png); margin-left: 0px !important; margin-right: 0px !important;">
                                    <div class="row rowFicticia">
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

                                            <div class="checkLI">
                                                <input type="checkbox" id="ch_LI" class="checkLI-input" />
                                                <label for="ch_LI"></label>
                                            </div>

                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkMI">
                                                <input type="checkbox" id="ch_MI" class="checkMI-input" />
                                                <label for="ch_MI"></label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">

                                            <div class="checkEI">
                                                <input type="checkbox" id="ch_EI" class="checkEI-input" />
                                                <label for="ch_EI"></label>
                                            </div>

                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkDCI">
                                                <input type="checkbox" id="ch_DCI" class="checkDCI-input" />
                                                <label for="ch_DCI"></label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkMCI">
                                                <input type="checkbox" id="ch_MCI" class="checkMCI-input" />
                                                <label for="ch_MCI"></label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkAR">
                                                <input type="checkbox" id="ch_AR" class="checkAR-input" />
                                                <label for="ch_AR"></label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkMP">
                                                <input type="checkbox" id="ch_MP" class="checkMP-input" />
                                                <label for="ch_MP"></label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkCD">
                                                <input type="checkbox" id="ch_CD" class="checkCD-input" />
                                                <label for="ch_CD"></label>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkDCD">
                                                <input type="checkbox" id="ch_DCD" class="checkDCD-input" />
                                                <label for="ch_DCD"></label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkMCD">
                                                <input type="checkbox" id="ch_MCD" class="checkMCD-input" />
                                                <label for="ch_MCD"></label>
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
                                            <div class="checkLD">
                                                <input type="checkbox" id="ch_LD" class="checkLD-input" />
                                                <label for="ch_LD"></label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkMD">
                                                <input type="checkbox" id="ch_MD" class="checkMD-input" />
                                                <label for="ch_MD"></label>
                                            </div>
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                        </div>
                                        <div class="col-md-2 col-sm-2 col-xs-2 text-left">
                                            <div class="checkED">
                                                <input type="checkbox" id="ch_ED" class="checkED-input" />
                                                <label for="ch_ED"></label>
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
                                    <div id="FichaTecnica_Altura" class="col-md-10 col-sm-10 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Altura:</label>
                                        </div>
                                        <input type="text" id="range_A16" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_Peso" class="col-md-10 col-sm-10 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">peso:</label>
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
                                    <div id="FichaTecnica_Velocidad" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Velocidad:</label>
                                        </div>
                                        <input name="PiernaHabil" type="text" id="range_A1" value="" name="range" />
                                    </div>
                                    <div id="FichaTecnica_Resistencia" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Resistencia:</label>
                                        </div>
                                        <input type="text" id="range_A2" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_Salto" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Salto:</label>
                                        </div>
                                        <input type="text" id="range_A3" value="" name="range" />
                                    </div>
                                    <div id="FichaTecnica_Fuerza" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Fuerza:</label>
                                        </div>
                                        <input type="text" id="range_A4" value="" name="range" />
                                    </div>
                                </div>
                                <div class="col-md-8 col-sm-8 col-xs-12">
                                    <h2><i class="fa fa-futbol-o"></i>&nbsp;&nbsp;Atributos Técnicos <small></small></h2>
                                </div>
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_ControlDeBalon" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Control:</label>
                                        </div>
                                        <input type="text" id="range_A5" value="" name="range" />
                                    </div>
                                    <div id="FichaTecnica_Regates" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Regates:</label>
                                        </div>
                                        <input type="text" id="range_A6" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_PaseCorto" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Pase Corto:</label>
                                        </div>
                                        <input type="text" id="range_A7" value="" name="range" />
                                    </div>
                                    <div id="FichaTecnica_PaseLargo" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Pase Largo:</label>
                                        </div>
                                        <input type="text" id="range_A8" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_Definicion" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Definición:</label>
                                        </div>
                                        <input type="text" id="range_A9" value="" name="range" />
                                    </div>
                                    <div id="FichaTecnica_Remate" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Remates:</label>
                                        </div>
                                        <input type="text" id="range_A10" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_Lanzamientopelotaparada" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Lanzamiento pelota parada:</label>
                                        </div>
                                        <input type="text" id="range_A14" value="" name="range" />
                                    </div>
                                    <div id="FichaTecnica_Marcaje" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Marcaje:</label>
                                        </div>
                                        <input type="text" id="range_A15" value="" name="range" />
                                    </div>
                                </div>
                                <div class="col-md-8 col-sm-8 col-xs-12">
                                    <h2><i class="fa fa-users"></i>&nbsp;&nbsp;Atributos Tácticos <small></small></h2>
                                </div>
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_DisciplinaTactica" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Disciplina Táctica:</label>
                                        </div>
                                        <input type="text" id="range_A11" value="" name="range" />
                                    </div>
                                    <div id="FichaTecnica_NivelDefensivo" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Nivel Defensivo:</label>
                                        </div>
                                        <input type="text" id="range_A12" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_NivelOfensivo" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group rowTitulitos">
                                            <label class="titulitos">Nivel Ofensivo:</label>
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

