namespace Model.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [StringLength(50)]
        public string userName { get; set; }

        public int id { get; set; }

        [StringLength(50)]
        public string passWord { get; set; }
    }
}
