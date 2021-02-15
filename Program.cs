using System;
using System.Collections;
using System.Collections.Generic;
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

      foreach (var article in articles)
      {
        Console.WriteLine(article.Id);
        Console.WriteLine(article.Title);
        Console.WriteLine(article.Url);
      }

    }
  }
}

