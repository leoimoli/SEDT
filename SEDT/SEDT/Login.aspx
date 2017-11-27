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
</head>

<body class="login">
    <div>
        <a class="hiddenanchor" id="signup"></a>
        <a class="hiddenanchor" id="signin"></a>

        <div class="login_wrapper">
            <div class="animate form login_form">
                <section class="login_content">
                    <form>
                        <h1>Autenticación de Usuario</h1>
                        <div>
                            <input id="txt_Login_Usuario" type="text" class="form-control" placeholder="Usuario" required="" />
                        </div>
                        <div>
                            <input id="txt_Login_Contraseña" type="password" class="form-control" placeholder="Contraseña" required="" />
                        </div>
                        <div>
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
                        <div>
                            <input id="txt_Login_Dni" type="text" class="form-control" placeholder="Dni" required="" />
                        </div>
                        <div>
                            <input id="txt_Login_Apellido" type="text" class="form-control" placeholder="Apellido" required="" />
                        </div>
                        <div>
                            <input id="txt_Login_Nombre" type="text" class="form-control" placeholder="Nombre" required="" />
                        </div>
                        <%-- <div>
                            <input type="email" class="form-control" placeholder="Teléfono" required="" />
                        </div>--%>
                        <div>
                            <input id="txt_Login_Email" type="email" class="form-control" placeholder="Email" required="" />
                        </div>
                        <div>
                            <input id="txt_Login_ContraseñaGuardar" type="password" class="form-control" placeholder="Contraseña" required="" />
                        </div>
                        <div>
                            <input id="txt_Login_RepitaContraseña" type="password" class="form-control" placeholder="Repita Contraseña" required="" />
                        </div>
                        <div>
                            <%-- <a class="btn btn-default submit" onclick="Guardar_Usuario()">Registrar</a>--%>
                            <button id="btn_Usuario_Nuevo" class="btn btn-default submit" onclick="Guardar_Usuario()" type="button">Ingresar</button>
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
</body>
</html>
