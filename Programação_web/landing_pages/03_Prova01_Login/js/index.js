const mode = document.getElementById("mode_icon")


//function teste(){
//    const form = document.getElementById('login_form')
//
//    if(mode.classList.contains('fa-moon')){
//        mode.classList.remove('fa-moon')
//        mode.classList.add('fa-sun')
//
//        form.classList.add('dark')
//
//    }else {
//        mode.classList.remove('fa-sun')
//        mode.classList.add('fa-moon')
//
//        form.classList.add('light')
//    }
//
//}
//
//mode.addEventListener('click',teste)


 mode.addEventListener('click',()=>{
     const form = document.getElementById('login_form')

     if(mode.classList.contains('fa-moon')){
         mode.classList.remove('fa-moon')
         mode.classList.add('fa-sun')

         form.classList.add('dark')

         return;
     }

     mode.classList.remove('fa-sun')
     mode.classList.remove('dark')
     mode.classList.add('fa-moon')

 })