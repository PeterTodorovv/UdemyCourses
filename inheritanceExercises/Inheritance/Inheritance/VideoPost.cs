using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class VideoPost :Post
    {
        double length;
        string videoURL;

        public VideoPost() { }


        public VideoPost(string title, string sendByUsername, bool isPublic, string videoURL, double length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.length = length;
            this.videoURL = videoURL;
        }

        public override string ToString()
        {
            return String.Format($"{Title} - {ID} - {videoURL} - by {SendByUsername} - {length}");
        }
    }
}
