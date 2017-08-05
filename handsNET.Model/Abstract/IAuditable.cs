﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsNET.Model.Abstract
{
    public interface IAuditable
    {
        // System field
        DateTime? Created { get; set; }
        string CreatedBy { get; set; }
        DateTime? Modified { get; set; }
        string ModifiedBy { get; set; }

        // SEO field
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        // Switch field
        bool Status { get; set; }
    }
}