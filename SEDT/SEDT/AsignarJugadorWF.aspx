<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AsignarJugadorWF.aspx.cs" Inherits="SEDT.AsignarJugadorWF" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="page-title">
            <div class="title_left">
                <h3>Asignar Jugador</h3>
            </div>
        </div>

        <div class="clearfix"></div>

        <div class="col-md-12 col-sm-12 col-xs-12">
            <div class="form-horizontal form-label-left">
                <div class="x_panel">
                    <div class="x_title">
                        <h2><i class="fa fa-users"></i>Asignar Jugador <small>Arrastre el nombre del jugador para asignarlo a un equipo.</small></h2>
                        <ul class="nav navbar-right panel_toolbox">
                            <li><a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                            </li>
                            <li><a class="close-link"><i class="fa fa-close"></i></a>
                            </li>
                        </ul>
                        <div class="clearfix"></div>
                    </div>

                    <div class="x_content">
                        <div class="drag-container">
                            <ul class="drag-list row">
                                <li class="drag-column drag-column-on-hold col-md-5 col-sm-10 col-xs-12">
                                    <span class="drag-column-header">Jugadores
                                        <%--<svg class="drag-header-more" data-target="options1" fill="#FFFFFF" height="24" viewBox="0 0 24 24" width="24"><path d="M0 0h24v24H0z" fill="none"/><path d="M12 8c1.1 0 2-.9 2-2s-.9-2-2-2-2 .9-2 2 .9 2 2 2zm0 2c-1.1 0-2 .9-2 2s.9 2 2 2 2-.9 2-2-.9-2-2-2zm0 6c-1.1 0-2 .9-2 2s.9 2 2 2 2-.9 2-2-.9-2-2-2z"/</svg>--%>
                                    </span>

                                    <div class="drag-options" id="options1"></div>

                                    <ul class="drag-inner-list" id="1">
                                        <li id="jugador_1" class="drag-item">Leonel Imoli</li>
                                        <li id="jugador_2" class="drag-item">Alejandro Walsh</li>
                                        <li id="jugador_7" class="drag-item">Leonel</li>
                                        <li id="jugador_8" class="drag-item">Alejandro</li>
                                        <li id="jugador_9" class="drag-item">Leonel Imoli Leonel Imoli</li>
                                        <li id="jugador_10" class="drag-item">Alejandro Walsh Alejandro Walsh</li>
                                    </ul>
                                </li>
                                <li class="col-md-2 col-sm-12 col-xs-12" style="text-align: center;">
                                    <i class="fa fa-arrow-circle-o-right fa-5x flechaDerecha" style="margin-top: 30px;"></i>
                                    <i class="fa fa-arrow-circle-o-down fa-5x flechaAbajo" style="display: none; margin-top: 10px; margin-bottom: 10px;"></i>
                                </li>
                                <li class="drag-column drag-column-in-progress col-md-5 col-sm-10 col-xs-12">
                                    <span class="drag-column-header">Equipo
                                        <%--<svg class="drag-header-more" data-target="options2" fill="#FFFFFF" height="24" viewBox="0 0 24 24" width="24"><path d="M0 0h24v24H0z" fill="none"/><path d="M12 8c1.1 0 2-.9 2-2s-.9-2-2-2-2 .9-2 2 .9 2 2 2zm0 2c-1.1 0-2 .9-2 2s.9 2 2 2 2-.9 2-2-.9-2-2-2zm0 6c-1.1 0-2 .9-2 2s.9 2 2 2 2-.9 2-2-.9-2-2-2z"/</svg>--%>
                                    </span>
                                    <section class="slider single-item">
                                        <div>
                                            <i class="fa fa-arrow-circle-o-right fa-2x"></i>
                                        </div>
                                        <div>
                                            <i class="fa fa-arrow fa-2x"></i>
                                        </div>
                                        <div>
                                            <i class="fa fa-arrow-up fa-2x"></i>
                                        </div>
                                        <div>
                                            <i class="fa fa-arrow-down fa-2x"></i>
                                        </div>
                                        <div>
                                            <i class="fa fa-arrow-left fa-2x"></i>
                                        </div>
                                        <div>
                                            <i class="fa fa-arrow-right fa-2x"></i>
                                        </div>
                                    </section>
                                    <div class="drag-options" id="options2"></div>
                                    <ul class="drag-inner-list" id="2">
                                        <li id="jugador_3" class="drag-item">Andres Silvestri</li>
                                        <li id="jugador_4" class="drag-item">Ticky Roldan</li>
                                        <li id="jugador_5" class="drag-item">Lucas Scarpitta</li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        $(document).on('ready', function() {
            $('.single-item').slick({
                dots: false,
                infinite: true,
                slidesToShow: 6,
                slidesToScroll: 6
            });
        });
    </script>

    <!-- Drag & Drop -->

    <script src="Scripts/dragula.min.js"></script>
    <script src="Scripts/index.js"></script>

</asp:Content>
