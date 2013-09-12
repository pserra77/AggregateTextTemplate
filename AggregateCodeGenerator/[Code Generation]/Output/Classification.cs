﻿// <autogenerated>
//   This file was generated by T4 code generator AggregateRootScript.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using Infrastructure.Seedwork.Domain;
using log4net;

namespace CAMP.AssetManagement.Domain.Model
{
	/// <summary>
    /// TODO
    /// </summary>
    /// <author>TODO</author>
	public class Classification : AbstractAggregateRootWithAudit<ClassificationId, IClassificationEvent, IClassificationCommand>
	{

		private static readonly ILog log = LogManager.GetLogger(typeof(Classification));

        public int ClassificationTypeId { get; protected set; }
        public int ClassificationName { get; protected set; }
        public IEnumerable<ClassificationLink> ClassificationLinks { get; protected set; }
        public IEnumerable<ClassificationTrackedSystem> TrackedSystems { get; protected set; }
  
        public Classification()
            : base(new NullEventPublisher())
        {
			if (log.IsDebugEnabled)
            {
                log.DebugFormat("Classification Created with NullEventPublisher.");
            }
        }

        public Classification(IDomainEventPublisher eventPublisher)
            : base(eventPublisher)
        {
			if (log.IsDebugEnabled)
            {
                log.DebugFormat("Classification Created. Event Publisher : {0}.", eventPublisher);
            }
        }
	}
}