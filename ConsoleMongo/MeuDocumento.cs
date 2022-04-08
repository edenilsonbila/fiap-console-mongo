using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ConsoleMongo
{
    //[BsonIgnoreExtraElements] //Ignora o que nao tiver no Elemento
    public class MeuDocumento
    {
        [BsonElement("nome_completo")]//Da um nome em como vai serializar essa coluna
        public string Nome { get; set; }

        [BsonExtraElements]//Elementos que nao fazem parte da classe, mas que estejam no mongo
        public BsonDocument Outros { get; set; }

    }
}
