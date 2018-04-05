using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraSuperDuperLanPartyProvider.Interfaces
{
    public interface IGamerCollection
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Remove(long id);
        Gamer Get(long id);
        List<Gamer> DataSource { get; }
        void Load();
        void Save();
    }
}
