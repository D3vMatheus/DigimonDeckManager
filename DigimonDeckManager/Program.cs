using DigimonDeckManager;
using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;
using Npgsql;
using System;
using System.Data;

var cs = "Host=localhost:5433;Username=postgres;Password=postgres;Database=postgres";

var con = new NpgsqlConnection(cs);
con.Open();

string sql = "SELECT * FROM \"Cards\"";
var cmd = new NpgsqlCommand(sql, con);
NpgsqlDataReader rdr = cmd.ExecuteReader();
while (rdr.Read())
{
    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13}",
    rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4),
    rdr.GetString(5), rdr.GetString(6), rdr.GetInt32(7), rdr.GetInt32(8), rdr.GetInt32(9), rdr.GetString(10),
    rdr.GetString(11), rdr.GetString(12), rdr.GetString(13));
}


//Create method Display info
//Initiate cards CRUD

CardList cardlist = new();
List<Card> cards = CardList.GetAllCardsFromCardList();
cardlist.AddCard();

Console.WriteLine(CardList.GetAllCardsFromCardList());

cardlist.ShowAllCards();
foreach (Card card in CardList.GetAllCardsFromCardList())
{
    DisplayGeneral.GeneralCardInfo(card);
}

Deck test = new("test");
test.AddCardToDeck("ST1-01");
test.AddCardToDeck("BT1-010");
test.ShowDeckCards();
test.RemoveCardFromDeck("ST1-01");
test.ShowDeckCards();

cardlist.ShowAllCards();
