using System.Xml;
using System.IO;
using System.Text;
namespace QuesterMergeConflict;

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


        public Question GetQuestion(int index)
        {
            return questions[index];
        }

        public int GetCountQuestions()
        {
            return questions.Count;
		}
    public Question? GetQuestion(Question question)
    {
        return _questions.FirstOrDefault(q => question.Answers == q.Answers && question.Text == q.Text);
    }
        }

        public async void SaveToFileAsync(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                for(int i=0;i<questions.Count;i++)
                {
                    byte[] buffer = Encoding.Default.GetBytes(questions[i].ToString()+"\n");
                    await stream.WriteAsync(buffer, 0, buffer.Length);
                }
            }
        }
    }
