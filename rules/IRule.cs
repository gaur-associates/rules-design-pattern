using System;

namespace rules
{

    public interface IRule
    {
        bool IsApplicable(Context ctx);

        String Execute(Context ctx);
    }
}
