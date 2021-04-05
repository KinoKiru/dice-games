

//check of alles is ingevuld zoja dan gaat de knop aan
function buttonState(){
    const Username = document.getElementById("Username").value.trim();
    const password = document.getElementById("password").value.trim();
    let button = document.querySelector("[name='submitButton']")

    // als hier de username en of de password leeg zijn returnt hij false
    if(Username === '' || password === '') return false;
    // als hij volledig is dan zal hij disabled van de link/button afhalen en daarna de cookies maken
    button.classList.remove('disabled')
    document.cookie = "Username=" + Username +";expires= Thu, 01 Jan 2030 00:00:00 UTC; path=/;"
    document.cookie = "password=" + password +";expires= Thu, 01 Jan 2030 00:00:00 UTC; path=/;"
}



$(function(){
    $('#knopje').attr('disabled', 'disabled');
    $('input').change(buttonState);
})