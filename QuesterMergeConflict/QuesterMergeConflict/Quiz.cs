namespace QuesterMergeConflict;

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