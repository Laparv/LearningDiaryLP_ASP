// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




function openPopup() {
    popup.classList.add("open-popup");
}
function closePopup() {
    popup.classList.remove("open-popup");
}

function confirmDelete() {
    let answer = confirm("Are you sure you want to delete?")
    if (answer) {
        document.getElementById("deletion")
    }
}

function grey(object) {
    object.style.backgroundColor = '#d3d3d3';
}
function white(object) {
    object.style.backgroundColor = 'white';
}



