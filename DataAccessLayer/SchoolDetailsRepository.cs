using System;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class SchoolDetailsRepository : ISchoolDetailsRepository
    {
        public SchoolDetailss InsertSP(SchoolDetailss SchoolDetail)
        {

            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var insertQuery = $"exec SchoolDetailsInsert '{SchoolDetail.SchoolName}', '{SchoolDetail.Address}', '{SchoolDetail.StartedDate}', {SchoolDetail.PhoneNumber}, '{SchoolDetail.Email_id}'";
                con.Execute(insertQuery);
                con.Close();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
            return SchoolDetail;
        }
        public IEnumerable<SchoolDetailss> ReadSP()
        {
            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"exec SchoolDetailsRead";
                var schoolDetails = con.Query<SchoolDetailss>(selectQuery);
                con.Close();
                return schoolDetails.ToList();

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public SchoolDetailss FindSchoolDetailsByIdSP(long Id)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var selectQuery = $"exec FindSchoolDetailsByNumber {Id}";
                var Find = con.QueryFirstOrDefault<SchoolDetailss>(selectQuery);
                con.Close();
                return Find;

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void DeleteSchoolDetailsByIdSP(long Id)
        {
            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var deleteQuery = $"exec SchoolDetailstDelete {Id}";
                con.QueryFirstOrDefault(deleteQuery);
                con.Close();


            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public SchoolDetailss UpdateSchoolDetailsByIdSP(long Id, SchoolDetailss Sch)
        {

            try
            {
                var connectionString = "Data source=DESKTOP-1U0BM0H\\SQLEXPRESS;initial catalog=batch7;user id=sa;password=Anaiyaan@123;";

                var con = new SqlConnection(connectionString);
                con.Open();
                var updateQuery = $"exec SchoolDetailsUpdate {Id},'{Sch.SchoolName}', '{Sch.Address}', '{Sch.StartedDate.ToString("MM/dd/yyyy")}', {Sch.PhoneNumber},'{Sch.Email_id}'";
                var shl = con.QueryFirstOrDefault<SchoolDetailss>(updateQuery);
                con.Execute(updateQuery);
                con.Close();
                return shl;

            }
            catch (SqlException sql)
            {
                throw;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
