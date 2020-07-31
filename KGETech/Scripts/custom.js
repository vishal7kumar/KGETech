$(document).ready(function() {
    $(".sideMenuToggler").on("click",
        function() {
            $(".wrapper").toggleClass("active");
        });

    var adjustSidebar = function() {
        $('.sidebar').slimScroll({
            height: document.documentElement.clientHeight - $('.navbar').outerHeight()
        });
    };

    adjustSidebar();

    $(window).resize(function() {
        adjustSidebar();
    });

    $('#dob').datepicker({
        format: "dd/mm/yyyy",
        autoclose: true,
    });
    $('#doj').datepicker({
        format: "dd/mm/yyyy",
        autoclose: true,
    });
});