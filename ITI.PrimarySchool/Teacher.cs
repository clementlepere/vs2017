using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PrimarySchool
{
    public class Teacher
    {
        #region Propriétés
        public string Name { get; internal set; }

        public School School { get; internal set; }

        public Classroom Assignment { get; internal set; }

        #endregion Propriétés

        #region Constructeurs
        internal Teacher(string name)
        {
            Name = (String.IsNullOrWhiteSpace(name)) ? throw new ArgumentException() : name;
        }
        #endregion Constructeurs

        #region Methods
        public void AssignTo(Classroom c)
        {
            if (c != null && !c.School.Equals(School))
                throw new ArgumentException();
            if (Assignment != null)
                Assignment.Teacher = null;
            if (c == null)
            {
                if (Assignment != null) Assignment = null;
                return;
            }
            c.Teacher = this;
            Assignment = c;
        }
        #endregion Methods
    }
}
