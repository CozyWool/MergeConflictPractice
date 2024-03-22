using QuesterMergeConflict;

Console.Write("Введите название пакета: ");
var packageName = Console.ReadLine();
Quiz quiz = new(new Package(packageName));
var question = new Question();

Console.Write("Введите текст вопроса: ");
var questionText = Console.ReadLine();
question.AddQuestion(questionText);

Console.Write("Введите правильный ответ: ");
var correctAnswer = Console.ReadLine();
question.AddAnswer(correctAnswer, true);

Console.Write("Введите неправильный ответ: ");
var uncorrectAnswer = Console.ReadLine();
question.AddAnswer(uncorrectAnswer, true);
quiz.AddQuestion(question);