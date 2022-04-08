// See https://aka.ms/new-console-template for more information

using ConsoleMongo;
using MongoDB.Bson;
using MongoDB.Driver;

string conString = "mongodb://localhost:27017";
var cliente = new MongoClient(conString);

var db = cliente.GetDatabase("db02");
var col = db.GetCollection<BsonDocument>("col02");

//var doc = BsonDocument.Parse("{ Nome: 'Teste' }");

var doc = new BsonDocument()
{
    {"Nome", "Edenilson" },
    {"Aula",
        new BsonArray(){
        "C#", "SQL"
        }
    }
};

var colMeuDoc = db.GetCollection<MeuDocumento>("col02");
var doc2 = new MeuDocumento() { Nome = "Edenilson" };
colMeuDoc.InsertOne(doc2);

col.InsertOne(doc);

var filtraTudo = BsonDocument.Parse("{}");

var resultado = col.Find(filtraTudo).ToList();

var updateSet2 = Builders<BsonDocument>.Update.Set("Nome", "Text");

var a = "pause";