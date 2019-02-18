using System;
using System.Collections.Generic;
using System.Text;

namespace ThisNetWorks.OrchardCore.SiteManager.Models
{
    public class SiteWarmerDto
    {
        public IList<string> EndpointsToHit { get; set; } = new List<string>();

        public IList<string> RelativeUrls { get; set; } = new List<string>();
    }
}
