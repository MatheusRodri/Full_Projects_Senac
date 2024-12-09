var horas = document.getElementById("horas")
var minutos = document.getElementById("minutos")
var segundos = document.getElementById("segundos")


setInterval(()=>{
    var data = new Date()

    horasTime = data.getHours()
    minutosTime = data.getMinutes()
    segundosTime = data.getSeconds()


    if(horasTime >= 0 && horasTime <= 9){
        horasTime = "0"+horasTime
    }else if(horasTime == 0){
        horasTime = "0"+horasTime
    }
    if(minutosTime > 0 && minutosTime <= 9){
        minutosTime = "0"+minutosTime;
    }else if(minutosTime == 0){
        minutosTime = "0"+minutosTime;
    }
    if(segundosTime > 0 && segundosTime <= 9){
        segundosTime = "0"+segundosTime;
    }else if(segundosTime == 0){
        segundosTime = "0"+segundosTime;
    }


    horas.innerHTML = horasTime
    minutos.innerHTML = minutosTime
    segundos.innerHTML = segundosTime

},1000)

