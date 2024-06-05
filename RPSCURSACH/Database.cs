﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSCURSACH
{
    public class Database
    {
        //SqlConnection sqlconn = new SqlConnection(@"Data Source=MATVEYPC; Initial Catalog=RPS_Game; Integrated Security = True;");
        //SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;" + "Atta" "Integrated Security = True;");
        SqlConnection sqlconn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;" + "AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "RPS_Game.mdf;" + "Integrated Security = True; User ID=chungachanga ;pwd=12345");

        public void OpenConnection()
        {
            if(sqlconn.State == System.Data.ConnectionState.Closed) 
            {
                sqlconn.Open();

            }
        }
        public List<int> GetStatisticsData()
        {
            List<int> statistics = new List<int>();
            OpenConnection();
            string queryString = $"SELECT Wins, Loses from WinsAndLoses";
 
            SqlCommand command = new SqlCommand(queryString, GetConnection());
            using (SqlDataReader reader = command.ExecuteReader()) 
            {
                while(reader.Read())
                {
                    
                   var wins = (int)reader["Wins"];
                   var loses = (int)reader["Loses"];
                    statistics.Add(wins);
                    statistics.Add(loses);
                }
            }
            return statistics;

        }
        public void UpdateTheStatisticsWin()
        {
            string queryString = "Update WinsAndLoses Set Wins = Wins + 1";
            SqlCommand command = new SqlCommand(queryString , GetConnection());
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public void UpdateTheStatisticsLose()
        {
            string queryString = "Update WinsAndLoses Set Loses = Loses + 1";
            SqlCommand command = new SqlCommand (queryString , GetConnection());
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public void InsertInTheHistory(int player_score, int enemy_score,int rounds, string result)
        {
            string query = $"INSERT INTO GameHistory (player_score, enemy_score, rounds, result) VALUES ({player_score},{enemy_score},{rounds},'{result}')";
            SqlCommand command = new SqlCommand(query , GetConnection());
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public DataTable GetHistory()
        {
            using(sqlconn)
            {
                string query = "SELECT session_id as \"ID Игры\", player_score as \"Ваш счет\", enemy_score as \"Счет противника\", rounds as \"Раунды\", result as \"Результат\" FROM GameHistory ";
                SqlCommand command = new SqlCommand(query, GetConnection());
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                return dt;
            }
      
            
        }
        public void CloseConnection()
        {
            if(sqlconn.State == System.Data.ConnectionState.Open)
            {
                sqlconn.Close();    
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlconn; 
        }

        
    }
}
