//Változók
let buttonsTorles = document.querySelectorAll("#btn-tanulo-torles");
let btnTorles = document.querySelector("#btn-torles");
let btnMegsem = document.querySelector("#btn-megsem");

let btnTorlesBaseHref = btnTorles.attributes.href.value;

// Összes törlés gombnak meg kell nyitnia a modalt és át kell adni az osztály ID és tanulo ID-t a megerősítés gombnak
for (var i = 0; i < buttonsTorles.length; i++) {
    buttonsTorles[i].addEventListener("click", function () {
        console.log(this.dataset.value);
        btnTorles.attributes.href.value += "?" + "osztalyId=" + this.getAttribute("data-value-osztalyId") + "&tanuloId=" + this.getAttribute("data-value-tanuloId");
    })
};

// Ha mégsem törli a modálon a tanulót, akkor resetelni kell a megerősítés gomb linkjét
btnMegsem.addEventListener("click", function () {
    btnTorles.attributes.href.value = btnTorlesBaseHref;
});


// Navbar nyitás
function w3_open() {
    document.getElementById("mySidebar").style.display = "block";
    document.getElementById("myOverlay").style.display = "block";
}

// Navbar zárás
function w3_close() {
    document.getElementById("mySidebar").style.display = "none";
    document.getElementById("myOverlay").style.display = "none";
}
