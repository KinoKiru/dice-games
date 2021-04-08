
//Download Teller
function klikTeller() {
    if (typeof(Storage) !== "undefined") {
        if (localStorage.downloadklik) {
            localStorage.downloadklik = Number(localStorage.downloadklik)+1;
        } else {
            localStorage.downloadklik = 1;
        }
        document.getElementById("result").innerHTML = "Dit bestand is " + localStorage.downloadklik + " keer gedownload.";
    } else {
        document.getElementById("result").innerHTML = "Sorry, jou browser ondersteund dit niet.";
    }
}

