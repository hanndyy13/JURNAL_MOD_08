using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static modul8_103022300064.BankTransferConfig;

namespace modul8_103022300064
{

    public class BankTransferConfig
    {
        public string? lang { get; set; }
        public string[] method { get; set; }

        public class Transfer
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee { get; set; }
        }

        public class Confirmation
        {
            public string end { get; set; }
            public string id { get; set; }
        }

        const string fileConfig = "D:\tpmod08\tpmod08\bank_transfer_config.json";

        public static BankTransferConfig LoadConfig()
        {
            if (File.Exists(fileConfig))
            {
                string jsonString = File.ReadAllText(fileConfig);
                BankTransferConfig config = JsonSerializer.Deserialize<BankTransferConfig>(jsonString);

                if (config != null)
                    return config;
            }

            BankTransferConfig bankTransferConfig = new BankTransferConfig
            {
                lang = "en",
                Transfer = new BankTransferConfig.Transfer
                {
                    threshold = 2500000,
                    low_fee = 6500,
                    high_fee = 15000
                },
                method = ["“RTO", "(real-time)”", "“SKN”", "“RTGS”", "“BI", "FAST”"],
                Confirmation = new BankTransferConfig.Confirmation
                {
                     end = "yes",
                     id = "ya"
                }

            };

            string defaultJson = JsonSerializer.Serialize(bankTransferConfig, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileConfig, defaultJson);

            return bankTransferConfig;
        }
    }


}
