<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AltaEquipoWF.aspx.cs" Inherits="SEDT.AltaEquipoWF" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="right_col" role="main">
        <div class="">
            <div class="page-title">
                <div class="title_left">
                    <h3>Alta Equipo</h3>
                </div>
            </div>
            <div class="clearfix"></div>
            <div class="row">



                <div class="col-md-12 col-sm-12 col-xs-12">
                    <div class="x_panel">
                        <div class="x_title">
                            <h2><i class="fa fa-shield"></i> Nuevo Equipo <small>Complete los campos para agregar un nuevo equipo.</small></h2>
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

                        <div class="x_content">
                            
                    <br />
                    <form runat="server" class="form-horizontal form-label-left">
                        
                            <div class="form-group">
                                <label class="control-label col-md-2 col-sm-2 col-xs-12" for="first-name">
                                    Nombre del Equipo <span class="required">*</span>
                                </label>
                                <div class="col-md-10 col-sm-10 col-xs-12">
                                    <asp:TextBox ID="txAgregar_Nombre_Equipo" type="text"  required="required" class="form-control col-md-12 col-xs-12" placeholder="" runat="server"></asp:TextBox>
                                </div>
                            </div>


                      <div class="ln_solid"></div>


                            <div class="form-group">
                                <div class="col-md-6 col-sm-6 col-xs-12">
                                    <button class="btn btn-primary" type="button">Cancelar</button>
                                    <button class="btn btn-primary" type="reset">Limpiar</button>
                                    <asp:Button type="submit" runat="server" ID="btnAgregarGeneral" class="btn btn-primary"
                                AutoPostBack="True" Text="Guardar" OnClick="btnGuardar_OnClick"></asp:Button>


                                </div>
                            </div>
                        </form>
                        </div>
                    </div>
                </div>


            </div>
        </div>
    </div>
</asp:Content>
