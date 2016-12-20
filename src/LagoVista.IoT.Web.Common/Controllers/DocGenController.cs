﻿using LagoVista.Core.Attributes;
using LagoVista.Core.Models.UIMetaData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LagoVista.IoT.Web.Common.Controllers
{
    [Route("metadata/dox")]
    public class DocGenController : Controller
    {
        [HttpGet("domains")]
        public List<DomainDescription> GetDomains()
        {
            return MetaDataHelper.Instance.Domains;
        }

        [HttpGet("domains/{domain}")]
        public List<EntityDescription> GetEntities(String domain)
        {
            var domainInstance = MetaDataHelper.Instance.Domains.Where(dmn => dmn.Name == domain).FirstOrDefault();
            return domainInstance.Entities;
        }
    }
}
