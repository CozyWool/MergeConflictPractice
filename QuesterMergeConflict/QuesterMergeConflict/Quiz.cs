namespace QuesterMergeConflict;

public class Quiz
{
    
}

public class Question(string condition, string answer)
{
    public string Condition { get; set; } = condition;
    public string Answer { get; set; } = answer;
}

public class Package
{
    private readonly List<Question> _questions;

    public Package(List<Question> questions, string name)
    {
        _questions = questions;
        Name = name;
    }

    public Package(string name) : this([], name)
    {
    }

    public string Name { get; set; }

    public void AddQuestion(Question question)
    {
        _questions.Add(question);
    }
    public void DeleteQuestion(Question question)
    {
        _questions.Remove(question);
    }

    public void UpdateQuestion(Question question)
    {
        var index = _questions.IndexOf(question);
        if (index == -1) return;

        _questions[index] = question;
    }

    public Question? GetQuestion(Question question)
    {
        return _questions.FirstOrDefault(q => question.Answer == q.Answer && question.Condition == q.Condition);
    }
    
    public Question? GetQuestion(int index)
    {
        if (index < 0 || index >= _questions.Count) return null;
        
        return _questions[index];
    }
}