//Atribuir a variável o método que vai selecionar o ícone da lua
const mode = document.getElementById('mode_icon');
//atribuir ao ícone ação de clique
mode.addEventListener('click', () => {
    const form = document.getElementById('login_form');
//Atribuir a variável que vai acionar o formulário
    if(mode.classList.contains('fa-moon')) { // testa se o ícone lua é verdadeiro
        mode.classList.remove('fa-moon');// se, sim, remove o ícone lua
        mode.classList.add('fa-sun');// troca pelo ícone sol

        form.classList.add('dark'); // executar os seletores do dark mode (css)
        return ; //para a execução da função nesse ponto.
    }
    
    mode.classList.remove('fa-sun'); // se o ícone for o sol remove
    mode.classList.add('fa-moon');// e adiciona o ícone lua

    form.classList.remove('dark');// limpa a execução dos seletor dark (css)
});