using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arabaotomasyon.PocosLayer;

namespace Arabaotomasyon.PocosLayer
{
    class AracEklePoco
    {
        private int _aracid { get; set; }

        private string _marka { get; set; }

        private string _model { get; set; }

        private string _yıl { get; set; }

        private string _plaka { get; set; }

        public AracEklePoco()
        {

        }


        public int aracid
        {
            get
            {
                return _aracid;
            }
            set
            {
                _aracid = value;
            }
        }
        public string marka
        {
            get
            {
                return _marka;
            }
            set
            {
                _marka = value;
            }
        }
        public string plaka
        {
            get
            {
                return _plaka;
            }
            set
            {
                _plaka = value;
            }
        }

        public string model
        {
            get 
            { 
                return _model; 
            }
            set
            {
                _model = value;
            }
        }
        public string yıl
        {
            get
            {
                return _yıl;
            }
            set
            {
                _yıl = value;
            }
        }

    }
}
