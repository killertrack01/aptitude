$(function () {
    $('#table1').DataTable({
        "paging": true,
        "lengthChange": false,
        "searching": true,
        "ordering": false,
        "info": false,
        "autoWidth": true,
        "responsive": false,
        "scrollX": false,
        "scrollY": false,
        "stateSave": true,
        "pageLength": 10,
    });
});