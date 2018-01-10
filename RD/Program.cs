using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = GetDynamicData(2);
            Console.WriteLine(test.Name);
        }
        public static dynamic GetDynamicData(dynamic i)
        {
            dynamic listdata = new[]
            { new {
                Id=1,
                Name = "Ehasanul Hoque",
                Position = "Senior Software Engineeer"
            },
            new {
                Id=2,
                Name = "Ehasanul Hoque",
                Position = "Senior Software Engineeer"
            }
            ,
            new {
                Id=3,
                Name = "Ehasanul Hoque",
                Position = "Senior Software Engineeer"
            }
            }.ToList();
            var data = ((IEnumerable< dynamic >) listdata).Where(x => x.Id == i).SingleOrDefault();
            return data;
        }
    }

}
