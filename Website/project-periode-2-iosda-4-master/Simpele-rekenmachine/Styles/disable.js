
    document.addEventListener("contextmenu", function(e){
    e.preventDefault();
        $('#bs_Warning').show();
        window.setTimeout(hide, 2000);
}, false); /*dit is voor de rechter muisknop*/


    if ('matchMedia' in window) {
        // Chrome, Firefox, and IE 10 support mediaMatch listeners
        window.matchMedia('print').addListener(function(media) {
            if (media.matches) {
                beforePrint();
            } else {
                // Fires immediately, so wait for the first mouse movement
                $(document).one('mouseover', afterPrint); //als er in die window geprint is dan gaat hij naar de functie before print, anders laat hij de content weer zien
            }
        });
    } else {
        // IE and Firefox fire before/after events
        $(window).on('beforeprint', beforePrint);
        $(window).on('afterprint', afterPrint);
    } // dit is voor internet explorer en firefox

    function beforePrint() {
        $("#AllContent").hide();
        $(".PrintMessage").show();
    }

    function afterPrint() {
        $(".PrintMessage").hide();
        $("#AllContent").show(); //dit laat print message hiden en all content showwen
    } /*dit is voor print screen*/



    document.onkeydown = function(e) {
        if(event.keyCode == 123) {
           /* alert("Copyright HQS")*/
            $('#bs_Warning').show();
            window.setTimeout(hide, 2000);
            return false;
        } //dit stopt f12
        if(e.ctrlKey && e.shiftKey && e.keyCode == 'I'.charCodeAt(0)) {
            $('#bs_Warning').show();
            window.setTimeout(hide, 2000);
            return false;
        } //dit stop control shift 1
        if(e.ctrlKey && e.shiftKey && e.keyCode == 'P'.charCodeAt(0)) {
            $('#bs_Warning').show();
            window.setTimeout(hide, 2000);
            return false;
        } //dit stopt control shijft p
        if(e.ctrlKey && e.keyCode == 'V'.charCodeAt(0)) {
            $('#bs_Warning').show();
            window.setTimeout(hide, 2000);
            return false;
        } // dit stopt control v
        if(e.ctrlKey && e.keyCode == 'J'.charCodeAt(0)) {
            $('#bs_Warning').show();
            window.setTimeout(hide, 2000);
            return false;
        } //dit stopt control j
        if(e.ctrlKey && e.keyCode == 'C'.charCodeAt(0)) {
            $('#bs_Warning').show();
            window.setTimeout(hide, 2000);
            return false;
        } //dit stopt control c
        if (e.ctrlKey && e.keyCode == 'U'.charCodeAt(0)){
            $('#bs_Warning').show();
            window.setTimeout(hide, 2000);
            return false;
        }
    }
    function hide (){
        $('#bs_Warning').hide();
    } // deze functie is aangemaakt om de alert te hiden na een bepaalde tijd




