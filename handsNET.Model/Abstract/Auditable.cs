﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsNET.Model.Abstract
{
    public class Auditable : IAuditable
    {
        public DateTime? Created { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        [MaxLength(256)]
        public string ModifiedBy { get; set; }
        public string MetaKeyword {  get; set; }
        public string MetaDescription {  get; set; }
        public bool Status {  get; set; }
    }
}
