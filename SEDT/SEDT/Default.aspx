<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SEDT._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!-- page content -->
    <div class="right_col" role="main">
        <!-- top tiles -->
        <div class="row tile_count">
            <div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
                <span class="count_top"><i class="fa fa-shield"></i> Total Equipos</span>
                <div class="count green">3</div>
                <span class="count_bottom" style="border-top: 1px solid #ADB2B5; padding-left: 30px; padding-right: 30px;">6</span>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
                <span class="count_top"><i class="fa fa-users"></i> Total Jugadores</span>
                <div class="count green">90</div>
                <span class="count_bottom" style="border-top: 1px solid #ADB2B5; padding-left: 30px; padding-right: 30px;">180</span>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
                <span class="count_top"><i class="fa fa-trophy"></i> Total Competiciones</span>
                <div class="count green">2</div>
                <span class="count_bottom" style="border-top: 1px solid #ADB2B5; padding-left: 30px; padding-right: 30px;">Ilimitado</span>
            </div>
            <div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
                <span class="count_top"><i class="fa fa-futbol-o"></i> Total Partidos</span>
                <div class="count green">42</div>
                <span class="count_bottom" style="border-top: 1px solid #ADB2B5; padding-left: 30px; padding-right: 30px;">Ilimitado</span>
            </div>
            <%--<div class="col-md-3 col-sm-6 col-xs-6 tile_stats_count" style="text-align: center">
              <span class="count_top"><i class="fa fa-futbol-o"></i> Total Partidos</span>
              <div class="count">4,567</div>
              <span class="count_bottom"><i class="red"><i class="fa fa-sort-desc"></i>12% </i> From last Week</span>
            </div>--%>
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
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb" style="padding: 10px 14px !important;">
                                <i class="fa fa-shield aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Equipo 1</a>
                                <p><strong>Torneo: </strong>lalalalalal </p>
                                <p>
                                    <small>3° Puesto</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb" style="padding: 10px 14px !important;">
                                <i class="fa fa-shield aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Equipo 1</a>
                                <p><strong>Torneo: </strong>lalalalalal </p>
                                <p>
                                    <small>3° Puesto</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb" style="padding: 10px 14px !important;">
                                <i class="fa fa-shield aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Equipo 1</a>
                                <p><strong>Torneo: </strong>lalalalalal </p>
                                <p>
                                    <small>3° Puesto</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb" style="padding: 10px 14px !important;">
                                <i class="fa fa-shield aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Equipo 1</a>
                                <p><strong>Torneo: </strong>lalalalalal </p>
                                <p>
                                    <small>3° Puesto</small>
                                </p>
                            </div>
                        </article>
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
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb">
                                <i class="fa fa-user aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Juan Pepe</a>
                                <p><strong>Equipo: </strong>Equipo 1 </p>
                                <p>
                                    <small>Algun dato</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb">
                                <i class="fa fa-user aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Juan Pepe</a>
                                <p><strong>Equipo: </strong>Equipo 1 </p>
                                <p>
                                    <small>Algun dato</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb">
                                <i class="fa fa-user aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Juan Pepe</a>
                                <p><strong>Equipo: </strong>Equipo 1 </p>
                                <p>
                                    <small>Algun dato</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb">
                                <i class="fa fa-user aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Juan Pepe</a>
                                <p><strong>Equipo: </strong>Equipo 1 </p>
                                <p>
                                    <small>Algun dato</small>
                                </p>
                            </div>
                        </article>
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
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb" style="padding: 9px 10px !important;">
                                <i class="fa fa-futbol-o aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Equipo 1 vs. Equipo 2</a>
                                <p><strong>Torneo: </strong>lalalalalal </p>
                                <p>
                                    <small>10/10/2018</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb" style="padding: 9px 10px !important;">
                                <i class="fa fa-futbol-o aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Equipo 1 vs. Equipo 2</a>
                                <p><strong>Torneo: </strong>lalalalalal </p>
                                <p>
                                    <small>10/10/2018</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb" style="padding: 9px 10px !important;">
                                <i class="fa fa-futbol-o aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Equipo 1 vs. Equipo 2</a>
                                <p><strong>Torneo: </strong>lalalalalal </p>
                                <p>
                                    <small>10/10/2018</small>
                                </p>
                            </div>
                        </article>
                        <article class="media event">
                            <a class="pull-left border-aero profile_thumb" style="padding: 9px 10px !important;">
                                <i class="fa fa-futbol-o aero"></i>
                            </a>
                            <div class="media-body">
                                <a class="title" href="#">Equipo 1 vs. Equipo 2</a>
                                <p><strong>Torneo: </strong>lalalalalal </p>
                                <p>
                                    <small>10/10/2018</small>
                                </p>
                            </div>
                        </article>
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
