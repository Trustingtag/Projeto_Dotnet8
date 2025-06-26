function toggleDropdown(btn) {
    const box = btn.parentElement.nextElementSibling;
    box.style.display = box.style.display === "none" ? "block" : "none";
}