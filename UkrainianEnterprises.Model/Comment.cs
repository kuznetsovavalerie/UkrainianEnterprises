using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkrainianEnterprises.Common
{
    public class Comment
    {
        public int ID { get; set; }

        public User Author { get; set; }

        public DateTime CreationTime { get; set; }

        public string Text { get; set; }
    }
}
