using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Windows.Forms;



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
        [DataMember]
        public int organization_id  { get; set; }

        private string path = "config.json";
        private DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ConfigJson[]));



        public ConfigJson()
        { }

        public ConfigJson(string server, string user, string password, string db,int organization_id)
        {
            this.server = server;
            this.user = user;
            this.password = password;
            this.db = db;
            this.organization_id = organization_id;

        }

        public void jsonWrite()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ConfigJson));
            if (!File.Exists(path)) File.Create(path);
                using (FileStream fs = new FileStream(path, FileMode.Truncate))
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
                  
                    try
                    {
                        return (ConfigJson)jsonFormatter.ReadObject(fs); 
                    }
                    catch
                    {
                        return null;
                    }
                                      
                    
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
            this.organization_id = res.organization_id;
            string strConnect = @"data source=" + this.server + ";initial catalog=" + this.db + ";user id=" + this.user + ";password=" + this.password+"; MultipleActiveResultSets=True;App=EntityFramework";
            return strConnect;
        }
    

        // написать метод
        public int SubsidiaryCompaniesRegion()
        {
            ConfigJson res = (new ConfigJson()).jsonRead();
            return res.organization_id;
        }

       

    }
}
