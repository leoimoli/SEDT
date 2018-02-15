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
function Consultar_Objeto(InvocarUrl, ObjetoVista, Mensaje, Funcion) {
    var Datos = JSON.stringify(ObjetoVista);
    $.ajax({
        type: "POST",
        url: InvocarUrl,
        data: "{obj:" + Datos + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown)
        {
            alert("Request: " + XMLHttpRequest.toString()
             + "\n\nStatus: " + textStatus
              + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function (result)
        {
            if (result.d.Exito) {
                executeFunctionByName(Funcion + "_Exito", window, result.d, Mensaje);
            }
            else {
                executeFunctionByName(Funcion + "_Error", window, result.d);
            }
        }
    });
}
//=======================================================================================================
// Este método recibe los datos necesarios para guardar correctamente un objeto.-
//=======================================================================================================
function Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje, Funcion) {
    var Datos = JSON.stringify(ObjetoVista);
    $.ajax({
        type: "POST",
        url: InvocarUrl,
        data: "{obj:" + Datos + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Request: " + XMLHttpRequest.toString()
             + "\n\nStatus: " + textStatus
              + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function (result) {

            if (result.d.Exito) {
                executeFunctionByName(Funcion + "_Guardar_Exito", window, result.d, Mensaje);
            }
            else {
                executeFunctionByName(Funcion + "_Guardar_Error", window, result.d);
            }
        }
    });
}

