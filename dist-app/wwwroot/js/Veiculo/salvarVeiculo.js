$(document).ready(function () {

    VerificarAcao();

    $('#valor').keyup(function () {
        FormatarValor();
    });

});

function somenteNumero (campo){
    campo.value = campo.value.replace(/[^0-9.]/g, '').replace(/(\..*?)\..*/g, '$1');
}

function AtualizarDrops() {
    
    var proprietarioId = $('#prop').val();
    var marcaId = $('#marca').val();
    var statusId = $('#status').val();

    statusId = CodigoStatus(statusId);

    if (proprietarioId > 0)
        $("#proprietarioId").val(proprietarioId);

    if (marcaId > 0)
        $("#marcaId").val(marcaId);

    if (proprietarioId > 0)
        $("#statusId").val(statusId);
}

function CodigoStatus(statusId) {

    if (statusId == 'Disponivel')
        statusId = 1;
    else if (statusId == 'Indisponivel')
        statusId = 2;
    else if (statusId == 'Vendido')
        statusId = 3;
    else
        statusId = 0;

    return statusId;
}

function VerificarAcao() {

    var id = $("#id").val();

    if (id > 0)
        AtualizarDrops();

};

function SalvarVeiculo() {

    var veiculoDTO = CriarObjVeiculo();
    veiculoDTO.Id = $('#id').val();
    veiculoDTO.ProprietarioId = $('#proprietarioId').val();
    veiculoDTO.MarcaId = $('#marcaId').val();
    veiculoDTO.Renavam = $('#renavam').val();
    veiculoDTO.Modelo = $('#modelo').val();
    veiculoDTO.AnoFabricacao = $('#fabricacao').val();
    veiculoDTO.AnoModelo = $('#ano').val();
    veiculoDTO.Quilometragem = $('#quilometragem').val();
    veiculoDTO.Valor = $('#valor').val();
    veiculoDTO.Status = $('#statusId').val();

    $.ajax({
        url: '/Veiculo/SalvarVeiculo',
        type: 'POST',
        cache: false,
        data: { veiculoDTO: veiculoDTO },
        success: function (data) {

            if (data) {
                window.location.href = '/Veiculo';
                alert("sucesso");
            } else {
                alert("Renavam existente");
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert("Falha ao realizar ação");
        }
    });

}

function CriarObjVeiculo() {

    var veiculoDTO = new Object();
    veiculoDTO.Id = 0;
    veiculoDTO.ProprietarioId = 0;
    veiculoDTO.MarcaId = 0;
    veiculoDTO.Renavam = null;
    veiculoDTO.Modelo = null;
    veiculoDTO.AnoFabricacao = 0;
    veiculoDTO.AnoModelo = 0;
    veiculoDTO.Quilometragem = 0;
    veiculoDTO.Valor = 0;
    veiculoDTO.Status = 0;

    return veiculoDTO;
}

function FormatarValor() {

    var elemento = document.getElementById('valor');
    var valor = elemento.value;

    valor = valor + '';
    valor = parseInt(valor.replace(/[\D]+/g, ''));
    valor = valor + '';
    valor = valor.replace(/([0-9]{2})$/g, ",$1");

    if (valor.length > 6) {
        valor = valor.replace(/([0-9]{3}),([0-9]{2}$)/g, ".$1,$2");
    }

    elemento.value = valor;
    if (valor == 'NaN') elemento.value = '';
}