using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PrimarySchool
{
    public class Pupil
    {
        #region Champs
        private string _firstName;

        private string _lastName;

        internal Classroom _classroom;
        #endregion Champs

        #region Propriétés
        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public Classroom Classroom { get { return _classroom; } internal set { _classroom = value; } }
        #endregion Propriétés 

        #region Constructeur 
        internal Pupil()
        {
            _firstName = "";
            _lastName = "";
        }

        internal Pupil(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        #endregion Constructeur
    }
}
