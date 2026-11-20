namespace BSIT_32E1_Elective_2_Assignment_1.Models;

public class Question
{
    public int Number { get; set; }
    public string Text { get; set; } = "";
    public List<string> Options { get; set; } = new();
    public int CorrectIndex { get; set; }
    public string Explanation { get; set; } = "";
    public string? Note { get; set; }
}
