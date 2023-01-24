class Learners
{
    public string firstname;
    public string lastname;
    public string gender;
    public int age;
    public char intial;
    
    public Learners (string Firstname,string Lastname,string Gender,int Age,char  Intial)
    {
        firstname = Firstname;
        lastname = Lastname;
        gender = Gender;
        age = Age;
        intial = Intial;
    }
       static void Main(string[] args)
    
    {
        Learners learner1 = new Learners("Mokgadi", " Malope", "female", 28, 'M');
        
        Console.WriteLine(learner1.firstname+ " " + learner1.lastname + " " +learner1.gender + " " + learner1.age +" " + learner1.intial + ' ');

    }

}
