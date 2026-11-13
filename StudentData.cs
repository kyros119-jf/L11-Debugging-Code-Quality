using System.Collections.Generic;
class StudentData
{
    public string Name;
    public List<int> Scores;

    public StudentData(string name, List<int> scores)
    {
        this.Name = name;
        this.Scores = scores;
    }

    public double CalculateAverage()
    {
        int total = 0;

        for (int i = 0; i < Scores.Count; i++)
        {
            total += Scores[i];
        }

        return (double)total / Scores.Count;
    }
}