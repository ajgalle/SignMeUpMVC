using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignMeUpMVC.Models
{
	public class OvertimeViewModel
	{
        public int OvertimeId { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> DateTimeStart { get; set; }
        public Nullable<System.DateTime> DateTimeEnd { get; set; }
        public Nullable<System.DateTime> SignUpEnd { get; set; }
        public Nullable<int> SelectedEmployeeId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }


    }
}