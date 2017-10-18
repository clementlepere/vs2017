using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PrimarySchool
{
    public class Teacher
    {
        internal Teacher()
        {
        }

        public string Name { get { return Name; } }

        public School School { get { return School; } }
        
        public Classroom Assignment
        {
            get { return Assignment; }
        }

        #region Methods
        public void AssignTo( Classroom c )
        {
            throw new ArgumentException();
        }
        #endregion Methods
    }
}
