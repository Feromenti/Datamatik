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
    }

    public DateTime BirthDate
    {
        get { return birthDate; } 
    }
    public double Height
    {
        get { return height; }    
    }
    public bool IsMarried
    {
        get { return isMarried; }
    }
    public int NoOfChildren
    {
        get { return noOfChildren; }
    }


    public Person(string name, DateTime birthTime, double height, bool isMarried, int noOfChildren)
    {
        this.name = name;
        this.birthDate = birthTime;
        this.height = height;
        this.isMarried = isMarried;
        this.noOfChildren = noOfChildren;
    }
    public string MakeTitle()
    {
        
        string titel = $"{name};{birthDate.ToString("dd-MM-yyyy HH':'mm':'ss")};{height};{isMarried};{noOfChildren}";
        return titel;
    }
}
