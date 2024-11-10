using Aula04._1;

User matheus = new User("Matheus","111.111.111-11");

Bilhete b1matheus = new Bilhete("estudante", matheus);

CentralDeRecarga picPay = new CentralDeRecarga("PicPay");
picPay.Recarregar(b1matheus,10.00f,"estudante");
picPay.Recarregar(b1matheus, 5.00f, "comum");

Transporte onibus675R10 = new Transporte("onibus",new Catraca(4.40f));
onibus675R10.catraca.Cobrar(b1matheus);
onibus675R10.catraca.Cobrar(b1matheus);
onibus675R10.catraca.Cobrar(b1matheus);
onibus675R10.catraca.Cobrar(b1matheus);

Onibus onibus607610 = new Onibus();
onibus607610.catraca.Cobrar(b1matheus);
onibus607610.catraca.Cobrar(b1matheus);
onibus607610.catraca.Cobrar(b1matheus);
onibus607610.catraca.Cobrar(b1matheus);

Trem trem = new Trem();
trem.catraca.Cobrar(b1matheus);