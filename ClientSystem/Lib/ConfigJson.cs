using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace ClientSystem.Lib
{
    [DataContract]
    class ConfigJson
    {

        [DataMember]
        public string server { get; set; }
        [DataMember]
        public string user { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string db { get; set; }
        private string path = "config.json";
        private DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ConfigJson[]));



        public ConfigJson()
        { }

        public ConfigJson(string server, string user, string password, string db)
        {
            this.server = server;
            this.user = user;
            this.password = password;
            this.db = db;

        }

        public void jsonWrite()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ConfigJson));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, this);
            }

        }


        public ConfigJson jsonRead()
        {
            if (File.Exists(path))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ConfigJson));

                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    ConfigJson config = (ConfigJson)jsonFormatter.ReadObject(fs);
                    return config;
                }
            }
            else return null;

        }
        


         public string StringConnecting()
        {

            ConfigJson res = (new ConfigJson()).jsonRead();
            this.server = res.server;
            this.user = res.user;
            this.password = res.password;
            this.db = res.db;
            string strConnect = "Data Source=" + this.server + ";Initial Catalog=" + this.db + ";User ID=" + this.user + ";Password=" + this.password;
            return strConnect;
        }



    }
}
