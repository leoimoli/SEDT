<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaFichaTecnicaWF.aspx.cs" Inherits="SEDT.AltaFichaTecnicaWF" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Alta Jugador</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-users"></i>Nuevo Jugador <small>Complete los campos para agregar un nuevo jugador.</small></h2>
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
                            </div>
                            <div class="col-md-8 col-sm-8 col-xs-12">
                                <div class="row grid_slider">
                                    <div id="FichaTecnica_PiernaHabil" class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Pierna Habil:</label>
                                        </div>
                                        <input name="PiernaHabil" type="text" id="range_A1" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Pierna NO Habil:</label>
                                        </div>
                                        <input type="text" id="range_A2" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Juego Aéreo:</label>
                                        </div>
                                        <input type="text" id="range_A3" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Nivel Defensivo:</label>
                                        </div>
                                        <input type="text" id="range_A4" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Nivel Ofensivo:</label>
                                        </div>
                                        <input type="text" id="range_A5" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Velocidad:</label>
                                        </div>
                                        <input type="text" id="range_A6" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Predisposición al Entrenamiento:</label>
                                        </div>
                                        <input type="text" id="range_A7" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Tecnica Individual:</label>
                                        </div>
                                        <input type="text" id="range_A8" value="" name="range" />
                                    </div>
                                </div>
                                <div class="row grid_slider">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="form-group">
                                            <label>Disciplina Táctica:</label>
                                        </div>
                                        <input type="text" id="range_A9" value="" name="range" />
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">

                                        <label>Pierna Hábil:</label>
                                        <p>
                                            D:
                        <input type="radio" class="flat" name="gender" id="piernaD" value="D" checked="" required />
                                            I:
                        <input type="radio" class="flat" name="gender" id="piernaI" value="I" />
                                        </p>
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

