using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Data.EntityClient;
using System.Data.SqlClient;


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
            string strConnect = @"data source=" + this.server + ";initial catalog=" + this.db + ";user id=" + this.user + ";password=" + this.password+"; MultipleActiveResultSets=True;App=EntityFramework";
            return strConnect;
        }
       /* public EntityConnectionStringBuilder StringConnecting()
        {
            ConfigJson res = (new ConfigJson()).jsonRead();
            
            var sqlBuilder = new SqlConnectionStringBuilder
            {
                DataSource = res.server,
                InitialCatalog= res.db,
                UserID = res.user,
                Password = res.password,
                
            };

            string providerString = sqlBuilder.ToString();
            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = providerString,
              
            };
            return entityBuilder;
        }
      */


        // написать метод
        public int SubsidiaryCompaniesRegion()
        {
            return 1;
        }

       

    }
}
