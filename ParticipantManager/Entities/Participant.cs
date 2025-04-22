using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantManager.Entities
{
    [Serializable]
    public class Participant : IComparable<Participant>, ICloneable
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public Participant() { }

        public Participant(string lastName, string firstName, DateTime birthDate)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException(nameof(lastName), "Last name cannot be empty");
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentNullException(nameof(firstName), "First name cannot be empty");

            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }
        
        //IComparable
        public int CompareTo(Participant other)
        {
            if (other == null) return 1;

            int lastNameComparison = string.Compare(this.LastName, other.LastName);
            if (lastNameComparison != 0)
                return lastNameComparison;

            return string.Compare(this.FirstName, other.FirstName);
        }

        //ICloneable
        public object Clone()
        {
            Participant clone = (Participant)this.MemberwiseClone();
            return clone;
        }
    }
}
