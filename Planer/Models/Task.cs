using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Planer.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Self
        {
            get
            {
                return string.Format(CultureInfo.CurrentCulture, "api/tasks/{0}", this.TaskId);
            }
        }
    }
}