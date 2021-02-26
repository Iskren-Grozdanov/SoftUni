using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            roster = new List<Player>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return roster.Count; } }

        public void AddPlayer(Player player)
        {
            if (Count < Capacity)
            {
                roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player pl = roster.FirstOrDefault(p => p.Name == name);
            if (pl == null)
            {
                return false;
            }
            roster.Remove(pl);
            return true;
        }
        public void PromotePlayer(string name)
        {
            Player pl = roster.FirstOrDefault(p => p.Name == name);
            if (pl.Rank != "Member")
            {
                pl.Rank = "Member";
            }
        }
        public void DemotePlayer(string name)
        {
            Player pl = roster.FirstOrDefault(p => p.Name == name);
            if (pl.Rank != "Trial")
            {
                pl.Rank = "Trial";
            }
        }
        //public Player[] KickPlayersByClass(string classs) 
        //{
        //    Player[] pl = roster.Where(p => p.Class == classs).ToArray();
        //    roster.RemoveAll(p=>p.Class==classs);
        //    return pl;
        //}
        public Player[] KickPlayersByClass(string classy)
        {

            List<Player> myListTemp = new List<Player>();
            foreach (var player in this.roster)
            {
                if (player.Class == classy)
                {
                    myListTemp.Add(player);
                }
            }
            Player[] myArrayToReturn = myListTemp.ToArray();

            this.roster = this.roster.Where(x => x.Class != classy).ToList();

            return myArrayToReturn;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");

            foreach (var player in this.roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }



    }
}
