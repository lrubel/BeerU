﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeerUAPI.Types
{
    [DataContract]
    public class Category
    {
        /// <summary>
        /// Gets or sets the id of Category.  
        /// </summary>
        [DataMember]
        public int id { get; set; }
        
        /// <summary>
        /// Gets or sets the name of Category.   
        /// </summary>
        [DataMember]
        public string name { get; set; }

    }
}
