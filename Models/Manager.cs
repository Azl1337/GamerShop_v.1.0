using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GamerShop_v1._0.Models
{
    public class Manager
    {
        public static Frame mainFrame { get; set; }
        public static Frame menuFrame { get; set; }
        
        public static int clientRole;
        public static int clientId;
        public static int gameId;
        public static bool defaultKeyStatus = false;
    }
}
