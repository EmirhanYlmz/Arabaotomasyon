using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arabaotomasyon.PocosLayer;

namespace Arabaotomasyon.PocosLayer
{
    class hasarliPoco
    {
        private int _hasarliid { get; set; }

        private string _marka { get; set; }

        private string _model { get; set; }

        private string _yıl { get; set; }

        private string _hasartipi { get; set; }


        public hasarliPoco()
        {

        }
        public int hasarliid
        {
            get
            {
                return _hasarliid;
            }
            set
            {
                _hasarliid = value;
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

        public string hasartipi
        {
            get
            {
                return _hasartipi;
            }
            set
            {
                _hasartipi = value;
            }
        }
    }
}
