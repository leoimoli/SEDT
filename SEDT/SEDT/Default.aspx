<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SEDT._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- page content -->
    <div class="right_col" role="main">
        <!-- top tiles -->
        <div class="row tile_count">
            <div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
                <span class="count_top"><i class="fa fa-shield"></i>Total Equipos</span>
                <div class="count green"><%= DatosDefault.CantidadEquipos %></div>
                <span class="count_bottom" style="border-top: 1px solid #ADB2B5; padding-left: 30px; padding-right: 30px;"><%= DatosDefault.plan.CantidadEquipos %></span>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
                <span class="count_top"><i class="fa fa-users"></i>Total Jugadores</span>
                <div class="count green"><%= DatosDefault.CantidadJugadores %></div>
                <span class="count_bottom" style="border-top: 1px solid #ADB2B5; padding-left: 30px; padding-right: 30px;"><%= DatosDefault.plan.CantidadJugadores %></span>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
                <span class="count_top"><i class="fa fa-trophy"></i>Total Competiciones</span>
                <div class="count green"><%= DatosDefault.CantidadCompetencias %></div>
                <span class="count_bottom" style="border-top: 1px solid #ADB2B5; padding-left: 30px; padding-right: 30px;">Ilimitado</span>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
                <span class="count_top"><i class="fa fa-futbol-o"></i>Total Partidos</span>
                <div class="count green"><%= DatosDefault.CantidadPartidos %></div>
                <span class="count_bottom" style="border-top: 1px solid #ADB2B5; padding-left: 30px; padding-right: 30px;">Ilimitado</span>
            </div>
        </div>
        <!-- /top tiles -->

        <div class="row">
            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="x_panel">
                    <div class="x_title">
                        <h2>Equipos <small>destacados</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li style="float: right;"><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <asp:Repeater runat="server" ID="repeaterEquipos">
                            <ItemTemplate>
                                <article class="media event">
                                    <a class="pull-left border-aero profile_thumb" style="padding: 10px 14px !important;">
                                        <img src="<%# (string)Eval("Imagen") != string.Empty ? Eval("Imagen") : "" %>" alt="Escudo de <%# Eval("NombreEquipo") %>" class="img-circle img-responsive" />
                                    </a>
                                    <div class="media-body">
                                        <p class="title"><%# Eval("NombreEquipo") %></p>
                                        <p><strong>Siglas: </strong><%# Eval("Siglas") %> </p>
                                        <p><a href="<%# Eval("SitioWeb") %>" style="text-decoration: underline">Sitio Web</a></p>
                                    </div>
                                </article>

                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="x_panel">
                    <div class="x_title">
                        <h2>Jugadores <small>destacados</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li style="float: right;"><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <asp:Repeater runat="server" ID="repeaterJugadores">
                            <ItemTemplate>
                                <article class="media event">
                                    <a class="pull-left border-aero profile_thumb">
                                        <img src="<%# (string)Eval("Imagen") != string.Empty ? Eval("Imagen") : "" %>" alt="Imagen de <%# Eval("Nombre") + " " + Eval("Apellido") %>" class="img-circle img-responsive" />
                                    </a>
                                    <div class="media-body">
                                        <p class="title"><%# Eval("Nombre") + " " + Eval("Apellido") %></p>
                                        <p><strong>Equipo: </strong><%# (string)Eval("NombreEquipo") != string.Empty ? Eval("NombreEquipo") : "No asignado" %></p>
                                        <p>
                                            <small>Posicion: <%# Eval("Posicion") %></small>
                                        </p>
                                    </div>
                                </article>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>

            <div class="col-md-4 col-sm-4 col-xs-12">
                <div class="x_panel">
                    <div class="x_title">
                        <h2>Partidos <small>próximos</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li style="float: right;"><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">
                        <asp:Repeater runat="server" ID="repeaterPartidos">
                            <ItemTemplate>
                                <article class="media event">
                                    <a class="pull-left border-aero profile_thumb" style="padding: 9px 10px !important;">
                                        <i class="fa fa-futbol-o aero"></i>
                                    </a>
                                    <div class="media-body">
                                        <p class="title"><%# Eval("EquipoPropio") %> vs. <%# Eval("EquipoRival") %></p>
                                        <p><strong>Torneo: </strong><%# Eval("NombreTorneo") %> </p>
                                        <p>
                                            <small><%# ((DateTime)Eval("FechaPartido")).ToShortDateString() %></small>
                                        </p>
                                    </div>
                                </article>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
        <%--------------------------------------------------------------------%>
