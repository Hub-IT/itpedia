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

    $("#customerCriterias").change(function() {

        var url = $("#FormId").data("get-transaction-criterias-by-customer-criteeria-id-url") + "/" + $(this).val();

        $.getJSON(url, function(data) {
            var items = "<option>Select Transaction Per Month</option>";

            $.each(data, function(i, transaction) {
                items += "<option value='" + transaction.Value + "'>" + transaction.Text + "</option>";
            });

            $("#transactionCriterias").html(items);
            $("#transactionCriterias").prop("disabled", false);
        });
    });

});