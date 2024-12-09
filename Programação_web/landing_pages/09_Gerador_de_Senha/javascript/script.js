function  getChartTypes(){

    const uppercase =  document.querySelector("#include_uppercase").checked;
    const lowercase =  document.querySelector("#include_lowercase").checked;
    const number =  document.querySelector("#include_number").checked;
    const specialCharacter =  document.querySelector("#include_special_character").checked;

    const charTypes = [];

    if(uppercase){
        charTypes.push("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
    }
    if(lowercase){
        charTypes.push("abcdefghijklmnopqrstuvwxyz")
    }
    if(number){
        charTypes.push("0123456789");
    }
    if(specialCharacter){
        charTypes.push("+-_!@#$%¨&*() :.<,>[]{}|\\/?^~`\";'=%`^´çÇ@&*çÁàÃã");
    }

    return charTypes;
}

function  getPasswordSize(){

    const size = document.querySelector('#size').value;

    if(isNaN(size) || size < 4 || size > 128){
        message('Tamanho invalido digite um número entre 4 e 128','danger')
    }

    return size;
}

function generatePassword(size,charTypes){

    let passwordGenerate = '';

    const selectedChars = charTypes.join('')
    charTypes.forEach(type =>{
        passwordGenerate  += type[Math.floor(Math.random()*type.length)];
    })
    while (passwordGenerate.length < size){
        passwordGenerate += selectedChars[Math.floor(Math.random()*selectedChars.length)];
    }
    passwordGenerate =passwordGenerate.split('').sort(() => Math.random() - 0.5).join('');
    return passwordGenerate;
}



function message(text,status = 'success'){
    Toastify({
        text: text,
        duration: 5000,
        style:{
            background: status === 'success' ? 'green' : 'red',
            boxShadow: 'none'
        }
    }).showToast();
}

document.querySelector("#generate").addEventListener('click',()=>{
  const size = getPasswordSize()
  const charTypes = getChartTypes();

  if(!size){
      return;
  }
  if(!charTypes.length){
      message('Selecione Pelo Menos um tipo de caracter !','danger')
      return;
  }

  const passwordGenerate = generatePassword(size,charTypes);
  document.querySelector("#password_container").classList.add("show");
  document.querySelector("#password").textContent = passwordGenerate;

})






