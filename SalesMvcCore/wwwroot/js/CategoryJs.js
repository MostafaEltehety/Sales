$(document).ready(function () {
    GetCateogries();
});

function GetCateogries() {
    $.ajax({
        url:'/Categories/GetCategories',
        type: 'get',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8',
        success: function (response) {
            if (response == null || response == undefined || response.length == 0) {
                var object = '';
                object += '<tr class="table-light">';
                object += '<td colspan="3" class="text-center">' + 'Categories not available' + '</td>';
                object += '</tr>';
                $('#tblBody').html(object);
            } else {
                var object = '';
                $.each(response, function (index, item) {
                    object += '<tr class="table-light">';
/*                    object += '<td>'+item.id+'<td/>';*/
                    object += '<td>'+item.name+'</td>';
                    object += '<td>' + item.description + '</td>';
                    object += '<td> <a href="" class="btn btn-outline-success btn-sm" onclick="Edit(' + item.id + ')"><i class="bi bi-pencil-fill"></i></a> <a href="" class="btn btn-outline-danger btn-sm" onclick="Delete(' + item.id + ')"><i class="bi bi-trash3-fill"></i></a> '+'</td>';
                    $('#tblBody').html(object);
                });
            }
        },
        error: function () {
            alert('Unable to read data');
        }
    });
}