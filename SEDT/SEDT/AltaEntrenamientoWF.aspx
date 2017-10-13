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


                        <section id="employer-post-new-job">
                            <div class="row">
                                <div class="container">
                                    <div class="row">
                                        <div class="col-xs-10 col-xs-offset-1" id="container">
                                            <div class="res-steps-container">
                                                <div class="res-steps res-step-one active" data-class=".res-form-one">
                                                    <div class="res-step-bar">1</div>
                                                    <div class="res-progress-bar"></div>
                                                    <div class="res-progress-title">Add Title & Description 1</div>
                                                </div>
                                                <div class="res-steps res-step-two" data-class=".res-form-two">
                                                    <div class="res-step-bar">2</div>
                                                    <div class="res-progress-bar"></div>
                                                    <div class="res-progress-title">Add Title & Description 2</div>
                                                </div>
                                                <div class="res-steps res-step-three" data-class=".res-form-three">
                                                    <div class="res-step-bar">3</div>
                                                    <div class="res-progress-bar"></div>
                                                    <div class="res-progress-title">Add Title & Description 3</div>
                                                </div>
                                                <div class="res-steps res-step-four" data-class=".res-form-four">
                                                    <div class="res-step-bar">4</div>
                                                    <div class="res-progress-bar"></div>
                                                    <div class="res-progress-title">Add Title & Description 4</div>
                                                </div>
                                            </div>
                                            <div class="clearfix">&nbsp;</div>
                                            <div class="clearfix">&nbsp;</div>

                                            <div class="res-step-form col-md-8 col-md-offset-2 res-form-one">
                                                <h3 class="text-center">Add Title &amp; Description 1</h3>
                                                <div class="form-horizontal">
                                                    <div class="form-group">
                                                        <label for="choose-title" class="col-sm-3 control-label">Choose Title</label>
                                                        <div class="col-sm-8">
                                                            <input type="text" class="form-control" id="choose-title" placeholder="Choose Title">
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="inputPassword3" class="col-sm-3 control-label">Description</label>
                                                        <div class="col-sm-8">
                                                            <textarea class="form-control" rows="3" placeholder="Add Description"></textarea>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="text-center">
                                                            <button type="button" class="btn btn-default col-xs-offset-1 btn res-btn-orange" data-class=".res-form-one">Next</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="res-step-form col-md-8 col-md-offset-2 res-form-two">
                                                <h3 class="text-center">Add Title &amp; Description 2</h3>
                                                <div class="form-horizontal">
                                                    <div class="form-group">
                                                        <label for="choose-title" class="col-sm-3 control-label">Choose Title</label>
                                                        <div class="col-sm-8">
                                                            <input type="text" class="form-control" id="choose-title" placeholder="Choose Title">
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="inputPassword3" class="col-sm-3 control-label">Description</label>
                                                        <div class="col-sm-8">
                                                            <textarea class="form-control" rows="3" placeholder="Add Description"></textarea>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="text-center">
                                                            <button type="button" class="btn btn-default btn res-btn-gray" data-class=".res-form-two">Back</button>
                                                            <button type="button" class="btn btn-default col-xs-offset-1 btn res-btn-orange" data-class=".res-form-two">Next</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="res-step-form col-md-8 col-md-offset-2 res-form-three">
                                                <h3 class="text-center">Add Title &amp; Description 3</h3>
                                                <div class="form-horizontal">
                                                    <div class="form-group">
                                                        <label for="choose-title" class="col-sm-3 control-label">Choose Title</label>
                                                        <div class="col-sm-8">
                                                            <input type="text" class="form-control" id="choose-title" placeholder="Choose Title">
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="inputPassword3" class="col-sm-3 control-label">Description</label>
                                                        <div class="col-sm-8">
                                                            <textarea class="form-control" rows="3" placeholder="Add Description"></textarea>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="text-center">
                                                            <button type="button" class="btn btn-default btn res-btn-gray" data-class=".res-form-three">Back</button>
                                                            <button type="button" class="btn btn-default col-xs-offset-1 btn res-btn-orange" data-class=".res-form-three">Next</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="res-step-form col-md-8 col-md-offset-2 res-form-four">
                                                <h3 class="text-center">Add Title &amp; Description 4</h3>
                                                <div class="form-horizontal">
                                                    <div class="form-group">
                                                        <label for="choose-title" class="col-sm-3 control-label">Choose Title</label>
                                                        <div class="col-sm-8">
                                                            <input type="text" class="form-control" id="choose-title" placeholder="Choose Title">
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="inputPassword3" class="col-sm-3 control-label">Description</label>
                                                        <div class="col-sm-8">
                                                            <textarea class="form-control" rows="3" placeholder="Add Description"></textarea>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <div class="text-center">
                                                            <button type="button" class="btn btn-default btn res-btn-gray" data-class=".res-form-four">Back</button>
                                                            <button type="button" class="btn btn-default col-xs-offset-1 btn res-btn-orange" data-class=".res-form-four">Preview</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </section>

                        <!-- FIN FORM WIZARD -->
                        <div style="clear:both;"></div>
                        <br />
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
