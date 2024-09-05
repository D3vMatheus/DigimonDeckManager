using DigimonDeckManager;
using DigimonDeckManager.DDMDB;
using DigimonDeckManager.Enums;
using DigimonDeckManager.UseCases;

Connection db= new Connection();
db.OpenConnection();
Menu menu= new Menu();
menu.StartMenu();


//Still need implementation
//Card limit in deck (duplicate and max limit)
//DB initialize (creating all tables when start a container)