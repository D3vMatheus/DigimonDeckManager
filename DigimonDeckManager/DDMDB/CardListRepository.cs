using DigimonDeckManager.UseCases;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DigimonDeckManager.DDMDB
{
    internal class CardListRepository
    {
        public void GetAllCardsFromCardList()
        {
            Connection con = new();
            string sql = "SELECT * FROM \"CardList\"";
            var cmd = new NpgsqlCommand(sql, con.OpenConnection());
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string type = rdr["Type"] != DBNull.Value ? rdr["Type"].ToString() : null;
                string attribute = rdr["Attribute"] != DBNull.Value ? rdr["Attribute"].ToString() : null;
                string lv = rdr["Lv"] != DBNull.Value ? rdr["Lv"].ToString() : null;
                string pc = rdr["PlayCost"] != DBNull.Value ? rdr["PlayCost"].ToString() : null;
                string dp = rdr["DigimonPower"] != DBNull.Value ? rdr["DigimonPower"].ToString() : null;
                string digiEvolutionCondition = rdr["DigievolutionCondition"] != DBNull.Value ? rdr["DigievolutionCondition"].ToString() : null;
                string form = rdr["Form"] != DBNull.Value ? rdr["Form"].ToString() : null;
                string mainEffect = rdr["MainEffect"] != DBNull.Value ? rdr["MainEffect"].ToString() : null;
                string secondaryEffect = rdr["SecondaryEffect"] != DBNull.Value ? rdr["SecondaryEffect"].ToString() : null;

                Console.WriteLine("___________________________________");
                Console.WriteLine   ("Number: {0}\n" +
                    "Name: {1}\n" +
                    "Rarity: {2}\n" +
                    "Color: {3}\n" +
                    "Category: {4}\n" +
                    "Type: {5}\n" +
                    "Attribute: {6}\n" +
                    "Level: {7}\n" +
                    "PC: {8}\n" +
                    "DP: {9}\n" +
                    "Digievolution Condition: {10}\n" +
                    "Form/Stage: {11}\n" +
                    "Main effect: {12}\n" +
                    "Secondary effect: {13}",
                rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4),
                type, attribute, lv, pc, dp, digiEvolutionCondition,
                form, mainEffect, secondaryEffect);
                Console.WriteLine("___________________________________");

            }
        }
        public bool DoesCardExist(string cardNumber)
        {
            Connection con = new();
            
            string sql = "SELECT EXISTS (SELECT 1 FROM \"CardList\" WHERE \"CardNumber\"  = @cardNumber)";
            var cmd = new NpgsqlCommand(sql, con.OpenConnection());
            cmd.Parameters.AddWithValue("cardNumber", cardNumber);
            
            bool exists = (bool)cmd.ExecuteScalar();
            
            return exists;
        }
        public void AddCardIntoCardList()
        {
            Card newCard = CreateCard.CreateCardAllTypes();
            Connection con = new();

            if (!DoesCardExist(newCard.CardNumber))
            {
                string sql = "INSERT INTO \"CardList\" (\r\n\"CardNumber\",\r\n\"CardName\",\r\n\"CardRarity\",\r\n\"CardColor\",\r\n\"CardCategory\",\r\n\"Type\",\r\n\"Attribute\",\r\n\"Lv\",\r\n\"PlayCost\",\r\n\"DigimonPower\",\r\n\"DigievolutionCondition\",\r\n\"Form\",\r\n\"MainEffect\",\r\n\"SecondaryEffect\") VALUES (@number, @name, @rarity, @color, @category, @type, @attribute, @lv, @pc, @dp, @evolutionCondition, @form, @mainEff, @secondEff)";
                var cmd = new NpgsqlCommand(sql, con.OpenConnection());
                cmd.Parameters.AddWithValue("CardNumber", newCard.CardNumber);
                cmd.Parameters.AddWithValue("CardName", newCard.CardName);
                cmd.Parameters.AddWithValue("CardRarity", newCard.CardRarity);
                cmd.Parameters.AddWithValue("CardColor", newCard.CardColour);
                cmd.Parameters.AddWithValue("CardCategory", newCard.CardCategory);
                cmd.Parameters.AddWithValue("Type", newCard.Type);
                cmd.Parameters.AddWithValue("Attribute", newCard.Attribute);
                cmd.Parameters.AddWithValue("Lv", newCard.Lv);
                cmd.Parameters.AddWithValue("PlayCost", newCard.PlayCost);
                cmd.Parameters.AddWithValue("DigimonPower", newCard.DigimonPower);
                cmd.Parameters.AddWithValue("DigievolutionCondition", newCard.DigievolutionCondition);
                cmd.Parameters.AddWithValue("Form", newCard.Form);
                cmd.Parameters.AddWithValue("MainEffect", newCard.MainEffect);
                cmd.Parameters.AddWithValue("SecondaryEffect", newCard.SecondaryEffect);
                
                cmd.ExecuteNonQuery();

                Console.WriteLine("Card added");
            }
            else
                Console.WriteLine("Card with same number already exists");

        }
    }
}
