using NzbDrone.Common.Messaging;
using NzbDrone.Core.Parser.Model;

namespace NzbDrone.Core.Download
{
    public class MovieAvailableEvent : IEvent
    {
        public RemoteMovie Movie { get; private set; }
        public string DownloadClient { get; set; }

        public MovieAvailableEvent(RemoteMovie movie)
        {
            Movie = movie;
        }
    }
}