<script>
     $(document).ready(function () {
         $(document).on('click', '.create, .update', function () {
             var id = $(this).closest('tr').find('p.id').val();
             var name = $(this).closest('tr').find('input.name').val();
             var surname = $(this).closest('tr').find('input.surname').val();
             var lastname = $(this).closest('tr').find('input.lastname').val();
             var date = $(this).closest('tr').find('input.date').val();
             var position = $(this).closest('tr').find('input.position').val();
             var companyId = $(this).closest('tr').find('input.compnyId').val();
             $.ajax({
                 type: 'POST',
                 url: '/Employee/Create',
                 data: { EmployeeID: id, Name: name, Surname: surname, Lastname: lastname, DateHiring: date, Position: position, CompanyID: companyId },
                 success: function (data) {
                     if ($(this).attr('class') != 'create') {
                         location.reload();
                     }
                 },
                 async: true
             });
         });
     });
$(document).ready(function () {
    $(document).on('click', '.delete', function () {
        var id = $(this).closest('tr').find('input.id').val();
        if (id == "") id = -1;
        var analysis = $(this).closest('tr').find('input.analysis').val();
        var date = $(this).closest('tr').find('input.date').val();
        var user_id = $(this).closest('tr').find('input.user_id').val();
        $.ajax({
            type: 'POST',
            url: '/analysis/delete',
            data: {id: id, analysis: analysis, date: date, user_id: user_id, action: $(this).attr('class')},
            success: function (data) {
                if ($(this).attr('class') != 'update') {
                    location.reload();
                }
            },
            async: true
        });
    });
});
</script>