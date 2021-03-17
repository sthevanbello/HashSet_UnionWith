using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSet_Course.Entities
{
    class Students
    {
        public int Id { get; set; }

        public Students(int id)
        {
            Id = id;
        }



        public override bool Equals(object obj)
        {
            if (!(obj is Students))
            {
                return false;
            }
            Students other = obj as Students;

            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
