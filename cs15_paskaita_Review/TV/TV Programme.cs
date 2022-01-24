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
            var service = new TVProgrammeService();
            service.AddTVShowService(ProgrammeList, show);
        }

        public void RemoveTVShowByName(string input)
        {
            var service = new TVProgrammeService();
            service.RemoveTVShowByNameService(ProgrammeList, input);
        }

        public void RemoveTVShowByID(Guid input)
        {
            var service = new TVProgrammeService();
            service.RemoveTVShowByIDService(ProgrammeList, input);
        }

        public void PrintProgramme()
        {
            var service = new TVProgrammeService();
            service.PrintProgrammeService(ProgrammeList);
        }

        public void ClearProgramme()
        {
            ProgrammeList.Clear();
        }
    }
}
