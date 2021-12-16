using ConnectionLibrary.Model;
using ConnectionLibrary.Model.Reports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLibrary.Repository
{
    public class MasterRepositoryNew
    {
        public static string LogError(string Query)
        {
            var cn = new ConnectionClass();

            try
            {
                var objGetData = cn.Insert(Query);
                return objGetData.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
          
        public static List<_Yadi> GetListYadi()
        {
            var result = new List<_Yadi>();
            try
            {
                var cn = new ConnectionClass();
                string query = "Select YadiID,Name,FatherName,Surname,Bhag.bhag as Bhag, Bhag.Bhagid as BhagID ,Nagar.Nagar as Nagar,Nagar.NagarID as NagarID,Mobile,Mail,Dob, Blood, " +

                    "Vasti.Vastiid as NvastiID, Vasti.Vasti as VastiName, MilanType.MTID as MTID, MilanType.MilanType," +

                    "shakha.ShakhaID,Shakha.ShakhaName, JobType, Business, Study, " +
"SanghSikshan, PresentD, DSelect, Gatividhi, Padadhikari, Uniform, " +
"Vadhya, SanghPravesh, Abhiruchi, SelectOrganization" +
" from Yadi " +
" left join Bhag on Yadi.BHagID = Bhag.BHagID" +
" left join Nagar on Yadi.NagarID = Nagar.NagarID" +
" left join Vasti on Yadi.NvastiID = Vasti.vastiid" +
" left join MilanType on Yadi.MilanType = MilanType.MTID" +
" left join Shakha on Yadi.ShakhaID = Shakha.ShakhaID" +
" order by YadiID";
                var Result = cn.Select(query);
                if (Result.Rows.Count > 0)
                {
                 //   result = Result.ToListof<_Yadi>();
                    result = Result.ToListof<_Yadi>();
                    return result;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public static List<_Yadi> GetListYadiPravasi()
         {
            var result = new List<_Yadi>();
            try
            {
                var cn = new ConnectionClass();
                string query = "Select Yadi.YadiID,Name+' ' +FatherName+' ' +Surname as Name,Mobile,Mail,Nagar.Nagar as Nagar,Star_Mast.Star,Star_Mast.ID as StarID, Dayitva_Mast.Dayitva, Dayitva_Mast.id as DayitvaID, PravasiKaryakarta.PravasiID, PravasiKaryakarta.Year,PravasiKaryakarta.RefID from Yadi " +
                    "left join Bhag on Yadi.BHagID = Bhag.BHagID " +
                    "left join Nagar on Yadi.NagarID = Nagar.NagarID " +
                    "left join PravasiKaryakarta on Yadi.YadiID = PravasiKaryakarta.YadiID " +
                    "left join Star_Mast on Star_Mast.ID = PravasiKaryakarta.StarID " +
                    "left join Dayitva_Mast on Dayitva_Mast.Id = PravasiKaryakarta.DayitvaID order by YadiID";
                var Result = cn.Select(query);
                if (Result.Rows.Count > 0)
                {
                    //result = Result.ToListof<_Yadi>();
                    result = Result.ToListof<_Yadi>();
                    return result;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public static string GetBhagIdByName(string bhagName)
        {
            var result = "0";
            try
            {
                var cn = new ConnectionClass();
                DataTable dtbhag = cn.Select(@"Select BhagID from Bhag where Bhag= '" + bhagName + "'");
                if (dtbhag.Rows.Count > 0)

                {
                    result = dtbhag.Rows[0]["BhagID"].ToString();
                    return result;
                }
                else
                {
                    return result.ToString();
                }

            }
            catch (Exception Ex)
            {
                return result.ToString();
            }
        }

        public static string GetNagarByName(string NagarName)
        {
            var result = "0";
            try
            {
                var cn = new ConnectionClass();
                DataTable dtbhag = cn.Select(@"Select NagarID from Nagar where Nagar= '" + NagarName + "'");
                if (dtbhag.Rows.Count > 0)
                {
                    result = dtbhag.Rows[0]["NagarID"].ToString();
                    return result;
                }
                else
                {
                    return result.ToString();
                }
            }
            catch (Exception Ex)
            {
                return result.ToString();
            }
        }

        public static string GetNivasivastiByName(string vastiName)
        {
            var result = "0";
            try
            {
                var cn = new ConnectionClass();
                // DataTable dtbhag = cn.Select(@"Select VastiID from Vasti where Vasti= '" + vastiName + "' and NagarID="+ NagarID+"");
                DataTable dtbhag = cn.Select(@"Select VastiID from Vasti where Vasti= '" + vastiName + "'");
                if (dtbhag.Rows.Count > 0)

                {
                    result = dtbhag.Rows[0]["VastiID"].ToString();
                    return result;
                }
                else
                {
                    return result.ToString();
                }

            }
            catch (Exception Ex)
            {
                return result.ToString();
            }
        }

        public static string GetShakhaByName(string ShakhaName)
        {
            var result = "0";
            try
            {
                var cn = new ConnectionClass();
                DataTable dtbhag = cn.Select(@"Select ShakhaID from Shakha where ShakhaName= '" + ShakhaName + "'");
                if (dtbhag.Rows.Count > 0)

                {
                    result = dtbhag.Rows[0]["ShakhaID"].ToString();
                    return result;
                }
                else
                {
                    return result.ToString();
                }

            }
            catch (Exception Ex)
            {
                return result.ToString(); 
            }
        }

        public static string GetMTypeByName(string MTypeName)
        {
            var result = "0";
            try
            {
                var cn = new ConnectionClass();
                DataTable dtbhag = cn.Select(@"Select MTID from MilanType where MilanType= '" + MTypeName + "'");
                if (dtbhag.Rows.Count > 0)

                {
                    result = dtbhag.Rows[0]["MTID"].ToString();
                    return result;
                }
                else
                {
                    return result.ToString();
                }
            }
            catch (Exception Ex)
            {
                return result.ToString();
            }

        }

        public static string GetMobile(string mobile)
        {
            var result = "0";
            try
            {
                var cn = new ConnectionClass();
                DataTable dtbhag = cn.Select(@"SELECT Mobile FROM yadi WHERE mobile like '%"+mobile+"%'");
                if (dtbhag.Rows.Count > 0)

                {
                    //result = dtbhag.Rows[0]["Mobile"].ToString();
                    result = "0";
                    return result;
                }
                else
                {
                    return result = mobile;
                }
            }
            catch (Exception Ex)
            {
                return result.ToString();
            }

        }



        public static List<_WrongYadi> GetListWrongYadi()
        {
            var result = new List<_WrongYadi>();
            try
            {
                var cn = new ConnectionClass();
                string query = "Select * From YadiWrong";
                var Result = cn.Select(query);
                if (Result.Rows.Count > 0)
                {
                    //   result = Result.ToListof<_Yadi>();
                    result = Result.ToListof<_WrongYadi>();
                    return result;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        public static bool InsertYadiData(_Yadi yadi)
        {
            var cn = new ConnectionClass();
            SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            try
            {
                DB.Open();
                string wquery = "INSERT INTO Yadi ([Name],[FatherName],[Surname],[BhagID],[NagarID],[Mobile],[Mail],[Dob],[Blood],[NvastiID],[MilanType],[ShakhaID],[JobType],[Business],[Study],[SanghSikshan],[PresentD],[DSelect],[Gatividhi],[Padadhikari],[Uniform],[Vadhya],[SanghPravesh],[Abhiruchi],[SelectOrganization]) VALUES" +
                    "('" + yadi.Name + "','" + yadi.FatherName + "','" + yadi.Surname + "','" + yadi.BhagID + "','" + yadi.NagarID + "','" + yadi.Mobile + "','" + yadi.Mail + "','" + yadi.Dob + "','" + yadi.Blood + "','" + yadi.NvastiID + "','" + yadi.MilanType + "','" + yadi.ShakhaID + "','" + yadi.JobType + "','" + yadi.Business + "','" + yadi.Study + "','" + yadi.SanghSikshan + "','" + yadi.PresentD + " ','" + yadi.DSelect + "','" + yadi.Gatividhi + "','" + yadi.Padadhikari + "','" + yadi.Uniform + "','" + yadi.Vadhya + "','" + yadi.SanghPravesh + "','" + yadi.Abhiruchi + "','" + yadi.SelectOrganization + "')";
                SqlCommand sqcmd = new SqlCommand(wquery, DB);
                sqcmd.ExecuteNonQuery();
                DB.Close();


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool updateYadiData(_Yadi yadi)
        {
            var cn = new ConnectionClass();
            SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            try
            {
                DB.Open();
                string wquery = "UPDATE Yadi SET [Name]='" + yadi.Name + "',[FatherName]='" + yadi.FatherName + "',[Surname]='" + yadi.Surname + "',[BhagID]='" + yadi.BhagID + "',[NagarID]='" + yadi.NagarID + "',[Mobile]='" + yadi.Mobile + "',[Mail]='" + yadi.Mail + "',[Dob]='" + yadi.Dob + "',[Blood]='" + yadi.Blood + "',[NvastiID]='" + yadi.VastiID + "',[MilanType]='" + yadi.MilanType + "',[ShakhaID]='" + yadi.ShakhaID + "',[JobType]='" + yadi.JobType + "',[Business]='" + yadi.Business + "',[Study]='" + yadi.Study + "',[SanghSikshan]='" + yadi.SanghSikshan + "',[PresentD]='" + yadi.PresentD + "',[DSelect]='" + yadi.DSelect + "',[Gatividhi]='" + yadi.Gatividhi + "',[Padadhikari]='" + yadi.Padadhikari + "',[Uniform]='" + yadi.Uniform + "',[Vadhya]='" + yadi.Vadhya + "',[SanghPravesh]='" + yadi.SanghPravesh + "',[Abhiruchi]='" + yadi.Abhiruchi + "',[SelectOrganization]='" + yadi.SelectOrganization + "' where yadiid = '" + yadi.YadiID + "'";
                SqlCommand sqcmd = new SqlCommand(wquery, DB);
                sqcmd.ExecuteNonQuery();
                DB.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        public static bool InsertPrvasiYadiData(_Yadi yadi)
        {
            var cn = new ConnectionClass();
            SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            try
            {
                DB.Open();
                string wquery = "INSERT INTO PravasiKaryakarta ([YadiID],[StarID],[DayitvaID],[RefID],[Year]) VALUES" +
                    "('" + yadi.YadiID + "','" + yadi.StarID + "','" + yadi.DayitvaID + "','" + yadi.RefID + "','" + yadi.Year + "')";
                SqlCommand sqcmd = new SqlCommand(wquery, DB);
                sqcmd.ExecuteNonQuery();
                DB.Close();


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool UpdatePrvasiYadiData(_Yadi yadi)
        {
            var cn = new ConnectionClass();
            SqlConnection DB = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            try
            {
                DB.Open();
                string wquery = "UPDATE PravasiKaryakarta SET [YadiID]='" + yadi.YadiID + "',[StarID]='" + yadi.StarID + "',[DayitvaID]='" + yadi.DayitvaID + "',[RefID]='" + yadi.RefID + "',[Year]='" + yadi.Year + "' where PravasiID = '" + yadi.PravasiID + "'";
                SqlCommand sqcmd = new SqlCommand(wquery, DB);
                sqcmd.ExecuteNonQuery();
                DB.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
