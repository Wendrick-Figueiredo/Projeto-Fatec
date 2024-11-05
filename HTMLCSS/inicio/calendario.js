const calendarBody = document.getElementById('calendar-body');
const monthYear = document.getElementById('month-year');
const prevMonthBtn = document.getElementById('prev-month');
const nextMonthBtn = document.getElementById('next-month');
const monthGrid = document.getElementById('month-grid');
const yearGrid = document.getElementById('year-grid');

let currentDate = new Date();
const today = new Date(); 
const maxDate = new Date(today.getFullYear() + 5, today.getMonth()); 

function renderCalendar() {
    const year = currentDate.getFullYear();
    const month = currentDate.getMonth();

    const firstDayOfMonth = new Date(year, month, 1).getDay();
    const daysInMonth = new Date(year, month + 1, 0).getDate();
    const daysInPrevMonth = new Date(year, month, 0).getDate();

    monthYear.textContent = `${currentDate.toLocaleString('default', { month: 'long' })} ${year}`;

    calendarBody.innerHTML = '';

    let dayCount = 1;
    let prevMonthDayCount = daysInPrevMonth - firstDayOfMonth + 1;

    for (let i = 0; i < 6; i++) {
        const row = document.createElement('tr');

        for (let j = 0; j < 7; j++) {
            const cell = document.createElement('td');

            if (i === 0 && j < firstDayOfMonth) {
                cell.textContent = prevMonthDayCount;
                cell.classList.add('inactive'); // Classe para dias do mês anterior
                prevMonthDayCount++;
            } else if (dayCount > daysInMonth) {
                cell.textContent = dayCount - daysInMonth;
                cell.classList.add('inactive'); // Classe para dias do mês seguinte
                dayCount++;
            } else {
                const date = new Date(year, month, dayCount);
                cell.textContent = dayCount;

                // Destaque para o dia atual
                if (date.toDateString() === today.toDateString()) {
                    cell.classList.add('today');
                } else {
                    cell.classList.add('current-month'); // Classe para dias do mês atual
                }

                cell.addEventListener('click', () => {
                    alert(`Data selecionada: ${date.toDateString()}`);
                });

                dayCount++;
            }

            row.appendChild(cell);
        }

        calendarBody.appendChild(row);
    }
}

function navigateMonth(direction) {
    const newDate = new Date(currentDate.getFullYear(), currentDate.getMonth() + direction);

    if (newDate > maxDate) {
        alert('Você não pode avançar mais de 5 anos!');
        return;
    }

    currentDate = newDate;
    renderCalendar();
}

function toggleMonthGrid() {
    monthGrid.classList.toggle('hidden');
}

function toggleYearGrid() {
    yearGrid.innerHTML = '';
    const currentYear = currentDate.getFullYear();
    const startYear = currentYear - 5; 
    const endYear = currentYear + 5;   

    for (let year = startYear; year <= endYear; year++) {
        const yearDiv = document.createElement('div');
        yearDiv.textContent = year;
        yearDiv.dataset.year = year;
        yearDiv.addEventListener('click', selectYear);
        yearGrid.appendChild(yearDiv);
    }

    yearGrid.classList.toggle('hidden');
}

function selectMonth(event) {
    if (event.target.dataset.month !== undefined) {
        const selectedMonth = parseInt(event.target.dataset.month);
        currentDate.setMonth(selectedMonth);
        renderCalendar();
        monthGrid.classList.add('hidden'); 
    }
}

function selectYear(event) {
    if (event.target.dataset.year !== undefined) {
        const selectedYear = parseInt(event.target.dataset.year);
        currentDate.setFullYear(selectedYear);
        renderCalendar();
        yearGrid.classList.add('hidden'); 
    }
}

monthYear.addEventListener('click', function() {
    if (monthGrid.classList.contains('hidden')) {
        toggleMonthGrid();
    } else {
        toggleYearGrid();
    }
});

prevMonthBtn.addEventListener('click', () => navigateMonth(-1));
nextMonthBtn.addEventListener('click', () => navigateMonth(1));

renderCalendar();

function abrirCalendario() {
    document.getElementById('calendario').style.display = 'flex';
}

function fecharCalendario() {
    document.getElementById('calendario').style.display = 'none';
}
