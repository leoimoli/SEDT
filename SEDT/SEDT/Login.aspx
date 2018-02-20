<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SEDT.Login" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <!-- Meta, title, CSS, favicons, etc. -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Gentelella Alela! | </title>

    <!-- Bootstrap -->
    <link href="Template/vendors/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="Template/vendors/font-awesome/css/font-awesome.min.css" rel="stylesheet">
    <!-- NProgress -->
    <link href="Template/vendors/nprogress/nprogress.css" rel="stylesheet">
    <!-- Animate.css -->
    <link href="Template/vendors/animate.css/animate.min.css" rel="stylesheet">

    <!-- Custom Theme Style -->
    <link href="Template/build/css/custom.css" rel="stylesheet">
    
    <link href="Content/Login.css" rel="stylesheet" />
</head>

<body class="login">
<div id="particles-js" style="width: 100%; height: 100%; position: fixed;"></div> 
    <div>
        <a class="hiddenanchor" id="signup"></a>
        <a class="hiddenanchor" id="signin"></a>

        <div class="login_wrapper">
            <div class="animate form login_form">
                <section class="login_content">
                    <form>
                        <h1>Login</h1>
                        <div class="PisoForm" style="margin-top: -25px !important;">
                            <input id="txt_Login_Usuario" type="text" class="effect-3" placeholder="Usuario" required="" />
                            <span class="focus-border"></span>
                        </div>
                        <div class="PisoForm">
                            <input id="txt_Login_Contraseña" type="password" class="effect-3" placeholder="Contraseña" required="" />
                            <span class="focus-border"></span>
                        </div>
                        <div style="margin-top: 25px !important;">
                            <!-- <a onclick="Login_Usuario()" class="btn btn-default submit">Ingresar</a>-->
                            <button id="btn_LoginUsuario_Nuevo" class="btn btn-default submit" onclick="Login_Usuario()" type="button">Ingresar</button>
                            <a class="reset_pass" href="#">Olvido su contraseña?</a>
                        </div>

                        <div class="clearfix"></div>

                        <div class="separator">
                            <p class="change_link">
                                Desea crear una nueva cuenta?
                  <a href="#signup" class="to_register">Registrarse </a>
                            </p>

                            <div class="clearfix"></div>
                            <br />

                            <div>
                                <h1><i class="fa fa-paw"></i>LeAnLe</h1>
                                <p>Cualquier inconveniente llame al ticky(11)30611882</p>
                            </div>
                        </div>
                    </form>
                </section>
            </div>

            <div id="register" class="animate form registration_form">
                <section class="login_content">
                    <form>
                        <h1>Crear Cuenta</h1>
                        <div class="PisoForm">
                            <input id="txt_Login_Dni" type="text" class="effect-3" placeholder="Dni" required="" />
                            <span class="focus-border"></span>
                        </div>
                        <div class="PisoForm">
                            <input id="txt_Login_Apellido" type="text" class="effect-3" placeholder="Apellido" required="" />
                            <span class="focus-border"></span>
                        </div>
                        <div class="PisoForm">
                            <input id="txt_Login_Nombre" type="text" class="effect-3" placeholder="Nombre" required="" />
                            <span class="focus-border"></span>
                        </div>
                        <%-- <div>
                            <input type="email" class="form-control" placeholder="Teléfono" required="" />
                        </div>--%>
                        <div class="PisoForm">
                            <input id="txt_Login_Email" type="email" class="effect-3" placeholder="Email" required="" />
                            <span class="focus-border"></span>
                        </div>
                        <div class="PisoForm">
                            <input id="txt_Login_ContraseñaGuardar" type="text" class="effect-3" placeholder="Contraseña" required="" />
                            <span class="focus-border"></span>
                        </div>
                        <div class="PisoForm">
                            <input id="txt_Login_RepitaContraseña" type="text" class="effect-3" placeholder="Repita Contraseña" required="" />
                            <span class="focus-border"></span>
                        </div>
                        <div style="margin-top: 25px;">
                            <%-- <a class="btn btn-default submit" onclick="Guardar_Usuario()">Registrar</a>--%>
                            <button id="btn_Usuario_Nuevo" class="btn btn-default submit" onclick="Guardar_Usuario()" type="button">Registrarse</button>
                        </div>
                        <div class="clearfix"></div>
                        <div class="separator">
                            <p class="change_link">
                                Ya sos usuario?
                  <a href="#signin" class="to_register">Iniciar sesión</a>
                            </p>

                            <div class="clearfix"></div>
                            <br />

                            <div>
                                <h1><i class="fa fa-paw"></i>LeAnLe</h1>
                                <p>Cualquier inconveniente llame al ticky(11)30611882</p>
                            </div>
                        </div>
                    </form>
                </section>
            </div>
        </div>
    </div>
    <script src="Scripts/funciones.js"></script>
    <script src="Template/vendors/jquery/dist/jquery.min.js"></script>
    <script src="Scripts/particles.js"></script>
    <script src="Scripts/particulas.js"></script>
</body>
</html>
