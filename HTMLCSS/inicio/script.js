function atualizarRelogio() {
    const agora = new Date();
    const horas = agora.getHours().toString().padStart(2, '0');
    const minutos = agora.getMinutes().toString().padStart(2, '0');
    const segundos = agora.getSeconds().toString().padStart(2, '0');

    document.getElementById('horas').textContent = horas;
    document.getElementById('minutos').textContent = minutos;
    document.getElementById('segundos').textContent = segundos;
}

setInterval(atualizarRelogio, 1000);
atualizarRelogio();


const header = document.querySelector('.header');
const main = document.querySelector('.main');

header.addEventListener('mouseenter', () => {
    main.classList.add("moverFixed");
});

header.addEventListener('mouseleave', () => {
    main.classList.remove("moverFixed");
});


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
