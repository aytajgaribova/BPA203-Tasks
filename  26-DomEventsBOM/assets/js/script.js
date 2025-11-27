let result = document.querySelector(".result");
let sumBtn = document.querySelector(".btn-success");
let subBtn = document.querySelector(".btn-info");
let mulBtn = document.querySelector(".btn-light");
let divBtn = document.querySelector(".btn-warning");

sumBtn.addEventListener = ("click", Sum);
subBtn.addEventListener = ("click", Sub);
mulBtn.addEventListener = ("click", Mul);
divBtn.addEventListener = ("click", Div);

function Sum() {
    if (CheckInputvalue()) {
        result.textContent = Number(inputOne.value) + Number(inputTwo.value);
    }
    ResetInputValue();
}

function Sub() {
    if (CheckInputvalue()) {
        result.textContent = Number(inputOne.value) - Number(inputTwo.value);
    }
    ResetInputValue();
}
function Mul() {
    if (CheckInputvalue()) {
        result.textContent = Number(inputOne.value) * Number(inputTwo.value);
    }
    ResetInputValue();
}
function Div() {
    if (CheckInputvalue()) {
        if (Number(inputTwo.value)==0) {
            alert("0-a bolmek olmaz");
            return;   
        }
        result.textContent = Number(inputOne.value) / Number(inputTwo.value);
    }
    ResetInputValue();
}
function CheckInputvalue() {
    if (inputOne.value == " " || inputTwo.value == " ") {
        alert("Please enter number!")
        return false;

    }
    if (isNaN(Number(inputOne.value)) || isNaN(Number(inputTwo.value))) {
        alert("eded cox boyukdur");
        return false;
        
    } return true;
}
function ResetInputValue() {
    inputOne.value = " ";
    inputTwo.value = " "
}