namespace QuesterMergeConflict;

public class Answer
{
    public string Text { get; set; }
    public bool IsCorrect { get; set; }
}

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

public class Quiz
{
    public List<Question> Questions { get; set; }

    public Quiz()
    {
        Questions = new List<Question>();
    }

    public void AddQuestionWithAnswers(string questionValue, List<string> answerValue, int correctAnswer)
    {
        var question = new Question();
        question.AddQuestion(questionValue);
        for (int i = 0; i < answerValue.Count; i++)
        {
            bool isCorrect = i == correctAnswer;
            question.AddAnswer(answerValue[i], isCorrect);
        }
        Questions.Add(question);
    }
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