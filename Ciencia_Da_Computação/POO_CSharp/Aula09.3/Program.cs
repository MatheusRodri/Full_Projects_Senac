using Aula08._1;
using Aula09._3;

Camera camera = new Camera();
CameraDeSeguranca cameraDeSeguranca = new CameraDeSeguranca();


Estagiario caio = new Estagiario("Caio", 0.1f);
Analista wanessa = new Analista("Wanessa", 50f);
Diretor Matheus = new Diretor("Matheus", 950545f);
Policial policial = new Policial("Peçanha");

camera.show(wanessa);
cameraDeSeguranca.show(policial);

