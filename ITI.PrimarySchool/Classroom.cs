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
        private Teacher _teacher;
        #endregion Champs

        #region Propriétés
        private List<Pupil> PupilList { get; set; }

        public School School { get; internal set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (School != null && School.ClassroomList.Exists(c => (c.Name == value) && ( Name != value)))
                    throw new ArgumentException();
                _name = value;
            }
        }

        public Teacher Teacher { get { return _teacher; } internal set { _teacher = value; } }
        #endregion Propriétés 

        #region Constructeurs
        internal Classroom(string name)
        {
            Name = (String.IsNullOrWhiteSpace(name)) ? throw new ArgumentException() : name;
            PupilList = new List<Pupil>();
        }

        #endregion Constructeurs

        #region Méthodes
        public Pupil AddPupil(string firstName, string lastName)
        {
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName)
                || firstName.Length < 2 || lastName.Length < 2
                || PupilList.Exists(c => (c.FirstName == firstName) && (c.LastName == lastName))) throw new ArgumentException();
            else
            {
                Pupil pupil = new Pupil(firstName, lastName);
                pupil.Classroom = this;
                PupilList.Add(pupil);
                return pupil;
            }
        }

        public Pupil FindPupil(string firstName, string lastName)
        {
            Pupil pupil = new Pupil();
            pupil = PupilList.Find(p => (p.FirstName == firstName) && (p.LastName == lastName));
            return pupil;
        }
        #endregion Méthodes

    }
}