<br />

        <div class="row">
            <div class="col-md-12">
                <div class="x_panel">
                    <div class="x_title">
                        <h2>Planes de pago<small>Mensuales</small></h2>
                        <div class="clearfix"></div>
                    </div>
                    <div class="x_content">

                        <div class="row" style="border-bottom: 1px solid #E0E0E0; padding-bottom: 5px; margin-bottom: 5px;">
                            <div class="col-md-3 col-sm-6 col-xs-12">
                                <div class="DivCategoria">
                                    <div style="width: 100%;">
                                        <h1 class="Categoria">Prueba</h1>
                                    </div>
                                    <div style="text-align: center; width: 100%;">
                                        <article>
                                            <ul class="quick-list">
                                                <li><a href="#">Duración de 30 días.</a></li>
                                                <li><a href="#">1 Equipos.</a></li>
                                                <li><a href="#">Máximo de 30 jugadores.</a></li>
                                            </ul>
                                        </article>
                                        <h1 class="PrecioCategoria">Gratis</h1>
                                        <button id="btn_Prueba" class="btn btn-login submit" disabled="disabled" type="button">Comprar Plan</button>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-3 col-sm-6 col-xs-12">
                                <div class="DivCategoria">
                                    <div style="width: 100%;">
                                        <h1 class="Categoria">Amateur</h1>
                                    </div>
                                    <div style="text-align: center; width: 100%;">
                                        <article>
                                            <ul class="quick-list">
                                                <li><a href="#">Duración de 1 año.</a></li>
                                                <li><a href="#">2 Equipos.</a></li>
                                                <li><a href="#">Máximo de 60 jugadores.</a></li>
                                            </ul>
                                        </article>
                                        <h1 class="PrecioCategoria">$30</h1>
                                        <button id="btn_Actualizar1" class="btn btn-login submit" type="button">Comprar Plan</button>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-3 col-sm-6 col-xs-12">
                                <div class="DivCategoria">
                                    <div style="width: 100%;">
                                        <h1 class="Categoria">Profesional</h1>
                                    </div>
                                    <div style="text-align: center; width: 100%;">
                                        <article>
                                            <ul class="quick-list">
                                                <li><a href="#">Duración de 1 año.</a></li>
                                                <li><a href="#">6 Equipos.</a></li>
                                                <li><a href="#">Máximo de 180 jugadores.</a></li>
                                            </ul>
                                        </article>
                                        <h1 class="PrecioCategoria">$50</h1>
                                        <button id="btn_Actualizar2" class="btn btn-login submit" type="button">Comprar Plan</button>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-3 col-sm-6 col-xs-12">
                                <div class="DivCategoria">
                                    <div style="width: 100%;">
                                        <h1 class="Categoria">Legendario</h1>
                                    </div>
                                    <div style="text-align: center; width: 100%;">
                                        <article>
                                            <ul class="quick-list">
                                                <li><a href="#">Duración de 1 año.</a></li>
                                                <li><a href="#">Equipos Ilimitados</a></li>
                                                <li><a href="#">jugadores ilimitados</a></li>
                                            </ul>
                                        </article>
                                        <h1 class="PrecioCategoria">$100</h1>
                                        <button id="btn_Actualizar3" class="btn btn-login submit" type="button">Comprar Plan</button>
                                    </div>
                                </div>
                            </div>
                            <%--<div class="col-md-7" style="overflow:hidden;">
                        <span class="sparkline_one" style="height: 160px; padding: 10px 25px;">
                                      <canvas width="200" height="60" style="display: inline-block; vertical-align: top; width: 94px; height: 30px;"></canvas>
                                  </span>
                        <h4 style="margin:18px">Weekly sales progress</h4>
                      </div>

                      <div class="col-md-5">
                        <div class="row" style="text-align: center;">
                          <div class="col-md-4">
                            <canvas class="canvasDoughnut" height="110" width="110" style="margin: 5px 10px 10px 0"></canvas>
                            <h4 style="margin:0">Bounce Rates</h4>
                          </div>
                          <div class="col-md-4">
                            <canvas class="canvasDoughnut" height="110" width="110" style="margin: 5px 10px 10px 0"></canvas>
                            <h4 style="margin:0">New Traffic</h4>
                          </div>
                          <div class="col-md-4">
                            <canvas class="canvasDoughnut" height="110" width="110" style="margin: 5px 10px 10px 0"></canvas>
                            <h4 style="margin:0">Device Share</h4>
                          </div>
                        </div>
                      </div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- /page content -->
</asp:Content>
