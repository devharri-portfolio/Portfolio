
document.addEventListener("click", function (event) {
    if (event.target.classList.contains("nav-link")) {

        var navbarCollapse = document.getElementById('navbarNavAltMarkup');
        if (navbarCollapse.classList.contains("show")) {
            var bsCollapse = new bootstrap.Collapse(navbarCollapse, {
                toggle: true
            });
        }
    }
});

function mymessage() {
    alert("This message was triggered from the onload event");
}