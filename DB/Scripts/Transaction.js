$(function () {

    
    
    $('#SubmitID').hide();

    $('#TransactionPMsID').change(function () {
        var URL = $('#CompanyEmployeeFormID').data('transactionListAction');
        $.getJSON(URL + '/' + $('#TransactionPMsID').val(), function (data) {
            var items = '<option>Select Transactions</option>';
            $.each(data, function (i, transaction) {
                items += "<option value='" + transaction.Value + "'>" + transaction.Text + "</option>";
                
            });
            $('#TransactionPMsID').html(items);
            $('#TransactionPMsID').show();

        });
    });

    $('#TransactionPMsID').change(function () {
        /*$('#CustomersDivID').show();*/
        /*$('#TransactionsDivID').show();*/
        $('#SubmitID').show();
    });
});