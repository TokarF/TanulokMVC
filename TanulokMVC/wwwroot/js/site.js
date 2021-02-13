let buttonsTorles = document.querySelectorAll("#btn-tanulo-torles");
let btnTorles = document.querySelector("#btn-torles");
let btnMegsem = document.querySelector("#btn-megsem");

let btnTorlesBaseHref = btnTorles.attributes.href.value;

for (var i = 0; i < buttonsTorles.length; i++) {
    buttonsTorles[i].addEventListener("click", function () {
        console.log(this.dataset.value);
        btnTorles.attributes.href.value += "&tanuloId=" + this.dataset.value;
    })
};

btnMegsem.addEventListener("click", function () {
    btnTorles.attributes.href.value = btnTorlesBaseHref;
});



function w3_open() {
    document.getElementById("mySidebar").style.display = "block";
    document.getElementById("myOverlay").style.display = "block";
}

function w3_close() {
    document.getElementById("mySidebar").style.display = "none";
    document.getElementById("myOverlay").style.display = "none";
}
