namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCategorisesTable : DbMigration
    {
        public override void Up()
        {
            //SEED BLOODTYPES

            Sql("INSERT INTO BloodTypes (Name) VALUES ('A+')");
            Sql("INSERT INTO BloodTypes (Name) VALUES ('A-')");
            Sql("INSERT INTO BloodTypes (Name) VALUES ('B+')");
            Sql("INSERT INTO BloodTypes (Name) VALUES ('B-')");
            Sql("INSERT INTO BloodTypes (Name) VALUES ('O+')");
            Sql("INSERT INTO BloodTypes (Name) VALUES ('O-')");
            Sql("INSERT INTO BloodTypes (Name) VALUES ('AB+')");
            Sql("INSERT INTO BloodTypes (Name) VALUES ('AB-')");


            //=================================================//

            //SEED DISEASES

            Sql("INSERT INTO Diseases (Name) VALUES ('Cancer')");
            Sql("INSERT INTO Diseases (Name) VALUES ('Blood pressure disorders')");
            Sql("INSERT INTO Diseases (Name) VALUES ('heart')");
            Sql("INSERT INTO Diseases (Name) VALUES ('Diabetes')");
            Sql("INSERT INTO Diseases (Name) VALUES ('chest allergy')");
            Sql("INSERT INTO Diseases (Name) VALUES ('Neuropathy')");
            Sql("INSERT INTO Diseases (Name) VALUES ('asthma')");
            Sql("INSERT INTO Diseases (Name) VALUES ('Pulmonary embolism')");

            //=================================================//

            //SEED USERS

            Sql("INSERT INTO Users (Name, Password, ConfirmPassword, Email, Birthdate, mobileNo, UpImage, Height, Weight, Gender, BloodType_Id) VALUES ('Ahmed Shaaban','aaaa1111','aaaa1111','shaaban@domin.com','23/3/1995', 01148177915,'qwesdasdjjhgkfqwewqeasd', 180.0, 1170.0, 0, 3)");
            Sql("INSERT INTO Users (Name, Password, ConfirmPassword, Email, Birthdate, mobileNo, UpImage, Height, Weight, Gender, BloodType_Id) VALUES ('Abdalla Ghanem','aaaa1111','aaaa1111','Ghanem@domin.com','01/3/1995', 01448177915,'shsdfgdshdfhfh', 170.0, 90.0, 0, 2)");
            Sql("INSERT INTO Users (Name, Password, ConfirmPassword, Email, Birthdate, mobileNo, UpImage, Height, Weight, Gender, BloodType_Id) VALUES ('Mahmoud haya','aaaa1111','aaaa1111','Mahmoud@domin.com','15/3/1996', 01448177915,'vbvmvcvnvnvcn', 160.0, 60.0, 0, 1)");
            Sql("INSERT INTO Users (Name, Password, ConfirmPassword, Email, Birthdate, mobileNo, UpImage, Height, Weight, Gender, BloodType_Id) VALUES ('Ahmed Salah','aaaa1111','aaaa1111','Salah@domin.com','01/3/1995', 01448177915,'uiopyuoyuioyuiooy', 180.0, 90.0, 0, 8)");

            //=================================================//

            //SEED OPERATOR

            Sql("INSERT INTO Operators (Name,Email, Password, ConfirmPassword, IdentificationNumber, MobilePhone,Birthdate, Hiredate,Salary,IsAdmin, Gender) VALUES ('Ahmed Shaaban','ahmedsrk114@gmail.com','aaaa1111','aaaa1111', 1, 01148177915,'23/3/1995','01/01/2018', 5000, 1, 0)");

            //=================================================//

            //SEED EVENTS

            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 30.9876, 30.5972, 1, 1, 0 )");
            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 31.0004, 30.7865, 2, 2, 0 )");
            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 32.8998, 24.0889, 3, 3, 0 )");
            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 30.8428, 29.3084, 1, 4, 0 )");
            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 31.5041, 30.5765, 2, 1, 0 )");
            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 33.8116, 27.2579, 3, 2, 0 )");
            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 30.4728, 31.0425, 2, 3, 0 )");
            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 31.1681, 30.9697, 1, 4, 0 )");
            Sql("INSERT INTO Events (dateTime, Longitude, Latitude, EventType, UserId, IsProcessed) VALUES ('May 27, 2018 3:11:33 AM', 31.4913, 30.0074, 3, 1, 0 )");
            
            //=================================================//

            //SEED USERS_DISEASES
            Sql("INSERT INTO UserDisease (UserId, DiseaseId) VALUES (1,1)");
            Sql("INSERT INTO UserDisease (UserId, DiseaseId) VALUES (2,2)");
            Sql("INSERT INTO UserDisease (UserId, DiseaseId) VALUES (3,3)");
            Sql("INSERT INTO UserDisease (UserId, DiseaseId) VALUES (4,4)");
            Sql("INSERT INTO UserDisease (UserId, DiseaseId) VALUES (5,1)");
            Sql("INSERT INTO UserDisease (UserId, DiseaseId) VALUES (6,2)");
            Sql("INSERT INTO UserDisease (UserId, DiseaseId) VALUES (7,3)");
            Sql("INSERT INTO UserDisease (UserId, DiseaseId) VALUES (8,4)");

        }

        public override void Down()
        {
        }
    }
}
