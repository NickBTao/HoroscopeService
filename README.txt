


---------------------------------------------------------------------------------

HOROSCOPE SERVICE 

An excercise used to practice SOAP clients and web services

Created by: Nicolas Beattie
LastUpdated: july 28, 2022

---------------------------------------------------------------------------------


DESCRIPTION

Several Programs using Client/Service SOAP protocol:

A Horoscope Client Web Form
A Horoscope webservice that recieves user data (name and date of birth) and returns various info
(Astrological Sign, Age, Life Advice)

Before returning info to user, Horoscope webservice makes use of a secondary Database web service
that makes note of user data and meta Data (Name, age, Sign, When service was consulted,Computer Name, IP adress) and inserts it into a Database

Finally another client, intended for use by an administrator, Lists all the user data tha has been collected in the database.


NOTA BENE:
Lot's of moving parts here, might be difficult to set up, even perfectly following the bellow steps


SETUP

Runs with Visual Studio 2019

Start by opening the TP_DB_HoroscopeService Folder in the project folder and
TP_DB_HoroscopeService.sln <--- run this file (Need Visual Studio)

Add a new data connection.

Under Data Source, choose: Microsoft SQL Server (SQLClient)
Under servername enter: (localDB)\MSSQLlocalDB
Enter a database name : ex : DB_Horoscope

with the new data connection selected open an run the sqlServerScript.sql in in the project file 
the sql files contains CREATE TABLE & CREATE PROCEDURE commands



Uder Tables, make sure the UserData tabble has been created.


Right click the new connection and select Properties
Under Connection in properties, copy Connection String
ex:
Data Source=(localDB)\MSSQLlocalDB;Initial Catalog=DB_Horoscope;Integrated Security=True
In the solution explorer, open the Models folder, then the DAO.cs file
Near the top is a varriable called connectionString
Paste the Connection String betwen the "" or at least make sure the string is the same
ex:
static string connectionString = "Data Source = (localDB)\\MSSQLlocalDB;Initial Catalog=DB_Horoscope;Integrated Security=True";
NOTE :  use \\  NOT  \ as this will generate an error

in order, run:
TP_DB_HoroscopeService
TP_HoroscopeService
TP_MVC_HoroscopeClient1
TP_MVC_AdminHoroscopeClient1

The Client1 webpage will ask for name and a date of birth.
Based on the date of birth, will return the Astorlogical sign, age, etc.

The ADMIN client webpage lists the meta data of all the previous users of the web service, including IP address, when the service was used, computer name, etc.
