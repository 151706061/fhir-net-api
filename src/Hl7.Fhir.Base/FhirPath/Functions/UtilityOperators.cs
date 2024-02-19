﻿using Hl7.Fhir.ElementModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Hl7.FhirPath.Functions
{
    internal static class UtilityOperators
    {
        public static IEnumerable<ITypedElement> Extension(this IEnumerable<ITypedElement> focus, string url)
        {
            var exts = focus.Navigate("extension").ToArray();
            var hasUrl = exts.Where(es => es.Children("url").Any()).ToArray();
            var urls = exts.Select(es => es.Children("url").FirstOrDefault()).ToArray();
            var matches = exts.Where(es => es.Children("url").SingleOrDefault().Value as string == url); 
            return focus.Navigate("extension")
                .Where(es => es.Children("url").SingleOrDefault().Value as string == url);
        }

        public static IEnumerable<ITypedElement> Trace(this IEnumerable<ITypedElement> focus, string name, EvaluationContext ctx)
        {
            ctx.Tracer?.Invoke(name, focus);
            return focus;
        }
    }
}
