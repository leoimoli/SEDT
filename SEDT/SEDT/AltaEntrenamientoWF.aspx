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

                        <!-- FORM WIZARD -->

                        <div class="col-md-12 col-sm-12 col-xs-12">
                            <div class="x_panel">
                                <div class="x_content">
                                    <!-- Smart Wizard -->
                                    <div id="wizard" class="form_wizard wizard_horizontal">
                                        <ul class="wizard_steps">
                                            <li>
                                                <a href="#step-1">
                                                    <span class="step_no">1</span>
                                                    <span class="step_descr">Entrenamiento<br />
                                                        <small>información de la actividad</small>
                                                    </span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#step-2">
                                                    <span class="step_no">2</span>
                                                    <span class="step_descr">Turnos<br />
                                                        <small>turnos a cumplir en el entrenamiento</small>
                                                    </span>
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#step-3">
                                                    <span class="step_no">3</span>
                                                    <span class="step_descr">Etapas<br />
                                                        <small>etapas que comforman los turnos</small>
                                                    </span>
                                                </a>
                                            </li>
                                        </ul>
                                        <div id="step-1">
                                            <h2 class="StepTitle">Entrenamiento</h2>
                                            <div class="form-horizontal form-label-left">
                                                <div class="row">
                                                    <div class="col-sm-12">
                                                        <div class="row">
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
                                                                    <label for="fname">Fecha:</label>
                                                                    <input type="text" class="form-control" id="txt_AltaEntrenamientoWF_Fecha" required>
                                                                </div>
                                                            </div>
                                                            <div class="col-sm-4">
                                                                <div class="form-group">
                                                                    <label for="fname">Cantidad de turnos:</label>
                                                                    <input type="text" class="form-control" id="txt_AltaEntrenamientoWF_CantidadTurnos"  value="1" required>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                        <div id="step-2">
                                            <h2 class="StepTitle">Turnos</h2>
                                            <div class="form-horizontal form-label-left">
                                                <div class="row">
                                                    <div class="col-sm-12">
                                                        <div id="container_AltaEntrenamientoWF_Turnos">
                                                            <div id="container_Clonar_1" class="clonedInput">
                                                                <div class="row">
                                                                    <div class="col-sm-4">
                                                                        <div class="form-group">
                                                                            <label for="fname">Horario:</label>
                                                                            <div class="input-group clockpicker Validacion">
                                                                                <input type="text" class="form-control fechaValidar" value="09:30" id="txt_AltaTurnoWF_Horario_1" required>
                                                                                <span class="input-group-addon">
                                                                                    <span class="glyphicon glyphicon-time"></span>
                                                                                </span>
                                                                            </div>
                                                                            <div id="Error_Fecha_1" class="Error_Fecha_Invisible">
                                                                                <span class="label label-danger-Validacion">Puede arrancar el turno a partir de las 14:00 o posterior.</span>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-sm-4">
                                                                        <div class="form-group">
                                                                            <label for="fname">Lugar de entrenamiento:</label>
                                                                            <select class="form-control">
                                                                                <option>Cargar lugar de DB</option>
                                                                                <option>Cargar lugar de DB</option>
                                                                            </select>
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-sm-4">
                                                                        <div class="form-group">
                                                                            <label for="fname">Cantidad de etapas:</label>
                                                                            <input type="text" class="form-control" id="txt_AltaEntrenamientoWF_CantidadEtapas_1" value="1" required>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                            </div>
                                        </div>
                                        <div id="step-3">

                                            <div id="Seccion_Turno_1">
                                                <div id="container_AltaEntrenamientoWF_Etapas">
                                                    <div id="container_Clonar_Etapas_1" class="clonedInput_Etapas">
                                                        <h2 class="StepTitle">Etapas del turno</h2>
                                                        <div id="container_Clonar_EtapaSingular_1_1" class="clonedInput_EtapaSingular">
                                                            <div class="row">
                                                                <div class="col-sm-4">
                                                                    <div class="form-group">
                                                                        <label for="fname">Tipo de Actividad:</label>
                                                                        <select class="form-control">
                                                                            <option>Cargar tipo de DB</option>
                                                                            <option>Cargar tipo de DB</option>
                                                                        </select>
                                                                    </div>
                                                                </div>
                                                                <div class="col-sm-4">
                                                                    <div class="form-group">
                                                                        <label for="lname">Material de trabajo:</label>
                                                                        <input type="text" class="form-control" id="txt_AltaEtapaWF_MaterialesDeTrabajo" required>
                                                                    </div>
                                                                </div>
                                                                <div class="col-sm-4">
                                                                    <div class="form-group">
                                                                        <label for="lname">Descripción:</label>
                                                                        <input type="text" class="form-control" id="txt_AltaEtapaWF_Descripcion" required>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- End SmartWizard Content -->
                                </div>
                            </div>
                        </div>

                        <!-- FIN FORM WIZARD -->
                        <div style="clear: both;"></div>

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
