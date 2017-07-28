using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunTell.Models
{
    public class ConnectionTree
    {
        /// <summary>
        /// the user id for the current node
        /// </summary>
        public string UserId { get; set; }
        
        /// <summary>
        /// The other children within the tree
        /// </summary>
        public ConnectionTree[] Children { get; set; }
    }
}