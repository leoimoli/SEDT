<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaEntrenamientoWF.aspx.cs" Inherits="SEDT.AltaEntrenamientoWF" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

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
                        <div id="entrenamiento_pasos" style="display: block !important;">
                            <div class="col-md-12 col-sm-12 col-xs-12">
                                <div class="x_panel">
                                    <div class="x_content">
                                        <!-- Smart Wizard -->
                                        <div id="wizard" class="form_wizard wizard_horizontal">
                                            <ul class="wizard_steps">
                                                <li>
                                                    <a id="paso-1" href="#step-1">
                                                        <span class="step_no">1</span>
                                                        <span class="step_descr">Entrenamiento<br />
                                                            <small>información de la actividad</small>
                                                        </span>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a id="paso-2" href="#step-2">
                                                        <span class="step_no">2</span>
                                                        <span class="step_descr">Turnos<br />
                                                            <small>turnos a cumplir en el entrenamiento</small>
                                                        </span>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a id="paso-3" href="#step-3">
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
                                                                    <div runat="server" id="AltaEntrenamiento_ComboEquipo" class="form-group">
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
                                                                        <input type="text" class="form-control" id="txt_AltaEntrenamientoWF_CantidadTurnos" value="1" required>
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
                                                                                <div class="input-group clockpicker">
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
                                                                            <div id="AltaEntrenamiento_ComboLugar" runat="server" class="form-group">

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
                                                            <h2 class="StepTitle">Etapas del turno que arranca 09:00:</h2>
                                                            <div id="container_Clonar_EtapaSingular_1_1" class="clonedInput_EtapaSingular">
                                                                <div class="row">
                                                                    <div class="col-sm-4">
                                                                        <div runat="server" id="AltaEntrenamiento_ComboActividad" class="form-group">
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-sm-8">
                                                                        <div class="form-group">
                                                                            <label for="lname">Descripción:</label>
                                                                            <input id="txt_AltaEtapaWF_Descripcion_1_1" type="text" class="form-control" required>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                                <div class="row">
                                                                    <div class="col-sm-12">
                                                                        <div class="form-group">
                                                                            <label for="lname">Material de trabajo:</label><br />
                                                                            <input id="txt_AltaEtapaWF_MaterialesDeTrabajo_1_1" type="text" class="form-control" value="pelos, pecheras" data-role="tagsinput" />
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
                                    <!-- End SmartWizard Content -->
                                </div>
                            </div>
                        </div>
                        <div id="entrenamiento_resultado" style="display: none !important;">
                            <!-- bar charts group -->
                            <div class="col-md-6 col-sm-6 col-xs-12">
                                <div class="x_panel">
                                    <div class="x_title">
                                        <h2>Gráfica del entrenamiento <small>detalle gráfico de la actividad</small></h2>
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
                                    <div class="x_content2">
                                        <div id="pruebas" style="width: 100%; height: 100%;"></div>
                                    </div>
                                </div>
                            </div>
                            <!-- /bar charts group -->

                            <!-- info description group -->
                            <div class="col-md-6 col-sm-6 col-xs-12">
                                <div class="x_panel">
                                    <div class="x_title">
                                        <h2>Descripción del entrenamiento</h2>
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
                                            <li><a class="close-link"><i class="fa fa-close"></i></a></li>
                                        </ul>
                                        <div class="clearfix"></div>
                                    </div>
                                    <div class="x_content">
                                        <ul class="list-unstyled timeline">
                                            <li id="Descripcion_Turno_1">
                                                <div id="Descripcion_Turno_Clonar">
                                                    <div class="block">
                                                        <div class="tags">
                                                            <!-- <a href="" class="tag"><span>09:30</span></a> -->
                                                        </div>
                                                        <div class="block_content">
                                                            <!-- <h2 class="title">
                                                            <a>ETAPA 1</a>
                                                        </h2> <br />
                                                        <p class="excerpt">
                                                            <span><b>Tipo de actividad:</b> asd asdasd asdasd</span><br />
                                                            <span><b>Descripción:</b> asdasdaasdas asdsdasd</span><br />
                                                            <span><b>Materiales:</b> asdasdasd asd asda sdasdas</span>
                                                        </p> -->
                                                        </div>
                                                    </div>
                                                </div>
                                            </li>
                                        </ul>

                                    </div>
                                </div>
                            </div>
                            <!-- /info description group -->
                        </div>
                    </div>

                    <!-- FIN FORM WIZARD -->
                    <div style="clear: both;"></div>

                    <div class="form-group">
                        <div class="col-md-12 col-sm-12 col-xs-12">
                            <div class="ln_solid"></div>
                            <button id="btn_AltaEntrenamiento_Nuevo" class="btn btn-primary" style="display: none;" onclick="AltaEntrenamiento_Nuevo()" type="button">Nuevo</button>
                            <button id="btn_AltaEntrenamiento_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEntrenamiento_Guardar()" type="button">Guardar</button>
                            <button id="btn_AltaEntrenamiento_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEntrenamiento_Limpiar()" type="button">Limpiar</button>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
