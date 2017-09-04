//=======================================================================================================
// Este método recibe un mensaje para mostrarlo como un pop-up de Éxito.-
//=======================================================================================================
function Mensaje_Exito(mensaje)
{
    var Msg_Exito = new PNotify({
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
    var Msg_Error = new PNotify({
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
        },
        success: function (result) {
            if (result.d.Exito)
            {
                Mensaje_Exito(Mensaje)
            }
            else
            {
                var errores = result.d.Errores;
                for (i = 0; i < errores.length; i++)
                {
                    Mensaje_Error(errores[i]);
                }
            }
        }
    });
}
//=======================================================================================================

function AltaEquipo_Guardar()
{
    var Mensaje = "Ha registrado el Equipo correctamente!";
    var InvocarUrl = "/AltaEquipoWF.aspx/GuardarDatos";

    var ObjetoVista = {
        NombreEquipo: document.getElementById("txt_AltaEquipoWF_NombreEquipo").value,
        Siglas: document.getElementById("txt_AltaEquipoWF_Siglas").value,
        SitioWeb: document.getElementById("txt_AltaEquipoWF_SitioWeb").value,
        TelefonoDeContacto: document.getElementById("txt_AltaEquipoWF_TelefonoDeContacto").value,
        ImagenEscudo: 'ImagenEscudo: TODO'
    };

    Guardar_Objeto(InvocarUrl, ObjetoVista, Mensaje);
}


$('[id*=UpdatePanel_AltaEquipo_Botones]').on("click", '[id*=btnGuardar]', function () {
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(Mensaje_Exito);
});

var btnCust = '<button type="button" class="btn btn-default" title="Add picture tags" ' +
    'onclick="alert(\'Call your custom code here.\')">' +
    '<i class="glyphicon glyphicon-tag"></i>' +
    '</button>';

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
    defaultPreviewContent: '<img src="/Template/fileInput/img/Escudo.png" alt="Su Escudo" style="width:160px"><h6 class="text-muted">Seleccionar un escudo</h6>',
    layoutTemplates: { main2: '{preview} {remove} {browse}' },
    allowedFileExtensions: ["jpg", "png", "gif"]
});