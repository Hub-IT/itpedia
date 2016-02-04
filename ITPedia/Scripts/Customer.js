$(function () {

    $('#TransactionsDivID').hide();

    $('#CustomersID').change(function () {

        var url = $('#CompanyEmployeeFormID').data('customerlistaction');

        $.getJSON(url + '/' + $('#CustomersID').val(), function (data) {

            var items = '<option>Select customers</option>';

            $.each(data, function (i, customer) {
                items += "<option value='" + customer.Value + "'>" + customer.Text + "</option>";
            });

            $('#CustomersID').html(items);
            $('#CustomersDivID').show();

        });
    });

    $('#CustomersID').change(function () {
        $('#TransactionsDivID').show();
    });
});