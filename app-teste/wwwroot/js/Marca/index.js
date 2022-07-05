$(document).ready(function() {

    PartialGrid();

});

function PartialGrid() {

    $.ajax({
        url: '/Marca/Grid',
        type: 'GET',
        cache: false,
        contentType: "html",
        success: function (data) {
            $("#_Grid").html(data);
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.responseText);
        }
    });

}

function CriarObjMarca() {
    var marcaDTO = new Object();
    marcaDTO.Id = 0;
    marcaDTO.Nome = null;
    marcaDTO.Status = null;

    return marcaDTO;
}

function AlterarStatusMarca(id) {
   
    var marcaDTO = CriarObjMarca();
    marcaDTO.Id = id;
     
    $.ajax({
        url: '/Marca/AlterarStatusMarca',
        type: 'PUT',
        cache: false,
        data: { marcaDTO: marcaDTO },
        success: function (data) {
            PartialGrid();
            alert("Status alterado!");
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.responseText);
        }
    });

}