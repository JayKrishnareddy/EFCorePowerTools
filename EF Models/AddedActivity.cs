﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace EF_Models
{
    public partial class AddedActivity
    {
        public long WorkflowInstanceInternalId { get; set; }
        public long WorkflowInstanceEventId { get; set; }
        public string QualifiedName { get; set; }
        public int ActivityTypeId { get; set; }
        public string ParentQualifiedName { get; set; }
        public string AddedActivityAction { get; set; }
        public int? Order { get; set; }
    }
}