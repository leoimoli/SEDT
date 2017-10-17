//=======================================================================================================
// Variables Globales.
//=======================================================================================================
var Msg_Exito = null;
var Msg_Error = null;
var Resultado = null;

function mySiguiente() {
    // Cantidad de turnos actual.-
    var Turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;
    // Contenedor donde se ubican todos los campos referentes a los turnos.-
    var containerTurnos = document.getElementById("container_AltaEntrenamientoWF_Turnos");
    // Tomamos el elemento Row que vamos a clonar.-
    var rowClonar = document.getElementById("container_Clonar");
    // Por las dudas chequeamos que los turnos sean válidos.-
    if (Turnos != null && Turnos != 0 && Turnos != "0") {
        // Por las dudas chequeamos que los contenedores sean válidos.-
        if (containerTurnos != null && containerTurnos != "null") {
            var countChild = containerTurnos.childNodes.length;
            // Limpiamos el contenido de todos los elementos dentro del div contenedor.-
            for (i = 0; i < countChild - 1; i++) { containerTurnos.removeChild(containerTurnos.lastChild); }
            for (i = 1; i <= Turnos; i++) {
                //Primero clonamos el elemento.-
                var elementoClonado = jQuery.extend({}, containerTurnos.firstChild)
                // Agregamos un nuevo elemento
                elementoClonado.innerHTML = elementoClonado.innerHTML.replace(/_0/g, '_' + i);
                containerTurnos.appendChild(elementoClonado);
            }
        }
    }
    /*
    var Etapas = document.getElementById("txt_AltaEntrenamientoWF_CantidadEtapas").value;
    if (Etapas != null && Etapas != 0 && Etapas != "0")
    {

    }*/

    //alert("Terminó el Siguiente!");
}
function myAnterior() {
    //alert("Terminó el Anterior!");
}
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
//=======================================================================================================
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
//=======================================================================================================

