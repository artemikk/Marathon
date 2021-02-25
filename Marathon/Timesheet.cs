namespace Marathon
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Timesheet")]
    public partial class Timesheet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Timesheetid { get; set; }

        public int Staffid { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public decimal? PayAmount { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
