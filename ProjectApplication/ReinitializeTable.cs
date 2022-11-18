using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectApplication
{
	public static class ReinitializeTable
	{
		public static void RemakeTable()
		{
			try
			{
				SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

				builder.DataSource = "(localdb)\\GabeLocal";
				builder.InitialCatalog = "CIS560";

				SqlDataAdapter adapter = new SqlDataAdapter();
				String sql;
				//String sql2;

				using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
				{
					connection.Open();

					sql = ReinitializeTable.RemakeTableString();
					using (SqlCommand command = new SqlCommand(sql, connection))
					{
						SqlDataReader reader = command.ExecuteReader();
						//reader.Close();
					}
					/*
                    SqlDataAdapter adapter2 = new SqlDataAdapter();

                    sql2 = ReinitializeTable.RepopulateTablesString();
                    adapter.InsertCommand = new SqlCommand(sql2, connection);
                    int rows = adapter2.InsertCommand.ExecuteNonQuery();

					*/
					connection.Close();
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public static void RepopulateTables()
		{
			try
			{
				SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

				builder.DataSource = "(localdb)\\GabeLocal";
				builder.InitialCatalog = "CIS560";

				SqlDataAdapter adapter = new SqlDataAdapter();
				String sql;

				using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
				{
					connection.Open();

					/*
                    sql = ReinitializeTable.RemakeTableString();
                    MessageBox.Show(sql);
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        //reader.Close();
                    }
					*/

					sql = ReinitializeTable.RepopulateTablesString();
					adapter.InsertCommand = new SqlCommand(sql, connection);
					int rows = adapter.InsertCommand.ExecuteNonQuery();


					connection.Close();
					MessageBox.Show("Success, tables re-initialized.");
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}


		public static string RemakeTableString()
		{
			return @"
			DROP TABLE IF EXISTS BarDeals.Comments;
			DROP TABLE IF EXISTS BarDeals.Votes;
			DROP TABLE IF EXISTS BarDeals.Users;
			DROP TABLE IF EXISTS BarDeals.Deals;
			DROP TABLE IF EXISTS BarDeals.Bars;
			DROP TABLE IF EXISTS BarDeals.CollegeTowns;

			CREATE TABLE BarDeals.CollegeTowns
			(
				CollegeTownID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
				University NVARCHAR(64) NOT NULL,
				City NVARCHAR(64) NOT NULL,
				[State] NVARCHAR(64) NOT NULL

				UNIQUE(University, City, [State])
			)

			CREATE TABLE BarDeals.Bars
			(
				BarID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
				CollegeTownID INT NOT NULL FOREIGN KEY
					REFERENCES BarDeals.CollegeTowns(CollegeTownID),
				BarName NVARCHAR(64) NOT NULL,
				[Address] NVARCHAR(64) NOT NULL,
				City NVARCHAR(64) NOT NULL,
				[State] NVARCHAR(64) NOT NULL,
				GoogleRating DECIMAL(2,1) NOT NULL

				UNIQUE(CollegeTownId, BarName)
			)

			CREATE TABLE BarDeals.Deals
			(
				[Description] NVARCHAR(64) NOT NULL,
				[DayOfWeek] NVARCHAR(64) NOT NULL,
				StartTime NVARCHAR(32) NOT NULL,
				EndTime NVARCHAR(32) NOT NULL,
				DealID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
				BarID INT NOT NULL FOREIGN KEY
					REFERENCES BarDeals.Bars(BarID),
				HappyHour INT NOT NULL	CHECK 
					(HappyHour <= 1 AND HappyHour >= 0),
				UNIQUE(BarId, [Description], [DayOfWeek])
			)



			CREATE TABLE BarDeals.Users 
			(
				UserID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
				Email NVARCHAR(128) NOT NULL,	
				UNIQUE(Email)
			)


			CREATE TABLE BarDeals.Votes
			(
				VoteID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
				DealID INT NOT NULL FOREIGN KEY
					REFERENCES BarDeals.Deals(DealID),
				UserID INT NOT NULL FOREIGN KEY
					REFERENCES BarDeals.Users(UserID),
				Vote INT NOT NULL
				CHECK (Vote <= 1 AND VOTE >= -1)
				UNIQUE(DealID, UserID)
			)

			CREATE TABLE BarDeals.Comments 
			(
				CommentID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
				UserID INT NOT NULL FOREIGN KEY
					REFERENCES BarDeals.Users(UserID),
				[Text] NVARCHAR(128) NOT NULL,
				TimeSent DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
				UNIQUE(UserID, TimeSent)
			)
			";




		}

		public static string RepopulateTablesString()
		{
			return @"USE [CIS560];
			INSERT BarDeals.CollegeTowns(University, City, [State])
			VALUES
				(N'Indiana University Bloomington',N'Bloomington', N'Indiana'),
				(N'University of Maryland',N'College Park', N'Maryland'),
				(N'University of Michigan',N'Ann Arbor', N'Michigan'),
				(N'Michigan State University',N'East Lansing', N'Michigan'),
				(N'Ohio State University',N'Columbus', N'Ohio'),
				(N'Pennsylvania State University',N'University Park', N'Pennsylvania'),
				(N'Rutgers',N'New Brunswick', N'New Jersey'),
				(N'University of Illinois',N'Urbana-Champaign', N'Illinois'),
				(N'University of Iowa',N'Iowa City', N'Iowa'),
				(N'University of Minnesota',N'Minnesota', N'Minnesota'),
				(N'University of Nebraska',N'Lincoln', N'Nebraska'),
				(N'Northwestern University',N'Evanston', N'Illinois'),
				(N'Purdue University',N'West Lafayette', N'Indiana'),
				(N'University of Wisconsin',N'Madison', N'Wisconsin'),

				(N'University of Arizona',N'Tucson',N'Arizona'),
				(N'Arizona State University',N'Tempe',N'Arizona'),
				(N'University of California, Berkeley',N'Berkeley',N'California'),
				(N'Univeristy of California',N'Los Angeles',N'California'),
				(N'University of Colorado',N'Boulder',N'Colorado'),
				(N'University of Oregon',N'Eugene',N'Oregon'),
				(N'Oregon State University',N'Corvallis',N'Oregon'),
				(N'University of Southern California',N'Los Angeles',N'California'),
				(N'Stanford University',N'Stanford',N'California'),
				(N'University of Utah',N'Salt Lake City',N'Utah'),
				(N'University of Washington',N'Seattle',N'Washington'),
				(N'Washington State University',N'Pullman',N'Washington'),

				(N'Boston College',N'Chestnut Hill',N'Massachusetts'),
				(N'Clemson University',N'Clemson',N'South Carolina'),
				(N'Duke University',N'Durham',N'North Carolina'),
				(N'Florida State University',N'Tallahassee',N'Florida'),
				(N'Georgia Institute of Technology',N'Atlanta',N'Georgia'),
				(N'University of Louisville',N'Louisville',N'Kentucky'),
				(N'University of Miami',N'Coral Gables',N'Florida'),
				(N'University of North Carolina',N'Chapel Hill',N'North Carolina'),
				(N'North Carolina State University',N'Raleigh',N'North Carolina'),
				(N'University of Notre Dame',N'Notre Dame',N'Indiana'),
				(N'University of Pittsburgh',N'Pittsburgh',N'Pennsylvania'),
				(N'Syracuse University',N'Syracuse',N'New York'),
				(N'University of Virginia',N'Charlottesville',N'Virginia'),
				(N'Virginia Polytechnic Institute and State University',N'Blacksburg',N'Virginia'),
				(N'Wake Forest University',N'Winston-Salem',N'North Carolina'),

				(N'Baylor University', N'Waco', N'Texas'),
				(N'Iowa State University', N'Ames', N'Iowa'),
				(N'University of Kansas', N'Lawrence', N'Kansas'),
				(N'Kansas State University', N'Manhattan', N'Kansas'),
				(N'University of Oklahoma', N'Norman', N'Oklahoma'),
				(N'Oklahoma State University', N'Stillwater', N'Oklahoma'),
				(N'Texas Christian University', N'Fort Worth', N'Texas'),
				(N'University of Texas', N'Austin', N'Texas'),
				(N'Texas Tech University', N'Lubbock', N'Texas'),
				(N'West Virginia University', N'Morgantown', N'West Virginia'),

				(N'University of Florida', N'Gainesville', N'Florida'),
				(N'University of Georgia', N'Athens', N'Georgia'),
				(N'University of Kentucky', N'Lexington', N'Kentucky'),
				(N'University of Missouri', N'Columbia', N'Missouri'),
				(N'University of South Carolina', N'Columbia', N'South Carolina'),
				(N'University of Tennessee', N'Knoxville', N'Tennessee'),
				(N'Vanderbilt University', N'Nashville', N'Tennessee'),
				(N'University of Alabama', N'Tuscaloosa', N'Alabama'),
				(N'University of Arkansas', N'Fayetteville', N'Arkansas'),
				(N'University of Auburn', N'Auburn', N'Alabama'),
				(N'Louisiana State University', N'Baton Rouge', N'Louisiana'),
				(N'University of Mississippi', N'Oxford', N'Mississippi'),
				(N'Mississippi State University', N'Starkville', N'Mississippi'),
				(N'Texas A&M University', N'College Station', N'Texas');

			INSERT BarDeals.Bars(CollegeTownID, BarName, [Address], GoogleRating, City, [State])
			SELECT CT.CollegeTownID, Temp.BarName, Temp.[Address], Temp.GoogleRating, Temp.City, Temp.[State]
			FROM (
				VALUES
					(N'Porter''s', N'706 N Manhattan Ave', N'Manhattan', N'Kansas', 'Kansas State University', 4.0),
					(N'Tubby''s', N'1127 Moro St', N'Manhattan', N'Kansas', 'Kansas State University', 3.9),
					(N'O''Malley''s', N'1210 Moro St', N'Manhattan', N'Kansas', 'Kansas State University', 4.3),
					(N'Fat''s', N'1209 Laramie St', N'Manhattan', N'Kansas', 'Kansas State University', 4.5),
					(N'Taco Lucha', N'1130 Moro St', N'Manhattan', N'Kansas', 'Kansas State University', 4.5),
					(N'La Fiesta', N'2301 Tuttle Creek Blvd', N'Manhattan', N'Kansas', 'Kansas State University', 4.2),
					(N'Yard Bar', N'1213 Moro St', N'Manhattan', N'Kansas', 'Kansas State University', 3.4),
					(N'Auntie Mae''s Parlor', N'616 N 12th St', N'Manhattan', N'Kansas', 'Kansas State University', 4.6),
					(N'Mojo''s Beach Bar', N'1101 Moro St', N'Manhattan', N'Kansas', 'Kansas State University', 4.5),
					(N'Dirty Dawg Saloon', N'531 N Manhattan Ave', N'Manhattan', N'Kansas', 'Kansas State University', 4.0),
					(N'Kite''s', N'615 N 12th St', N'Manhattan', N'Kansas', 'Kansas State University', 4.0),
					(N'Finn''s Neighborhood Pub', N'317 Poyntz Ave', N'Manhattan', N'Kansas', 'Kansas State University', 4.5),
					(N'RC McGraws', N'2317 Tuttle Creek Blvd', N'Manhattan', N'Kansas', 'Kansas State University', 4.4),
					(N'Shot Stop', N'1215 Moro St', N'Manhattan', N'Kansas', 'Kansas State University', 4.4),
					(N'Tanner''s', N'1200 Moro St', N'Manhattan', N'Kansas', 'Kansas State University', 4.2),
					(N'McCool''s', N'710 N Manhattan Ave', N'Manhattan', N'Kansas', 'Kansas State University', 4.2),

					(N'Welch Ave. Station', N'207 Welch Ave', N'Ames', N'Iowa', 'Iowa State University', 4.6),
					(N'Sips', N'223 Welch Ave', N'Ames', N'Iowa', 'Iowa State University', 3.7),
					(N'Mickey''s Irish Pub', N'109 Welch Ave', N'Ames', N'Iowa', 'Iowa State University', 4.1),
					(N'Bar La Tosca', N'124 Welch Ave', N'Ames', N'Iowa', 'Iowa State University', 4.4),
					(N'Stomping Grounds Cafe', N'303 Welch Ave', N'Ames', N'Iowa', 'Iowa State University', 4.4),

					(N'Bullwinkles Bar', N'1344 Tennessee St', N'Lawrence', N'Kansas', 'University of Kansas', 3.8),
					(N'Jayhawk Cafe', N'1340 Ohio St', N'Lawrence', N'Kansas', 'University of Kansas', 2.6),
					(N'The Wheel', N'507 W 14st', N'Lawrence', N'Kansas', 'University of Kansas', 4.5),
					(N'Louise''s Bar', N'1009 Massachusetts St', N'Lawrence', N'Kansas', 'University of Kansas', 4.3),
					(N'Replay Lounge', N'946 Massachusetts St', N'Lawrence', N'Kansas', 'University of Kansas', 4.5),

					(N'Copper Penny', N'408 S Washington St', N'Stillwater', N'Oklahoma', 'Oklahoma State University', 3.9),
					(N'The Union', N'412 S Washington St', N'Stillwater', N'Oklahoma', 'Oklahoma State University', 3.9),
					(N'The Salty Bronc', N'911 W 5th Ave', N'Stillwater', N'Oklahoma', 'Oklahoma State University', 4.7),
					(N'Willies Saloon', N'323 S Washington St', N'Stillwater', N'Oklahoma', 'Oklahoma State University', 4.1),
					(N'J R Murphy''s', N'306 S Washington St', N'Stillwater', N'Oklahoma', 'Oklahoma State University', 4.0),

					(N'Library Bar & Grill', N'607 W Boyd St', N'Norman', N'Oklahoma', 'University of Oklahoma', 4.4),
					(N'The Deli', N'3089 White St', N'Norman', N'Oklahoma', 'University of Oklahoma', 4.6),
					(N'O''Connell''s Irish Pub & Grille', N'769 Asp Ave', N'Norman', N'Oklahoma', 'University of Oklahoma', 4.2),
					(N'Sideline Bar & Grill', N'563 Buchanan Ave', N'Norman', N'Oklahoma', 'University of Oklahoma', 4.3),
					(N'Rock House Bar', N'103 W Apache St', N'Norman', N'Oklahoma', 'University of Oklahoma', 4.4),
		
					(N'Crown and Anchor Pub', N'2911 San Jacinto Blvd', N'Austin', N'Texas', N'University of Texas', 4.3),
					(N'Buck Wild', N'308 E 6th St', N'Austin', N'Texas', 'University of Texas', 4.1),
					(N'Hole in the Wall', N'2538 Guadalupe St', N'Austin', N'Texas', 'University of Texas', 3.9),
					(N'Mockingbird Saloon', N'2610 Guadalupe St', N'Austin', N'Texas', 'University of Texas', 3.7),
					(N'Dirty Bill''s', N'511 Rio Grande St', N'Austin', N'Texas', 'University of Texas', 3.3),

					(N'Cricket''s Draft House', N'2412 Broadway St', N'Lubbock', N'Texas', 'Texas Tech University', 4),
					(N'Mesquites Bar', N'2419 Broadway St', N'Lubbock', N'Texas', 'Texas Tech University', 4.2),
					(N'Bar PM', N'1211 University Ave', N'Lubbock', N'Texas', 'Texas Tech University', 3.8),
					(N'Bash Riprock''s', N'2419 Main St', N'Lubbock', N'Texas', 'Texas Tech University', 3.7),
					(N'The Roof', N'2252 Marsha Sharp Fwy', N'Lubbock', N'Texas', 'Texas Tech University', 3.9),

					(N'University Pub', N'3019 S University Dr', N'Fort Worth', N'Texas', 'Texas Christian University', 4.3),
					(N'Buffalo Bros', N'3015 S University Dr', N'Fort Worth', N'Texas', 'Texas Christian University', 4.4),
					(N'Lot 12 Rooftop Bar', N'2512 W Berry St', N'Fort Worth', N'Texas', 'Texas Christian University', 4.6),
					(N'Ye Olde Bull & Bush', N'2300 Montgomery St', N'Fort Worth', N'Texas', 'Texas Christian University', 4.7),
					(N'Poop Deck Bar and Grill', N'3505 Blue Bonnet Cir', N'Fort Worth', N'Texas', 'Texas Christian University', 4.3),

					(N'Dancing Bear Pub', N'1117 Speight Ave', N'Waco', N'Texas', 'Baylor University', 4.3),
					(N'The Buckle', N'500 Bagby Ave', N'Waco', N'Texas', 'Baylor University', 4.3),
					(N'Truelove Bar', N'414 Franklin Ave', N'Waco', N'Texas', 'Baylor University', 4.1),
					(N'Freight Icehouse and Yardbar', N'1614 James Ave', N'Waco', N'Texas', 'Baylor University', 4.2),
					(N'The Boiler Room', N'501 S 8th St', N'Waco', N'Texas', 'Baylor University', 5.0)

				) Temp(BarName, [Address], City, [State], University, GoogleRating)
			INNER JOIN BarDeals.CollegeTowns AS CT ON CT.University = Temp.University AND CT.[State] = Temp.[State] AND CT.[City] = Temp.[City]

			INSERT BarDeals.Deals(B.BarID, [Description], HappyHour, [DayOfWeek], StartTime, EndTime)
			SELECT B.BarID, Temp.[Description], Temp.HappyHour, Temp.[DayOfWeek], Temp.StartTime, Temp.EndTime
			FROM (
					VALUES 
						(N'Porter''s', N'$7 Domestic Pitchers', 0, N'Monday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$3 Deep Eddy Bombs', 0, N'Monday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$4 Double Wells', 0, N'Monday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$2 You-Call-Its', 0, N'Wednesday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$2 Shots', 0, N'Wednesday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$2 Domestic Bottles', 0, N'Wednesday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$3.50 Bombs', 0, N'Wednesday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$5 Marg Pitchers', 0, N'Thursday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$3 Bombs', 0, N'Thursday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$3 Wells', 0, N'Thursday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$3 Import Bottles', 0, N'Thursday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$5 Rum Buckets', 0, N'Friday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$3 Svedka Shots', 0, N'Friday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$2 Mystery Shots', 0, N'Friday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$5 Rum Buckets', 0, N'Saturday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$3 Svedka Shots', 0, N'Saturday', N'4:00 PM', N'2:00 AM'),
						(N'Porter''s', N'$2 Mystery Shots', 0, N'Saturday', N'4:00 PM', N'2:00 AM'),

						(N'Tubbys''s', N'50¢ Well Shots', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Tubbys''s', N'$2 Flavored Shots', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Tubbys''s', N'$2.50 Pounders', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Tubbys''s', N'$2 Wells', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Tubbys''s', N'50¢ Wells', 0, N'Thursday', N'6:00 PM', N'2:00 AM'),
						(N'Tubbys''s', N'$1 Wells', 0, N'Friday', N'10:00 PM', N'11:00 PM'),
						(N'Tubbys''s', N'$1 Wells', 0, N'Saturday', N'10:00 PM', N'11:00 PM'),

						(N'O''Malley''s', N'$2.25 PBR Bottles', 0, N'Monday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2.25 Wells', 0, N'Monday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2 You-Call-Its', 0, N'Tuesday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$3.50 Bombs', 0, N'Tuesday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2.25 PBR', 0, N'Wednesday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2.25 Wells', 0, N'Wednesday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2 Shots', 0, N'Wednesday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2.25 PBR Bottles', 0, N'Thursday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2.25 Wells', 0, N'Thursday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2 Domestic Bottles', 0, N'Thursday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$3.25 Wells', 0, N'Friday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$3 Busch Light Bottles', 0, N'Friday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$3 Highlife Bottles', 0, N'Friday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$3.25 Wells', 0, N'Saturday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$3 Busch Light Bottles', 0, N'Saturday', N'2:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$3 Highlife Bottles', 0, N'Saturday', N'2:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2.25 PBR Bottles', 0, N'Sunday', N'4:00 PM', N'2:00 AM'),
						(N'O''Malley''s', N'$2.25 Wells', 0, N'Sunday', N'4:00 PM', N'2:00 AM'),

						(N'Fat''s', N'$2.50 Bottles', 0, N'Monday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$2 Wells', 0, N'Monday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$2 Wells', 0, N'Tuesday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$6 Fish Bowls', 0, N'Tuesday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$4 Double Redbull Vodkas', 0, N'Wednesday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$1 Double Wells', 0, N'Wednesday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$1 Double Wells', 0, N'Thursday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$4 Double Redbull Vodkas', 0, N'Thursday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$4 Fish Bowls', 0, N'Thursday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$2 Domestic Bottles', 0, N'Thursday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$8 Fish Bowls', 0, N'Friday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$4 Wells', 0, N'Friday', N'6:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$8 Fish Bowls', 0, N'Saturday', N'4:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$4 Wells', 0, N'Saturday', N'4:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$2.50 Bottles', 0, N'Sunday', N'4:00 PM', N'2:00 AM'),
						(N'Fat''s', N'$2 Wells', 0, N'Sunday', N'4:00 PM', N'2:00 AM'),

						(N'Taco Lucha', N'$3 Modelo, Dos Equis, Pacifico', 0, N'Tuesday', N'10:00 PM', N'12:00 AM'),
						(N'Taco Lucha', N'$3 Modelo, Dos Equis, Pacifico', 0, N'Wednesday', N'10:00 PM', N'12:00 AM'),
						(N'Taco Lucha', N'$3 Modelo, Dos Equis, Pacifico', 0, N'Thursday', N'10:00 PM', N'12:00 AM'),
						(N'Taco Lucha', N'$3 Modelo, Dos Equis, Pacifico', 0, N'Friday', N'10:00 PM', N'12:00 AM'),
						(N'Taco Lucha', N'$3 Modelo, Dos Equis, Pacifico', 0, N'Saturday', N'10:00 PM', N'12:00 AM'),
						(N'Taco Lucha', N'$2 Tecate Cans', 0, N'Sunday', N'11:00 AM', N'9:00 PM'),

						(N'La Fiesta', N'Half Off Margs', 0, N'Monday', N'11:00 AM', N'10:00 PM'),
						(N'La Fiesta', N'$7 24OZ Margs', 0, N'Tuesday', N'11:00 AM', N'10:00 PM'),
						(N'La Fiesta', N'$7 24OZ Margs', 0, N'Wednesday', N'11:00 AM', N'10:00 PM'),
						(N'La Fiesta', N'Half Off Beer', 0, N'Wednesday', N'11:00 AM', N'10:00 PM'),
						(N'La Fiesta', N'$6 24OZ Margs', 0, N'Thursday', N'11:00 AM', N'10:00 PM'),

						(N'Yard Bar', N'2 for $1 Double Wells', 0, N'Thursday', N'8:00 PM', N'9:00 PM'),
						(N'Yard Bar', N'$1 Pounders', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Yard Bar', N'$1 Wells', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Yard Bar', N'$2 Premiums', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Yard Bar', N'$2 Shots', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Yard Bar', N'$2 Bombs', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Yard Bar', N'50¢ Draws', 0, N'Saturday', N'8:00 PM', N'9:00 PM'),

						(N'Auntie Mae''s Parlor', N'$2 Wells', 0, N'Tuesday', N'3:00 PM', N'7:00 PM'),
						(N'Auntie Mae''s Parlor', N'$5 Moscow Mules', 0, N'Tuesday', N'7:00 PM', N'2:00 AM'),
						(N'Auntie Mae''s Parlor', N'$2 Wells', 0, N'Wednesday', N'3:00 PM', N'7:00 PM'),
						(N'Auntie Mae''s Parlor', N'$5 Craft Beer Pints', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Auntie Mae''s Parlor', N'$2 Wells', 0, N'Thursday', N'3:00 PM', N'7:00 PM'),
						(N'Auntie Mae''s Parlor', N'$2 Wells', 0, N'Friday', N'3:00 PM', N'7:00 PM'),
						(N'Auntie Mae''s Parlor', N'$3 Craft Beer Shorties', 0, N'Saturday', N'12:00 PM', N'7:00 PM'),
						(N'Auntie Mae''s Parlor', N'$3 Breakfast Shots', 0, N'Sunday', N'12:00 PM', N'2:00 AM'),

						(N'Mojo''s Beach Bar', N'$2 Sea Shots', 0, N'Tuesday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$2 Domestic Pounders/Bottles', 0, N'Tuesday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$2 Wells', 0, N'Tuesday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$2 Truly''s', 0, N'Tuesday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$3 Double Wells', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$3 Domestic Beers', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$2 Sea Shots', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$1 Rummy Bears', 0, N'Wednesday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$3 Double Wells', 0, N'Thursday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$3 Domestic Beers', 0, N'Thursday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$2 Sea Shots', 0, N'Thursday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$1 Rummy Bears', 0, N'Thursday', N'7:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$5 Double Wells', 0, N'Friday', N'5:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$3.50 Domestic Pounders', 0, N'Friday', N'5:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$2 Sea Shots', 0, N'Friday', N'5:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$1 Rummy Bears', 0, N'Friday', N'5:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$5 Double Wells', 0, N'Saturday', N'5:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$3.50 Domestic Pounders', 0, N'Saturday', N'5:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$2 Sea Shots', 0, N'Saturday', N'5:00 PM', N'2:00 AM'),
						(N'Mojo''s Beach Bar', N'$1 Rummy Bears', 0, N'Saturday', N'5:00 PM', N'2:00 AM'),

						(N'Dirty Dawg Saloon', N'$2 Coors Light and Miller Lite Bottles', 0, N'Thursday', N'7:00 PM', N'2:00 AM'),
						(N'Dirty Dawg Saloon', N'$5 Vegas Bombs', 0, N'Friday', N'7:00 PM', N'2:00 AM'),
						(N'Dirty Dawg Saloon', N'$5 Green Tea Shots', 0, N'Saturday', N'7:00 PM', N'2:00 AM'),

						(N'Kite''s', N'$4 Buckets', 0, N'Tuesday', N'9:00 PM', N'2:00 AM'),
						(N'Kite''s', N'$4 Buckets', 0, N'Thursday', N'9:00 PM', N'2:00 AM'),
						(N'Kite''s', N'$1 Wells', 0, N'Thursday', N'9:00 PM', N'2:00 AM'),
						(N'Kite''s', N'$2.50 Domestic Bottles', 1, N'Monday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$2.50 Domestic Bottles', 1, N'Tuesday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$2.50 Domestic Bottles', 1, N'Wednesday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$2.50 Domestic Bottles', 1, N'Thursday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$2.50 Domestic Bottles', 1, N'Friday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$3 Doubles', 1, N'Monday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$3 Doubles', 1, N'Tuesday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$3 Doubles', 1, N'Wednesday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$3 Doubles', 1, N'Thursday', N'3:00 PM', N'6:00 PM'),
						(N'Kite''s', N'$3 Doubles', 1, N'Friday', N'3:00 PM', N'6:00 PM'),

						(N'Finn''s Neighborhood Pub', N'$3 Domestic Pints', 0, N'Monday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$4.50 Summer Beers', 0, N'Monday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$5 Guinness Pints', 0, N'Monday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$2.50 Miller High Life & PBR', 0, N'Tuesday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$2.75 Domestic Bottles', 0, N'Tuesday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$4 Premium Bottles', 0, N'Tuesday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$3.75 Call Shots', 0, N'Wednesday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$4.75 Premium Shots', 0, N'Wednesday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$11.50 60OZ Domestic Pitchers', 0, N'Wednesday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$11 60OZ Domestic Pitchers', 0, N'Thursday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$6 32OZ Domestic Draws', 0, N'Friday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$3 Rum & Pepsi', 0, N'Friday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$3 Fireball Shots', 0, N'Friday', N'2:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$6 32OZ Domestic Draws', 0, N'Saturday', N'1:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$3 Fireball Shots', 0, N'Saturday', N'1:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$4 Bloody Marys', 0, N'Sunday', N'1:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$4.50 Summer Beers', 0, N'Sunday', N'1:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$5 Mini Beers', 0, N'Sunday', N'1:00 PM', N'2:00 AM'),
						(N'Finn''s Neighborhood Pub', N'$2.75 House Shots', 1, N'Sunday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$3.00 House Mixed Cocktails', 1, N'Sunday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$2.75 House Shots', 1, N'Monday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$3.00 House Mixed Cocktails', 1, N'Monday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$2.75 House Shots', 1, N'Tuesday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$3.00 House Mixed Cocktails', 1, N'Tuesday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$2.75 House Shots', 1, N'Wednesday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$3.00 House Mixed Cocktails', 1, N'Wednesday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$2.75 House Shots', 1, N'Thursday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$3.00 House Mixed Cocktails', 1, N'Thursday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$2.75 House Shots', 1, N'Friday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$3.00 House Mixed Cocktails', 1, N'Friday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$2.75 House Shots', 1, N'Saturday', N'3:00 PM', N'5:00 PM'),
						(N'Finn''s Neighborhood Pub', N'$3.00 House Mixed Cocktails', 1, N'Saturday', N'3:00 PM', N'5:00 PM'),

						(N'RC McGraws', N'$3 Pounders', 0, N'Monday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$3 Wells', 0, N'Monday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$3 Bottles', 0, N'Tuesday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$3 Bottles', 0, N'Wednesday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$3 Michelob Ultra Pounders', 0, N'Thusday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$5 Jack Daniels', 0, N'Thursday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$4.50 Vegas Bombs', 0, N'Friday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$3 Fireball', 0, N'Friday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$4.50 Vegas Bombs', 0, N'Saturday', N'11:00 AM', N'2:00 AM'),
						(N'RC McGraws', N'$3 Fireball', 0, N'Saturday', N'11:00 AM', N'2:00 AM'),

						(N'Shot Stop', N'2 for $1 Double Wells', 0, N'Thursday', N'8:00 PM', N'9:00 PM'),
						(N'Shot Stop', N'$1 Pounders', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Shot Stop', N'$1 Wells', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Shot Stop', N'$2 Premiums', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Shot Stop', N'$2 Shots', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Shot Stop', N'$2 Bombs', 0, N'Friday', N'8:00 PM', N'9:00 PM'),
						(N'Shot Stop', N'50¢ Draws', 0, N'Saturday', N'8:00 PM', N'9:00 PM'),

						(N'Tanner''s', N'$13 Domestic Buckets', 0, N'Monday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3.50 Deep Eddy Vodkas', 0, N'Monday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$4 Deep Eddy Bombs', 0, N'Monday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$4 Mexi-Beers', 0, N'Tuesday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$18 Mexi-Beer Buckets', 0, N'Tuesday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$4 House Margaritas', 0, N'Tuesday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3 Tequila Shots', 0, N'Tuesday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$4 Angry Orchard', 0, N'Wednesday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3.50 Captain Morgan', 0, N'Wednesday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$5 Deep Eddy Mules', 0, N'Wednesday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3.50 Jim Beam', 0, N'Thursday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$13 Domestic Beer Buckets', 0, N'Friday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$4 Titos Vodka', 0, N'Friday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3 Slurpees', 0, N'Friday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3 Fireball', 0, N'Friday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3 Slurpees', 0, N'Saturday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3 Soco Lime Shots', 0, N'Saturday', N'11:00 AM', N'2:00 AM'),
						(N'Tanner''s', N'$3 Slurpees', 0, N'Sunday', N'11:00 AM', N'12:00 AM'),
						(N'Tanner''s', N'$3 Soco Lime Shots', 0, N'Sunday', N'11:00 AM', N'12:00 AM')
				) Temp(BarName, [Description], HappyHour, [DayOfWeek], StartTime, EndTime)
			INNER JOIN BarDeals.Bars AS B ON B.BarName = Temp.BarName AND B.CollegeTownID = 45

			INSERT BarDeals.Users(Email)
			VALUES
      			  (N'hunter.harris@gmail.com'),
      			  (N'gabe.whitehair@gmail.com'),
      			  (N'patrick.surtain@gmail.com'),
      			  (N'justin.simmons@gmail.com'),
      			  (N'adrien.howard@gmail.com'),
      			  (N'will.martinez@gmail.com'),
      			  (N'john.smith@gmail.com'),
      			  (N'steve.man@gmail.com'),
      			  (N'gilbert.davie@gmail.com'),
      			  (N'ben.walock@gmail.com'),
      			  (N'nick.williams@gmail.com'),
      			  (N'adam.champlin@gnail.com'),
      			  (N'brock.lesnar@gmail.com'),
      			  (N'harry.kane@gmail.com'),
      			  (N'evan.wayne@gmail.com'),
      			  (N'kenzie.grace@gmail.com'),
      			  (N'joe.johnson@gmail.com'),
      			  (N'tim.patrick@gmail.com'),
      			  (N'brent.manning@gmail.com'),
      			  (N'ned.strack@gmail.com'),
      			  (N'bryan.griffin@gmail.com'),
      			  (N'donald.wilson@gmail.com'),
      			  (N'virgil.green@gmail.com'),
      			  (N'ryan.guy@gmail.com'),
      			  (N'clint.chapel@gmail.com'),
      			  (N'will.vetter@gmail.com'),
      			  (N'luke.horsch@gmail.com'),
      			  (N'grant.rachwal@gmail.com'),
      			  (N'logan.talley@gmail.com'),
      			  (N'sam.doser@gmail.com'),
      			  (N'charlie.mcgraw@gmail.com'),
      			  (N'matthew.wittenaur@gmail.com'),
      			  (N'sage.sieperda@gmail.com'),
      			  (N'gavin.drozinski@gmail.com'),
      			  (N'jayce.zukowski@gmail.com'),
      			  (N'maddy.mcdonald@gmail.com'),
      			  (N'tyler.bret@gmail.com'),
      			  (N'anna.brazil@gmail.com'),
      			  (N'ashton.rider@gmail.com'),
      			  (N'lexi.knappen@gmail.com'),
      			  (N'megan.mccoy@gmail.com'),
      			  (N'jenna.tammen@gmail.com'),
      			  (N'ashley.sagi@gmail.com'),
      			  (N'jack.dedrickson@gmail.com'),
      			  (N'sean.farnow@gmail.com'),
      			  (N'greg.hanes@gmail.com'),
      			  (N'jeff.strickland@gmail.com'),
      			  (N'nate.brown@gmail.com'),
      			  (N'nicole.porter@gmail.com'),
      			  (N'heather.lee@gmail.com'),
      			  (N'michael.alva@gmail.com');

			INSERT BarDeals.Votes(D.DealID, U.UserID, Vote)
			SELECT D.DealID, U.UserID, Vote
			FROM (
					VALUES
      				  (N'gabe.whitehair@gmail.com', -1, N'Porter''s', N'$7 Domestic Pitchers', N'Monday'),
      				  (N'patrick.surtain@gmail.com', 1, N'Tubby''s', N'50¢ Well Shots', N'Wednesday'),
      				  (N'justin.simmons@gmail.com', -1, N'O''Malley''s', N'$2.25 PBR Bottles', N'Monday'),
      				  (N'adrien.howard@gmail.com', 1, N'Fat''s', N'$2.50 Bottles', N'Monday'),
      				  (N'will.martinez@gmail.com', -1, N'Taco Lucha', N'$3 Modelo, Dos Equis, Pacifico', N'Tuesday'),
      				  (N'john.smith@gmail.com', 1, N'La Fiesta', N'Half Off Margs', N'Monday'),
      				  (N'steve.man@gmail.com', 1, N'Yard Bar', N'2 for $1 Double Wells', N'Thursday'),
      				  (N'gilbert.davie@gmail.com', 1, N'Auntie Mae''s Parlor', N'$2 Wells', N'Tuesday'),
      				  (N'ben.walock@gmail.com', 1, N'Mojo''s Beach Bar', N'$2 Sea Shots', N'Tuesday'),
      				  (N'gabe.whitehair@gmail.com', 1, N'Mojo''s Beach Bar', N'$2 Sea Shots', N'Tuesday')

				) Temp(Email, Vote, BarName, [Description], [DayOfWeek])
			INNER JOIN BarDeals.Users AS U ON U.Email = Temp.Email
			INNER JOIN BarDeals.Deals AS D ON D.[Description] = Temp.[Description] AND D.[DayOfWeek] = Temp.[DayOfWeek]
			INNER JOIN BarDeals.Bars AS B ON B.CollegeTownID = 45 AND B.BarName = Temp.BarName

			INSERT BarDeals.Comments(U.UserID, [Text], TimeSent)
			SELECT U.UserID, V.[Text], V.TimeSent
			FROM
      			  (
            			VALUES
                  			  (N'hunter.harris@gmail.com', N'Manhattan''s bar deals rock!', '2025-12-10 12:32:10'),
                  			  (N'hunter.harris@gmail.com', N'$1 doubles at fats on Wednesday and Thursday is the best deal!', '2025-12-10 12:32:11'),
                  			  (N'hunter.harris@gmail.com', N'McCools is an awesome new bar!', '2025-12-10 12:32:12'),
                  			  (N'hunter.harris@gmail.com', N'Anyone want to meet up for drinks?', '2025-12-10 12:32:13'),
                  			  (N'hunter.harris@gmail.com', N'Come to Omalleys.', '2025-12-10 12:32:14'),                  
							  (N'hunter.harris@gmail.com', N'Watching the cats play at Kites.', '2025-12-10 12:32:15'),
                  			  (N'hunter.harris@gmail.com', N'I wish Dawgs had more deals.', '2025-12-10 12:32:16'),
                  			  (N'hunter.harris@gmail.com', N'I have learned about a lot of new deals from this app!', '2025-12-10 12:32:17'),
                  			  (N'hunter.harris@gmail.com', N'Finn''s has a ton of deals!', '2025-12-10 12:32:18'),
                  			  (N'hunter.harris@gmail.com', N'Any recommendations on where to get a pitcher of beer', '2025-12-10 12:32:19'),
                  			  (N'gabe.whitehair@gmail.com', N'This app is awesome!', '2025-12-10 12:32:20'),
                  			  (N'gabe.whitehair@gmail.com', N'Hi everyone!', '2025-12-10 12:32:23')
      			  ) V(Email, [Text], TimeSent)
			INNER JOIN BarDeals.Users U ON U.Email = V.Email
			";
		}

	}
}
