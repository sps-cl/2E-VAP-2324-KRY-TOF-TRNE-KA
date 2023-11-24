let a = 0;
let b = 0;

let h = 1;
let c = 0;
function zvysitA(){
    a++;
    console.log(a);
}
function zvysitB(){
    b++;
    console.log(b);
}
function vypsatCisla(){
    c = a*b
    while (h<=c) {
        console.log(h);
        h+=2;
    }
}
function resetovat() {
    a = 0;
    b = 0;
}