<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaEstadisticaPartidoWF.aspx.cs" Inherits="SEDT.AltaEstadisticaPartidoWF" %>

<%--<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaTorneoWF.aspx.cs" Inherits="SEDT.AltaTorneoWF" %>--%>

<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Alta Partido</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-users"></i>Alta nuevo Partido <small>Complete los campos para agregar un nuevo jugador.</small></h2>
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
                            <div class="col-sm-9">
                                <%--      1--%>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <div runat="server" id="cmb_ComboEquipo" class="form-group">
                                            </div>
                                            <asp:Image ID="Image_miEquipo" runat="server" />
                                        </div>
                                    </div>
                                </div>
                                <%--2--%>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <div runat="server" id="cmb_Torneo" class="form-group">
                                            </div>
                                            <div runat="server" id="cmb_ComboEquipoRival" class="form-group">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <%--3 Fecha--%>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <label for="txt_AltaEstadisticaPartidoWF_FechaPartido">Fecha del partido:<span class="kv-reqd"> (*)</span></label>
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
                                </div>
                                <%--Condición--%>
                                <div class="row">
                                    <div class="col-sm-6">
                                        <div class="form-group">
                                            <div runat="server" id="cmb_ComboCondicion" class="form-group">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <%--Resultado--%>
                                <div class="row">
                                    <div class="col-sm-1.5">
                                        <div class="form-group">
                                            <label for="txt_AltaEstadisticaPartidoWF_MarcadorLocal">Resultado:<span class="kv-reqd"> (*)</span></label>
                                            <div class="row">
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_MarcadorLocal" style="width: 100px" value="Local">
                                                    </div>
                                                </div>
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_MarcadorVisitante" style="width: 100px" value="Visitante">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <%--Corners y faltas--%>
                                <div class="row">
                                    <div class="col-sm-1.5">
                                        <div class="form-group">
                                            <label for="txt_AltaEstadisticaPartidoWF_CornerPropio">Tiro de Esquina:</label>
                                            <label for="txt_AltaEstadisticaPartidoWF_CornerPropio" style="width: 200px;"></label>
                                            <label for="txt_AltaEstadisticaPartidoWF_MarcadorLocal">Faltas:</label>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-1">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_CornerPropio" style="width: 100px" value="Favor">
                                            </div>
                                        </div>
                                        <div class="col-sm-2">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_CornerRival" style="width: 100px" value="En contra">
                                            </div>
                                        </div>
                                        <div>
                                            <div class="row">
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_FaltasRecibidas" style="width: 100px" value="Favor">
                                                    </div>
                                                </div>
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_FaltasCometidas" style="width: 100px" value="En contra">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <%--Penales y offside--%>
                                <div class="row">
                                    <div class="col-sm-1.5">
                                        <div class="form-group">
                                            <label for="txt_AltaEstadisticaPartidoWF_CornerPropio">Penales:</label>
                                            <label for="txt_AltaEstadisticaPartidoWF_CornerPropio" style="width: 250px;"></label>
                                            <label for="txt_AltaEstadisticaPartidoWF_MarcadorLocal">Offside:</label>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-1">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_PenalesRecibidos" style="width: 100px" value="Favor">
                                            </div>
                                        </div>
                                        <div class="col-sm-2">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_PenalesCometidos" style="width: 100px" value="En contra">
                                            </div>
                                        </div>
                                        <div>
                                            <div class="row">
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_OffsidePropio" style="width: 100px" value="Favor">
                                                    </div>
                                                </div>
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_OffsideRival" style="width: 100px" value="En contra">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <%--Remates y Tiros--%>
                                <div class="row">
                                    <div class="col-sm-1.5">
                                        <div class="form-group">
                                            <label for="txt_AltaEstadisticaPartidoWF_CornerPropio">Remates:</label>
                                            <label for="txt_AltaEstadisticaPartidoWF_CornerPropio" style="width: 250px;"></label>
                                            <label for="txt_AltaEstadisticaPartidoWF_MarcadorLocal">Tiros al arco:</label>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-1">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_RematesPropios" style="width: 100px" value="Favor">
                                            </div>
                                        </div>
                                        <div class="col-sm-2">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_RematesRecibidos" style="width: 100px" value="En contra">
                                            </div>
                                        </div>
                                        <div>
                                            <div class="row">
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_TirosPropios" style="width: 100px" value="Favor">
                                                    </div>
                                                </div>
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_TirosRecibidos" style="width: 100px" value="En Contra">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <%--Pases y posesion--%>
                                <div class="row">
                                    <div class="col-sm-1.5">
                                        <div class="form-group">
                                            <label for="txt_AltaEstadisticaPartidoWF_CornerPropio">Pases:</label>
                                            <label for="txt_AltaEstadisticaPartidoWF_CornerPropio" style="width: 250px;"></label>
                                            <label for="txt_AltaEstadisticaPartidoWF_MarcadorLocal">Posesión:</label>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-1">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_PasesPropios" style="width: 100px" value="Favor">
                                            </div>
                                        </div>
                                        <div class="col-sm-2">
                                            <div class="form-group">
                                                <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_PasesRivales" style="width: 100px" value="En contra">
                                            </div>
                                        </div>
                                        <div>
                                            <div class="row">
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_PosesionPropia" style="width: 100px" value="Favor">
                                                    </div>
                                                </div>
                                                <div class="col-sm-1">
                                                    <div class="form-group">
                                                        <input type="text" class="form-control" id="txt_AltaEstadisticaPartidoWF_PosesionRival" style="width: 100px" value="En Contra">
                                                    </div>
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

                                    <button id="btn_AltaEstadisticaPartido_Nuevo" class="btn btn-primary" style="display: none;" onclick="AltaEstadisticaPartido_Nuevo()" type="button">Nuevo</button>
                                    <button id="btn_AltaEstadisticaPartido_Siguiente" class="btn btn-success" style="display: none;" onclick="AltaEstadisticaPartido_Siguiente()" type="button">Estadistica Jugador</button>
                                    <button id="btn_AltaEstadisticaPartido_Guardar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEstadisticaPartido_Guardar()" type="button">Guardar</button>
                                    <button id="btn_AltaEstadisticaPartido_Limpiar" class="btn btn-primary" style="display: inline-block;" onclick="AltaEstadisticaPartido_Limpiar()" type="button">Limpiar</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
