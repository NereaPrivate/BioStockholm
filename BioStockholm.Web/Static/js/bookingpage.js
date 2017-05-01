$(document).ready(function () {

    var chkbox_list = new Array('seat_1_1', 'seat_1_2', 'seat_1_3', 'seat_1_4');

    console.log(chkbox_list);


    var shuffled_arr = shuffle(chkbox_list);
    $('input[type=checkbox]').prop('checked', false);
    for (var i = 0; i < 2; i++) {
        $('#' + shuffled_arr[i]).prop('checked', true);
        $('#' + shuffled_arr[i]).attr("disabled", true);
    }
    function shuffle(o) {
        for (var j, x, i = o.length; i; j = parseInt(Math.random() * i), x = o[--i], o[i] = o[j], o[j] = x);
        return o;
    };


    console.log("ready!");

    

  


    $('td')
        .click(function () {
            console.log($('input:checkbox:checked').length);
            console.log($("seats: " + $('#quantitySeats').val()));
            if ($('input:checkbox:checked').length >= $('#quantitySeats').val()) {

                console.log("disable");

                $('input:checkbox:not(:checked)')
                    .each(function() {
                        $(this).attr("disabled", true);
                    });
            } else {
                $('input:checkbox:not(:checked)')
                    .each(function () {
                        $(this).attr("disabled", false);
                    });
            }

        });
});