$(document).ready(function () {

    PartialGrid();

});

function PartialGrid() {
    
    $.ajax({
        url: '/Veiculo/Grid',
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