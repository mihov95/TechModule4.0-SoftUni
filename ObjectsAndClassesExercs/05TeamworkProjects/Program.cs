using System;
using System.Collections.Generic;
using System.Linq;

namespace _05TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < countTeams; i++)
            {
                string[] splittedInput = Console.ReadLine().Split('-');

                string creator = splittedInput[0];
                string teamName = splittedInput[1];

                bool isTeamNameExist = teams.Any(x => x.Name == teamName);
                bool isCreatorNameExist = teams.Any(x => x.CreatorName == creator);

                if (isTeamNameExist)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                if (isCreatorNameExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (!isTeamNameExist && !isCreatorNameExist)
                {
                    var team = new Team(teamName, creator);
                    teams.Add(team);
                }
            }


            while (true)
            {
            string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                string[] splittedInput = Console.ReadLine().Split("->");

                string user = splittedInput[0];
                string teamName = splittedInput[1];

                bool isTeamNameExist = teams.Any(x => x.Name == teamName);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(user));

                if (isTeamNameExist == false)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                if (isAlreadyMember)
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }

                if (isTeamNameExist == false && isAlreadyMember == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == teamName);
                    teams[indexOfTeam].Members.Add(user);
                }

                
            }

                
        }
    }
    public class Team
    {
        public Team(string name, string creatorName)
        {
            Name = name;
            CreatorName = creatorName;
            Members = new List<string>();   
        }
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}
