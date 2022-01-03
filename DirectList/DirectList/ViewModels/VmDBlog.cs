﻿using DirectList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList.ViewModels
{
    public class VmDBlog :VmLayout
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public VmSearch Search { get; set; }

        public List<BlogComment> BlogComments { get; set; }
        public BlogComment BlogComment { get; set; }




    }
}
