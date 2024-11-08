const header = document.querySelector('header');
const main = document.querySelector('main');

header.addEventListener('mouseenter', () => {
    main.classList.add("moverFixed");
});

header.addEventListener('mouseleave', () => {
    main.classList.remove("moverFixed");
});