//=======================================================================================================
// Métodos referentes a la pantalla: AltaEquipoWF.-
//=======================================================================================================
function AltaEquipo_Guardar() {
    var Mensaje = "Ha registrado el Equipo correctamente!";
    var InvocarUrl = "/AltaEquipoWF.aspx/GuardarDatos";

    var ObjetoVista = {
        NombreEquipo: document.getElementById("txt_AltaEquipoWF_NombreEquipo").value,
        Siglas: document.getElementById("txt_AltaEquipoWF_Siglas").value,
        SitioWeb: document.getElementById("txt_AltaEquipoWF_SitioWeb").value,
        TelefonoDeContacto: document.getElementById("txt_AltaEquipoWF_TelefonoDeContacto").value,
        Imagen: null
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

    var ObjetoVista = {};

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
//=======================================================================================================
function AltaEquipo_Guardar_Exito(Respuesta, Mensaje) {
    Mensaje_Exito(Mensaje);
    if (Respuesta != null && Respuesta != false && Respuesta.Exito != false) {
        document.getElementById("btn_AltaEquipo_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaEquipo_Guardar").style.display = 'none';
        document.getElementById("btn_AltaEquipo_Limpiar").style.display = 'none';
    }
}

function AltaEquipo_Guardar_Error(Respuesta) {
    var errores = Respuesta.Errores;
    for (i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
}

function AltaJugador_Guardar_Exito(Respuesta, Mensaje) {
    Mensaje_Exito(Mensaje);
    if (Respuesta != null && Respuesta != false && Respuesta.Exito != false) {
        document.getElementById("btn_AltaJugador_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaJugador_Guardar").style.display = 'none';
        document.getElementById("btn_AltaJugador_Limpiar").style.display = 'none';
    }
}

function AltaJugador_Guardar_Error(Respuesta) {
    var errores = Respuesta.Errores;
    for (i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
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
$(function () {
    $('#btnAdd').click(function () {
        // Checks to see how many "duplicatable" input fields we currently have
        var num = $('.clonedInput').length;

        // Cantidad de turnos actual.-
        var Turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;

        // En caso de que haya la misma cantidad no se hace nada.-
        if (num == Turnos) return false;

        // En caso de que haya menos una cantidad mayor eliminamos.-
        if (Turnos < num) {
            var cantEliminar = num - Turnos;
            if (cantEliminar == 1) {
                cantEliminar++;
            }
            for (i = num; i >= cantEliminar; i--) {
                $('#container_Clonar_' + i).remove();
            }
            return false;
        }

        var cantAgregar = Turnos - num;
        for (i = num; i < Turnos; i++) {
            newNum = new Number(num + 1);      // The numeric ID of the new input field being added, increasing by 1 each time
            newElem = $('#container_Clonar_' + 1).clone().attr('id', 'container_Clonar_' + newNum).fadeIn('slow'); // create the new element via clone(), and manipulate it's ID using newNum value

            /*  This is where we manipulate the name/id values of the input inside the new, cloned element
                Below are examples of what forms elements you can clone, but not the only ones.
                There are 2 basic structures below: one for an H2, and one for form elements.
                To make more, you can copy the one for form elements and simply update the classes for its label and input.
                Keep in mind that the .val() method is what clears the element when it gets cloned. Radio and checkboxes need .val([]) instead of .val('').
            */
            /*
            // H2 - section
            newElem.find('.heading-reference').attr('id', 'ID' + newNum + '_reference').attr('name', 'ID' + newNum + '_reference').html('Entry #' + newNum);

            // Title - select
            newElem.find('.label_ttl').attr('for', 'ID' + newNum + '_title');
            newElem.find('.select_ttl').attr('id', 'ID' + newNum + '_title').attr('name', 'ID' + newNum + '_title').val('');

            // First name - text
            newElem.find('.label_fn').attr('for', 'ID' + newNum + '_first_name');
            newElem.find('.input_fn').attr('id', 'ID' + newNum + '_first_name').attr('name', 'ID' + newNum + '_first_name').val('');

            // Last name - text
            newElem.find('.label_ln').attr('for', 'ID' + newNum + '_last_name');
            newElem.find('.input_ln').attr('id', 'ID' + newNum + '_last_name').attr('name', 'ID' + newNum + '_last_name').val('');

            // Flavor - checkbox
            // Note that each input_checkboxitem has a unique identifier "-0". This helps pair up duplicated checkboxes and labels correctly. A bit verbose, at the moment.
            newElem.find('.label_checkboxitem').attr('for', 'ID' + newNum + '_checkboxitem');
            newElem.find('.input_checkboxitem-0').attr('id', 'ID' + newNum + '_checkboxitem-0').attr('name', 'ID' + newNum + '_checkboxitem').val([]);
            newElem.find('.input_checkboxitem-1').attr('id', 'ID' + newNum + '_checkboxitem-1').attr('name', 'ID' + newNum + '_checkboxitem').val([]);
            newElem.find('.input_checkboxitem-2').attr('id', 'ID' + newNum + '_checkboxitem-2').attr('name', 'ID' + newNum + '_checkboxitem').val([]);
            newElem.find('.input_checkboxitem-3').attr('id', 'ID' + newNum + '_checkboxitem-3').attr('name', 'ID' + newNum + '_checkboxitem').val([]);

            // Flavor - checkbox labels
            // Note that each checkboxitem has a unique identifier "-0". This helps pair up duplicated checkboxes and labels correctly. A bit verbose, at the moment.
            newElem.find('.checkboxitem-0').attr('for', 'ID' + newNum + '_checkboxitem-0');
            newElem.find('.checkboxitem-1').attr('for', 'ID' + newNum + '_checkboxitem-1');
            newElem.find('.checkboxitem-2').attr('for', 'ID' + newNum + '_checkboxitem-2');
            newElem.find('.checkboxitem-3').attr('for', 'ID' + newNum + '_checkboxitem-3');

            // Skate - radio
            newElem.find('.label_radio').attr('for', 'ID' + newNum + '_radioitem');
            newElem.find('.input_radio').attr('id', 'ID' + newNum + '_radioitem').attr('name', 'ID' + newNum + '_radioitem').val([]);

            // Email - text
            newElem.find('.label_email').attr('for', 'ID' + newNum + '_email_address');
            newElem.find('.input_email').attr('id', 'ID' + newNum + '_email_address').attr('name', 'ID' + newNum + '_email_address').val('');

            // Twitter handle (for Bootstrap demo) - append and text
            newElem.find('.label_twt').attr('for', 'ID' + newNum + '_twitter_handle');
            newElem.find('.input_twt').attr('id', 'ID' + newNum + '_twitter_handle').attr('name', 'ID' + newNum + '_twitter_handle').val('');

            */
            // Insert the new element after the last "duplicatable" input field
            $('#container_Clonar_' + i).after(newElem);
            //$('#ID' + newNum + '_title').focus();
            //Actualizamos el nuevo valor autoIncremental.-
            num++;
        }
        // Enable the "remove" button. This only shows once you have a duplicated section.
        $('#btnDel').attr('disabled', false);

        // Right now you can only add 4 sections, for a total of 5. Change '5' below to the max number of sections you want to allow.
        //if (newNum == 5)
        //  $('#btnAdd').attr('disabled', true).prop('value', "You've reached the limit"); // value here updates the text in the 'add' button when the limit is reached 
    });

    $('#btnDel').click(function () {
        // Confirmation dialog box. Works on all desktop browsers and iPhone.
        if (confirm("Are you sure you wish to remove this section? This cannot be undone.")) {
            var num = $('.clonedInput').length;
            // how many "duplicatable" input fields we currently have
            $('#entry' + num).slideUp('slow', function () {
                $(this).remove();
                // if only one element remains, disable the "remove" button
                if (num - 1 === 1)
                    $('#btnDel').attr('disabled', true);
                // enable the "add" button
                $('#btnAdd').attr('disabled', false).prop('value', "add section");
            });
        }
        return false; // Removes the last section you added
    });
    // Enable the "add" button
    $('#btnAdd').attr('disabled', false);
    // Disable the "remove" button
    $('#btnDel').attr('disabled', true);
});
//=======================================================================================================
//=======================================================================================================