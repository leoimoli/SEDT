<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ConsultaEstadisticaPartidoWF.aspx.cs" Inherits="SEDT.ConsultaEstadisticaPartidoWF" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Estadísica de Partido</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-line-chart"></i>Estadísticas de Partidos <small>A continuación se muestran diagramas que muestran estadísticas según un rango de fechas.</small></h2>
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
                                </div>
                                <div class="row">
                                </div>
                                <div class="row">
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

                            <button id="btn_ConsultaEstadisticaPartido_Nuevo" class="btn btn-primary" style="display: none;" onclick="ConsultaEstadisticaPartido_Nuevo()" type="button">Nuevo</button>
                            <button id="btn_ConsultaEstadisticaPartido_Imprimir" class="btn btn-primary" style="display: none;" onclick="ConsultaEstadisticaPartido_Imprimir()" type="button">Imprimir</button>
                            <button id="btn_ConsultaEstadisticaPartido_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="ConsultaEstadisticaPartido_Guardar()" type="button">Consultar</button>
                            <button id="btn_ConsultaEstadisticaPartido_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="ConsultaEstadisticaPartido_Limpiar()" type="button">Limpiar</button>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>