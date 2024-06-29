
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall'},
        "columns": [
            { data: 'position', "width": "15%"},
            { data: 'ingredients', "width": "15%" },
            { data: 'priceSmall', "width": "15%" },
            { data: 'priceBig', "width": "15%" },
            { data: 'category.name', "width": "15%" },
            { data: 'productType.type', "width": "15%" }
        ]
    });
} 