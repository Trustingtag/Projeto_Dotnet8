document.querySelectorAll('.menu-level > li > a').forEach(menuItem => {
    menuItem.addEventListener('click', function (e) {
        const submenu = this.nextElementSibling;
        if (submenu && submenu.classList.contains('submenu')) {
            e.preventDefault();
            if (submenu.style.maxHeight) {
                submenu.style.maxHeight = null;
            } else {
                submenu.style.maxHeight = submenu.scrollHeight + 'px'; 
            }
        }
    });
});

function toggleIcon(event) {
    event.preventDefault();

    const icon = document.getElementById('menu-icon');
    const submenu = event.target.closest('li').querySelector('.submenu');

   
    submenu.classList.toggle('open');

    
    if (submenu.classList.contains('open')) {
        icon.src = '/IMG/chevron-up-solid.svg';
    } else {
        icon.src = '/IMG/chevron-down-solid.svg';
    }
}

function toggleSubmenu(button) {
    const submenu = button.nextElementSibling;
    if (submenu && submenu.classList.contains('submenu')) {
        if (submenu.style.maxHeight) {
            submenu.style.maxHeight = null;
        } else {
            submenu.style.maxHeight = submenu.scrollHeight + 'px';
        }
    }
}

