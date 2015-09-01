/**
 * @author Unkown
 * @author Rizart Dokollari <r.dokollari@gmail.com>
 * @since 9/1/2015
 * 
 * Listen for a change on select list with customers. When this change happens, asynchrounsly retrieve the possible number of transactions. 
 * When done retreiving those numbers, save them to a select list, and show them to user.
 * 
 */
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