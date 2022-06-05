using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class TimeManager
    {
        private static TimeManager instance;

        public float time { get; set; }

        public static TimeManager Instance {
            get {
                if (instance == null)
                    instance = new TimeManager();

                return instance;
            }
        }
    }
}
