$(function () {
    // Set the events for the external login buttons
    $('.fb').on('click', function () {
        $('#provider').val('facebook');
        $('#ExternalLogin').submit();
    });
    
    $('.tw').on('click', function () {
        $('#provider').val('twitter');
        $('#ExternalLogin').submit();
    });
});
