using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UltraSuperDuperLanPartyProvider.Interfaces;
using static UltraSuperDuperLanPartyProvider.Gamer;

namespace UltraSuperDuperLanPartyProvider
{
    public class GamerCollection : IGamerCollection
    {
        private List<Gamer> collection;
        private string path;

 
        public GamerCollection()
        {
            collection = new List<Gamer>();
            path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Gamers.xml";
            Load();
        }

        public void Add(Gamer gamer)
        {
            if(gamer.Team == Gamer.TeamType.None)
            {
                gamer.Team = GetColor();
            }
            collection.Add(gamer);
        }

        public void Update(Gamer gamer)
        {
            foreach (var item in collection.Where(x => x == gamer))
            {
                item.Name = gamer.Name;
                item.Nickname = gamer.Nickname;
                item.HasPaid = gamer.HasPaid;
                item.IsPresent = gamer.IsPresent;
            }
        }

        public void Remove(long id)
        {
            collection.RemoveAll(x => x.Id == id);
        }

        public Gamer Get(long id)
        {
            return collection.Where(x => x.Id == id).FirstOrDefault();
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

        public List<Gamer> DataSource
        {
            get
            {
                return collection;
            }
        }

        private TeamType GetColor()
        {
            if(collection.Count(x => x.Team == Gamer.TeamType.Blue) > collection.Count(x => x.Team == Gamer.TeamType.Red))
            {
                return TeamType.Red;
            }
            else
            {
                return TeamType.Blue;
            }
        }

        public void RandomizeTeams()
        {
            List<int> usedIndexes = new List<int>();
            Random r = new Random();

            for(int i=0; i< collection.Count; i++)
            {
                int index = 0;
                while (usedIndexes.Contains(index))
                {
                    index = r.Next(0, collection.Count);
                }
                collection[index].Team = GetColor();
                usedIndexes.Add(index);
            }
        }
    }
}
