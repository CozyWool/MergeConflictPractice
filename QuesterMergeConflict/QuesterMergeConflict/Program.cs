using QuesterMergeConflict;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        var quiz = new Quiz();
        List<string> answers = new List<string> { "A", "B", "C", "D" };

        quiz.AddQuestionWithAnswers("Какой-то вопрос", answers, 0);


        foreach (var question in quiz.Questions)
        {
            Console.WriteLine(question.Text);
            for (int i = 0; i < question.Answers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Answers[i].Text}");
            }

            Console.Write("Введите номер вашего ответа ");
            int answer = int.Parse(Console.ReadLine()) - 1;

Console.WriteLine("Hello, World!");