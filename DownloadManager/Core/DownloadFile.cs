using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager.Core
{
    internal class DownloadFile
    {
       private string mFileName;
       private string mUrl;
       private string mFileSize;
       private string mStatues;
       private string mProgressValue;
        
        public DownloadFile()
        {
           
        }
        public DownloadFile(string filename , string url , string size , string statues , string ProgressValue)
        {
            mFileName = filename;
            mUrl = url;
            mFileSize = size;
            mStatues = statues;
            mProgressValue = ProgressValue;
        }
        public string FileName
        {
            get { return mFileName; }
            set { mFileName = value; }
        }

        public string Url
        {
            get { return mUrl; }
            set { mUrl = value; }
        }

        public string FileSize
        {
            get { return mFileSize; }
            set { mFileSize = value; }
        }

        public string Statues
        {
            get { return mStatues; }
            set { mStatues = value; }
        }

        public string ProgressValue
        {
            get { return mProgressValue; }
            set { mProgressValue = value; }
        }


    }
}
