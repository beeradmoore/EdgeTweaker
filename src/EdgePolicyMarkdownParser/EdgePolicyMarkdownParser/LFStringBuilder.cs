using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgePolicyMarkdownParser;

internal class LFStringBuilder
{
    StringBuilder _internal = new StringBuilder();

    public void AppendLine(string? value)
    {
        _internal.Append(value);
        _internal.Append("\n");
    }

    public override string ToString()
    {
        return _internal.ToString();
    }
}
