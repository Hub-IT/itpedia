/**
 * @author Unkown
 * @author Rizart Dokollari <r.dokollari@gmail.com>
 * @since 9/1/2015
 * 
 * Listen for a change on select list with customers. When this change happens, asynchrounsly retrieve the possible number of transactions. 
 * When done retreiving those numbers, save them to a select list, and show them to user.
 * 
 */
$(function() {

    $("#customerCode").change(function() {

        var url = $("#CompanyEmployeeFormId").data("transactionlistaction") + "/" + $(this).val();

        $.getJSON(url, function(data) {

            var items = "<option>Select Transaction Per Month</option>";

            $.each(data, function(i, transaction) {
                items += "<option value='" + transaction.Value + "'>" + transaction.Text + "</option>";
            });

            $("#transactionCode").html(items);
            $("#TransactionsDiv").show();
        });
    });

});