using Aula07._1;
using Aula07._1.Mamifero;


Zoologico zoologico = new Zoologico();

Cachorro cachorro1 = new Cachorro("Bilu",2,2.5f,"Marrom");
Gato gato = new Gato("Embraer",4,3.0f,"Branco");

zoologico.listadDeAnimais.Add(cachorro1);
zoologico.listadDeAnimais.Add(gato);

zoologico.chamada();
zoologico.barulho(cachorro1);
zoologico.barulho(gato);


//cachorro1.emitirSom();