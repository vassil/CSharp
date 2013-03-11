using System;
using System.Collections.Generic;

namespace School
{
    public class School
    {
        private List<Class> allClasses = new List<Class>();
        private string name;

        public School(string schoolName)
        {
            this.name = schoolName;
        }

        #region Properties

        //there is no school without name, right?
        public string Name{
            get { return name; } 
        }

        IReadOnlyCollection<Class> AllClasses
        {
            get { return allClasses; }
        }

        #endregion

        /// <summary>
        ///     Add a class with a unique identifier
        ///     E.g. "12B" -> 12B class
        /// </summary>
        /// <param name="classIdentifier"></param>
        public void AddClass(Class schoolClass)
        {
            allClasses.Add(schoolClass);
        }

    }
}
