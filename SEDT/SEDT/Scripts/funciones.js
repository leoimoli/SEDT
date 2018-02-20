//=======================================================================================================
// Variables Globales.
//=======================================================================================================
var Msg_Exito = null;
var Msg_Error = null;
var Resultado = null;
//=======================================================================================================
//=======================================================================================================
// Nos permite invocar una función JavaScript solo sabiendo su nombre.-
//=======================================================================================================
function executeFunctionByName(functionName, context /*, args */) {
    var args = [].slice.call(arguments).splice(2);
    var namespaces = functionName.split(".");
    var func = namespaces.pop();
    for (var i = 0; i < namespaces.length; i++) {
        context = context[namespaces[i]];
    }
    return context[func].apply(context, args);
}
//=======================================================================================================
//=======================================================================================================
// Este método recibe un mensaje para mostrarlo como un pop-up de Éxito.-
//=======================================================================================================
function Mensaje_Exito(mensaje) {
    Msg_Exito = new PNotify({
        title: 'Exito!',
        text: mensaje,
        type: 'success',
        styling: 'bootstrap3'
    });
}
//=======================================================================================================
//=======================================================================================================
// Este método recibe un mensaje para mostrarlo como un pop-up de Éxito.-
//=======================================================================================================
function Mensaje_Error(mensaje) {
    Msg_Error = new PNotify({
        title: 'Error!',
        text: mensaje,
        type: 'error',
        styling: 'bootstrap3'
    });
}
//=======================================================================================================//=======================================================================================================
// Este método recibe los datos necesarios para guardar correctamente un objeto.-
//=======================================================================================================
function Consultar_Objeto(invocarUrl, objetoVista, mensaje, funcion) {
    var datos = JSON.stringify(objetoVista);
    $.ajax({
        type: "POST",
        url: invocarUrl,
        data: "{obj:" + datos + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            alert("Request: " + xmlHttpRequest.toString()
                + "\n\nStatus: " + textStatus
                + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function (result) {
            if (result.d.Exito) {
                executeFunctionByName(funcion + "_Exito", window, result.d, mensaje);
            }
            else {
                executeFunctionByName(funcion + "_Error", window, result.d);
            }
        }
    });
}
//=======================================================================================================
// Este método recibe los datos necesarios para guardar correctamente un objeto.-
//=======================================================================================================
function Guardar_Objeto(invocarUrl, objetoVista, mensaje, funcion) {
    var datos = JSON.stringify(objetoVista);
    $.ajax({
        type: "POST",
        url: invocarUrl,
        data: "{obj:" + datos + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            alert("Request: " + xmlHttpRequest.toString()
                + "\n\nStatus: " + textStatus
                + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function (result) {
            if (result.d.Exito) {
                executeFunctionByName(funcion + "_Guardar_Exito", window, result.d, mensaje);
            }
            else {
                executeFunctionByName(funcion + "_Guardar_Error", window, result.d);
            }
        }
    });
}

function Loguear(invocarUrl, objetoVista) {
    var datos = JSON.stringify(objetoVista);
    $.ajax({
        type: "POST",
        url: invocarUrl,
        data: "{obj:" + datos + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            alert("Request: " + xmlHttpRequest.toString()
                + "\n\nStatus: " + textStatus
                + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function (result) {
            if (result.d.Exito) {
                window.location.href = "Default.aspx";
            }
            else {
                alert("Puede verificar la información");
            }

            return false;
        }
    });
}
function Desloguear(invocarUrl) {
    $.ajax({
        type: "POST",
        url: invocarUrl,
        data: "{}",
        //contentType: "application/json; charset=utf-8",
        //dataType: "json",
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            alert("Request: " + xmlHttpRequest.toString()
                + "\n\nStatus: " + textStatus
                + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function () {

            window.location.href = "Login.aspx";
            return false;
        }
    });
}
//=======================================================================================================

//=======================================================================================================
// Métodos referentes a la pantalla: AltaEquipoWF.-
//=======================================================================================================
function Guardar_Usuario() {
    var mensaje = "Ha registrado el Usuario correctamente!";
    var invocarUrl = "/Login.aspx/GuardarUsuario";

    var objetoVista = {
        Dni: document.getElementById("txt_Login_Dni").value,
        Apellido: document.getElementById("txt_Login_Apellido").value,
        Nombre: document.getElementById("txt_Login_Nombre").value,
        Email: document.getElementById("txt_Login_Email").value,
        Contraseña: document.getElementById("txt_Login_ContraseñaGuardar").value
    };

    Guardar_Objeto(invocarUrl, objetoVista, mensaje, "");
}

function Login_Usuario() {
    var invocarUrl = "/Login.aspx/LoginUsuario";

    var objetoVista = {
        Dni: document.getElementById("txt_Login_Usuario").value,
        Contraseña: document.getElementById("txt_Login_Contraseña").value
    };

    Loguear(invocarUrl, objetoVista);
}

//=======================================================================================================
// CONSULTAS.-
//=======================================================================================================
function ConsultaJugador_Consultar() {
    var mensaje = "Ha registrado el Equipo correctamente!";
    var invocarUrl = "/ConsultaJugadorWF.aspx/ConsultarDatos";

    var e = document.getElementById("cmb_ConsultaJugadorWF_Equipo");
    var equipoSelecto = e.options[e.selectedIndex].value;

    var objetoVista = {
        Dni: document.getElementById("txt_ConsultaJugadorWF_DNI").value,
        Apellido: document.getElementById("txt_ConsultaJugadorWF_Apellido").value,
        Nombre: document.getElementById("txt_ConsultaJugadorWF_Nombre").value,
        Apodo: document.getElementById("txt_ConsultaJugadorWF_Apodo").value,
        idEquipo: equipoSelecto,
        IdPersonaFisicaJugador: 0,
        idUsuario: 0,
        idEquipo: 0,
    };

    Consultar_Objeto(invocarUrl, objetoVista, mensaje, "ConsultaJugador");
}
function ConsultaJugador_Nuevo() {
    ConsultaJugador_Limpiar();
}

function ConsultaJugador_Limpiar() {
    //Limpiamos los campos del formulario.-
    document.getElementById("txt_AltaEquipoWF_NombreEquipo").value = "";
    document.getElementById("txt_AltaEquipoWF_Siglas").value = "";
    document.getElementById("txt_AltaEquipoWF_SitioWeb").value = "";
    document.getElementById("txt_AltaEquipoWF_TelefonoDeContacto").value = "";

    //Aplicamos visibilidad a los botones del formulario.-
    document.getElementById("btn_ConsultaJugador_Nuevo").style.display = 'none';
    document.getElementById("btn_ConsultaJugador_Consultar").style.display = 'inline-block';
    document.getElementById("btn_ConsultaJugador_Limpiar").style.display = 'inline-block';
}

function isEven(value) {
    if (value % 2 == 0)
        return true;
    else
        return false;
}

function ConsultaJugador_Exito(respuesta, mensaje) {
    //alert(mensaje);
    //Mensaje_Exito(Mensaje);
    //ResultadoConsultar
    var tabla = "";
    if (respuesta != null && respuesta != false && respuesta.Exito != false) {
        if (respuesta.ResultadoConsultar != null && respuesta.ResultadoConsultar.length > 0) {
            for (var i = 0; i < respuesta.ResultadoConsultar.length; i++) {
                var elemento = respuesta.ResultadoConsultar[i];
                if (isEven(i)) { tabla += '<tr class="even pointer">'; } else { tabla += '<tr class="odd pointer">'; }
                tabla += '<td class="a-center "><input type="checkbox" class="flat" name="table_records"></td>';
                tabla += '<td class=" ">' + elemento.Nombre + '</td>';
                tabla += '<td class=" ">' + elemento.Apellido + '</td>';
                tabla += '<td class=" ">' + elemento.Apodo + '</td>';
                tabla += '<td class=" ">' + elemento.Posicion + '</td>';
                tabla += '<td class=" ">' + elemento.Altura + '</td>';
                tabla += '<td class="a-right a-right ">' + elemento.Peso + '</td>';
                tabla += '<td class=" "><a href="#">Ver</a></td>';
                tabla += '<td class=" "><a href="#">Editar</a></td>';
                tabla += '<td class=" last"><a href="#">Eliminar</a></td></tr>';
            }
        }
        $('#ConsultaJugador_TablaResultado').html(tabla);
    }
    return false;
}

function ConsultaJugador_Error(respuesta, mensaje) {

}
//=======================================================================================================
// ALTAS.-
//=======================================================================================================
function AltaEquipo_Guardar() {
    debugger;
    var mensaje = "Ha registrado el Equipo correctamente!";
    var invocarUrl = "/AltaEquipoWF.aspx/GuardarDatos";
    var imagenData = GetImagen();

    var objetoVista = {
        NombreEquipo: document.getElementById("txt_AltaEquipoWF_NombreEquipo").value,
        Siglas: document.getElementById("txt_AltaEquipoWF_Siglas").value,
        SitioWeb: document.getElementById("txt_AltaEquipoWF_SitioWeb").value,
        Imagen: imagenData,
        TelefonoDeContacto: document.getElementById("txt_AltaEquipoWF_TelefonoDeContacto").value,
        IdEquipoUsuario: 0,
        IdUsuario: 0

    };

    Guardar_Objeto(invocarUrl, objetoVista, mensaje, "AltaEquipo");
}

function AltaEquipo_Nuevo() {
    AltaEquipo_Limpiar();
}

function AltaEquipo_Limpiar() {
    //Limpiamos los campos del formulario.-
    document.getElementById("txt_AltaEquipoWF_NombreEquipo").value = "";
    document.getElementById("txt_AltaEquipoWF_Siglas").value = "";
    document.getElementById("txt_AltaEquipoWF_SitioWeb").value = "";
    document.getElementById("txt_AltaEquipoWF_TelefonoDeContacto").value = "";

    //Aplicamos visibilidad a los botones del formulario.-
    document.getElementById("btn_AltaEquipo_Nuevo").style.display = 'none';
    document.getElementById("btn_AltaEquipo_Guardar").style.display = 'inline-block';
    document.getElementById("btn_AltaEquipo_Limpiar").style.display = 'inline-block';
}



//=======================================================================================================
// Equipo Rival.-
//=======================================================================================================

function AltaEquipoRival_Guardar() {
    debugger;
    var mensaje = "Ha registrado el Equipo rival correctamente!";
    var invocarUrl = "/AltaEquipoRivalWF.aspx/GuardarDatos";
    var imagenData = GetImagen();

    var objetoVista = {
        NombreEquipo: document.getElementById("txt_AltaEquipoWF_NombreEquipo").value,
        ImagenEscudo: imagenData,
        IdEquipoRival: 0
    };

    Guardar_Objeto(invocarUrl, objetoVista, mensaje, "AltaEquipoRival");
}

function AltaEquipoRival_Guardar_Exito(respuesta, mensaje) {
    Mensaje_Exito(mensaje);

    if (respuesta != null && respuesta != false && respuesta.Exito != false) {
        document.getElementById("btn_AltaEquipo_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaEquipo_Guardar").style.display = 'none';
        document.getElementById("btn_AltaEquipo_Limpiar").style.display = 'none';
    }
    return false;
}

function AltaEquipoRival_Guardar_Error(respuesta) {
    var errores = respuesta.Errores;
    for (var i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
    return false;
}
//=======================================================================================================

function GetImagen() {
    debugger;
    var canvas = document.createElement("canvas");
    var img1 = document.createElement("img");
    var p = document.getElementsByClassName("file-preview-image")[0].src;
    img1.setAttribute('src', p);
    canvas.width = img1.width;
    canvas.height = img1.height;
    var ctx = canvas.getContext("2d");
    ctx.drawImage(img1, 0, 0);
    var dataUrl = canvas.toDataURL();
    return dataUrl;
}

function AltaJugador_Guardar() {
    var mensaje = "Ha registrado el Jugador correctamente!";
    var invocarUrl = "/AltaJugadorWF.aspx/GuardarDatos";
    var imagenData = GetImagen();

    var objetoVista =
        {
            IdPersonaFisicaJugador: 0,
            idUsuario: 0,
            idEquipo: 0,
            Dni: document.getElementById("txt_AltaJugadorWF_DNI").value,
            Apellido: document.getElementById("txt_AltaJugadorWF_Apellido").value,
            Nombre: document.getElementById("txt_AltaJugadorWF_Nombre").value,
            Apodo: document.getElementById("txt_AltaJugadorWF_Apodo").value,
            FechaNacimiento: document.getElementById("single_cal2").value,
            Altura: '',
            Peso: '',
            Imagen: imagenData,
            Telefono: document.getElementById("txt_AltaJugadorWF_Telefono").value
        };

    Guardar_Objeto(invocarUrl, objetoVista, mensaje, "AltaJugador");
}
function AltaJugador_Cartera_Guardar() {
    var Mensaje = "Ha registrado el Jugador correctamente!";
    var InvocarUrl = "/AltaJugadorCarteraWF.aspx/GuardarDatos";
    debugger;
    var ObjetoVista =
        {
            Apellido: document.getElementById("txt_AltaJugadorWF_Apellido").value,
            Nombre: document.getElementById("txt_AltaJugadorWF_Nombre").value,
            Apodo: document.getElementById("txt_AltaJugadorWF_Apodo").value,
            FechaPartido: document.getElementById("single_cal2").value,
            Telefono: document.getElementById("txt_AltaJugadorWF_Telefono").value,
            Email: document.getElementById("txt_AltaJugadorWF_Email").value,
            RedSocial: document.getElementById("txt_AltaJugadorWF_RedSocial").value,
            EquipoObservado: document.getElementById("txt_AltaJugadorWF_EquipoObservado").value,
            EquipoRival: document.getElementById("txt_AltaJugadorWF_EquipoRival").value
        };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje, "AltaJugador");
}



function AltaJugador_Nuevo() {
    AltaJugador_Limpiar();
}
function AltaJugador_Siguiente() {
    window.location.href = "AltaFichaTecnicaWF.aspx";
    return false;
}
function AltaJugadorCartera_Siguiente() {
    window.location.href = "AltaAtributosJugadorCarteraWF";
    return false;
}

function AltaJugador_Limpiar() {
    //Limpiamos los campos del formulario.-
    document.getElementById("txt_AltaJugadorWF_Nombre").value = "";
    document.getElementById("txt_AltaJugadorWF_Apellido").value = "";
    document.getElementById("txt_AltaJugadorWF_Apodo").value = "";
    document.getElementById("txt_AltaJugadorWF_DNI").value = "";
    document.getElementById("txt_AltaJugadorWF_FechaNacimiento").value = "";
    document.getElementById("txt_AltaJugadorWF_Telefono").value = "";


    //Aplicamos visibilidad a los botones del formulario.-
    document.getElementById("btn_AltaJugador_Nuevo").style.display = 'none';
    document.getElementById("btn_AltaJugador_Guardar").style.display = 'inline-block';
    document.getElementById("btn_AltaJugador_Limpiar").style.display = 'inline-block';
}
//=======================================================================================================

//=======================================================================================================
// Métodos referentes a la pantalla: AltaFichaTecnicaWF.-
//=======================================================================================================
function AltaFichaTecnica_Guardar() {
    var mensaje = "Ha registrado la ficha técnica del jugador correctamente!";
    var invocarUrl = "/AltaFichaTecnicaWF.aspx/GuardarDatos";

    var derecha = document.getElementById("piernaD").checked;
    var izquierda = document.getElementById("piernaI").checked;
    var piernahabil = "";
    if (derecha == true) { piernahabil = "D" } else if (izquierda == true) { piernahabil = "I" };
    var pesoVista = $('#FichaTecnica_Peso').find('.irs-to').html();
    var alturaVista = $('#FichaTecnica_Altura').find('.irs-to').html();

    /////Atributos
    var saltoVista = $('#FichaTecnica_Salto').find('.irs-to').html();
    var velocidadVista = $('#FichaTecnica_Velocidad').find('.irs-to').html();
    var resistenciaVista = $('#FichaTecnica_Resistencia').find('.irs-to').html();
    var fuerzaVista = $('#FichaTecnica_Fuerza').find('.irs-to').html();
    var controlDeBalonVista = $('#FichaTecnica_ControlDeBalon').find('.irs-to').html();
    var regatesVista = $('#FichaTecnica_Regates').find('.irs-to').html();
    var definicionVista = $('#FichaTecnica_Definicion').find('.irs-to').html();
    var marcajeVista = $('#FichaTecnica_Marcaje').find('.irs-to').html();
    var paseCortoVista = $('#FichaTecnica_PaseCorto').find('.irs-to').html();
    var paseLargoVista = $('#FichaTecnica_PaseLargo').find('.irs-to').html();
    var remateVista = $('#FichaTecnica_Remate').find('.irs-to').html();
    var tiroLibreVista = $('#FichaTecnica_Lanzamientopelotaparada').find('.irs-to').html();
    var disciplinaTacticaVista = $('#FichaTecnica_DisciplinaTactica').find('.irs-to').html();
    var nivelDefensivoVista = $('#FichaTecnica_NivelDefensivo').find('.irs-to').html();
    var nivelOfensivoVista = $('#FichaTecnica_NivelOfensivo').find('.irs-to').html();
    /////Canchita
    var posicionesVista = "";

    if ($('#ch_AR').is(":checked")) { posicionesVista += "AR " }
    if ($('#ch_LD').is(":checked")) { posicionesVista += "LD " }
    if ($('#ch_DCD').is(":checked")) { posicionesVista += "DFD " }
    if ($('#ch_DCI').is(":checked")) { posicionesVista += "DFI " }
    if ($('#ch_LI').is(":checked")) { posicionesVista += "LI " }
    if ($('#ch_MD').is(":checked")) { posicionesVista += "MD " }
    if ($('#ch_MCD').is(":checked")) { posicionesVista += "MCD " }
    if ($('#ch_MCI').is(":checked")) { posicionesVista += "MCI " }
    if ($('#ch_MI').is(":checked")) { posicionesVista += "MI " }
    if ($('#ch_MP').is(":checked")) { posicionesVista += "MP " }
    if ($('#ch_ED').is(":checked")) { posicionesVista += "ED " }
    if ($('#ch_CD').is(":checked")) { posicionesVista += "CD " }
    if ($('#ch_EI').is(":checked")) { posicionesVista += "EI " }
    var objetoVista = {
        PiernaHabil: piernahabil,
        Peso: pesoVista,
        Altura: alturaVista,
        Salto: saltoVista,
        Velocidad: velocidadVista,
        Resistencia: resistenciaVista,
        Fuerza: fuerzaVista,
        ControlDeBalon: controlDeBalonVista,
        Regates: regatesVista,
        Definicion: definicionVista,
        Marcaje: marcajeVista,
        PaseCorto: paseCortoVista,
        PaseLargo: paseLargoVista,
        Remate: remateVista,
        TiroLibre: tiroLibreVista,
        DisciplinaTactica: disciplinaTacticaVista,
        NivelDefensivo: nivelDefensivoVista,
        NivelOfensivo: nivelOfensivoVista,
        PosicionDeCampo: posicionesVista
    };

    //Ejemplo para obtener valor de una de las barritas.-
    // document.getElementById("txt_AltaJugadorWF_Altura").value;



    Guardar_Objeto(invocarUrl, objetoVista, mensaje, "AltaFichaTecnica");
}

function AltaFichaTecnicaCartera_Guardar() {
    debugger;
    var mensaje = "Ha registrado la ficha técnica del jugador cartera correctamente!";
    var invocarUrl = "/AltaAtributosJugadorCarteraWF.aspx/GuardarDatos";

    var derecha = document.getElementById("piernaD").checked;
    var izquierda = document.getElementById("piernaI").checked;
    var piernahabil = "";
    if (derecha == true) { piernahabil = "D" } else if (izquierda == true) { piernahabil = "I" };
    var pesoVista = $('#FichaTecnica_Peso').find('.irs-to').html();
    var alturaVista = $('#FichaTecnica_Altura').find('.irs-to').html();

    /////Atributos
    var saltoVista = $('#FichaTecnica_Salto').find('.irs-to').html();
    var velocidadVista = $('#FichaTecnica_Velocidad').find('.irs-to').html();
    var resistenciaVista = $('#FichaTecnica_Resistencia').find('.irs-to').html();
    var fuerzaVista = $('#FichaTecnica_Fuerza').find('.irs-to').html();
    var controlDeBalonVista = $('#FichaTecnica_ControlDeBalon').find('.irs-to').html();
    var regatesVista = $('#FichaTecnica_Regates').find('.irs-to').html();
    var definicionVista = $('#FichaTecnica_Definicion').find('.irs-to').html();
    var marcajeVista = $('#FichaTecnica_Marcaje').find('.irs-to').html();
    var paseCortoVista = $('#FichaTecnica_PaseCorto').find('.irs-to').html();
    var paseLargoVista = $('#FichaTecnica_PaseLargo').find('.irs-to').html();
    var remateVista = $('#FichaTecnica_Remate').find('.irs-to').html();
    var tiroLibreVista = $('#FichaTecnica_Lanzamientopelotaparada').find('.irs-to').html();
    var disciplinaTacticaVista = $('#FichaTecnica_DisciplinaTactica').find('.irs-to').html();
    var nivelDefensivoVista = $('#FichaTecnica_NivelDefensivo').find('.irs-to').html();
    var nivelOfensivoVista = $('#FichaTecnica_NivelOfensivo').find('.irs-to').html();
    /////Canchita
    var posicionesVista = "";

    if ($('#ch_AR').is(":checked")) { posicionesVista += "AR " }
    if ($('#ch_LD').is(":checked")) { posicionesVista += "LD " }
    if ($('#ch_DCD').is(":checked")) { posicionesVista += "DFD " }
    if ($('#ch_DCI').is(":checked")) { posicionesVista += "DFI " }
    if ($('#ch_LI').is(":checked")) { posicionesVista += "LI " }
    if ($('#ch_MD').is(":checked")) { posicionesVista += "MD " }
    if ($('#ch_MCD').is(":checked")) { posicionesVista += "MCD " }
    if ($('#ch_MCI').is(":checked")) { posicionesVista += "MCI " }
    if ($('#ch_MI').is(":checked")) { posicionesVista += "MI " }
    if ($('#ch_MP').is(":checked")) { posicionesVista += "MP " }
    if ($('#ch_ED').is(":checked")) { posicionesVista += "ED " }
    if ($('#ch_CD').is(":checked")) { posicionesVista += "CD " }
    if ($('#ch_EI').is(":checked")) { posicionesVista += "EI " }
    var objetoVista = {
        PiernaHabil: piernahabil,
        Peso: pesoVista,
        Altura: alturaVista,
        Salto: saltoVista,
        Velocidad: velocidadVista,
        Resistencia: resistenciaVista,
        Fuerza: fuerzaVista,
        ControlDeBalon: controlDeBalonVista,
        Regates: regatesVista,
        Definicion: definicionVista,
        Marcaje: marcajeVista,
        PaseCorto: paseCortoVista,
        PaseLargo: paseLargoVista,
        Remate: remateVista,
        TiroLibre: tiroLibreVista,
        DisciplinaTactica: disciplinaTacticaVista,
        NivelDefensivo: nivelDefensivoVista,
        NivelOfensivo: nivelOfensivoVista,
        PosicionDeCampo: posicionesVista
    };

    //Ejemplo para obtener valor de una de las barritas.-
    // document.getElementById("txt_AltaJugadorWF_Altura").value;



    Guardar_Objeto(invocarUrl, objetoVista, mensaje, "AltaFichaTecnicaCartera");
}

function AltaFichaTecnica_Nuevo() {
    AltaFichaTecnica_Limpiar();
}

function AltaFichaTecnica_Limpiar() {
    //Limpiamos los campos del formulario.-
    document.getElementById("po").checked = false;
    document.getElementById("ld").checked = false;
    document.getElementById("dcd").checked = false;
    document.getElementById("dci").checked = false;
    document.getElementById("li").checked = false;
    document.getElementById("md").checked = false;
    document.getElementById("mcd").checked = false;
    document.getElementById("mci").checked = false;
    document.getElementById("mi").checked = false;
    document.getElementById("mp").checked = false;
    document.getElementById("ed").checked = false;
    document.getElementById("ei").checked = false;
    document.getElementById("cd").checked = false;
}

function AltaFichaTecnicaCartera_Limpiar() {
    //Limpiamos los campos del formulario.-
    document.getElementById("po").checked = false;
    document.getElementById("ld").checked = false;
    document.getElementById("dcd").checked = false;
    document.getElementById("dci").checked = false;
    document.getElementById("li").checked = false;
    document.getElementById("md").checked = false;
    document.getElementById("mcd").checked = false;
    document.getElementById("mci").checked = false;
    document.getElementById("mi").checked = false;
    document.getElementById("mp").checked = false;
    document.getElementById("ed").checked = false;
    document.getElementById("ei").checked = false;
    document.getElementById("cd").checked = false;
}
//=======================================================================================================

//=======================================================================================================
// Métodos referentes a la pantalla: AltaEntrenamientoWF.-
//=======================================================================================================
function AltaEntrenamiento_Guardar() {
    var mensaje = "Ha registrado el entrenamiento correctamente!";
    var invocarUrl = "/AltaEntrenamientoWF.aspx/GuardarDatos";

    var objetoVista = {

    };

    Guardar_Objeto(invocarUrl, objetoVista, mensaje, "AltaEntrenamiento");

}

function AltaEntrenamiento_Nuevo() {
    AltaEntrenamiento_Limpiar();
}

function AltaEntrenamiento_Limpiar() {
    document.getElementById('entrenamiento_pasos').style.display = 'block';
    document.getElementById('entrenamiento_resultado').style.display = 'none';

    document.getElementById('btn_AltaEntrenamiento_Nuevo').style.display = 'none';
    document.getElementById('btn_AltaEntrenamiento_Guardar').style.display = 'inline-block';
    document.getElementById('btn_AltaEntrenamiento_Limpiar').style.display = 'inline-block';

    document.getElementById('step-1').style.display = 'block';
    document.getElementById('step-2').style.display = 'none';
    document.getElementById('step-3').style.display = 'none';

    $("#btnDel").click();
    $("#btnDel").click();

    $('#paso-1').attr('class', 'selected');
    $('#paso-2').attr('class', 'disabled');
    $('#paso-2').attr('isdone', '0');
    $('#paso-3').attr('class', 'disabled');
    $('#paso-3').attr('isdone', '0');

    //$('#btnAdd').attr('class', 'buttonNext btn btn-success');
    //$('#btnDel').attr('class', 'buttonPrevious btn btn-primary buttonDisabled');

    /*
    // Enable the "add" button
    $('#btnAdd').attr('disabled', false);
    // Enable the "remove" button
    $('#btnDel').attr('disabled', true);
    */

    var turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

    for (var i = 1; i <= turnos; i++) {
        // Cantidad de turnos y estapas actuales.-
        var horario = document.getElementById("txt_AltaTurnoWF_Horario_" + i).value;
        var etapas = document.getElementById("txt_AltaEntrenamientoWF_CantidadEtapas_" + i).value;

        for (var j = 1; j <= etapas; j++) {
            document.getElementById("txt_AltaEtapaWF_Descripcion_" + i + "_" + j).value = "";
            document.getElementById("txt_AltaEtapaWF_MaterialesDeTrabajo_" + i + "_" + j).value = "";
            document.getElementById("txt_AltaEntrenamientoWF_CantidadEtapas_" + i).value = "1";
            document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value = "1";
        }
    }
}
//=======================================================================================================

//=======================================================================================================
// Resultadaos de las operaciones de las diferentes pantallas.-
//=======================================================================================================
function AltaEntrenamiento_Guardar_Exito(respuesta, mensaje) {
    Mensaje_Exito(mensaje);

    if (respuesta != null && respuesta != false && respuesta.Exito != false) {
        document.getElementById("btn_AltaEntrenamiento_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaEntrenamiento_Guardar").style.display = 'none';
        document.getElementById("btn_AltaEntrenamiento_Limpiar").style.display = 'none';

        Graficar_Entrenamiento();

        document.getElementById('entrenamiento_pasos').style.display = 'none';
        document.getElementById('entrenamiento_resultado').style.display = 'block';
    }
    return false;
}

function AltaEntrenamiento_Guardar_Error(respuesta) {
    var errores = respuesta.Errores;
    for (var i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
    return false;
}

function AltaEquipo_Guardar_Exito(respuesta, mensaje) {
    Mensaje_Exito(mensaje);
    if (respuesta != null && respuesta != false && respuesta.Exito != false) {
        document.getElementById("btn_AltaEquipo_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaEquipo_Guardar").style.display = 'none';
        document.getElementById("btn_AltaEquipo_Limpiar").style.display = 'none';
    }
    return false;
}

function AltaEquipo_Guardar_Error(respuesta) {
    var errores = respuesta.Errores;
    for (var i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
    return false;
}

function AltaJugador_Guardar_Exito(respuesta, mensaje) {
    Mensaje_Exito(mensaje);
    if (respuesta != null && respuesta != false && respuesta.Exito != false) {
        document.getElementById("btn_AltaJugador_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaJugador_Siguiente").style.display = 'inline-block';
        document.getElementById("btn_AltaJugador_Guardar").style.display = 'none';
        document.getElementById("btn_AltaJugador_Limpiar").style.display = 'none';
    }
    return false;
}

function AltaJugador_Guardar_Error(respuesta) {
    var errores = respuesta.Errores;
    for (var i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
    return false;
}

//=======================================================================================================
//=======================================================================================================


//=======================================================================================================
//=======================================================================================================
$("#avatar-2").fileinput({
    overwriteInitial: true,
    maxFileSize: 1500,
    showClose: false,
    showCaption: false,
    showBrowse: false,
    browseOnZoneClick: true,
    removeLabel: '',
    removeIcon: '<i class="glyphicon glyphicon-remove"></i>',
    removeTitle: 'Cancel or reset changes',
    elErrorContainer: '#kv-avatar-errors-2',
    msgErrorClass: 'alert alert-block alert-danger',

    defaultPreviewContent: '<img id="Imagen_Escudo" src="/Template/fileInput/img/Escudo.png" alt="Su Escudo" style="width:160px"><h6 class="text-muted">Seleccionar un imagen</h6>',
    layoutTemplates: { main2: '{preview} {remove} {browse}' },
    allowedFileExtensions: ["jpg", "png", "gif"]
});
//=======================================================================================================
//=======================================================================================================
function AltaTorneo_Guardar() {
    debugger;
    var mensaje = "Ha registrado el Torneo correctamente!";
    var invocarUrl = "/AltaTorneoWF.aspx/GuardarDatos";
    var imagenData = GetImagen();

    var objetoVista = {
        NombreTorneo: document.getElementById("txt_AltaTorneoWF_NombreTorneo").value,
        FormatoTorneo: document.getElementById("txt_AltaTorneoWF_Formato").value,
        DuracionPartidos: parseInt(document.getElementById("txt_AltaTorneoWF_DuracionPartidos").value) || 0,
        Descripcion: document.getElementById("txt_AltaTorneoWF_Descripción").value,
        ImagenTorneo: imagenData
    };

    Guardar_Objeto(invocarUrl, objetoVista, mensaje, "AltaTorneo");
}

function AltaTorneo_Nuevo() {
    AltaTorneo_Limpiar();
}

function AltaTorneo_Limpiar() {
    //Limpiamos los campos del formulario.-
    document.getElementById("txt_AltaTorneoWF_NombreTorneo").value = "";
    document.getElementById("txt_AltaTorneoWF_Formato").value = "";
    document.getElementById("txt_AltaTorneoWF_DuracionPartidos").value = "";
    document.getElementById("txt_AltaTorneoWF_Descripción").value = "";

    //Aplicamos visibilidad a los botones del formulario.-
    document.getElementById("btn_AltaTorneo_Nuevo").style.display = 'none';
    document.getElementById("btn_AltaTorneo_Guardar").style.display = 'inline-block';
    document.getElementById("btn_AltaTorneo_Limpiar").style.display = 'inline-block';
}

function AltaTorneo_Guardar_Exito(respuesta, mensaje) {
    Mensaje_Exito(mensaje);
    if (respuesta != null && respuesta != false && respuesta.Exito != false) {
        document.getElementById("btn_AltaTorneo_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaTorneo_Guardar").style.display = 'none';
        document.getElementById("btn_AltaTorneo_Limpiar").style.display = 'none';
    }
}

function AltaTorneo_Guardar_Error(respuesta) {
    var errores = respuesta.Errores;
    for (var i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
}

//=======================================================================================================
//=======================================================================================================
// LOGICA PARA AGREGAR Y ELIMINAR ELEMENTOS DUPLICADOS DEL FORMULARIO.-
//=======================================================================================================
//=======================================================================================================

function Aplicar_Cambio_Solapa_Etapas_por_Turno() {
    // Cantidad de turnos actual.-
    var turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

    for (var i = 1; i <= turnos; i++) {
        // Cantidad de turnos y estapas actuales.-
        var horarioActual = document.getElementById("txt_AltaTurnoWF_Horario_" + i).value;
        var etapasActual = document.getElementById("txt_AltaEntrenamientoWF_CantidadEtapas_" + i).value;

        // Checks to see how many "duplicatable" input fields we currently have
        var num = $('#container_Clonar_Etapas_' + i).find('.clonedInput_EtapaSingular').length;

        // En caso de que haya la misma cantidad no se hace nada.-
        if (num == etapasActual) continue;

        // En caso de que haya menos una cantidad mayor eliminamos.-
        if (etapasActual < num) {
            var cantEliminar = num - etapasActual;
            for (var j = num; j > etapasActual; j--) {
                $('#container_Clonar_EtapaSingular_' + i + '_' + j).remove();
            }
            continue;
        }

        var cantAgregar = etapasActual - num;
        for (var k = num; k < etapasActual; k++) {
            // The numeric ID of the new input field being added, increasing by 1 each time
            var newNum = new Number(num + 1);
            // create the new element via clone(), and manipulate it's ID using newNum value
            var newElem = $('#container_Clonar_EtapaSingular_' + i + '_' + 1).clone().attr('id', 'container_Clonar_EtapaSingular_' + i + '_' + newNum).fadeIn('slow');
            newElem.find('#txt_AltaEtapaWF_Actividad_1_1').attr('id', 'txt_AltaEtapaWF_Actividad_' + i + '_' + newNum);
            newElem.find('#txt_AltaEtapaWF_Descripcion_1_1').attr('id', 'txt_AltaEtapaWF_Descripcion_' + i + '_' + newNum);
            newElem.find('#txt_AltaEtapaWF_MaterialesDeTrabajo_1_1').attr('id', 'txt_AltaEtapaWF_MaterialesDeTrabajo_' + i + '_' + newNum);
            $('#container_Clonar_EtapaSingular_' + i + '_' + 1).after(newElem);
            num++;
        }

        $("#container_Clonar_EtapaSingular_" + i + "_1").find('#txt_AltaEtapaWF_Actividad_1_1').attr('id', 'txt_AltaEtapaWF_Actividad_' + i + '_1');
        $("#container_Clonar_EtapaSingular_" + i + "_1").find('#txt_AltaEtapaWF_Descripcion_1_1').attr('id', 'txt_AltaEtapaWF_Descripcion_' + i + '_1');
        $("#container_Clonar_EtapaSingular_" + i + "_1").find('#txt_AltaEtapaWF_MaterialesDeTrabajo_1_1').attr('id', 'txt_AltaEtapaWF_MaterialesDeTrabajo_' + i + '_1');
    }
}

function Aplicar_Cambio_Solapa_Etapa() {
    // Checks to see how many "duplicatable" input fields we currently have
    var num = $('.clonedInput_Etapas').length;

    // Cantidad de turnos actual.-
    var turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

    for (i = 1; i <= turnos; i++) {
        var Horario = $('#txt_AltaTurnoWF_Horario_' + i).val();

        var color = "color_Azul";
        // Add to the set
        var Set2 = "2 5 8";
        if (~Set2.indexOf(i)) { color = "color_Verde"; }
        // Add to the set
        var Set3 = "3 6 9";
        if (~Set3.indexOf(i)) { color = "color_Rojo"; }

        $('#container_Clonar_Etapas_' + i).find('.StepTitle').html('Etapas del turno que arranca <span class="' + color + '">' + Horario + '</span>:');
    }

    // En caso de que haya la misma cantidad no se hace nada.-
    if (num == turnos) return false;

    // En caso de que haya menos una cantidad mayor eliminamos.-
    if (turnos < num) {
        var cantEliminar = num - turnos;
        for (var i = num; i > turnos; i--) {
            $('#container_Clonar_Etapas_' + i).remove();
        }
        return false;
    }

    var cantAgregar = turnos - num;
    for (var i = num; i < turnos; i++) {
        // The numeric ID of the new input field being added, increasing by 1 each time
        var newNum = new Number(num + 1);
        // create the new element via clone(), and manipulate it's ID using newNum value
        var newElem = $('#container_Clonar_Etapas_' + 1).clone().attr('id', 'container_Clonar_Etapas_' + newNum).fadeIn('slow');
        newElem.find('#container_Clonar_EtapaSingular_1_1').attr('id', 'container_Clonar_EtapaSingular_' + newNum + '_1');
        $('#container_Clonar_Etapas_' + i).after(newElem);
        num++;
    }

    // Enable the "remove" button. This only shows once you have a duplicated section.
    $('#btnDel').attr('disabled', false);
    return false;
}

function Aplicar_Cambio_Solapa_Turno() {
    // Checks to see how many "duplicatable" input fields we currently have
    var num = $('.clonedInput').length;

    // Cantidad de turnos actual.-
    var turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

    // En caso de que haya la misma cantidad no se hace nada.-
    if (num == turnos) return false;

    // En caso de que haya menos una cantidad mayor eliminamos.-
    if (turnos < num) {
        var cantEliminar = num - turnos;
        for (var i = num; i > turnos; i--) {
            $('#container_Clonar_' + i).remove();
        }
        return false;
    }

    var cantAgregar = turnos - num;
    for (var i = num; i < turnos; i++) {
        var newNum = new Number(num + 1);      // The numeric ID of the new input field being added, increasing by 1 each time
        var newElem = $('#container_Clonar_' + 1).clone().attr('id', 'container_Clonar_' + newNum).fadeIn('slow'); // create the new element via clone(), and manipulate it's ID using newNum value
        newElem.find('#txt_AltaTurnoWF_Horario_1').attr('id', 'txt_AltaTurnoWF_Horario_' + newNum);
        newElem.find('#Error_Fecha_1').attr('id', 'Error_Fecha_' + newNum);
        newElem.find('#txt_AltaEntrenamientoWF_CantidadEtapas_1').attr('id', 'txt_AltaEntrenamientoWF_CantidadEtapas_' + newNum);
        /*newElem.find('.heading-reference').attr('id', 'ID' + newNum + '_reference');*/

        newElem.find('.clockpicker').clockpicker({
            placement: 'top',
            align: 'left',
            donetext: 'Elegir',
            afterDone: function () { ClockPicker_HoraSeleccionada(); }
        });

        // Insert the new element after the last "duplicatable" input field
        $('#container_Clonar_' + i).after(newElem);
        //Actualizamos el nuevo valor autoIncremental.-
        num++;
    }
    // Enable the "remove" button. This only shows once you have a duplicated section.
    $('#btnDel').attr('disabled', false);
    return false;
}

$(function () {
    $('#btnAdd').click(function () {
        Aplicar_Cambio_Solapa_Turno();
        Aplicar_Cambio_Solapa_Etapa();
        Aplicar_Cambio_Solapa_Etapas_por_Turno();
        ClockPicker_HoraSeleccionada();
        return false; // Removes the last section you added
    });

    $('#btnDel').click(function () {
        Aplicar_Cambio_Solapa_Turno();
        Aplicar_Cambio_Solapa_Etapa();
        Aplicar_Cambio_Solapa_Etapas_por_Turno();
        ClockPicker_HoraSeleccionada();
        return false; // Removes the last section you added
    });

    // Enable the "add" button
    $('#btnAdd').attr('disabled', false);
    // Enable the "remove" button
    $('#btnDel').attr('disabled', false);
});
//=======================================================================================================
//=======================================================================================================
function Graficar_Entrenamiento() {
    // Cantidad de turnos actual.-
    var turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;
    var arr = [];

    for (var i = 1; i <= turnos; i++) {
        // Cantidad de turnos y estapas actuales.-
        var horario = document.getElementById("txt_AltaTurnoWF_Horario_" + i).value;
        var etapas = document.getElementById("txt_AltaEntrenamientoWF_CantidadEtapas_" + i).value;

        // create the new element via clone(), and manipulate it's ID using newNum value
        if (i >= 2) {
            var h = i - 1;
            var newElem = $('#Descripcion_Turno_1').clone().attr('id', 'Descripcion_Turno_' + i).fadeIn('slow');
            $('#Descripcion_Turno_' + h).after(newElem);
        }

        var horarioTurnoHtml = '<a class="tag"><span>' + horario + '</span></a>';
        var descripcionEtapaHtml = '';

        var fisico = 0; var tecnico = 0;
        var tactico = 0; var futbol = 0;

        for (var j = 1; j <= etapas; j++) {
            var tipoActividad = document.getElementById("txt_AltaEtapaWF_Actividad_" + i + '_' + j).value;

            if (tipoActividad == "Físico") fisico++;
            if (tipoActividad == "Técnico") tecnico++;
            if (tipoActividad == "Táctico") tactico++;
            if (tipoActividad == "Fútbol") futbol++;

            descripcionEtapaHtml += '<h2 class="title">';
            descripcionEtapaHtml += '<a>ETAPA ' + j + '</a>';
            descripcionEtapaHtml += '</h2> <br />';
            descripcionEtapaHtml += '<p class="excerpt">';
            descripcionEtapaHtml += '<span><b>Tipo de actividad:</b> ' + tipoActividad + '</span><br />';
            descripcionEtapaHtml += '<span><b>Descripción:</b> ' + document.getElementById("txt_AltaEtapaWF_Descripcion_" + i + '_' + j).value + '</span><br />';
            descripcionEtapaHtml += '<span><b>Materiales:</b> ' + document.getElementById("txt_AltaEtapaWF_MaterialesDeTrabajo_" + i + '_' + j).value + '</span>';
            descripcionEtapaHtml += '</p>';
        }

        arr.push({ x: 'Turno ' + horario, y: tecnico, z: fisico, a: tactico, b: futbol });

        // Añado todo el HTML generado para remarcar el horario del turno.-
        $('#Descripcion_Turno_' + i).find('.tags').html(horarioTurnoHtml);
        // Añado todo el HTML generado para las etapas de este turno.-
        $('#Descripcion_Turno_' + i).find('.block_content').html(descripcionEtapaHtml);
    }

    if ($('#pruebas').length) {
        Morris.Bar({
            element: 'pruebas',
            data: arr,
            xkey: 'x',
            ykeys: ['y', 'z', 'a', 'b'],
            barColors: ['#5cb85c', '#337ab7', '#f0ad4e', '#d9534f'],
            hideHover: 'auto',
            labels: ['Técnico', 'Físico', 'Táctico', 'Fútbol'],
            resize: true
        }).on('click', function (i, row) {
            console.log(i, row);
        });
    }
    return false;
}
//=======================================================================================================
//=======================================================================================================
function ClockPicker_HoraSeleccionada() {
    // Checks to see how many "duplicatable" input fields we currently have
    var num = $('.clonedInput').length;

    // Corroboramos que todas las fechas sean correctas entre si.
    for (i = 2; i <= num; i++) {
        var contador = i;
        var valorNuevo = $('#txt_AltaTurnoWF_Horario_' + contador).val();
        contador--;
        var valorActual = $('#txt_AltaTurnoWF_Horario_' + contador).val();
        valorActual = moment.utc(valorActual, 'hh:mm').add(1, 'hour').format('hh:mm');

        //input-group clockpicker Validacion
        if (valorActual > valorNuevo) {
            $('#container_Clonar_' + i).find('.fechaValidar').attr('class', 'form-control fechaValidar Validacion');
            $('#container_Clonar_' + i).find('#Error_Fecha_' + i).attr('class', 'Error_Fecha_Visible');
            $('#container_Clonar_' + i).find('.label-danger-Validacion').html("Puede arrancar el turno a partir de las " + valorActual + " o posterior.");
        }
        else {
            $('#container_Clonar_' + i).find('.fechaValidar').attr('class', 'form-control fechaValidar');
            $('#container_Clonar_' + i).find('#Error_Fecha_' + i).attr('class', 'Error_Fecha_Invisible');
        }
    }
    // .trigger('change')
}

//============================================================================================================
//============================================================================================================
function consultaJugador_Resultado() {
    /*
                                    <tr class="even pointer">
                                    <td class="a-center ">
                                        <input type="checkbox" class="flat" name="table_records">
                                    </td>
                                    <td class=" ">121000040</td>
                                    <td class=" ">May 23, 2014 11:47:56 PM </td>
                                    <td class=" ">121000210 <i class="success fa fa-long-arrow-up"></i></td>
                                    <td class=" ">John Blank L</td>
                                    <td class=" ">Paid</td>
                                    <td class="a-right a-right ">$7.45</td>
                                    <td class=" last"><a href="#">View</a>
                                    </td>
                                </tr>
                                                                <tr class="odd pointer">
                                    <td class="a-center ">
                                        <input type="checkbox" class="flat" name="table_records">
                                    </td>
                                    <td class=" ">121000039</td>
                                    <td class=" ">May 23, 2014 11:30:12 PM</td>
                                    <td class=" ">121000208 <i class="success fa fa-long-arrow-up"></i>
                                    </td>
                                    <td class=" ">John Blank L</td>
                                    <td class=" ">Paid</td>
                                    <td class="a-right a-right ">$741.20</td>
                                    <td class=" last"><a href="#">View</a>
                                    </td>
                                </tr>
    */
}
