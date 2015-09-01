$(function () {

    $('#CustomersID').change(function () {

        var url = $('#CompanyEmployeeFormID').data('transactionlistaction');

        $.getJSON(url + '/' + $('#CustomersID').val(), function (data) {

            var items = '<option>Select Transactions</option>';

            $.each(data, function (i, transaction) {
                items += "<option value='" + transaction.Value + "'>" + transaction.Text + "</option>";
            });

            $('#TransactionPMsID').html(items);
            $('#TransactionsDivID').show();
        });
    });

});