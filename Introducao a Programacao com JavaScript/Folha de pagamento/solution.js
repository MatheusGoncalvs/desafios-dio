let colaboradorNumero = parseInt(gets());
let horasTrabalhadas = parseInt(gets());
let valorHora = parseFloat(gets());
let salary = parseFloat(horasTrabalhadas * valorHora).toFixed(2); // Digite aqui o calculo do salário
console.log("NUMBER = " + colaboradorNumero);
console.log("SALARY = U$ " + salary);