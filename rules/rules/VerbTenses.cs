using System;

namespace rules.rules
{
    public class VerbTenses : IRule
    {
        public string Execute(Context ctx)
        {
            if (ctx.date < DateTime.Today) return "In Past";

            ctx.InPast = false;

            if (ctx.date == DateTime.Today) return "Present";

            return "In Future";
        }

        public bool IsApplicable(Context ctx)
        {
            if (ctx.date == DateTime.MinValue) return false;
            return true;
        }
    }
}
