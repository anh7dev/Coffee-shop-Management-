using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.DAO
{
    public class DataBaseDAO
    {

        static string connectionSTR = @"Data Source=DESKTOP-5V50FAS;Initial Catalog=QuanLyQuanCaPheNTN;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connectionSTR);
 

        public static bool BackupData(string backupPath)
        {
            try
            {
                string fileName = "\\QuanLyQuanCaPheNTN(" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm") + ").bak";
                string sqlBackupQuery = "USE QuanLyQuanCaPheNTN;  BACKUP DATABASE QuanLyQuanCaPheNTN TO DISK = N'" + backupPath + fileName + "'";

                return DataProvider.ExecuteNonQuery(sqlBackupQuery, conn);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool RestoreData(string restorePath)
        {
            try
            {
                string sqlRestoreQuery = $"USE master; RESTORE DATABASE QuanLyQuanCaPheNTN FROM DISK = N'{restorePath}' WITH REPLACE";

                return DataProvider.ExecuteNonQuery(sqlRestoreQuery, conn);
            }
            catch (Exception ex)
            {
                return false;
            }

           
        }

    }
}
