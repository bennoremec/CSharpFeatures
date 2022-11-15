namespace CSharpNewFeatures;

public class Person
{
    public string FirstName { get; }
    public string MiddleName { get; }
    public string LastName { get; }
    public string City { get; }
    public decimal Lohn { get; }

    public Person(string fname, string mname, string lname,
        string cityName, decimal lohn)
    {
        FirstName = fname;
        MiddleName = mname;
        LastName = lname;
        City = cityName;
        Lohn = lohn;
    }

    // c# 7 Deconstruction
    public void Deconstruct(out string fname, out string lname)
    {
        fname = FirstName;
        lname = LastName;
    }

    public void Deconstruct(out string fname, out string lname,
        out string city, out decimal lohn)
    {
        fname = FirstName;
        lname = LastName;
        city = City;
        lohn = Lohn;
    }
}