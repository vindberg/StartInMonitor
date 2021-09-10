using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartInMonitor
{
    public class Model
    {
        /// <summary>
        /// The monitor number (starts with 1 which is the main monitor)
        /// </summary>
        public int Monitor { get; set; } = 1;

        /// <summary>
        /// Full path and name of the application
        /// </summary>
        public string Application { get; set; }

        /// <summary>
        /// Argumments for the application
        /// </summary>
        public string Arguments { get; set; }

        /// <summary>
        /// Pixels away from the left side of the monitor/screen
        /// </summary>
        public int Left { get; set; }
        
        /// <summary>
        /// Pixels away from the top of the monitor/screen
        /// </summary>
        public int Top { get; set; }

        /// <summary>
        /// Pixels that are subtracted from the total width of the monitor/screen. The application is defaulted to full width.
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// Pixels that are subtracted from the total heigth of the monitor/screen. The application is defaulted to full height.
        /// </summary>
        public int Height { get; set; }

    }
}
