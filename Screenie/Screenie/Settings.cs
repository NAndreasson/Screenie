using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace Screenie
{
    [DataContract]
    public class Settings {
        [DataMember]
        public ImageFormat FileFormat { get; set; }
        [DataMember]
        public string SavePath { get; set; }
        [DataMember]
        public bool FtpEnabled { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string FtpAddress { get; set; }

        public Settings() { }


        public static void SaveSettings(Settings settings) {
            using (FileStream fileStream  = File.Open(@"Settings.xml", FileMode.Create)) {
                DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(Settings));
                dataContractSerializer.WriteObject(fileStream, settings);
            }
        }

        public static Settings LoadSettings() {
            if (File.Exists(@"Settings.xml")) {
                using (FileStream fileStream = File.Open(@"Settings.xml", FileMode.Open)) {
                    DataContractSerializer dataContractSerializer = new DataContractSerializer(typeof(Settings));
                    return (Settings)dataContractSerializer.ReadObject(fileStream);
                }
            }
            return DefaultSettings();
        }

        private static Settings DefaultSettings()
        {
            Settings settings = new Settings();
            settings.SavePath = "./";
            settings.FileFormat = new ImageFormat(System.Drawing.Imaging.ImageFormat.Jpeg);
            settings.FtpEnabled = true;
            settings.FtpAddress = @"ftp://ftp.google.se/";
            settings.Username = "hej";
            settings.Password = "tja";
            return settings;
        }

    }
}
