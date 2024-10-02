using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrangeTreeSim;

public class OrangeTree
{
    private int age {  get; set; }
    private int height;
    private bool treeAlive;
    private int numOranges;
    private int orangesEaten;

    

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetHeight(int height)
    {
        this.height = height;
    }

    public int GetHeight()
    {
        return height;
    }

    public void SetTreeAlive(bool treeAlive)
    {
        this.treeAlive = treeAlive;
        treeAlive = true;
    }

    public bool GetTreeAlive()
    {
        return treeAlive;
    }

    public int GetNumOranges()
    {
        return numOranges;
    }

    public int GetOrangesEaten()
    {
        return orangesEaten;
    }

    public void OneYearPasses()
    {
        age++;

        if (age < 80 && treeAlive == true)
            height = height + 2;

        else
            treeAlive = false;
        numOranges = 0;

        if (age > 1)
            numOranges = numOranges + 5;
        int count = numOranges;
    }

    public void EatOrange(int count)
    {
        count = numOranges;
    }


}
