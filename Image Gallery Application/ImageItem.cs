using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Gallery_Application
{
    public class ImageItem
    {
        // Properties (metadata)
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime DateUploaded { get; set; }
        public List<string> Tags { get; set; }

        // Constructor
        public ImageItem(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
            DateUploaded = DateTime.Now;
            Tags = new List<string>();
        }

        // Method to add tags
        public void AddTags(string[] tags)
        {
            foreach (string tag in tags)
            {
                string cleanTag = tag.Trim().ToLower();

                if (!Tags.Contains(cleanTag) && cleanTag != "")
                {
                    Tags.Add(cleanTag);
                }
            }
        }

        // Method to display tags as a string (optional)
        public string GetTagsAsString()
        {
            return string.Join(", ", Tags);
        }

        // Override ToString (VERY IMPORTANT for UI)
        public override string ToString()
        {
            return FileName;
        }
    }
}
    