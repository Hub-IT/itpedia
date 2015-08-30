$(function () {

    $('#EmployeesDivID').hide();
    $('#CustomersDivID').hide();
    $('#TransactionsDivID').hide();
    $('#SubmitID').hide();

    $('#CompaniesID').change(function () {
        var URL = $('#CompanyEmployeeFormID').data('employeeListAction');
        $.getJSON(URL + '/' + $('#CompaniesID').val(), function (data) {
            var items = '<option>Select Employees</option>';
            $.each(data, function (i, employee) {
                items += "<option value='" + employee.Value + "'>" + employee.Text + "</option>";
                
            });
            $('#EmployeesID').html(items);
            $('#EmployeesDivID').show();

        });
    });

    $('#EmployeesID').change(function () {
        $('#CustomersDivID').show();
      /*  $('#TransactionsDivID').show();*/
        /*$('#SubmitID').show();*/
    });
});