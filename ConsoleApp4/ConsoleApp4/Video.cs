using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp4
{
    public class Video
    {
        public enum State
        {
            Play, Pause, Stop
        }
        private string username;
        private string url;
        private string title;
        private State currentState;
        private string tag;
        private List<string> tags = new List<string>();


        public Video(string username, string url, string title)
        {
            this.username = username;
            this.url = url;
            this.title = title;
        }

        public Video()
        {
            currentState = State.Stop;
        }

        public Video(List<string> tags)
        {
            this.tags = tags;
        }


        public string Username { get { return username; } set => username = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("field cannot be empty or null"); }
        public string Url { get { return url; } set => url = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("field cannot be empty or null"); }
        public string Title { get { return title; } set => title = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("field cannot be empty or null"); }
        public State CurentState { get { return currentState; } set { currentState = value; } }

        public string Tag { get { return tag; } set => tag = !string.IsNullOrEmpty(value) && value.Substring(0)=="#" ? value : throw new ArgumentException("field cannot be empty or null and must begin with #"); }

        public List<string> Tags { get { return tags; } set { tags = value; } }

        public override string ToString()
        {
            return "\ntitle: " + title.ToString() + ".\nurl: " + url.ToString() + ".";
        }
    }
}
