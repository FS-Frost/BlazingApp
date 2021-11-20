namespace MyLib {
    public class Person {
        /// <summary>
        /// The name.
        /// </summary>
        public string? Name { get; set; }
        public int Age { get; set; }

        public override string ToString() {
            return $"Person{{Name: {Name}, Age: {Age}}}";
        }
    }

    public class UsefulStuff {
        public static Person NewPerson() {
            return new Person { Age = 27, Name = "Frost" };
        }
    }
}