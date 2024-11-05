const express = require('express');
const fs = require('fs');
const app = express();
const PORT = 3000;

app.use(express.json());
app.use(express.static('public')); // Para servir arquivos estáticos

const filePath = 'numbers.txt';

// Rota para gerar um número aleatório
app.post('/generate', (req, res) => {
    fs.readFile(filePath, 'utf8', (err, data) => {
        if (err) {
            console.error(err);
            return res.status(500).send('Erro ao ler o arquivo');
        }

        const generatedNumbers = data.split('\n').filter(Boolean).map(Number);
        const numbersSet = new Set(generatedNumbers);
        let randomNumber;

        do {
            randomNumber = Math.floor(1000 + Math.random() * 9000); // Gera um número entre 1000 e 9999
        } while (numbersSet.has(randomNumber));

        fs.appendFile(filePath, `${randomNumber}\n`, (err) => {
            if (err) {
                console.error(err);
                return res.status(500).send('Erro ao salvar o número');
            }
            res.json({ number: randomNumber });
        });
    });
});

// Rota para resetar os números
app.post('/reset', (req, res) => {
    fs.writeFile(filePath, '', (err) => {
        if (err) {
            console.error(err);
            return res.status(500).send('Erro ao resetar os números');
        }
        res.send('Números resetados com sucesso');
    });
});

app.listen(PORT, () => {
    console.log(`Servidor rodando em http://localhost:${PORT}`);
});