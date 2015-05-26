using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSkyDotNet.Json.Objects
{
    interface ITranslationStatus
    {
        string FileName { get; }

        ILocale Locale { get; }

        string Progress { get; }

        int StringCount { get; }

        int WordCount { get; }
    }
}
