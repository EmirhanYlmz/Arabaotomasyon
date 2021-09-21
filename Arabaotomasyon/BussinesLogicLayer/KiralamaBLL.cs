using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arabaotomasyon.DataAccessObjectLayer;
using Arabaotomasyon.PocosLayer;
using System.Data;

namespace Arabaotomasyon.BussinesLogicLayer
{
    class KiralamaBLL
    {
        private KiralamaDAO kiralamaDAO;
        public KiralamaBLL()
        {
            kiralamaDAO = new KiralamaDAO();
        }
        public KiralamaPoco kaydetmusteri(string musteriid, string isim, string soyisim, string telefon, string alınantarih, string teslimtarih, string fiyat)
        {

            KiralamaPoco kirakaydet = new KiralamaPoco();
            DataTable dataTable = new DataTable();

            kiralamaDAO.insertkiralama(musteriid, isim, soyisim, telefon, alınantarih, teslimtarih, fiyat);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["musteri"] = kirakaydet.musteriid;
                dr["isim"] = kirakaydet.isim;
                dr["soyisim"] = kirakaydet.soyisim;
                dr["telefon"] = kirakaydet.telefon;
                dr["alınantarih"] = kirakaydet.alınantarih;
                dr["teslimtarih"] = kirakaydet.teslimtarih;
                dr["fiyat"] = kirakaydet.fiyat;
            }
            return kirakaydet;
        }
        public KiralamaPoco updatekiralama(string musteriid, string isim, string soyisim, string telefon, string alınantarih, string teslimtarih, string fiyat)
        {
            KiralamaPoco kiraguncelle = new KiralamaPoco();
            DataTable dataTable = new DataTable();

            kiralamaDAO.guncellekiralama(musteriid, isim, soyisim, telefon, alınantarih, teslimtarih, fiyat);
            foreach (DataRow dr in dataTable.Rows)
            {


                dr["musteri"] = kiraguncelle.musteriid;
                dr["isim"] = kiraguncelle.isim;
                dr["soyisim"] = kiraguncelle.soyisim;
                dr["telefon"] = kiraguncelle.telefon;
                dr["alınantarih"] = kiraguncelle.alınantarih;
                dr["teslimtarih"] = kiraguncelle.teslimtarih;
                dr["fiyat"] = kiraguncelle.fiyat;



            }
            return kiraguncelle;
        }
        public KiralamaPoco silkiralama(string musteri)
        {
            KiralamaPoco kiralamasil = new KiralamaPoco();
            DataTable dataTable = new DataTable();

            kiralamaDAO.deletekiralama(Convert.ToString(musteri));

            return kiralamasil;
        }
    }
}
