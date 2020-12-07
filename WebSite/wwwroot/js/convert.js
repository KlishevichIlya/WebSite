let inputDollar = document.getElementById("inputDollar");
let inputEuro = document.getElementById("inputEuro");
const dol = 2.56;
const euro = 3.14;
inputDollar.oninput = function () {
    document.getElementById("outputDollar").innerHTML = (inputDollar.value / dol).toFixed(1);
}
inputEuro.oninput = function () {
    document.getElementById("outputEuro").innerHTML = (inputEuro.value / euro).toFixed(1);
}


