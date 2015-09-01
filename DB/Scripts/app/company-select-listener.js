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
