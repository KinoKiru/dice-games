
let mission = document.getElementById("mission");
let portofolio =  document.getElementById('portfolio');
let contact =  document.getElementById('contact');
// check for saved 'darkMode' in localStorage
// check for saved 'darkMode' in localStorage
let darkMode = localStorage.getItem('darkMode');

const darkModeToggle = document.querySelector('#dark-mode-toggle');

const enableDarkMode = () => {
    // door middel van classlist toggle 'voeg' je een class toe aan die element
    document.body.classList.toggle('darkmode');
    mission.classList.toggle('darkmodeContainer');
    portofolio.classList.toggle('darkmodeContainer');
    contact.classList.toggle('darkmodeContainer');
    document.getElementById('dark-mode-toggle').checked = true;
    // 2. Update darkMode in localStorage
    localStorage.setItem('darkMode', 'enabled');
}

const disableDarkMode = () => {
    // hier verwijder je de class van de id's
    document.body.classList.remove('darkmode');
    mission.classList.remove('darkmodeContainer');
    portofolio.classList.remove('darkmodeContainer');
    contact.classList.remove('darkmodeContainer');
    document.getElementById('dark-mode-toggle').checked = false;
    // 2. Update darkMode in localStorage
    localStorage.setItem('darkMode', null);
}

// If the user already visited and enabled darkMode
// start things off with it on
if (darkMode === 'enabled') {
    enableDarkMode();
}

// When someone clicks the button
darkModeToggle.addEventListener('click', () => {
    // get their darkMode setting
    darkMode = localStorage.getItem('darkMode');

    // if it not current enabled, enable it
    if (darkMode !== 'enabled') {
        enableDarkMode();
        // if it has been enabled, turn it off
    } else {
        disableDarkMode();
    }
});

