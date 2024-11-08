function abrirModal() {
    document.getElementById('modal').style.display = 'flex';
}

function fecharModal() {
    document.getElementById('modal').style.display = 'none';
}

function ativaTextArea() {
    const checkbox = document.getElementById('exibeTextArea');
    const textarea = document.getElementById('minhaTextArea');

    if (checkbox.checked) {
        textarea.style.display = 'block';
        textarea.style.margin = '0 auto';
        textarea.disabled = false;
    } else {
        textarea.value = '';
        textarea.style.display = 'none';
        textarea.disabled = true;
    }
}