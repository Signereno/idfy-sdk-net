﻿using System.Collections.Generic;

namespace Idfy.Addons.Entities.Organization
{
    public class OrganizationAccountingModel
    {
        /// <summary>
        ///     List of accounting years
        /// </summary>
        public List<OrganizationAccountingYearModel> Years { get; set; }

        /// <summary>
        ///     Meta data for the content, contains source information, url and other metadata.
        /// </summary>
        public OrganizationMetaData Metadata { get; set; }
    }
}