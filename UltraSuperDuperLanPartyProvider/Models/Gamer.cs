using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraSuperDuperLanPartyProvider
{
    public class Gamer
    {
        private long id;
        private string name;
        private string nickname;
        private bool isPresent;
        private bool hasPaid;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

        public bool IsPresent
        {
            get
            {
                return isPresent;
            }

            set
            {
                isPresent = value;
            }
        }

        public bool HasPaid
        {
            get
            {
                return hasPaid;
            }

            set
            {
                hasPaid = value;
            }
        }

        public Gamer()
        {
            this.Id = 0;
            this.Name = null;
            this.Nickname = null;
            this.IsPresent = false;
            this.HasPaid = false;
        }

        public Gamer(int id, string name, string nickname, bool isPresent, bool hasPaid)
        {
            this.Id = id;
            this.Name = name;
            this.Nickname = nickname;
            this.IsPresent = isPresent;
            this.HasPaid = hasPaid;
        }
    }
}
