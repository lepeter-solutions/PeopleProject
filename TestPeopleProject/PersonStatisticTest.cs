using PeopleProject;

namespace TestPeopleProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            PersonStatistic personStatistic = new PersonStatistic();
        }


        [Test]

        public void TestAverageAge()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            personStatistic.people.Add(new Person(1, "John", 20, true, 80));
            personStatistic.people.Add(new Person(2, "Jane", 30, false, 70));
            personStatistic.people.Add(new Person(3, "Joe", 40, true, 60));
            Assert.AreEqual(30, personStatistic.getAverageAge());
        }

        [Test]
        public void TestAverageAgeEmpty()
        {

            PersonStatistic personStatistic = new PersonStatistic();
            Assert.AreEqual(0, personStatistic.getAverageAge());

        }

        [Test]

        public void TestNumberOfStudents()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            personStatistic.people.Add(new Person(1, "John", 20, true, 80));
            personStatistic.people.Add(new Person(2, "Jane", 30, false, 70));
            personStatistic.people.Add(new Person(3, "Joe", 40, true, 60));
            Assert.AreEqual(2, personStatistic.getNumberOfStudents());
        }

        [Test]

        public void TestNumberOfStudentsEmpty()
        {

            PersonStatistic personStatistic = new PersonStatistic();
            Assert.AreEqual(0, personStatistic.getNumberOfStudents());
        }

        public void TestPersonWithHighestScore()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            personStatistic.people.Add(new Person(1, "John", 20, true, 80));
            personStatistic.people.Add(new Person(2, "Jane", 30, false, 70));
            personStatistic.people.Add(new Person(3, "Joe", 40, true, 60));
            Assert.AreEqual(80, personStatistic.getPersonWithHighestScore().Score);
        }
        [Test]
        public void TestPersonWithHighestScoreEmpty()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            Assert.AreEqual(null, personStatistic.getPersonWithHighestScore());
        }

        [Test]

        public void TestAverageScoreOfStudents()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            personStatistic.people.Add(new Person(1, "John", 20, true, 80));
            personStatistic.people.Add(new Person(2, "Jane", 30, false, 70));
            personStatistic.people.Add(new Person(3, "Joe", 40, true, 60));
            Assert.AreEqual(70, personStatistic.getAverageScoreOfStudents());
        }

        public void TestAverageScoreOfStudentsEmpty()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            Assert.AreEqual(0, personStatistic.getAverageScoreOfStudents());
        }

        [Test]

        public void TestOldestStudent()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            personStatistic.people.Add(new Person(1, "John", 20, true, 80));
            personStatistic.people.Add(new Person(2, "Jane", 30, false, 70));
            personStatistic.people.Add(new Person(3, "Joe", 40, true, 60));
            Assert.AreEqual(40, personStatistic.getOldestStudent().Age);
        }


        [Test]

        public void TestOldestStudentEmpty()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            Assert.AreEqual(null, personStatistic.getOldestStudent());
        }

        [Test]

        public void IsAnyoneFailingTestThrowsFalse()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            personStatistic.people.Add(new Person(1, "John", 20, true, 80));
            personStatistic.people.Add(new Person(2, "Jane", 30, false, 70));
            personStatistic.people.Add(new Person(3, "Joe", 40, true, 60));
            Assert.AreEqual(false, personStatistic.isAnyoneFailing());

        }

        [Test]

        public void IsAnyoneFailingTestThrowsTrue()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            personStatistic.people.Add(new Person(1, "John", 20, true, 80));
            personStatistic.people.Add(new Person(2, "Jane", 30, false, 70));
            personStatistic.people.Add(new Person(3, "Joe", 40, true, 30));
            Assert.AreEqual(true, personStatistic.isAnyoneFailing());
        }

        [Test]


        public void IsAnyoneFailingTestThrowsEmpty()
        {
            PersonStatistic personStatistic = new PersonStatistic();
            Assert.AreEqual(false, personStatistic.isAnyoneFailing());
        }
    }
}