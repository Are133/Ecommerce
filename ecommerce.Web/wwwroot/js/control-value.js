let checkIsActive = document.getElementById("checkActivo");
let checkIsAdmin = document.getElementById("checkAdmin")


checkIsActive.addEventListener("change", validCheckboxIsActive, false);
checkIsAdmin.addEventListener("change", validCheckboxIsAdmin, false);


function validCheckboxIsActive() {
    let checked = checkIsActive.checked;

    if (checked) {
        checkIsActive.value = true; 
    } else {
        checkIsActive.value = false;
    }
}

function validCheckboxIsAdmin() {
    let checked = checkIsAdmin.checked;

    if (checked) {
        checkIsAdmin.value = true;
    } else {
        checkIsAdmin.value = false;
    }
}
