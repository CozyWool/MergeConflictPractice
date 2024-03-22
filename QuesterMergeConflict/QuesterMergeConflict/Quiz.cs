namespace QuesterMergeConflict;

public class Quiz
{
    public string Name { get; set; }
    public int point = 0;
    private Package Package;

    public Quiz(string name, Package package)
    {

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
        Name = name;
        Package = package;
    }

    public void StartQuiz()
    {
        for (int i = 0; i < Package.GetCountQuestions(); i++)
        {
            string answer=Console.ReadLine();
            if (CheckAnswer(answer, i));
        }
    }

    public bool CheckAnswer(string answer, int index)
    {
        if (answer==Package.GetQuestion(index).AnswerText) return true;
        return false;
    }
}