/**
 * @author Rizart Dokollari <r.dokollari@gmail.com>
 * @since 9/1/2015
 * 
 * Listen for a change on select list with employees. When this change happens, asynchrounsly retrieve the possible number of customers. 
 * When done retreiving those numbers, save them to a select list, and show them to user.
 * 
 */
$(function() {

    $("#employee-criterion").change(function() {

        $("#transaction-criterion").prop("disabled", true);
        $("#customer-criterion").prop("disabled", true);

        var url = $("#criteria-form").data("get-customer-criterias-by-employee-criteria-id-url") + "?employeeId=" + $(this).val() + "&industryId=" + $("#industryCriterias").val();

        $.getJSON(url, function(data) {

            var items = "<option>Select customers</option>";

            $.each(data, function(i, customer) {
                items += "<option value='" + customer.Value + "'>" + customer.Text + "</option>";
            });

            $("#customer-criterion").html(items);
            $("#customer-criterion").prop("disabled", false);
        });
    });
});