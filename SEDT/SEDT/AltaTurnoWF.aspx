<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaTurnoWF.aspx.cs" Inherits="SEDT.AltaTurnoWF" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Alta Turno</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-clock-o"></i>Nuevo Turno <small>Complete los campos para agregar un nuevo turno de entrenamiento.</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a></li>
                            <li><a class="close-link"><i class="fa fa-close"></i></a></li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>

                    <div class="x_content">

                        <div id="kv-avatar-errors-2" class="center-block" style="width: 800px; display: none"></div>

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
                                            <input type="text" class="form-control" id="txt_AltaEntrenamientoWF_CantidadTurnos" required>
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
                            <button id="btn_AltaTurno_Nuevo" class="btn btn-primary" style="display: none;" onclick="AltaTurno_Nuevo()" type="button">Nuevo</button>
                            <button id="btn_AltaTurno_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaTurno_Guardar()" type="button">Guardar</button>
                            <button id="btn_AltaTurno_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaTurno_Limpiar()" type="button">Limpiar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
