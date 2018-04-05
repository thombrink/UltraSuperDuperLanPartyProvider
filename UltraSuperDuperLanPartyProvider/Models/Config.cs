using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraSuperDuperLanPartyProvider
{
    class Config
    {
        private string webcam;

        public Config()
        {
            this.webcam = null;
        }

        public Config(string webcam)
        {
            this.webcam = webcam;
        }

        public string Webcam
        {
            get
            {
                return webcam;
            }

            set
            {
                webcam = value;
            }
        }
    }
}
