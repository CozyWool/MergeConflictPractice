namespace QuesterMergeConflict;

public class Question
{
    public string Text { get; set; }
    public List<Answer> Answers { get; set; }

    public Question()
    {
        Answers = new List<Answer>();
    }

    public void AddQuestion(string questionValue)
    {
        Text = questionValue;
    }

    public void AddAnswer(string text, bool isCorrect = false)
    {
        var answer = new Answer { Text = text, IsCorrect = isCorrect };
        Answers.Add(answer);
    }

    public bool CheckAnswer(int selectedAnswer)
    {
        if (selectedAnswer >= 0 && selectedAnswer < Answers.Count)
        {
            return Answers[selectedAnswer].IsCorrect;
        }
        return false;
    }
}