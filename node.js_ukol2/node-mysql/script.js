const jmena = ["dominik", "matyas", "david", "petr", "pavel", "jan", "kryštof", "karel", "ivan", "oliver", "antonin", "radim", "richard", "adam", "filip", "michal", "milan", "matej"];
const prijmeni = ["wepper", "dohnal", "dvorak", "novak", "komarek", "kucera", "kysela", "prazak", "sindelar", "sindler", "polak", "novotny", "marek", "trnecka", "trnavsky", "harasta", "fiala", "kunc"];

function jmenaPr() {
    const randomName = jmena[Math.floor(Math.random() * jmena.length)];
    const randomSurName = prijmeni[Math.floor(Math.random() * prijmeni.length)];
    const randomId = Math.floor(Math.random() * (1000 - 0) + 0);
    return { jmena: randomName, prijmeni: randomSurName, id: randomId};
}

function send() {
    fetch("http://localhost:7707/insert",
        {
            headers: {
                'content-type': 'application/json'
            },
            method:"post",
            body: JSON.stringify(jmenaPr())
        }
    )
}