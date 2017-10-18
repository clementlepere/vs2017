using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PrimarySchool
{
    public class Classroom
    {
         #region Champs
        private string _name;
         #endregion Champs

        #region Propriétés
        public List<Pupil> PupilList { get; set; }

        public School School { get; set; }

        public string Name
        {
            get { return _name; }
            set {_name = value;}
        }

        public Teacher Teacher
        {
            get { return Teacher; }
        }
        #endregion Propriétés 

        #region Constructeurs
        public Classroom(string name)
        {
            Name = (String.IsNullOrWhiteSpace(name)) ? throw new ArgumentException() : name;
            PupilList = new List<Pupil>();
            School = new School(name);
        }

        internal Classroom()
        {
        }
        #endregion Constructeurs

        #region Méthodes
        public Pupil AddPupil( string firstName, string lastName )
        {
            Pupil pupil = new Pupil(firstName, lastName);           
            PupilList.Add(pupil);
            return pupil;
        }

        public Pupil FindPupil( string firstName, string lastName )
        {
            Pupil pupil = new Pupil();
            pupil = PupilList.Find(p =>( p.FirstName == firstName) && (p.LastName == lastName));
            return pupil;
        }
        #endregion Méthodes

    }
}
