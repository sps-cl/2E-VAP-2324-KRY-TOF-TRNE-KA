
import url from 'url';
import path from 'path';
import express from 'express';
import {Person} from './person.js';
import mysql from 'mysql2';

const __dirname = path.dirname(url.fileURLToPath(import.meta.url));
const app = express();

app.use(express.static(__dirname));
app.use(express.urlencoded({extended: true}));
app.use(express.json());

const connection = mysql.createConnection({
    host: "127.0.0.1",
    user: "root",
    password: "root",
    database: "persons",
    port: 3306
});

connection.connect((error) => {
    if(error) {
        console.log(error.message);
    } else {
        console.log("pripojeno");
    }
});

app.post("/insert", (req, res) => {
    const person = req.body;
    console.log("Insert person");
    const query = `INSERT INTO PERSONS(jmena,prijmeni) VALUES('${person.jmena}','${person.prijmeni}');`;    
    connection.query(query, (err, data) => {
        console.log(err);
    }
    );
    res.end();
});

app.get("/", (req, res) => {
    res.sendFile(path.join(__dirname, "index.html"));
    res.end();
})

// endpoint pro random osobu
app.get("/persons", (req, res) => {
    const query = `SELECT * FROM PERSONS;`;    
    connection.query(query, (err, data) => {
        res.json(data);
        res.end();
    }
    );
    
});

app.listen(7707);