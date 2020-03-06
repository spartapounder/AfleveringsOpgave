
namespace AfleveringsOpgave
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int score { get; set; }

        public User(int _id, string _name, int _age, int _score)
        {
            id = _id;
            name = _name;
            age = _age;
            score = _score;
        }
        public override string ToString()
        {
            return (id.ToString() + " - " + name);
        }
    }
}
