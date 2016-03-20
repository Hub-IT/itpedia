/**
 * @author Unkown
 * @editor Rizart Dokollari <r.dokollari@gmail.com>
 * @since 9/1/2015
 * 
 * Listen for a change on select list with companies. When this change happens, asynchrounsly retrieve the possible number of employees. 
 * When done retreiving those numbers, save them to a select list, and show them to user.
 * 
 */
$(function() {

    $("#industryCriterias").change(function() {

        $("#employeeCriterias").prop("disabled", false);
        $("#customerCriterias").prop("disabled", true);
        $("#transactionCriterias").prop("disabled", true);
        $("#Submit").prop("disabled", true);

        var url = $("#FormId").data("get-employee-criterias-by-industry-criteria-id-url") + "/" + $(this).val();

        $.getJSON(url, function(data) {
            var items = "<option>Select employees</option>";

            $.each(data, function(i, employee) {
                items += "<option value='" + employee.Value + "'>" + employee.Text + "</option>";
            });

            $("#employeeCriterias").html(items);
            $("#employeeCriteriasDiv").prop("disabled", false);
        });
    });
});