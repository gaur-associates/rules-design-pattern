using System;
using System.Collections.Generic;
using System.Linq;

namespace rules
{
    public class RuleEvaulator
    {
        private IEnumerable<IRule> _rules;

        public void Execute(Context ctx)
        {
            var result = _rules
                        .Where(rule => rule.IsApplicable(ctx))
                        .Select(rule => rule.Execute(ctx));

            if (result != null
                && result.Any())
            {
                result.ToList().ForEach(x => Console.WriteLine(x));
            }
        }
        public RuleEvaulator(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }
    }
}
