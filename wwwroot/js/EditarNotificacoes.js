document.addEventListener('DOMContentLoaded', function () {
    const selectSala = document.getElementById('salaPc');
    const btnEnviar = document.getElementById('btnEnviarPc');

    if (!selectSala || !btnEnviar) return;

    function atualizarBotao() {
        const salaSelecionada = selectSala.value.trim() !== '';
        btnEnviar.disabled = !salaSelecionada;
        btnEnviar.style.opacity = salaSelecionada ? '1' : '0.6';
        btnEnviar.style.cursor = salaSelecionada ? 'pointer' : 'not-allowed';
    }

    // Estado inicial
    atualizarBotao();

    // Atualiza sempre que o usuário muda a seleção
    selectSala.addEventListener('change', atualizarBotao);
});
