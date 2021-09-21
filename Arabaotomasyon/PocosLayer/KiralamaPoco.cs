using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arabaotomasyon.PocosLayer;

namespace Arabaotomasyon.PocosLayer
{
    class KiralamaPoco
    {
        private int _musteriid { get; set; }

        private string _isim { get; set; }

        private string _soyisim { get; set; }

        private string _telefon { get; set; }

        private string _alınantarih { get; set; }

        private string _teslimtarih { get; set; }

        private string _fiyat { get; set; }

        public KiralamaPoco()
        {

        }
        public int musteriid
        {
            get
            {
                return _musteriid;
            }
            set
            {
                _musteriid = value;
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

        public string soyisim
        {
            get
            {
                return _soyisim;
            }
            set
            {
                _soyisim = value;
            }
        }
        public string telefon
        {
            get
            {
                return _telefon;
            }
            set
            {
                _telefon = value;
            }
        }

        public string alınantarih
        {
            get
            {
                return _alınantarih;
            }
            set
            {
                _alınantarih = value;
            }
        }
            public string teslimtarih
        {
            get
            {
                return _teslimtarih;
            }
            set
            {
                _teslimtarih = value;
            }
        }
               public string fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                _fiyat = value;
            }

        }
    }

}
