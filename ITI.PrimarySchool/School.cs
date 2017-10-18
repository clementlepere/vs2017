using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.PrimarySchool
{
    public class School
    {
        #region Champs
        private string _name;
        #endregion Champs

        #region Propriétés 
        public string Name
        {
            get { return _name; }private set { _name = value; }
        }
        public List<Classroom> ClassroomList { get; set; }

        public List<Teacher> TeacherList { get; set; }

        //public School (string name) => Name = name;
        #endregion Propriétés 

        #region Constructeurs
        public School(string name)
        {
            Name = (String.IsNullOrWhiteSpace(name)) ? throw new ArgumentException() : name;

            TeacherList = new List<Teacher>();

            ClassroomList = new List<Classroom>();
        }
        #endregion Constructeurs

        #region Méthodes    
        public Teacher AddTeacher( string name )
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }
            else
            { 
                Teacher teacher = new Teacher();
                 

                if (TeacherList.Exists(c => c.Name == name))
                {
                    throw new ArgumentException();
                }
                else
                {
                    TeacherList.Add(teacher);
                }
                return teacher;
            }

        }

        public Teacher FindTeacher( string name )
        {
            Teacher teacher = new Teacher();

            teacher = TeacherList.Find(t => t.Name == name);

            return teacher;
        }

        public Classroom AddClassRoom( string name )
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException();
            }
            else
            {
                Classroom classRoom = new Classroom
                {
                    Name = name         
                };
                if (ClassroomList.Exists(c => c.Name == name))
                {
                    throw new ArgumentException();
                }
                else
                {
                    ClassroomList.Add(classRoom);
                }
                return classRoom;
            }
        }

        public Classroom FindClassRoom( string name )
        {
            Classroom classroom = new Classroom();
            classroom = ClassroomList.Find(c => c.Name == name);
            return classroom;
        }
        #endregion Méthodes
    }
}
