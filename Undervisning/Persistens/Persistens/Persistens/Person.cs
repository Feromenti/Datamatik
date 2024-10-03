namespace persistens;

public class Person
{
    private string name;
    private DateTime birthDate;
    private double height;
    private bool isMarried;
    private int noOfChildren;

    public string Name
    {        
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("En person skal have et navn med mindst en karakter. Dvs. en tom tekststreng er ikke acceptabel som navn");
            }

            name = value;
        }
    
  
    }
    public DateTime BirthDate
    {
        get { return birthDate; }
        set
        {
            if (value < new DateTime(1900,1,1))
            {
                throw new Exception("Fødselsdatoen for en person må ikke være før 1. januar 1900.");
            }

            birthDate = value;
        }
    }
    public double Height
    {
        get { return height; }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Højden på en person skal være større end 0");
            }

            height = value;
        }
    }
    public bool IsMarried
    {
        get { return isMarried; }
        set { isMarried = value; }
    }
    public int NoOfChildren
    {
        get { return noOfChildren; }
        set
        {
            if (value < 0)
            {
                throw new Exception("En person må ikke have et negativt antal børn.");
            }

            noOfChildren = value;
        }
    }

    public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren = 0)
    {
        Name = name;
        BirthDate = birthDate;
        Height = height;
        IsMarried = isMarried;
        NoOfChildren = noOfChildren;
    }
    public string MakeTitle()
    {

        string titel = $"{name};{birthDate.ToString("dd-MM-yyyy HH':'mm':'ss")};{height};{isMarried};{noOfChildren}";
        return titel;
    }

}