﻿using System.Collections.Generic;

namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationSigningOptionModel
    { 
        /// <summary>
        /// List of required signers
        /// </summary>
        public List<OrganizationSignature> Required { get; set; }
    }
}
