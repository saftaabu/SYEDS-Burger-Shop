// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//calulcation for the burger
function Calculation() {

    var Ex_Patties = document.getElementById("ExPatties");
    var Ex_Patties_value = Ex_Patties.value;

    var bacon = document.getElementById("bacon");
    var bacon_value = bacon.value;

    var price = 5;

    if (bacon_value == "Yes") {
        price += 1;
    }

    if (Ex_Patties_value == "1" || Ex_Patties_value == 1) {
        price += 0.5;
    }
    else if (Ex_Patties_value == "2" || Ex_Patties_value == 2) {
        price += 1;
    }
    else if (Ex_Patties_value == "3" || Ex_Patties_value == 3) {
        price += 1.5;
    }

    document.getElementById("Cost").innerHTML = price;

    $("#Cost").val("$"+ price);

}
