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

    $("#employeeCode").change(function() {

        $("#transactionCode").prop("disabled", true);
        $("#customerCode").prop("disabled", true);

        var url = $("#CompanyEmployeeFormId").data("customerlistaction") + "/employeeCode" + $(this).val();

        $.getJSON(url, function(data) {

            var items = "<option>Select customers</option>";

            $.each(data, function(i, customer) {
                items += "<option value='" + customer.Value + "'>" + customer.Text + "</option>";
            });

            $("#customerCode").html(items);
            $("#customerCode").prop("disabled", false);
        });
    });
});