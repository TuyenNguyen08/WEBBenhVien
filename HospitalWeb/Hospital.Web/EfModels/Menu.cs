﻿using System;
using System.Collections.Generic;

namespace Hospital.Web.EfModels
{
    public partial class Menu
    {
        public Menu()
        {
            Page = new HashSet<Page>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Idparrent { get; set; }
        public int? Prioty { get; set; }
        public string Link { get; set; }
        public int FkNgonNgu { get; set; }
        public bool? Root { get; set; }
        public string PageName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ParamId { get; set; }

        public virtual NgonNgu FkNgonNguNavigation { get; set; }
        public virtual ICollection<Page> Page { get; set; }
    }
}
