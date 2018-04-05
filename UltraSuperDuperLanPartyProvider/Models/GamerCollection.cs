using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UltraSuperDuperLanPartyProvider.Interfaces;

namespace UltraSuperDuperLanPartyProvider
{
    class GamerCollection : IGamerCollection
    {
        private List<Gamer> collection;
        private string path;

        public List<Gamer> DataSource
        {
            get
            {
                return collection;
            }
        }

        public GamerCollection()
        {
            collection = new List<Gamer>();
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Gamers.xml";
            Load();
        }

        public void Add(Gamer gamer)
        {
            collection.Add(gamer);
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            collection.RemoveAll(x => x.Id == id);
        }

        public Gamer Get(long id)
        {
            return collection.Where(x => x.Id.ToString().Substring(id.ToString().Length - 3) == id.ToString().Substring(id.ToString().Length - 3)).FirstOrDefault();
        }

        public void Load()
        {
            if (File.Exists(path))
            {
                XmlSerializer reader = new XmlSerializer(typeof(List<Gamer>));
                StreamReader file = new StreamReader(path);
                collection = (List<Gamer>)reader.Deserialize(file);
                file.Close();
            }
        }

        public void Save()
        {            
            XmlSerializer writer =new XmlSerializer(typeof(List<Gamer>));         
            FileStream file = File.Create(path);
            writer.Serialize(file, collection);
            file.Close();
        }
    }
}
