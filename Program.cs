using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.ApplicationInsights.AspNetCore.Extensions;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.Language.Intermediate;


namespace Greeting_Website
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebHost.CreateDefaultBuilder(args)
                .Configure(app =>
                {
                    app.Run(async context =>
                    {
                        context.Response.StatusCode = 200;
                        var date = DateTime.Now.ToString("h:mmtt on dd MMMM yyyy");
                        var dir = context.Request.Path.Value;
                        var names = OrganiseDirectoryValues(dir);
                        await context.Response.WriteAsync($"Hello {names} {date}");
                    });
                })
                .Build()
                .Run();
        }

        private static string OrganiseDirectoryValues(string dir)
        {
            var names = dir.Split('/');
            var numOfNames = names.Length-1;
            switch (numOfNames)
            {
                  case 0:
                      return " ";
                  case 1:
                      return names[0];
                  case 2:
                      return names[0] + "and " + names[1];
                  default:
                      var organisedNames = "";
                      var endOfNames = names[names.Length - 2] + " and " + names[names.Length - 1];
                      for (var i = 0; i < names.Length-2; i++)
                      {
                          organisedNames += names[i] +", ";
                      }

                      return organisedNames + endOfNames;
                      
            }
        }
    }
}
