﻿using Microsoft.EntityFrameworkCore.Storage;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigimonDeckManager.DDMDB
{
    internal class DeckRepository
    {
        //Have to create this when initialize the server for the 1st time
        public void DeckTable()
        {
            Connection con = new();
            string sql = "Create table\r\n  \"Deck\" (\r\n    \"DeckID\" INT PRIMARY KEY,\r\n    \"Name\" VARCHAR(500),\r\n    \"CardNumber\" VARCHAR,\r\n    \"Quantity\" INT,\r\n    CONSTRAINT \"FK_CardNumber\"\r\n    FOREIGN KEY(\"CardNumber\")\r\n    REFERENCES \"CardList\"(\"CardNumber\")\r\n  )";
            var cmd = new NpgsqlCommand(sql, con.OpenConnection());
            cmd.ExecuteNonQuery();
        }
        
        public void CreateDeck() {
            Connection con = new();
            string sql = "INSERT INTO \"Deck\"(\"DeckID\",\"Name\", \"CardNumber\")\r\nVALUES(@deckID, @name, @cardNumber)";
            var cmd = new NpgsqlCommand(sql, con.OpenConnection());
            cmd.ExecuteNonQuery();
        }
        public void InsertCardIntoDeck(int deckId, string cardNumber)
        {
            Connection con = new();
            string sql = "INSERT INTO \"DeckCard\"(\"DeckID\", \"CardNumber\") VALUES(@deckId, @cardNumber)";
            var cmd = new NpgsqlCommand(sql, con.OpenConnection());
            cmd.Parameters.Add("@deckId", NpgsqlTypes.NpgsqlDbType.Integer).Value = (object)deckId;
            cmd.Parameters.AddWithValue("@cardNumber", cardNumber);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Card added");
            con.CloseConnection();

        }
        public string GetDeckName(int deckId)
        {
            Connection con = new();

            string sql = "SELECT \"Name\" FROM \"Deck\" WHERE \"DeckID\" = @deckId";
            var cmd = new NpgsqlCommand(sql, con.OpenConnection());
            cmd.Parameters.AddWithValue("deckId", deckId);
            
            NpgsqlDataReader rdr = cmd.ExecuteReader();
            string deckName = " ";
            if (rdr.Read())
            {
                deckName = rdr.GetString(rdr.GetOrdinal("Name"));
            }

            con.CloseConnection();

            return deckName;
        }
        public void ShowDeckCards(int deckId)
        {
            Connection con = new();

            string sql = "SELECT * FROM \"DeckCard\" WHERE \"DeckID\" = @deckId";
            var cmd = new NpgsqlCommand(sql, con.OpenConnection());
            cmd.Parameters.AddWithValue("deckId", deckId);

            NpgsqlDataReader rdr = cmd.ExecuteReader();
            string deckName = GetDeckName(deckId);

            Console.WriteLine($"Deck: {deckName.ToUpper()}");

            while(rdr.Read()) {
                Console.WriteLine("___________________________________");
                Console.WriteLine($"Number: {rdr["CardNumber"].ToString()}");
            }
                Console.WriteLine("___________________________________");
            con.CloseConnection();
        }
    }
}
