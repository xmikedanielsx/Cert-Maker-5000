using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertMaker5000.Screens.Parts
{
    public class DatabasesSupportedListItem
    {
        public DatabasesSupportedListItem()
        {
            this.Name = string.Empty;
        }
        public string Name { get; set; }
        public Control? Control { get; set; }
    }
}
