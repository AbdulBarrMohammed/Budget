$("#openTransactionModalBtn").on("click", function () {
    console.log('t modal');
    $("#addTransactionModal").modal("show");
});

function formatDateToISO(dateStr) {
    let d = new Date(dateStr);
    if (!isNaN(d)) {
        let month = (d.getMonth() + 1).toString().padStart(2, '0');
        let day = d.getDate().toString().padStart(2, '0');
        let year = d.getFullYear();
        return `${year}-${month}-${day}`;
    }
    return ''; // fallback if invalid
}



$(".openUpdateTransactionModalBtn").on("click", function () {
    var id = $(this).closest('tr').find('td:first').html();
    var date = $(this).closest('tr').find('td:eq(1) .transaction-date').html();
    var amount = $(this).closest('tr').find('.transaction-amount div').html();
    var title = $(this).closest('tr').find('.transaction-title').html();
    //var categoryId = $(this).closest('tr').find('td:eq(4)').html();
    var categoryId = $(this).closest('tr').find('.transaction-category').data('category-id');


    var formattedDate = formatDateToISO(date);

    // Trim and set the values into the modal form
    $('#Insert-transaction-form #InsertTransaction_Id').val($.trim(id));
    $('#Insert-transaction-form #InsertTransaction_Date').val(formattedDate);
    $('#Insert-transaction-form #InsertTransaction_Amount').val($.trim(amount));
    $('#Insert-transaction-form #InsertTransaction_Title').val($.trim(title));
    $('#Insert-transaction-form #InsertTransaction_CategoryId').val(categoryId);

    //$(`#Insert-transaction-form #InsertTransaction_CategoryId option[value=${categoryId}]`).attr('selected', 'selected');

    // Show the modal
    $('#addTransactionModal').modal("show");
});
