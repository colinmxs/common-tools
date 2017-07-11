using Microsoft.AspNetCore.Mvc.Razor;
using System.Collections.Generic;

namespace AspNetCore.Infrastructure
{
    public class FeatureFolderViewLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            //{2} is area, {1} is controller,{0} is the action
            string[] locations = new string[]
            {
                "Features/{1}/{0}.cshtml",
                "Features/Shared/{0}.cshtml",
                "Features/{0}.cshtml"
            };
            return locations;
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }
    }
}
