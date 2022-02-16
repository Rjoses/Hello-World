using System;
public class Candidate {
    public Candidate()
    {
    }
    public Candidate(string name)
    {
        Name = name;
        Age = 30;
    }
    public string Name {get;set;}
    public int Age {get;set;}
    public double Alt{get;set;}
    public double kg{get;set;}

    public int FazerAnivesario(){
      Age = Age + 1;
      return Age;
    }
    public void Andar(){
      
    }
}