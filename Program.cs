using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var articles = new List<Article>();
            articles.Add(new Article("Artigo oop", "oop-oop"));
            articles.Add(new Article("Artigo dotnet", ".Net"));
            articles.Add(new Article("Artigo AspNet", "Asp_Net"));

            foreach (var article in articles)
            {
                Console.WriteLine($"-----{article.Title}------");
                Console.WriteLine($"Id => {article.Id}");
                Console.WriteLine($"URL => {article.Url}");
                
            }

            System.Console.WriteLine("------------------------");

            var course = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentaos-oop-oop");
            var courseAspNet = new Course("Fundamentos AspNet", "fundamentaos-AspNet");
            var courseDotNet = new Course("Fundamentos DotNet", "fundamentaos-dotNet");
            course.Add(courseOOP);
            course.Add(courseAspNet);
            course.Add(courseDotNet);

            var careers = new List<Career>();

            var careerDotNet = new Career("Especialista DotNet", "Especialista-DotNet");
            var careerItem2 = new CareerItem(2, "OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", null);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", null);

            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem);

            careers.Add(careerDotNet);

            foreach(var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach(var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }
        }
    }
}
