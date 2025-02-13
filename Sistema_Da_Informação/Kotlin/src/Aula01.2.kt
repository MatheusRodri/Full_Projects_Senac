fun main(){

    println("================================Troco====================================")
    val pago = 10.0
    val total = 3.50 + 5.00
    val troco = pago - total
    println("O troco é R$ $troco")
    println("=================================Fim=====================================")

    println("===============================Combustivel===============================")
    val distancia = 360
    val consumo = 12
    val litros = distancia/consumo
    println("A o consumo  é $litros por km")
    println("=================================Fim=====================================")

    println("===============================Permissão de idade================================")
    val idadePermitida = 18
    val idadeJovem = 16
    if (idadeJovem >= idadePermitida){
        println("Entrada Aprovada")
    }else{
        println("Entrada Negadas")
    }
    println("=================================Fim=====================================")

    println("===============================IMC================================")
    val peso = 55.0
    val altura = 1.55
    val imc =  peso/(altura * altura)

    println("seu IMC é: $imc")
    println("=================================Fim=====================================")

}