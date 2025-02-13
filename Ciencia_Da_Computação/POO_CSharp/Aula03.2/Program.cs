using Aula03._2;

Heroi magoSup = new Heroi();
magoSup.nome = "Mago top";
magoSup.tipo = "Mago";
magoSup.status.forca = 50;
magoSup.status.defesa = 30;
magoSup.status.sorte = 50;
magoSup.status.vida = 80;

Monstro zordeSub = new Monstro();
zordeSub.nome = "Zorde Sub";
zordeSub.tipo = "Dragão";
zordeSub.status.forca = 55;
zordeSub.status.defesa = 20;
zordeSub.status.sorte = 12;
zordeSub.status.vida = 90;




for (int i = 0; magoSup.status.vida >=0 || zordeSub.status.vida >= 0 ; i++)
{
    Console.WriteLine($"Mostro vida: {zordeSub.status.vida} ");
    if (magoSup.status.vida < 0 || zordeSub.status.vida < 0)
    {
        if ( magoSup.status.vida < 0)
        {
            Console.WriteLine("Mostro ganhou");
            break;
        }
        else
        {
            Console.WriteLine("Heroi ganhou");
            break;
        }
    }
    else
    {
        magoSup.Atacar(zordeSub);
        zordeSub.Atacar(magoSup);
    }
    
}