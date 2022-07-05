$(document).ready(function () {

    PartialGrid();

});

function PartialGrid() {
    
    $.ajax({
        url: '/Proprietario/Grid',
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