using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrvizarWebPageServer.SharedFolder
{
    public class SourceElements
    {
        public List<Videos> AllVideos { get; set; }
        public Videos GetVideoById(int Id) => AllVideos.Where(video => video.Id == Id).FirstOrDefault();
    }
}
