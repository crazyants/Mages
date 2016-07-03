﻿namespace Mages.Repl
{
    using Mages.Core;
    using System;

    static class InteractivityExtensions
    {
        public static void Display(this IInteractivity interactivity, ParseError error, String source)
        {
            var start = error.Start.Index - 1;
            var end = error.End.Index - 1;
            var lines = source.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            source = String.Join(" ", lines).Replace('\t', ' ');

            if (end == start)
            {
                end++;
            }

            var range = 80;
            var message = error.Code.GetMessage();
            var middle = (end + start) / 2;
            var ss = Math.Max(middle - range / 2, 0);
            var se = Math.Min(middle + range / 2, source.Length);
            var snippet = source.Substring(ss, se - ss);
            interactivity.Error(snippet);
            interactivity.Error(Environment.NewLine);
            interactivity.Error(new String(' ', Math.Max(0, start - ss)));
            interactivity.Error(new String('^', Math.Max(0, end - start)));
            interactivity.Error(Environment.NewLine);
            interactivity.Error("Error: ");
            interactivity.Error(message);
        }
    }
}
