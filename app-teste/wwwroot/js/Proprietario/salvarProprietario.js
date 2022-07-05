$(document).ready(function () {

    $("#cep").keyup(function () {
        BuscarCEP();
    });

    $("#logradouro").on("change", function () {
        AtualizarEndereco();
    });

    VerificarAcao();
});

function somenteNumero(campo) {
    campo.value = campo.value.replace(/[^0-9.]/g, '').replace(/(\..*?)\..*/g, '$1');
}

function VerificarAcao() {

    var id = $("#id").val();

    if (id > 0)
        QuebrarEndereco();

};

function QuebrarEndereco() {
    
    var endereco = $('#endereco').val();

    var arrayEndereco = endereco.split(' - ');

    RepopularEndereco(arrayEndereco);
}

function RepopularEndereco(arrayEndereco) {
    
    var rua = arrayEndereco[0];
    var logradouro = arrayEndereco[1];
    var bairro = arrayEndereco[2];
    var cidade = arrayEndereco[3];
    var uf = arrayEndereco[4];

    $("#rua").val(rua);
    $("#logradouro").val(logradouro);
    $("#bairro").val(bairro);
    $("#cidade").val(cidade);
    $("#uf").val(uf);

}

function AtualizarEndereco() {

    var endereco = $("#endereco").val();
    var logradouro = $("#logradouro").val();

    endereco = endereco.replace("@logradouro", logradouro);

    $("#endereco").val(endereco);
}

function BuscarCEP() {

    var url = 'https://brasilapi.com.br/api/cep/v1/';

    var cep = $("#cep").val();
    
    if (cep.length == 8) {

        $.ajax({
            url: url + cep,
            type: 'GET',
            cache: false,
            dataType: "json",
            success: function (data) {
                $("#rua").val(data.street);
                $("#bairro").val(data.neighborhood);
                $("#cidade").val(data.city);
                $("#uf").val(data.state);

                $('#endereco').val(data.street + " - @logradouro - " + data.neighborhood + " - " + data.city + " - " + data.state);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert(xhr.responseText);
            }
        });
    }
}

function SalvarProprietario() {

    var proprietarioDTO = CriarObjProprietario();
    proprietarioDTO.Id = $("#id").val();
    proprietarioDTO.Nome = $("#nome").val();
    proprietarioDTO.Email = $("#email").val();
    proprietarioDTO.Documento = $("#documento").val();
    proprietarioDTO.CEP = $("#cep").val();
    proprietarioDTO.Endereco = $("#endereco").val();
    proprietarioDTO.Status = $("#status").is(":checked");
     
    $.ajax({
        url: '/Proprietario/SalvarProprietario',
        type: 'POST',
        cache: false,
        data: { proprietarioDTO: proprietarioDTO },
        success: function (data) {
            window.location.href = '/Proprietario';
            alert("sucesso");
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(xhr.responseText);
        }
    });
}

function CriarObjProprietario() {
    var proprietarioDTO = new Object();
    proprietarioDTO.Id = 0;
    proprietarioDTO.Nome = null;
    proprietarioDTO.Documento = null;
    proprietarioDTO.Email = null;
    proprietarioDTO.CEP = null;
    proprietarioDTO.Endereco = null;
    proprietarioDTO.Status = true;
    return proprietarioDTO;
}