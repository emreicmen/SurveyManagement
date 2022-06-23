using CommonLayer;
using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    //Database'den toplam sayı verilerinin çekildiği sınıf.Sadece Count() işlemi için bu sınıf kullanılmıştır.
    //Diğer sorgu işlemleri Repository bölümündedir.
    public class SingleDatas : RepositoryBase
    {
        private string connectedString = "Server=ICMEN\\SQLEXPRESS;Database=PollDB;Integrated Security=SSPI";

        public int Completed()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectedString);
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(IsCompleted) FROM Polls where IsCompleted=1", conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int NotCompleted()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectedString);
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(IsCompleted) FROM Polls where IsCompleted=0", conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AllPolls()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectedString);
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(PollID) FROM Polls", conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AllCustomers()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectedString);
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(CustomerID) FROM Customers", conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int TotalCompanies()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectedString);
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(CompanyID) FROM Companies", conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int CustomersAverageAge()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectedString);
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT AVG(Age) FROM Customers", conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int SystemUsers()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectedString);
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(SystemUserID) FROM SystemUsers", conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Countries()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectedString);
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(distinct Country) FROM Customers", conn);
                Int32 count = (Int32)comm.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
