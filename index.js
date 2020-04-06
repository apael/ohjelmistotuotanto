var express = require("express");
var mysql = require("mysql");
var bodyParser = require("body-parser");
var cors = require("cors");

const http = require('http');
const url = require('url');
const hostname = '127.0.0.1';
const port = process.env.PORT || 3002;

var app = express();
//app.use(bp.json());
//app.use(express.json());
app.use(cors());
//app.use(express.urlencoded());
app.use(bodyParser.urlencoded({
  extended: true
}));
app.use(express.static(__dirname + '/public'));

const path = require("path");

var connection = mysql.createConnection({
  host: 'localhost',
  user: 'x',  // HUOM! Älä käytä root:n tunnusta tuotantokoneella!!!!
  password: 'x',
  database: 'vn',
  port: '3307'//databaseport tähän

});
app.get('/', function (req, res) {
  res.statusCode = 200;
  res.sendFile('J:/projektit/ohjelmistotuotanto/index.html');
});

// --- GET varaukset	   ---
app.get("/varaukset", (req, res, n) => {

  if (req.query.id !== undefined) {
    var sql = ("SELECT * FROM varaus where asiakas_id='" + req.query.id + "';")

  } else
    var sql = ("SELECT * FROM`varaus` CROSS JOIN`lasku` ON`varaus`.`varaus_id` = `lasku`.`varaus_id` CROSS JOIN`asiakas` ON`varaus`.`asiakas_id` = `asiakas`.`asiakas_id`;")

  if (req.query.id == "k")
    var sql = ("SELECT * FROM varaus")

  console.log(sql);


  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });

});

// --- GET laskut ---
app.get("/laskut", (req, res, n) => {

  if (req.body.length > 0) {
    var sql = ("SELECT * FROM lasku where asiakas_id='" + req.body.asiakas_id + "';")

  } else
    var sql = ("SELECT * FROM lasku")


  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });

});

// --- GET palvelut ---
app.get("/palvelut", (req, res, n) => {

  if (req.body.length > 0) {
    var sql = ("SELECT * FROM lasku where toimintaalue_id='" + req.body.alue + "';")

  } else
    var sql = ("SELECT * FROM palvelu")


  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});

// --- GET toimialueet ---
app.get("/toimialueet", (req, res, n) => {

  var sql = ("SELECT * FROM toimintaalue")

  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});

// --- GET asiakkaat ---
app.get("/asiakkaat", (req, res, n) => {

  var sql = ("SELECT * FROM asiakas");
  console.log("asiakkaat haettu");
  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});

// --- GET mokit ---
app.get("/mokit", (req, res, n) => {

  var sql = ("SELECT * FROM mokki");
  console.log("mokit haettu");
  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});


// --- CREATE asiakas ---
app.post("/asiakkaat", (req, res, n) => {
  console.log("Body = " + JSON.stringify(req.body));
  console.log(req.body);
  if (req.body.length > 0) {
    console.log(req.body);
  }

  var sql = ("INSERT INTO asiakas (etunimi,sukunimi,lahiosoite,postitoimipaikka,postinro,email,puhelinnro) VALUES ('" + req.body.etunimi + "','" + req.body.sukunimi + "','" + req.body.lahiosoite + "','" + req.body.postitoimipaikka + "','" + req.body.postinro + "','" + req.body.email + "','" + req.body.puhelinnro + "');")
  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});


// --- CREATE mokki ---
app.post("/mokit", (req, res, n) => {
  console.log("Body = " + JSON.stringify(req.body));
  console.log(req.body);
  if (req.body.length > 0) {
    console.log(req.body);
  }

  var sql = ("INSERT INTO`vn`.`mokki`(`toimintaalue_id`, `postinro`, `mokkinimi`, `katuosoite`, `kuvaus`, `henkilomaara`, `varustelu`) VALUES('" + req.body.toimintaalue_id + "', '" + req.body.postinro + "', '" + req.body.mokkinimi + "', '" + req.body.katuosoite + "', '" + req.body.kuvaus + "', '" + req.body.henkilomaara + "', '" + req.body.varustelu + "');")


  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});


