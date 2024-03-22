namespace QuesterMergeConflict;

public class Quiz
{
    private Package Package { get; set; }

    public Quiz(Package package)
    {
        Package = package;
    }

    public Quiz() : this(new())
    {
        
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
        Package.AddQuestion(question);
    }
    public void AddQuestion(Question question)
    {
        Package.AddQuestion(question);
    }
}