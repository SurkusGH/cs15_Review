using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15_paskaita_Review
{
    public class TV_Programme
    {
        public List<TV_Show> ProgrammeList { get; set; }

        public TV_Programme()
        {
            ProgrammeList = new List<TV_Show>();
        }

        public void AddTVShow(TV_Show show)
        {
            ProgrammeList.Add(show);
        }
        public void RemoveTVShowByName(string input)
        {

            foreach (var item in ProgrammeList)
            {
                if (item.Title == input)
                {
                    ProgrammeList.Remove(item);
                    break;
                }
            }
        }

        public void RemoveTVShowByID(Guid input)
        {
            foreach (var item in ProgrammeList)
            {
                if (item.ID == input)
                {
                    ProgrammeList.Remove(item);
                    break;
                }
            }
        }

        public void PrintProgramme()
        {
            foreach (var item in ProgrammeList)
            {
                Console.WriteLine($"ID: {item.ID} | Duration: {item.Duration} | Title: {item.Title} | Descritpion {item.Description} | Start Time: {item.StartTime}");
            }
        }

        public void ClearProgramme()
        {
            ProgrammeList.Clear();
        }
    }
}
