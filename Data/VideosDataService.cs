using OrvizarWebPageServer.SharedFolder;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrvizarWebPageServer.Data
{

    public enum PlayList
    {
        Python,
        Anaconda,
        MatplotLib,
        Pandas,
        Csharp,
        Unity,
        Opencv,
        Optimizacion,

    }
    public class VideosDataService
    {
        public PlayList playList { get; set; }
        public SourceElements elements { get; set; }

        public Videos video { get; set; }
        public SourceElements ListVideos(PlayList playList)
        {
            elements = new SourceElements();
            switch (playList)
            {
                case PlayList.Anaconda:
                    elements.AllVideos = new List<Videos>
                    {

                        new Videos  {  Name = @"https://www.youtube.com/embed/_ihdkS8jBvA"},
                        new Videos  {  Name = @"https://www.youtube.com/embed/_ihdkS8jBvA" },

                    };
                    return elements;
                case PlayList.Python:
                    elements.AllVideos = new List<Videos>
                    {

                        new Videos  {  Name = "https://www.youtube.com/embed/videoseries?list=PL6GZzVvsfrGEDJ5oOLO210mP1MSj13PFX" },
                        new Videos  {  Name = "https://www.youtube.com/embed/videoseries?list=PL6GZzVvsfrGEDJ5oOLO210mP1MSj13PFX" },

                    };
                    return elements;
                case PlayList.MatplotLib:
                    break;
                case PlayList.Pandas:
                    break;
                case PlayList.Csharp:
                    break;
                case PlayList.Unity:
                    break;
                case PlayList.Opencv:
                    break;
                default:
                    break;

            }
            return null;
        }

        public Task<SourceElements> GetVideosAsync(PlayList playL)
        {
            return Task.FromResult(ListVideos(playL));
        }
    }
}
