let button = document.getElementById("modal_window_button");
let modal = document.getElementById("modal_window");

let openModal = () => {
    modal.style.display = "block";
}

let closeModal = () => {
    modal.style.display = "none";
}

button.addEventListener("click", () => {
    openModal();
});