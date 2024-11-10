using Aula07._3;
using Aula07._3.Alunos;
using Aula07._3.Disciplina;
using Aula07._3.Professores;

AlunosGraduacao matheus = new AlunosGraduacao("Matheus",20);
AlunosGraduacao wanessa = new AlunosGraduacao("Wanessa", 20);
ProfessorEfetivo quintas = new ProfessorEfetivo("Quintas",45);
ProfessorHorista eliseu = new ProfessorHorista("Eliseu", 45);

Disciplina poo = new Disciplina("POO",quintas);
Disciplina algoritmo = new Disciplina("Algoritmos 2", eliseu);

Curso bcc = new Curso("bcc");

bcc.alunos.Add(matheus);
bcc.alunos.Add(wanessa);

bcc.disciplinas.Add(poo);
bcc.disciplinas.Add(algoritmo);


bcc.exibirInformacoes();

