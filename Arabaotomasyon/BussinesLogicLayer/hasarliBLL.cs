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
    class hasarliBLL
    {
        private hasarliDAO hasarliDAO;

        public hasarliBLL()
        {
            hasarliDAO = new hasarliDAO();
        }
        public hasarliPoco kaydethasarlı(string hasarlı, string marka, string model, string yıl, string hasartipi)
        {

            hasarliPoco hasarlıkaydet = new hasarliPoco();
            DataTable dataTable = new DataTable();

            hasarliDAO.inserthasarlı(hasarlı, marka, model, yıl, hasartipi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["arac"] = hasarlıkaydet.hasarliid;
                dr["marka"] = hasarlıkaydet.marka;
                dr["model"] = hasarlıkaydet.model;
                dr["yıl"] = hasarlıkaydet.yıl;              
                dr["hasartipi"] = hasarlıkaydet.hasartipi;
            }
            return hasarlıkaydet;
        }
        public hasarliPoco updatehasarlı(string hasarlı, string marka, string model, string yıl, string hasartipi)
        {
            hasarliPoco hasarlıguncelle = new hasarliPoco();
            DataTable dataTable = new DataTable();

            hasarliDAO.guncellehasar(hasarlı, marka, model, yıl,  hasartipi);
            foreach (DataRow dr in dataTable.Rows)
            {


                dr["arac"] = hasarlıguncelle.hasarliid;
                dr["marka"] = hasarlıguncelle.marka;
                dr["model"] = hasarlıguncelle.model;
                dr["yıl"] = hasarlıguncelle.yıl;               
                dr["hasartipi"] = hasarlıguncelle.hasartipi;



            }
            return hasarlıguncelle;
        }
        public hasarliPoco silhasarlı(string hasarlı)
        {
            hasarliPoco hsarlısil = new hasarliPoco();
            DataTable dataTable = new DataTable();

            hasarliDAO.deletehasar(Convert.ToString(hasarlı));

            return hsarlısil;
        }
    }
}
