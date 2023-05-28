
using FootballTask;

//Team1 (Barcelona players)

GoalKeeper GoalKeeper1 = new GoalKeeper ("Marc-André ter Stegen", 1,35,1.95);
Defender defender1 = new Defender ("Ronald Araújo", 2, 26, 1.85);
Defender defender2 = new Defender ("Jules Koundé", 3, 27, 1.75);
Defender defender3 = new Defender ("Marcos Alonso", 4, 28, 1.90);
Defender defender4 = new Defender ("Sergi Roberto", 5, 24, 1.82);
Midfielder midfielder1 = new Midfielder ("Gavi", 6, 25, 1.83);
Midfielder midfielder2 = new Midfielder ("Pedri", 7, 26, 1.76);
Midfielder midfielder3 = new Midfielder ("Sergio Busquets", 8, 27, 1.88);
Midfielder midfielder4 = new Midfielder ("Frenkie de Jong", 9, 23, 1.70);
Striker striker1 = new Striker ("Robert Lewandowski", 10, 24, 1.75);
Striker striker2 = new Striker ("Ousmane Dembélé", 11, 25, 1.80);

FootballPlayer[] playersTeam1 = new FootballPlayer[]
{
    GoalKeeper1,
    defender1,
    defender2,
    defender3,
    defender4,
    midfielder1,
    midfielder2,
    midfielder3,
    midfielder4,
    striker1,
    striker2
};
//Team2 (PSG players)
GoalKeeper goalkeeper2 = new GoalKeeper ("Keylor Navas", 1, 26, 1.82);
Defender defender5 = new Defender ("Thilo Kehrer", 2, 27, 1.85);
Defender defender6 = new Defender ("Abdou Diallo", 3, 28, 1.75);
Defender defender7 = new Defender ("Layvin Kurzawa", 4, 24, 1.90);
Defender defender8 = new Defender ("Presnel Kimpembe", 5, 25, 1.82);
Midfielder midfielder5 = new Midfielder ("Renato Sanches", 6, 26, 1.83);
Midfielder midfielder6 = new Midfielder ("Marco Verratti", 7, 27, 1.76);
Midfielder midfielder7 = new Midfielder ("Carlos Soler", 8, 23, 1.88);
Midfielder midfielder8 = new Midfielder ("Fabián Ruiz", 9, 24, 1.70);
Striker striker3 = new Striker ("Kylian Mbappé", 10, 25, 1.75);
Striker striker4 = new Striker ("Lionel Messi", 11, 30, 1.80);

FootballPlayer[] playersTeam2 = new FootballPlayer[]
{
    goalkeeper2,
    defender5,
    defender6,
    defender7,
    defender8,
    midfielder5,
    midfielder6,
    midfielder7,
    midfielder8,
    striker3,
    striker4
};

    
Coach coach = new Coach ("Christophe Galtier",  40);
Coach coach1 = new Coach("Xavi", 50);  
Referee referee = new Referee ("Felix Brych", 47);
    
AssistantReferee assistantReferee1 = new AssistantReferee  ("Anthony Taylor", 44 );    
AssistantReferee assistantReferee2 = new AssistantReferee  ("Daniele Orsato", 46 );
    
Team team1 = new Team(coach, playersTeam1);
Team team2 = new Team(coach, playersTeam2);    

Game game = new Game(team1, team2, referee, assistantReferee1, assistantReferee2);   
Console.WriteLine($"Match is starting!");    
Console.WriteLine($"Our referee today is {referee.Name}");    
Console.WriteLine($"Assistant referees are {assistantReferee1.Name} and {assistantReferee2.Name}");
Console.WriteLine($"The Average age of a Team1 players is {team1.PrintAverageAge()}");
Console.WriteLine($"The Average age of a Team2 players is {team2.PrintAverageAge()}");

game.PrintGoal(10, striker1, team1);    
game.ScoreGoal(team1);    
game.PrintGoal(13, striker3, team2);    
game.ScoreGoal(team2);    
game.PrintGoal(65, striker3, team2);    
game.ScoreGoal(team2);
string winner = game.GetWinner();
Console.WriteLine($"End of the Match!");
Console.WriteLine($"The winner is: {winner}");

   
