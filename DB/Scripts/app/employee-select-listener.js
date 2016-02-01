/**
 * @author Unkown
 * @author Rizart Dokollari <r.dokollari@gmail.com>
 * @since 9/1/2015
 * 
 * Listen for a change on select list with employees. When this change happens, asynchrounsly retrieve the possible number of customers. 
 * When done retreiving those numbers, save them to a select list, and show them to user.
 * 
 */
$(function() {

    $("#employees").change(function() {

        $("#TransactionsDiv").hide();
        $("#CustomersDiv").hide();

        var url = $("#CompanyEmployeeFormId").data("customerlistaction");

        $.getJSON(url + "/" + $("#employees").val(), function(data) {

            var items = "<option>Select customers</option>";

            $.each(data, function(i, customer) {
                items += "<option value='" + customer.Value + "'>" + customer.Text + "</option>";
            });

            $("#customers").html(items);
            $("#CustomersDiv").show();
        });
    });
});