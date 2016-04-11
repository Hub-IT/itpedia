/**
 * @editor Rizart Dokollari <r.dokollari@gmail.com>
 * @since 9/1/2015
 * 
 * Listen for a change on select list with companies. When this change happens, asynchrounsly retrieve the possible number of employees. 
 * When done retreiving those numbers, save them to a select list, and show them to user.
 * 
 */
$(function() {
    $("#industry-criterion").change(function() {

        $("#employee-criterion").prop("disabled", false);
        $("#customer-criterion").prop("disabled", true);
        $("#transaction-criterion").prop("disabled", true);
        $("#sumbit-btn").prop("disabled", true);

        var url = $("#criteria-form").data("get-employee-criterias-by-industry-criteria-id-url") + "/" + $(this).val();

        console.log(url);

        $.getJSON(url, function(data) {
            var items = "<option>Select employees</option>";

            $.each(data, function(i, employee) {
                items += "<option value='" + employee.Value + "'>" + employee.Text + "</option>";
            });

            $("#EmployeeCriteria").html(items);
            $("#employeeCriteriasDiv").prop("disabled", false);
        });
    });
});