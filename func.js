function tweak_font () {
    $("*").each(function () {
        $(this).css("font-family","ProximaNova");
        $(this).css("font-weight", "normal");
    });
}