﻿using GogsExhibition.Classes;
using NLog;
using GogsExhibition.Controllers.Abstraction;

namespace GogsExhibition.Controllers
{
    public class SexesController : OverloadedController<Sex>
    {
        public SexesController(DbSets dbSets, ILogger logger) : base(dbSets, logger)
        {
        }
    }
}
