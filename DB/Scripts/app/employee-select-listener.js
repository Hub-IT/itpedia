/**
 * Listens for changes on select list with employees. When an employee is selected, it instruct the browser to retrieve asynchrously the possible number of customers.
 */
$(function () {

    $('#EmployeesID').change(function () {

        $('#TransactionsDivID').hide();

        var url = $('#CompanyEmployeeFormID').data('customerlistaction');

        $.getJSON(url + '/' + $('#EmployeesID').val(), function (data) {

            var items = '<option>Select Customers</option>';

            $.each(data, function (i, customer) {
                items += "<option value='" + customer.Value + "'>" + customer.Text + "</option>";
            });

            $('#CustomersID').html(items);
            $('#CustomersDivID').show();
        });
    });
});