/**
 * @author Unkown
 * @author Rizart Dokollari <r.dokollari@gmail.com>
 * @since 9/1/2015
 * 
 * Listen for a change on select list with companies. When this change happens, asynchrounsly retrieve the possible number of employees. 
 * When done retreiving those numbers, save them to a select list, and show them to user.
 * 
 */
$(function () {

    $('#CompaniesID').change(function () {

        $('#EmployeesDivID').show();
        $('#CustomersDivID').hide();
        $('#TransactionsDivID').hide();
        $('#SubmitID').hide();

        var url = $('#CompanyEmployeeFormID').data('employeelistaction');

        $.getJSON(url + '/' + $('#CompaniesID').val(), function (data) {

            var items = '<option>Select Employees</option>';

            $.each(data, function (i, employee) {
                items += "<option value='" + employee.Value + "'>" + employee.Text + "</option>";
            });

            $('#EmployeesID').html(items);
            $('#EmployeesDivID').show();
        });
    });
});
