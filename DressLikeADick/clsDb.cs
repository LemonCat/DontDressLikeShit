using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace DressLikeADick
{
    class clsDb
    {
        SQLiteConnection m_dbConnection;

        public clsDb()
        {

            //AppDomain.CurrentDomain.BaseDirectory + "";


            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "dlad"))
	        {
		        //con to db
                m_dbConnection = new SQLiteConnection("Data Source=dlad;Version=3;");
                m_dbConnection.Open();

            }else
	        {
                //create db, init con

                SQLiteConnection.CreateFile("dlad");

                m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                m_dbConnection.Open();

                //sql string create database tables
                string sql = "CREATE TABLE tbl_outfit (id_outfit real(10) NOT NULL, PRIMARY KEY (id_outfit));";
                sql += "CREATE TABLE tbl_piece_tbl_outfit (tbl_pieceid_piece real(10) NOT NULL, tbl_outfitid_outfit real(10) NOT NULL, order_nb integer(10), PRIMARY KEY (tbl_pieceid_piece, tbl_outfitid_outfit), FOREIGN KEY(tbl_pieceid_piece) REFERENCES tbl_piece(id_piece), FOREIGN KEY(tbl_outfitid_outfit) REFERENCES tbl_outfit(id_outfit));";
                sql +="CREATE TABLE tbl_piece (id_piece real(10) NOT NULL, PRIMARY KEY (id_piece));";
                sql += "CREATE UNIQUE INDEX tbl_outfit_id_outfit ON tbl_outfit (id_outfit);";
                sql +="CREATE UNIQUE INDEX tbl_piece_id_piece ON tbl_piece (id_piece);";


                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                /*string sql = "insert into highscores (name, score) values ('Me', 9001)";

                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                m_dbConnection.Close();*/
                
	        }
            
        }

        //Destructeur
        ~clsDb()
        {
            try
            {
                m_dbConnection.Close();
            }
            catch (Exception)
            {
                
            }
            
        }

        public float getLastPieceID()
        {
            float lastPieceID;
            lastPieceID = 0;

            string sql = "SELECT TOP 1 id_piece FROM tbl_piece ORDER BY id_piece DESC;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            
            while (reader.Read())
	        {
                lastPieceID = reader.GetFloat(0);

                if (DBNull.Value.Equals(lastPieceID))
                {
                    lastPieceID = 0;
                }

	        }

            return lastPieceID;
        }

    }
}
