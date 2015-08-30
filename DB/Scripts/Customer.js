$(function () {

    
    $('#TransactionsDivID').hide();
    $('#SubmitID').hide();

    $('#CustomersID').change(function () {
        var URL = $('#CompanyEmployeeFormID').data('customerListAction');
        $.getJSON(URL + '/' + $('#CustomersID').val(), function (data) {
            var items = '<option>Select Customers</option>';
            $.each(data, function (i, customer) {
                items += "<option value='" + customer.Value + "'>" + customer.Text + "</option>";
                
            });
            $('#CustomersID').html(items);
            $('#CustomersDivID').show();

        });
    });

    $('#CustomersID').change(function () {
        /*$('#CustomersDivID').show();*/
        $('#TransactionsDivID').show();
        /*$('#SubmitID').show();*/
    });
});