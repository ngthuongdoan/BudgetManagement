using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement
{
    public class CategogyModel
    {
        private string categogyName;
        private byte[] categogyImage;

        public CategogyModel()
        {

        }
        public string CategogyName {
            get { return this.categogyName; }
            set { this.categogyName = value; }
        }
        public byte[] CategogyImage {
            get { return this.categogyImage; }
            set { this.categogyImage = value; }
        }
    }
}