function Loguear(InvocarUrl, ObjetoVista, Mensaje, Funcion) {
    var Datos = JSON.stringify(ObjetoVista);
    $.ajax({
        type: "POST",
        url: InvocarUrl,
        data: "{obj:" + Datos + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Request: " + XMLHttpRequest.toString()
             + "\n\nStatus: " + textStatus
              + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function (result) {
            debugger;
            if (result.d.Exito) {
                window.location.href = "Default.aspx";
            }
            else {
                alert("Puede verificar la información")
            }

            return false;
        }
    });
}
function Desloguear(InvocarUrl, ObjetoVista, Mensaje, Funcion) {
    $.ajax({
        type: "POST",
        url: InvocarUrl,
        data: "{}",
        //contentType: "application/json; charset=utf-8",
        //dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Request: " + XMLHttpRequest.toString()
             + "\n\nStatus: " + textStatus
              + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function (result) {

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
    var Mensaje = "Ha registrado el Usuario correctamente!";
    var InvocarUrl = "/Login.aspx/GuardarUsuario";

    var ObjetoVista = {
        Dni: document.getElementById("txt_Login_Dni").value,
        Apellido: document.getElementById("txt_Login_Apellido").value,
        Nombre: document.getElementById("txt_Login_Nombre").value,
        Email: document.getElementById("txt_Login_Email").value,
        Contraseña: document.getElementById("txt_Login_ContraseñaGuardar").value
    };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje, "");
}

function Login_Usuario() {
    var Mensaje = "asdasda";
    var InvocarUrl = "/Login.aspx/LoginUsuario";

    var ObjetoVista = {
        Dni: document.getElementById("txt_Login_Usuario").value,
        Contraseña: document.getElementById("txt_Login_Contraseña").value
    };

    Loguear(InvocarUrl, ObjetoVista, Mensaje, "");
}

//=======================================================================================================
// CONSULTAS.-
//=======================================================================================================
function ConsultaJugador_Consultar()
{
    var Mensaje = "Ha registrado el Equipo correctamente!";
    var InvocarUrl = "/ConsultaJugadorWF.aspx/ConsultarDatos";

    var e = document.getElementById("cmb_ConsultaJugadorWF_Equipo");
    var equipoSelecto = e.options[e.selectedIndex].value;

    var ObjetoVista = {
        Dni: document.getElementById("txt_ConsultaJugadorWF_DNI").value,
        Apellido: document.getElementById("txt_ConsultaJugadorWF_Apellido").value,
        Nombre: document.getElementById("txt_ConsultaJugadorWF_Nombre").value,
        Apodo: document.getElementById("txt_ConsultaJugadorWF_Apodo").value,
        idEquipo: equipoSelecto
    };

    Consultar_Objeto(InvocarUrl, ObjetoVista, Mensaje, "ConsultaJugador");
}
function ConsultaJugador_Nuevo() {
    ConsultaJugador_Limpiar();
}

function ConsultaJugador_Limpiar()
{
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

function ConsultaJugador_Exito(Respuesta, Mensaje)
{
    debugger;
    //Mensaje_Exito(Mensaje);
    var tabla = "";
    if (Respuesta != null && Respuesta != false && Respuesta.Exito != false)
    {
        if (Respuesta.Resultado != null && Respuesta.Resultado.length > 0)
        {
            for (var i=0; i < Respuesta.Resultado.length; i++)
            {
                var elemento = Respuesta.Resultado[i];
                if (isEven(i)) { tabla += '<tr class="even pointer">'; } else { tabla += '<tr class="odd pointer">'; }
                tabla += '<td class="a-center "><input type="checkbox" class="flat" name="table_records"></td>';
                tabla += '<td class=" ">' + elemento.IdPersonaFisicaJugador + '</td>';
                tabla += '<td class=" ">' + elemento.Apellido + '</td>';
                tabla += '<td class=" ">' + elemento.Apodo + '</td>';
                tabla += '<td class=" ">' + elemento.Posicion + '</td>';
                tabla += '<td class=" ">' + elemento.Altura + '</td>';
                tabla += '<td class="a-right a-right ">' + elemento.Peso + '</td>';
                tabla += '<td class=" last"><a href="#">Ver</a></td></tr>';
            }
        }
        $('#ConsultaJugador_TablaResultado').html(tabla);
    }
    return false;
}

function ConsultaJugador_Error(Respuesta, Mensaje)
{

}
//=======================================================================================================
// ALTAS.-
//=======================================================================================================
function AltaEquipo_Guardar() {
    var Mensaje = "Ha registrado el Equipo correctamente!";
    var InvocarUrl = "/AltaEquipoWF.aspx/GuardarDatos";

    var ObjetoVista = {
        NombreEquipo: document.getElementById("txt_AltaEquipoWF_NombreEquipo").value,
        Siglas: document.getElementById("txt_AltaEquipoWF_Siglas").value,
        SitioWeb: document.getElementById("txt_AltaEquipoWF_SitioWeb").value,
        TelefonoDeContacto: document.getElementById("txt_AltaEquipoWF_TelefonoDeContacto").value
    };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje, "AltaEquipo");
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

function AltaJugador_Guardar() {
    var Mensaje = "Ha registrado el Jugador correctamente!";
    var InvocarUrl = "/AltaJugadorWF.aspx/GuardarDatos";

    var ObjetoVista =
    {
        Dni: document.getElementById("txt_AltaJugadorWF_DNI").value,
        Apellido: document.getElementById("txt_AltaJugadorWF_Apellido").value,
        Nombre: document.getElementById("txt_AltaJugadorWF_Nombre").value,
        Apodo: document.getElementById("txt_AltaJugadorWF_Apodo").value,
        FechaNacimiento: document.getElementById("txt_AltaJugadorWF_FechaNacimiento").value,
        Altura: document.getElementById("txt_AltaJugadorWF_Altura").value,
        Peso: document.getElementById("txt_AltaJugadorWF_Peso").value,
        Imagen: null
    };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje, "AltaJugador");
}

function AltaJugador_Nuevo() {
    AltaJugador_Limpiar();
}

function AltaJugador_Limpiar() {
    //Limpiamos los campos del formulario.-
    document.getElementById("txt_AltaJugadorWF_Nombre").value = "";
    document.getElementById("txt_AltaJugadorWF_Apellido").value = "";
    document.getElementById("txt_AltaJugadorWF_Apodo").value = "";
    document.getElementById("txt_AltaJugadorWF_DNI").value = "";
    document.getElementById("txt_AltaJugadorWF_FechaNacimiento").value = "";
    document.getElementById("txt_AltaJugadorWF_Peso").value = "";
    document.getElementById("txt_AltaJugadorWF_Altura").value = "";

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
    var Mensaje = "Ha registrado la ficha técnica del jugador correctamente!";
    var InvocarUrl = "/AltaFichaTecnicaWF.aspx/GuardarDatos";
    debugger;

    var Derecha = document.getElementById("piernaD").checked;
    var Izquierda = document.getElementById("piernaI").checked;
    var piernahabil = "";
    if (Derecha == true) { piernahabil = "D" } else if (Izquierda == true) { piernahabil = "I" };
    var Altura_Vista = $('#FichaTecnica_Altura').find('.irs-to').html();
    var Peso_Vista = $('#FichaTecnica_Peso').find('.irs-to').html();

    /////Atributos
    var Salto_Vista = $('#FichaTecnica_Salto').find('.irs-to').html();
    var Velocidad_Vista = $('#FichaTecnica_Velocidad').find('.irs-to').html();
    var Resistencia_Vista = $('#FichaTecnica_Resistencia').find('.irs-to').html();
    var Fuerza_Vista = $('#FichaTecnica_Fuerza').find('.irs-to').html();
    var ControlDeBalon_Vista = $('#FichaTecnica_ControlDeBalon').find('.irs-to').html();
    var Regates_Vista = $('#FichaTecnica_Regates').find('.irs-to').html();
    var Definicion_Vista = $('#FichaTecnica_Definicion').find('.irs-to').html();
    var Marcaje_Vista = $('#FichaTecnica_Marcaje').find('.irs-to').html();
    var PaseCorto_Vista = $('#FichaTecnica_PaseCorto').find('.irs-to').html();
    var PaseLargo_Vista = $('#FichaTecnica_PaseLargo').find('.irs-to').html();
    var Remate_Vista = $('#FichaTecnica_Remate').find('.irs-to').html();
    var TiroLibre_Vista = $('#FichaTecnica_Lanzamientopelotaparada').find('.irs-to').html();
    var DisciplinaTactica_Vista = $('#FichaTecnica_DisciplinaTactica').find('.irs-to').html();
    var NivelDefensivo_Vista = $('#FichaTecnica_NivelDefensivo').find('.irs-to').html();
    var NivelOfensivo_Vista = $('#FichaTecnica_NivelOfensivo').find('.irs-to').html();
    /////Canchita
    var posiciones_Vista = "";

    if ($('#ch_AR').is(":checked")) { posiciones_Vista += "AR " }
    if ($('#ch_LD').is(":checked")) { posiciones_Vista += "LD " }
    if ($('#ch_DCD').is(":checked")) { posiciones_Vista += "DFD " }
    if ($('#ch_DCI').is(":checked")) { posiciones_Vista += "DFI " }
    if ($('#ch_LI').is(":checked")) { posiciones_Vista += "LI " }
    if ($('#ch_MD').is(":checked")) { posiciones_Vista += "MD " }
    if ($('#ch_MCD').is(":checked")) { posiciones_Vista += "MCD " }
    if ($('#ch_MCI').is(":checked")) { posiciones_Vista += "MCI " }
    if ($('#ch_MI').is(":checked")) { posiciones_Vista += "MI " }
    if ($('#ch_MP').is(":checked")) { posiciones_Vista += "MP " }
    if ($('#ch_ED').is(":checked")) { posiciones_Vista += "ED " }
    if ($('#ch_CD').is(":checked")) { posiciones_Vista += "CD " }
    if ($('#ch_EI').is(":checked")) { posiciones_Vista += "EI " }
    var ObjetoVista = {
        PiernaHabil: piernahabil,
        Peso: Peso_Vista,
        Altura: Altura_Vista,
        Salto: Salto_Vista,
        Velocidad: Velocidad_Vista,
        Resistencia: Resistencia_Vista,
        Fuerza: Fuerza_Vista,
        ControlDeBalon: ControlDeBalon_Vista,
        Regates: Regates_Vista,
        Definicion: Definicion_Vista,
        Marcaje: Marcaje_Vista,
        PaseCorto: PaseCorto_Vista,
        PaseLargo: PaseLargo_Vista,
        Remate: Remate_Vista,
        TiroLibre: TiroLibre_Vista,
        DisciplinaTactica: DisciplinaTactica_Vista,
        NivelDefensivo: NivelDefensivo_Vista,
        NivelOfensivo: NivelOfensivo_Vista,
        PosicionDeCampo: posiciones_Vista
    };

    //Ejemplo para obtener valor de una de las barritas.-
    // document.getElementById("txt_AltaJugadorWF_Altura").value;



    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje, "AltaFichaTecnica");
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
//=======================================================================================================

//=======================================================================================================
// Métodos referentes a la pantalla: AltaEntrenamientoWF.-
//=======================================================================================================
function AltaEntrenamiento_Guardar() {
    var Mensaje = "Ha registrado el entrenamiento correctamente!";
    var InvocarUrl = "/AltaEntrenamientoWF.aspx/GuardarDatos";

    var ObjetoVista = {

    };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje, "AltaEntrenamiento");

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

    var Turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

    for (i = 1; i <= Turnos; i++) {
        // Cantidad de turnos y estapas actuales.-
        var Horario = document.getElementById("txt_AltaTurnoWF_Horario_" + i).value;
        var Etapas = document.getElementById("txt_AltaEntrenamientoWF_CantidadEtapas_" + i).value;

        for (j = 1; j <= Etapas; j++) {
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
function AltaEntrenamiento_Guardar_Exito(Respuesta, Mensaje) {
    Mensaje_Exito(Mensaje);

    if (Respuesta != null && Respuesta != false && Respuesta.Exito != false) {
        document.getElementById("btn_AltaEntrenamiento_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaEntrenamiento_Guardar").style.display = 'none';
        document.getElementById("btn_AltaEntrenamiento_Limpiar").style.display = 'none';

        Graficar_Entrenamiento();

        document.getElementById('entrenamiento_pasos').style.display = 'none';
        document.getElementById('entrenamiento_resultado').style.display = 'block';
    }
    return false;
}

function AltaEntrenamiento_Guardar_Error(Respuesta) {
    var errores = Respuesta.Errores;
    for (i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
    return false;
}

function AltaEquipo_Guardar_Exito(Respuesta, Mensaje) {
    Mensaje_Exito(Mensaje);
    if (Respuesta != null && Respuesta != false && Respuesta.Exito != false) {
        document.getElementById("btn_AltaEquipo_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaEquipo_Guardar").style.display = 'none';
        document.getElementById("btn_AltaEquipo_Limpiar").style.display = 'none';
    }
    return false;
}

function AltaEquipo_Guardar_Error(Respuesta) {
    var errores = Respuesta.Errores;
    for (i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
    return false;
}

function AltaJugador_Guardar_Exito(Respuesta, Mensaje) {
    Mensaje_Exito(Mensaje);
    if (Respuesta != null && Respuesta != false && Respuesta.Exito != false) {
        document.getElementById("btn_AltaJugador_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaJugador_Guardar").style.display = 'none';
        document.getElementById("btn_AltaJugador_Limpiar").style.display = 'none';
    }
    return false;
}

function AltaJugador_Guardar_Error(Respuesta) {
    var errores = Respuesta.Errores;
    for (i = 0; i < errores.length; i++) {
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
    defaultPreviewContent: '<img id="Imagen_Escudo" src="/Template/fileInput/img/Escudo.png" alt="Su Escudo" style="width:160px"><h6 class="text-muted">Seleccionar un escudo</h6>',
    layoutTemplates: { main2: '{preview} {remove} {browse}' },
    allowedFileExtensions: ["jpg", "png", "gif"]
});
//=======================================================================================================
//=======================================================================================================
function AltaTorneo_Guardar() {
    var Mensaje = "Ha registrado el Torneo correctamente!";
    var InvocarUrl = "/AltaTorneoWF.aspx/GuardarDatos";

    var ObjetoVista = {
        NombreTorneo: document.getElementById("txt_AltaTorneoWF_NombreTorneo").value,
        FormatoTorneo: document.getElementById("txt_AltaTorneoWF_Formato").value,
        DuracionPartidos: document.getElementById("txt_AltaTorneoWF_DuracionPartidos").value,
        Descripcion: document.getElementById("txt_AltaTorneoWF_Descripción").value,
        //Imagen: null
    };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje, "AltaTorneo");
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

function AltaTorneo_Guardar_Exito(Respuesta, Mensaje) {
    Mensaje_Exito(Mensaje);
    if (Respuesta != null && Respuesta != false && Respuesta.Exito != false) {
        document.getElementById("btn_AltaTorneo_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaTorneo_Guardar").style.display = 'none';
        document.getElementById("btn_AltaTorneo_Limpiar").style.display = 'none';
    }
}

function AltaTorneo_Guardar_Error(Respuesta) {
    var errores = Respuesta.Errores;
    for (i = 0; i < errores.length; i++) {
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
    var Turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

    for (i = 1; i <= Turnos; i++) {
        // Cantidad de turnos y estapas actuales.-
        var HorarioActual = document.getElementById("txt_AltaTurnoWF_Horario_" + i).value;
        var EtapasActual = document.getElementById("txt_AltaEntrenamientoWF_CantidadEtapas_" + i).value;

        // Checks to see how many "duplicatable" input fields we currently have
        var num = $('#container_Clonar_Etapas_' + i).find('.clonedInput_EtapaSingular').length;

        // En caso de que haya la misma cantidad no se hace nada.-
        if (num == EtapasActual) continue;

        // En caso de que haya menos una cantidad mayor eliminamos.-
        if (EtapasActual < num) {
            var cantEliminar = num - EtapasActual;
            for (j = num; j > EtapasActual; j--) {
                $('#container_Clonar_EtapaSingular_' + i + '_' + j).remove();
            }
            continue;
        }

        var cantAgregar = EtapasActual - num;
        for (k = num; k < EtapasActual; k++) {
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
    var Turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

    for (i = 1; i <= Turnos; i++) {
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
    if (num == Turnos) return false;

    // En caso de que haya menos una cantidad mayor eliminamos.-
    if (Turnos < num) {
        var cantEliminar = num - Turnos;
        for (i = num; i > Turnos; i--) {
            $('#container_Clonar_Etapas_' + i).remove();
        }
        return false;
    }

    var cantAgregar = Turnos - num;
    for (i = num; i < Turnos; i++) {
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
    var Turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

    // En caso de que haya la misma cantidad no se hace nada.-
    if (num == Turnos) return false;

    // En caso de que haya menos una cantidad mayor eliminamos.-
    if (Turnos < num) {
        var cantEliminar = num - Turnos;
        for (i = num; i > Turnos; i--) {
            $('#container_Clonar_' + i).remove();
        }
        return false;
    }

    var cantAgregar = Turnos - num;
    for (i = num; i < Turnos; i++) {
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
    var Turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;
    var arr = [];

    for (i = 1; i <= Turnos; i++) {
        // Cantidad de turnos y estapas actuales.-
        var Horario = document.getElementById("txt_AltaTurnoWF_Horario_" + i).value;
        var Etapas = document.getElementById("txt_AltaEntrenamientoWF_CantidadEtapas_" + i).value;

        // create the new element via clone(), and manipulate it's ID using newNum value
        if (i >= 2) {
            var h = i - 1;
            var newElem = $('#Descripcion_Turno_1').clone().attr('id', 'Descripcion_Turno_' + i).fadeIn('slow');
            $('#Descripcion_Turno_' + h).after(newElem);
        }

        var horarioTurno_HTML = '<a class="tag"><span>' + Horario + '</span></a>';
        var descripcionEtapa_HTML = '';

        var fisico = 0; var tecnico = 0;
        var tactico = 0; var futbol = 0;

        for (j = 1; j <= Etapas; j++) {
            var TipoActividad = document.getElementById("txt_AltaEtapaWF_Actividad_" + i + '_' + j).value;

            if (TipoActividad == "Físico") fisico++;
            if (TipoActividad == "Técnico") tecnico++;
            if (TipoActividad == "Táctico") tactico++;
            if (TipoActividad == "Fútbol") futbol++;

            descripcionEtapa_HTML += '<h2 class="title">';
            descripcionEtapa_HTML += '<a>ETAPA ' + j + '</a>';
            descripcionEtapa_HTML += '</h2> <br />';
            descripcionEtapa_HTML += '<p class="excerpt">';
            descripcionEtapa_HTML += '<span><b>Tipo de actividad:</b> ' + TipoActividad + '</span><br />';
            descripcionEtapa_HTML += '<span><b>Descripción:</b> ' + document.getElementById("txt_AltaEtapaWF_Descripcion_" + i + '_' + j).value + '</span><br />';
            descripcionEtapa_HTML += '<span><b>Materiales:</b> ' + document.getElementById("txt_AltaEtapaWF_MaterialesDeTrabajo_" + i + '_' + j).value + '</span>';
            descripcionEtapa_HTML += '</p>';
        }

        arr.push({ x: 'Turno ' + Horario, y: tecnico, z: fisico, a: tactico, b: futbol });

        // Añado todo el HTML generado para remarcar el horario del turno.-
        $('#Descripcion_Turno_' + i).find('.tags').html(horarioTurno_HTML);
        // Añado todo el HTML generado para las etapas de este turno.-
        $('#Descripcion_Turno_' + i).find('.block_content').html(descripcionEtapa_HTML);
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
