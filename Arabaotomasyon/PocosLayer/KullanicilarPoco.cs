using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arabaotomasyon.PocosLayer;

namespace Arabaotomasyon.PocosLayer
{
    class KullanicilarPoco
    {
        private int _kullanici { get; set; }

        private string _isim { get; set; }

        private string _sifre { get; set; }




        public KullanicilarPoco()
        {

        }


        public int kullanici
        {
            get
            {
                return _kullanici;
            }
            set
            {
                _kullanici = value;
            }
        }


        public string isim
        {
            get
            {
                return _isim;
            }
            set
            {
                _isim = value;
            }
        }
        public string sifre
        {
            get
            {
                return _sifre;
            }
            set
            {
                _sifre = value;
            }
        }

    }



}