// --- CREATE palvelu ---
app.post("/palvelut", (req, res, n) => {
  console.log("Body = " + JSON.stringify(req.body));
  console.log(req.body);
  if (req.body.length > 0) {
    console.log(req.body);
  }

  var sql = ("INSERT INTO`vn`.`palvelu`(`palvelu_id`, `toimintaalue_id`, `nimi`, `tyyppi`, `kuvaus`, `hinta`, `alv`) VALUES('" + req.body.palvelu_id + "', '" + req.body.toimintaalue_id + "', '" + req.body.nimi + "', '" + req.body.tyyppi + "', '" + req.body.kuvaus + "', '" + req.body.hinta + "', '" + req.body.alv + "');")


  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});


// --- CREATE toimialue ---
app.post("/toimialueet", (req, res, n) => {
  console.log("Body = " + JSON.stringify(req.body));
  console.log(req.body);
  if (req.body.length > 0) {
    console.log(req.body);
  }

  var sql = ("INSERT INTO`vn`.`toimintaalue`(`nimi`) VALUES('" + req.body.nimi + "');")

  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});

// --- CREATE posti ---
app.post("/posti", (req, res, n) => {
  console.log("Body = " + JSON.stringify(req.body));
  console.log(req.body);
  if (req.body.length > 0) {
    console.log(req.body);
  }

  var sql = ("INSERT INTO `vn`.`posti` (`postinro`, `toimipaikka`) VALUES ('" + req.body.postinro + "', '" + req.body.toimipaikka + "');")

  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});

// --- CREATE varaus ---
app.post("/varaukset", (req, res, n) => {
  console.log("Body = " + JSON.stringify(req.body));
  console.log(req.body);
  if (req.body.length > 0) {
    console.log(req.body);
  }

  var sql = ("INSERT INTO`vn`.`varaus`(`asiakas_id`, `mokki_mokki_id`, `varattu_pvm`, `vahvistus_pvm`, `varattu_alkupvm`, `varattu_loppupvm`) VALUES('" + req.body.asiakas_id + "', '" + req.body.mokki_mokki_id + "', '" + req.body.varattu_pvm + "', '" + req.body.vahvistus_pvm + "', '" + req.body.varattu_alkupvm + "', '" + req.body.varattu_loppupvm + "');")

  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});

// --- CREATE varauspalvelu ---
app.post("/varauspalvelu", (req, res, n) => {
  console.log("Body = " + JSON.stringify(req.body));
  console.log(req.body);
  if (req.body.length > 0) {
    console.log(req.body);
  }

  var sql = ("INSERT INTO`vn`.`varauksen_palvelut`(`varaus_id`, `palvelu_id`, `lkm`) VALUES('" + req.body.varaus_id + "', '" + req.body.palvelu_id + "', '" + req.body.lkm + "');")

  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});

// --- CREATE lasku ---
app.post("/varauspalvelu", (req, res, n) => {
  console.log("Body = " + JSON.stringify(req.body));
  console.log(req.body);
  if (req.body.length > 0) {
    console.log(req.body);
  }

  var sql = ("INSERT INTO`vn`.`lasku`(`lasku_id`, `varaus_id`, `summa`, `alv`, `maksettu`) VALUES('" + req.body.lasku_id + "', '" + req.body.varaus_id + "', '" + req.body.summa + req.body.alv + "', '" + req.body.maksettu + "');")

  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});

// --- UPDATE lasku ---
app.put("/lasku", (req, res, n) => {



  var sql = ("UPDATE lasku SET maksettu ='" + req.body.arvo + "' where varaus_id = '" + req.body.id + "'");
  connection.query(sql, function (error, results, fields) {

    if (error) {
      console.log("Virhe, syy: " + error);
      res.send({ "status": 500, "error": error, "response": null });
    }
    res.json(results);
  });
});


// --- START SERVER ---
app.listen(port, hostname, () => {
  console.log(`Server running AT http://${hostname}:${port}/`);
});

