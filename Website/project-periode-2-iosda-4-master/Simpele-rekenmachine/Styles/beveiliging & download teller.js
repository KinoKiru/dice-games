document.onkeypress = function (event) {
    event = (event || window.event);
    if (event.keyCode === 123) {
        return false;
    }
}
document.onmousedown = function (event) {
    event = (event || window.event);
    if (event.keyCode === 123) {
        return false;
    }
}
document.onkeydown = function (event) {
    event = (event || window.event);
    if (event.keyCode === 123) {
        return false;
    }
}
function schakelCtrlUit(e)
{
//list all CTRL + key combinations you want to disable
    var verbodenToetsen = new Array('a', 'n', 'c', 'x', 'v', 'j' , 'w', 'i');
    var toets;
    var isCtrl;
    if(window.event)
    {
        toets = window.event.keyCode;     //Internet Explorer
        if(window.event.ctrlKey)
            isCtrl = true;
        else
            isCtrl = false;
    }
    else
    {
        toets = e.which;     //Firefox
        if(e.ctrlKey)
            isCtrl = true;
        else
            isCtrl = false;
    }
//Wanneer Ctrl is ingedrukt, kijk of er ook een andere toets is ingedrukt die in de Array voorkomt.
    if(isCtrl)
    {
        for(i=0; i<verbodenToetsen.length; i++)
        {
//Hoofdlettergevoeligheid eruitgehaald.
            if(verbodenToetsen[i].toLowerCase() === String.fromCharCode(toets).toLowerCase())
            {
                alert('Toets combinatie CTRL + '+String.fromCharCode(toets) +' is uitgeschakeld.');
                return false;
            }
        }
    }
    return true;
}

document.onkeydown = function(e) {
    if (e.keyCode === 123){
        alert('Dit is niet toegestaan');
        return false;
    }
    else if (e.ctrlKey && (e.keyCode === 86 || e.keyCode === 73 || e.keyCode === 117 || e.keyCode === 85 || e.keyCode === 67 || e.keyCode === 123)){
        alert('Dit is niet toegestaan');
        return false;
    } else {
        return true;
    }
}

//Download Teller
function klikTeller() {
    if (typeof(Storage) !== "undefined") {
        if (localStorage.clickcount) {
            localStorage.clickcount = Number(localStorage.clickcount)+1;
        } else {
            localStorage.clickcount = 1;
        }
        document.getElementById("result").innerHTML = "Dit bestand is " + localStorage.clickcount + " keer gedownload.";
    } else {
        document.getElementById("result").innerHTML = "Sorry, jou browser ondersteund dit niet.";
    }
}