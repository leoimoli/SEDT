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

function Aplicar_Cambio_Solapa_Etapas_por_Turno()
{
    // Cantidad de turnos actual.-
    var Turnos = document.getElementById("txt_AltaEntrenamientoWF_CantidadTurnos").value;
    
    for (i = 1; i <= Turnos; i++)
    {
        // Cantidad de turnos actual.-
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
        for (k = num; k < EtapasActual; k++)
        {
            // The numeric ID of the new input field being added, increasing by 1 each time
            var newNum = new Number(num + 1);
            // create the new element via clone(), and manipulate it's ID using newNum value
            var newElem = $('#container_Clonar_EtapaSingular_' + i + '_' + 1).clone().attr('id', 'container_Clonar_EtapaSingular_' + i +'_'+ newNum).fadeIn('slow');
            $('#container_Clonar_EtapaSingular_' + i + '_' + 1).after(newElem);
            num++;
        }
    }
}

function Aplicar_Cambio_Solapa_Etapa()
{
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
    for (i = num; i < Turnos; i++)
    {
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

function Aplicar_Cambio_Solapa_Turno()
{
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
    for (i = num; i < Turnos; i++)
    {
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
    $('#btnAdd').click(function ()
    {
        Aplicar_Cambio_Solapa_Turno();
        Aplicar_Cambio_Solapa_Etapa();
        Aplicar_Cambio_Solapa_Etapas_por_Turno();
        return false; // Removes the last section you added
    });

    $('#btnDel').click(function ()
    {
        Aplicar_Cambio_Solapa_Turno();
        Aplicar_Cambio_Solapa_Etapa();
        Aplicar_Cambio_Solapa_Etapas_por_Turno();
        return false; // Removes the last section you added
    });

    // Enable the "add" button
    $('#btnAdd').attr('disabled', false);
    // Disable the "remove" button
    $('#btnDel').attr('disabled', true);
});
//=======================================================================================================
//=======================================================================================================
function ClockPicker_HoraSeleccionada()
{
    // Checks to see how many "duplicatable" input fields we currently have
    var num = $('.clonedInput').length;

    // Corroboramos que todas las fechas sean correctas entre si.
    for (i = 2; i <= num; i++)
    {
        var contador = i;
        var valorNuevo = $('#txt_AltaTurnoWF_Horario_' + contador).val();
        contador--;
        var valorActual = $('#txt_AltaTurnoWF_Horario_' + contador).val();
        valorActual = moment.utc(valorActual, 'hh:mm').add(1, 'hour').format('hh:mm');
        
        //input-group clockpicker Validacion
        if (valorActual > valorNuevo)
        {
            $('#container_Clonar_' + i).find('.fechaValidar').attr('class', 'form-control fechaValidar Validacion');
            $('#container_Clonar_' + i).find('#Error_Fecha_' + i).attr('class', 'Error_Fecha_Visible');
            $('#container_Clonar_' + i).find('.label-danger-Validacion').html("Puede arrancar el turno a partir de las " + valorActual + " o posterior.");
        }
        else
        {
            $('#container_Clonar_' + i).find('.fechaValidar').attr('class', 'form-control fechaValidar');
            $('#container_Clonar_' + i).find('#Error_Fecha_' + i).attr('class', 'Error_Fecha_Invisible');
        }
    }
    // .trigger('change')
}