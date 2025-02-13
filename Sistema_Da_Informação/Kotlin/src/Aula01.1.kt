fun main() {
    println("================================Inicio===================================")

    val numero = 10
    val numero2 = 20
    println("Imprime a variavel: ${numero}")
    println("Imprime a condição: ${numero % 2 == 0}")
    println("Imprime a multiplicação: ${numero * numero}")
    println("Imprime a soma: ${numero + numero2} ")

    println("=================================Fim=====================================")

    println("================================Inicio===================================")

    val a = 25.30f
    val b = 10.29f

    println("Soma: ${soma(a,b)}")
    println("Subtração: ${subtracao(a,b)}")
    println("Multiplicação: ${multiplicacao(a,b)}")
    println("Divisão: ${divisao(a,b)}")

    println("=================================Fim=====================================")


}

fun soma(x:Float, y:Float):Float{
    return x + y
}

fun subtracao(x:Float,y:Float):Float{
    return x - y
}

fun multiplicacao(x: Float,y: Float):Float{
    return x * y
}

fun divisao (x: Float,y: Float):Float{
    return x/y
}