function checkBoxClick(a, b) {
    var full = document.getElementById(a);
    var liability = document.getElementById(b);

    if (full.checked == true) {
        full.disabled = false;
        liability.checked = false;
        liability.disabled = true;
    }
    else if (liability.checked == true) {
        liability.disabled = false;
        full.checked = false;
        full.disabled = true;
    }
    else {
        full.disabled = false;
        full.checked = false;
        liability.disabled = false;
        liability.checked = false;
    }
}