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
    class AracEkleBLL
    {
        private AracEkleDAO AracEkleDAO;

    public AracEkleBLL()
        {
            AracEkleDAO = new AracEkleDAO();
        }
    public AracEklePoco kaydetarac(string arac, string marka, string model, string yıl, string plaka)
        {

            AracEklePoco arackaydet = new AracEklePoco();
            DataTable dataTable = new DataTable();

            AracEkleDAO.insertarac(arac, marka, model, yıl, plaka);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["arac"] = arackaydet.aracid;
                dr["marka"] = arackaydet.marka;
                dr["model"] = arackaydet.model;
                dr["yıl"] = arackaydet.yıl;
                dr["plaka"] = arackaydet.plaka;
            }
            return arackaydet;
        }
        public AracEklePoco updatearac(string arac, string marka, string model, string yıl, string plaka)
        {
            AracEklePoco aracguncelle = new AracEklePoco();
            DataTable dataTable = new DataTable();

            AracEkleDAO.guncellearac(arac, marka, model, yıl, plaka);
            foreach (DataRow dr in dataTable.Rows)
            {


                dr["arac"] = aracguncelle.aracid;
                dr["marka"] = aracguncelle.marka;
                dr["model"] = aracguncelle.model;
                dr["yıl"] = aracguncelle.yıl;
                dr["plaka"] = aracguncelle.plaka;



            }
            return aracguncelle;
        }
        public AracEklePoco silarac(string arac)
        {
            AracEklePoco aracsil = new AracEklePoco();
            DataTable dataTable = new DataTable();

            AracEkleDAO.deletearac(Convert.ToString(arac));

            return aracsil;
        }

    }

}
