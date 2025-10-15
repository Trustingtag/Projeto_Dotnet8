document.addEventListener('DOMContentLoaded', function () {
    const selectSala = document.getElementById('sala');
    const btnCarregar = document.getElementById('btnCarregar');

    if (!selectSala || !btnCarregar) return;

    function atualizarEstadoBotao() {
        const salaSelecionada = selectSala.value.trim() !== '';
        btnCarregar.disabled = !salaSelecionada;
        btnCarregar.style.opacity = salaSelecionada ? '1' : '0.6';
        btnCarregar.style.cursor = salaSelecionada ? 'pointer' : 'not-allowed';
    }

    // Estado inicial
    atualizarEstadoBotao();

    // Monitora mudanças
    selectSala.addEventListener('change', atualizarEstadoBotao);
});
