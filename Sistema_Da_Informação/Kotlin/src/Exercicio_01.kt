data class ItemPiquenique(
    val nome: String,
    val item: String,
    val classificacao: Int // 1 - Doce, 2 - Salgado, 3 - Refrigerante
)

fun main() {
    val listaPiquenique = listOf(
        ItemPiquenique("Alice", "Bolo de chocolate", 1),
        ItemPiquenique("Bruno", "Salgadinhos", 2),
        ItemPiquenique("Carlos", "Refrigerante de cola", 3),
        ItemPiquenique("Diana", "Brigadeiros", 1),
        ItemPiquenique("Eduardo", "Coxinhas", 2),
        ItemPiquenique("Fernanda", "Suco de laranja", 3)
    )

    var qtd_refrigerante:Int = 0
    var qtd_doce:Int = 0
    var qtd_salgado:Int = 0

    for(item in listaPiquenique){
        if (item.classificacao == 1){
            qtd_doce++
        }else if (item.classificacao == 2){
            qtd_salgado++
        }else{
            qtd_refrigerante++
        }
    }


    println("Total de pessoas participantes: ${listaPiquenique.count()}")
    println("Quantidade de doces: ${qtd_doce}")
    println("Quantidade de refrigerantes: ${qtd_refrigerante}")
    println("Quantidade de salgado: ${qtd_salgado}")
}
