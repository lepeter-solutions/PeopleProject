using System.Text.Json.Serialization;

namespace PeopleProject
{
    public class PersonStatistic
    {

        public List<Person> people { get; set; }

        public PersonStatistic()
        {
            this.people = new List<Person>();
        }

        public double getAverageAge()
        {
            double sum = 0;
            foreach (Person person in people)
            {
                sum += person.Age;
            }
            if (people.Count == 0)
            {
                return 0;
            }

            return sum / people.Count;
        }

        public int getNumberOfStudents()
        {
            return people.Count(p => p.isStudent);
        }

        public Person getPersonWithHighestScore()
        {
            if (people.Count == 0)
            {
                return null;
            }
            return people.OrderByDescending(p => p.Score).First();
        }

        public double getAverageScoreOfStudents()
        {
            double sum = 0;
            int count = 0;
            foreach (Person person in people)
            {
                if (person.isStudent)
                {
                    sum += person.Score;
                    count++;
                }
            }
            return sum / count;
        }

        public Person getOldestStudent()

        {
            if (people.Count == 0)
            {
                return null;
            }
            return people.Where(p => p.isStudent).OrderByDescending(p => p.Age).First();
        }

        public bool isAnyoneFailing()
        {
            return people.Any(p => p.Score < 40);
        }

    }
}
