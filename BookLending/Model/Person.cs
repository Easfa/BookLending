using System.ComponentModel.DataAnnotations;

namespace BookLending.Model
{
    public class Person
    {
        [Key]
        public int P_ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, string lastname, int age) { Name = name; LastName = lastname; Age = age; }
    }
}
