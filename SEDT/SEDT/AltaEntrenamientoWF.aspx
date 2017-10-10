<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaEntrenamientoWF.aspx.cs" Inherits="SEDT.AltaEntrenamientoWF" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Alta Entrenamiento</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-clock-o"></i>Nuevo Entrenamiento <small>Complete los campos para agregar un nuevo entrenamiento.</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a></li>
                            <li><a class="close-link"><i class="fa fa-close"></i></a></li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>

                    <div class="x_content">
                        <div id="wizard" class="form_wizard wizard_horizontal">
                            <ul class="wizard_steps">
                                <li>
                                    <a href="#step-1">
                                        <span class="step_no">1</span>
                                        <span class="step_descr">Entrenamiento<br />
                                            <small>Creación inicial del entrenamiento</small>
                                        </span>
                                    </a>
                                </li>
                                <li>
                                    <a href="#step-2">
                                        <span class="step_no">2</span>
                                        <span class="step_descr">Turnos<br />
                                            <small>Carga de los turnos que lo conforman</small>
                                        </span>
                                    </a>
                                </li>
                                <li>
                                    <a href="#step-3">
                                        <span class="step_no">3</span>
                                        <span class="step_descr">Etapas<br />
                                            <small>Diferentes etapas para cada turno</small>
                                        </span>
                                    </a>
                                </li>
                            </ul>
                            <div id="step-1">
                                <form class="form-horizontal form-label-left">
                                    <div class="row">
                                        <div class="col-sm-12">
                                            <div class="row calendar-exibit">
                                                <div class="col-sm-4">
                                                    <div class="form-group">
                                                        <label for="fname">Equipo:</label>
                                                        <select class="form-control">
                                                            <option>Cargar equipo de DB</option>
                                                            <option>Cargar equipo de DB</option>
                                                        </select>
                                                    </div>
                                                </div>
                                                <div class="col-sm-4">
                                                    <div class="form-group">
                                                        <label for="fname">Cantidad de turnos:</label>
                                                        <input type="text" class="form-control" id="txt_AltaEntrenamientoWF_CantidadTurnoEntrenamiento" required>
                                                    </div>
                                                </div>
                                                <div class="col-sm-4">
                                                    <label for="txt_AltaEntrenamientoWF_FechaEntrenamiento">Fecha de entrenamiento:</label>
                                                    <div class="control-group">
                                                        <div class="controls">
                                                            <div class="col-md-11 xdisplay_inputx form-group has-feedback">
                                                                <input type="text" class="form-control has-feedback-left" id="txt_AltaEntrenamientoWF_FechaEntrenamiento" aria-describedby="inputSuccess2Status">
                                                                <span class="fa fa-calendar-o form-control-feedback left" aria-hidden="true"></span>
                                                                <span id="inputSuccess2Status" class="sr-only">(success)</span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </form>
                            </div>
                            <div id="step-2"></div>
                            <div id="step-3"></div>
                        </div>
                        <!-- End SmartWizard Content -->
                    </div>
                    <br />
                    <div class="form-group">
                        <div class="col-md-12 col-sm-12 col-xs-12">
                            <div class="ln_solid"></div>
                            <button id="btn_AltaEquipo_Nuevo" class="btn btn-primary" style="display: none;" onclick="AltaEntrenamiento_Nuevo()" type="button">Nuevo</button>
                            <button id="btn_AltaEquipo_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEntrenamiento_Guardar()" type="button">Guardar</button>
                            <button id="btn_AltaEquipo_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEntrenamiento_Limpiar()" type="button">Limpiar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
