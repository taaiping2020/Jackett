using Jackett.Common.Indexers.Abstract;
using Jackett.Common.Models;
using Jackett.Common.Services.Interfaces;
using Jackett.Common.Utils.Clients;
using NLog;

namespace Jackett.Common.Indexers
{
    public class CinemaZ : AvistazTracker
    {
        public CinemaZ(IIndexerConfigurationService configService, WebClient wc, Logger l, IProtectionService ps)
            : base("CinemaZ",
                   description: "Part of the Avistaz network.",
                   link: "https://cinemaz.to/",
                   caps: new TorznabCapabilities
                   {
                       SupportsImdbMovieSearch = true
                   },
                   configService: configService,
                   client: wc,
                   logger: l,
                   p: ps)
            => Type = "private";
    }
}
