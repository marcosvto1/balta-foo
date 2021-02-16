using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;

namespace Balta
{
  class Program
  {
    static void Main(string[] args)
    {
      var articles = new List<Article>();

      articles.Add(new Article("Artigo sobre OOP", "orientecao-objeto"));
      articles.Add(new Article("Artigo sobre Angular", "angular"));
      articles.Add(new Article("Artigos sobre c#", "csharp"));

      // foreach (var article in articles)
      // {
      //   Console.WriteLine(article.Id);
      //   Console.WriteLine(article.Title);
      //   Console.WriteLine(article.Url);
      // }

      var courses = new List<Course>();
      var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
      var courseAspNet = new Course("Fundamentos ASP.NET", "fundamento ASP.NET");
      var courseCSharp = new Course("Fundamentos CSharp", "fundamento Csharp");

      courses.Add(courseOOP);
      courses.Add(courseAspNet);
      courses.Add(courseCSharp);

      var careers = new List<Career>();
      var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
      var careerItem3 = new CareerItem(3, "Fudanmentos APS.NET", "", courseAspNet);
      var careerItem = new CareerItem(1, "Começe por aqui", "", null);
      var careerItem2 = new CareerItem(2, "Fudanmentos C#", "", courseCSharp);

      careerDotNet.Items.Add(careerItem3);
      careerDotNet.Items.Add(careerItem);
      careerDotNet.Items.Add(careerItem2);

      careers.Add(careerDotNet);

      foreach (var carreer in careers) {
        System.Console.WriteLine($">>{carreer.Title}");
        foreach (var item in carreer.Items.OrderBy(x => x.Order)) {
          System.Console.WriteLine($"{item.Order}-{item.Title}");
          System.Console.WriteLine($"\tCourse:{item.Course?.Title}");
          System.Console.WriteLine($"\tLevel:{item.Course?.Level}");

        }
      }

    }
  }
}

