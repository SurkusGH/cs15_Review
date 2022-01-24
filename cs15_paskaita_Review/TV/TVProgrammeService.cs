using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15_paskaita_Review
{
    internal class TVProgrammeService
    {
        public void AddTVShowService(List<TV_Show> list, TV_Show show)
        {
            list.Add(show);
        }
        public void RemoveTVShowByNameService(List<TV_Show> list, string input)
        {
            foreach (var item in list)
            {
                if (item.Title == input)
                {
                    list.Remove(item);
                    break;
                }
            }
        }

        public void RemoveTVShowByIDService(List<TV_Show> list, Guid input)
        {
            foreach (var item in list)
            {
                if (item.ID == input)
                {
                    list.Remove(item);
                    break;
                }
            }
        }

        public void PrintProgrammeService(List<TV_Show> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"ID: {item.ID} | Duration: {item.Duration} | Title: {item.Title} | Descritpion {item.Description} | Start Time: {item.StartTime}");
            }
        }
    }
}
