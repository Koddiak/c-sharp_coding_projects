using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Knockout.Models
{
    public static class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            DirectoryInfo emailRepo = new DirectoryInfo(@"C:\GitHub\repositories\c-sharp_coding_projects\Knockout\Knockout\wwwroot\emails\");

            using(var context = new WebmailContext(serviceProvider.GetRequiredService<DbContextOptions<WebmailContext>>()))
            {
                if (context.Email.Any())
                {
                    return;
                }

                foreach (var file in emailRepo.GetFiles("*.txt"))
                {
                    var _folder = File.ReadLines(file.FullName).SkipWhile(line => !line.Contains("Folder:")).TakeWhile(line => !line.Contains("ENDFOLDER"));
                    string folder = String.Join("", _folder).Substring(8);
                    var _from = File.ReadLines(file.FullName).SkipWhile(line => !line.Contains("From:")).TakeWhile(line => !line.Contains("ENDFROM"));
                    string from = String.Join("", _from).Substring(6);
                    var _to = File.ReadLines(file.FullName).SkipWhile(line => !line.Contains("To:")).TakeWhile(line => !line.Contains("ENDTO"));
                    string to = String.Join("", _to).Substring(4);
                    var _subject = File.ReadLines(file.FullName).SkipWhile(line => !line.Contains("Subject:")).TakeWhile(line => !line.Contains("ENDSUBJECT"));
                    string subject = String.Join("", _subject).Substring(9);
                    var _message = File.ReadLines(file.FullName).SkipWhile(line => !line.Contains("Message:")).TakeWhile(line => !line.Contains("ENDMESSAGE"));
                    string message = String.Join("", _message).Substring(9);

                    Random gen = new Random();
                    DateTime start = new DateTime(2020, 1, 1);
                    int range = (DateTime.Today - start).Days;
                    DateTime date = start.AddDays(gen.Next(range));

                    context.Email.AddRange(
                        new Email
                        {
                            Folder = folder,
                            From = from,
                            To = to,
                            Subject = subject,
                            Date = date,
                            Message = message
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}
