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
function executeFunctionByName(functionName, context /*, args */)
{
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
function Mensaje_Exito(mensaje)
{
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
function Mensaje_Error(mensaje)
{
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
function Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje)
{
    var Datos = JSON.stringify(ObjetoVista);
    $.ajax({
        type: "POST",
        url: InvocarUrl,
        data: "{obj:" + Datos + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        error: function (XMLHttpRequest, textStatus, errorThrown){
            alert("Request: " + XMLHttpRequest.toString()
             + "\n\nStatus: " + textStatus
              + "\n\nError: " + errorThrown);
            Resultado = null;
        },
        success: function (result) {
            if (result.d.Exito)
            {
                executeFunctionByName("AltaEquipo_Guardar_Exito", window, result.d, Mensaje);
            }
            else
            {
                executeFunctionByName("AltaEquipo_Guardar_Error", window, result.d);
            }
        }
    });
}
//=======================================================================================================

//=======================================================================================================
//=======================================================================================================
function AltaEquipo_Guardar()
{
    var Mensaje = "Ha registrado el Equipo correctamente!";
    var InvocarUrl = "/AltaEquipoWF.aspx/GuardarDatos";

    var img = document.getElementById("Imagen_Escudo");
    var imgCanvas = document.createElement("canvas"),
    imgContext = imgCanvas.getContext("2d");
    // Make sure canvas is as big as the picture
    imgCanvas.width = image.width;
    imgCanvas.height = image.height;
    // Draw image into canvas element
    imgContext.drawImage(image, 0, 0, image.width, image.height);
    // Save image as a data URL
    imgInfom = imgCanvas.toDataURL("image/png");

    var ObjetoVista = {
        NombreEquipo: document.getElementById("txt_AltaEquipoWF_NombreEquipo").value,
        Siglas: document.getElementById("txt_AltaEquipoWF_Siglas").value,
        SitioWeb: document.getElementById("txt_AltaEquipoWF_SitioWeb").value,
        TelefonoDeContacto: document.getElementById("txt_AltaEquipoWF_TelefonoDeContacto").value,
        Imagen: imgInfom
    };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje);
}

function AltaEquipo_Nuevo()
{   
    AltaEquipo_Limpiar();
}

function AltaEquipo_Limpiar()
{
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

function AltaEquipo_Guardar_Exito(Respuesta, Mensaje)
{
    Mensaje_Exito(Mensaje);
    if (Respuesta != null && Respuesta != false && Respuesta.Exito != false) {
        document.getElementById("btn_AltaEquipo_Nuevo").style.display = 'inline-block';
        document.getElementById("btn_AltaEquipo_Guardar").style.display = 'none';
        document.getElementById("btn_AltaEquipo_Limpiar").style.display = 'none';
    }
}

function AltaEquipo_Guardar_Error(Respuesta)
{
    var errores = Respuesta.Errores;
    for (i = 0; i < errores.length; i++) {
        Mensaje_Error(errores[i]);
    }
}
//=======================================================================================================

//=======================================================================================================
function AltaJugador_Guardar()
{
    var Mensaje = "Ha registrado el Jugador correctamente!";
    var InvocarUrl = "/AltaJugadorWF.aspx/GuardarDatos";

    var ObjetoVista = {
        Dni: document.getElementById("txt_AltaJugadorWF_DNI").value,
        Apellido: document.getElementById("txt_AltaJugadorWF_Apellido").value,
        Nombre: document.getElementById("txt_AltaJugadorWF_Nombre").value,
        Apodo: document.getElementById("txt_AltaJugadorWF_Apodo").value,
        FechaNacimiento: document.getElementById("txt_AltaJugadorWF_FechaNacimiento").value,
        Altura: document.getElementById("txt_AltaJugadorWF_Altura").value,
        Peso: document.getElementById("txt_AltaJugadorWF_Peso").value,
        Imagen: null
    };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje);
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