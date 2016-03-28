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

    $("#EmployeeCriteria").change(function() {

        $("#TransactionCriterion").prop("disabled", true);
        $("#CustomerCriterion").prop("disabled", true);

        var url = $("#FormId").data("get-customer-criterias-by-employee-criteria-id-url") + "?employeeId=" + $(this).val() + "&industryId=" + $("#industryCriterias").val();

        $.getJSON(url, function(data) {

            var items = "<option>Select customers</option>";

            $.each(data, function(i, customer) {
                items += "<option value='" + customer.Value + "'>" + customer.Text + "</option>";
            });

            $("#CustomerCriterion").html(items);
            $("#CustomerCriterion").prop("disabled", false);
        });
    });
});