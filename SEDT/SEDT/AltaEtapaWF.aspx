<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaEtapaWF.aspx.cs" Inherits="SEDT.AltaEtapaWF" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Alta Etapa</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-clock-o"></i>Nuevo Etapa <small>Complete los campos para agregar una nueva etapa de entrenamiento.</small></h2>
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
                                            <label for="fname">Turno:</label>
                                            <select class="form-control">
                                                <option>Cargar turno de DB</option>
                                                <option>Cargar turno de DB</option>
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
                                <div class="row">
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="form-group">
                        <div class="col-md-12 col-sm-12 col-xs-12">
                            <div class="ln_solid"></div>
                            <button id="btn_AltaEtapa_Nuevo" class="btn btn-primary" style="display: none;" onclick="AltaEtapa_Nuevo()" type="button">Nuevo</button>
                            <button id="btn_AltaEtapa_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEtapa_Guardar()" type="button">Guardar</button>
                            <button id="btn_AltaEtapa_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEtapa_Limpiar()" type="button">Limpiar</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
