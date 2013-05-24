﻿// <copyright file="OffSiteCourse.cs" company="Telerik academy">
// Telerik academy homework for high quality classes - Task 03.SoftwareAcademy
// </copyright>
namespace SoftwareAcademy
{
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Represents an off-site software academy course.
    /// </summary>
    public class OffSiteCourse : Course
    {
        /// <summary>
        /// The name of the town in which the course is held.
        /// </summary>
        private string town;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OffSiteCourse"/> class.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher.</param>
        /// <param name="students">A list of students attending the course.</param>
        /// <param name="town">The town of the course.</param>
        public OffSiteCourse(string name, string teacherName, IList<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffSiteCourse"/> class.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        public OffSiteCourse(string name)
            : this(name, null, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffSiteCourse"/> class.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher.</param>
        public OffSiteCourse(string name, string teacherName)
            : this(name, teacherName, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffSiteCourse"/> class.
        /// </summary>
        /// <param name="name">The name of the course.</param>
        /// <param name="teacherName">The name of the teacher.</param>
        /// <param name="students">A list of students attending the course.</param>
        public OffSiteCourse(string name, string teacherName, IList<string> students)
            : this(name, teacherName, students, null)
        {
        }

        #endregion

        /// <summary>
        /// Gets or sets the town of the course.
        /// </summary>
        /// <value>Gets or sets the town field.</value>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                this.town = value;
            }
        }

        /// <summary>
        /// Returns the string representation of the course info -
        /// its base class info, plus the town name.
        /// </summary>
        /// <returns>A string which represents the off-site course info.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { ");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.AppendFormat("; Town = {0}", this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}