using System.Linq;
using NLog;
using NzbDrone.Core.DecisionEngine;
using NzbDrone.Core.Download;
using NzbDrone.Core.Parser.Model;

namespace NzbDrone.Core.MediaFiles.MovieImport.Specifications
{
    public class SameFileSpecification : IImportDecisionEngineSpecification
    {
        private readonly Logger _logger;

        public SameFileSpecification(Logger logger)
        {
            _logger = logger;
        }

        public Decision IsSatisfiedBy(LocalMovie localMovie, DownloadClientItem downloadClientItem)
        {
            return Decision.Accept();
        }
    }
}
