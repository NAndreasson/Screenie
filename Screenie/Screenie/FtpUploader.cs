using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace Screenie
{
    class FtpUploader: FileUploader
    {
        private UserCredentials _userCredentials;
        private string _ftpAdress;

        public FtpUploader(UserCredentials usercredentials, string ftpAddress)
        {
            _userCredentials = usercredentials;
            _ftpAdress = ftpAddress;
        }

        public void UploadFile(string filePath)
        {
            // get filename and type
            string fileName = Path.GetFileName(filePath);
            
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpAdress + fileName);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            
            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(_userCredentials.Username, _userCredentials.Password);
            
            // Copy the contents of the file to the request stream.
            StreamReader sourceStream = new StreamReader(filePath);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

            response.Close();
        }

    }
}
