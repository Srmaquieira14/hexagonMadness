const mysql = require('promise-mysql');

const hostval = "localhost";
const databaseval = "hexagonmadness";
const userval = "root";
const connection = mysql.createConnection({
    host: hostval,
    database: databaseval,
    user: userval,
    password: ""
});

const getConnection = () => {
    return connection;
}

const express = require('express');
const app = express();
const PORT = 8080;

app.use(express.json())

app.get('/records', async(req, res)=>{
    try{
    const connection = await getConnection();
    const result = await connection.query("SELECT * from records order by valor desc");
    res.json(result);
    } catch(e){
        res.status(500);
        res.send(e.message);
    }
});

app.post('/record', async(req, res) => {
    try{
    const {nombre, valor} = req.body;    
    const connection = await getConnection();
    const result = await connection.query("insert into records (nombre, valor) values ('"+nombre+"',"+valor+")");
    res.json(result);
    } catch(e){
        res.status(500);
        res.send(e.message);
    }
});

app.listen(
    PORT,
    () => console.log(`Funciona en http://localhost:${PORT}`)
)