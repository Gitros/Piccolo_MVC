
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall'},
        "columns": [
            { data: 'position', "width": "10%"},
            { data: 'ingredients', "width": "25%" },
            { data: 'priceSmall', "width": "5%" },
            { data: 'priceBig', "width": "5%" },
            { data: 'category.name', "width": "10%" },
            { data: 'productType.type', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class= "w-75 btn-group" role="group">
                        <a href="/admin/product/edit?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i>Edit</a>
                        <a href="/admin/product/delete/${data}" class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i>Delete</a>
                    </div>`
                },
                "width": "20%"
            }
        ]
    });
} 