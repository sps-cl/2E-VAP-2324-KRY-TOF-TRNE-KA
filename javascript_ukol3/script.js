var platno = document.getElementById("platno")
var kontext = platno.getContext("2d")
var stredKruhuX = 100;
var stredKruhuY = 100;
platno.onmousemove = pohyb;

function nakresli() {
    kontext.clearRect(0,0,platno.clientWidth,platno.clientHeight);
    kontext.beginPath();
    kontext.arc(stredKruhuX,stredKruhuY,50,0,2*Math.PI);
    kontext.fillStyle = "purple";
    kontext.fill();
    kontext.fillStyle = "yellow";
    kontext.fillRect(200,200,100,100);
        requestAnimationFrame(nakresli);

}

function pohyb(event) {
    let rect = platno.getBoundingClientRect();
    stredKruhuX = event.clientX - rect.left;
    stredKruhuY = event.clientY - rect.top;
}

    

nakresli();
