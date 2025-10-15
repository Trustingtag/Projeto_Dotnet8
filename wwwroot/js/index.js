document.querySelectorAll(".menu-level > li > a").forEach((menuItem) => {
  menuItem.addEventListener("click", function (e) {
    const submenu = this.nextElementSibling;
    if (submenu && submenu.classList.contains("submenu")) {
      e.preventDefault();
      if (submenu.style.maxHeight) {
        submenu.style.maxHeight = null;
      } else {
        submenu.style.maxHeight = submenu.scrollHeight + "px";
      }
    }
  });
});

function toggleIcon(event) {
  event.preventDefault();

  const icon = document.getElementById("menu-icon");
  const submenu = event.target.closest("li").querySelector(".submenu");

  submenu.classList.toggle("open");

  if (submenu.classList.contains("open")) {
    icon.src = "/IMG/chevron-up-solid.svg";
  } else {
    icon.src = "/IMG/chevron-down-solid.svg";
  }
}

function toggleSubmenu(button) {
  const submenu = button.nextElementSibling;
  if (submenu && submenu.classList.contains("submenu")) {
    if (submenu.style.maxHeight) {
      submenu.style.maxHeight = null;
    } else {
      submenu.style.maxHeight = submenu.scrollHeight + "px";
    }
  }
}

document.addEventListener("DOMContentLoaded", function () {
  const nomePc = document.getElementById("nomePc");
  const selectSala = document.getElementById("salaPc");
  const novaSala = document.getElementById("novaSala");
  const btnEnviar = document.getElementById("btnEnviarPc");

  if (!nomePc || !selectSala || !novaSala || !btnEnviar) return;

  function atualizarBotao() {
    const nomePreenchido = nomePc.value.trim() !== "";
    const salaSelecionada = selectSala.value.trim() !== "";
    const novaSalaPreenchida = novaSala.value.trim() !== "";

    // Só habilita se o nome estiver preenchido E (uma sala for escolhida OU nova sala preenchida)
    const habilitar = nomePreenchido && (salaSelecionada || novaSalaPreenchida);

    btnEnviar.disabled = !habilitar;
    btnEnviar.style.opacity = habilitar ? "1" : "0.6";
    btnEnviar.style.cursor = habilitar ? "pointer" : "not-allowed";
  }

  // Estado inicial
  atualizarBotao();

  // Observa mudanças em todos os campos
  nomePc.addEventListener("input", atualizarBotao);
  selectSala.addEventListener("change", atualizarBotao);
  novaSala.addEventListener("input", atualizarBotao);
});
