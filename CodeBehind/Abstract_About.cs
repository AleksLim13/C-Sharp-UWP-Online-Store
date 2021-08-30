using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza.CodeBehind
{
    abstract class Abstract_About
    {
        private string missionStatement;
        private string background;
        private string values;
        private string interests;
        private string qualifications;
        private string inspirations;

        public Abstract_About() { }

        public Abstract_About(string missionStatement, string background, string values, string interests, string qualifications, string inspirations)
        {
            MissionStatement = missionStatement;
            Background = background;
            Values = values;
            Interests = interests;
            Qualifications = qualifications;
            Inspirations = inspirations;
        }//End C:*



        public string MissionStatement { get => missionStatement; set => missionStatement = value; }
        public string Background { get => background; set => background = value; }
        public string Values { get => values; set => values = value; }
        public string Interests { get => interests; set => interests = value; }
        public string Qualifications { get => qualifications; set => qualifications = value; }
        public string Inspirations { get => inspirations; set => inspirations = value; }
    }//End CL:*

}//End NS:*
