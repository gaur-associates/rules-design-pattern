using System;
using rules.rules;

namespace rules
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var ctx = new Context() { date = new DateTime(2014, 7, 28) };

            var rules = new IRule[] {
                new VerbTenses(),
                new FactCheck()

            };
            new RuleEvaulator(rules).Execute(ctx);

        }
    }
}
