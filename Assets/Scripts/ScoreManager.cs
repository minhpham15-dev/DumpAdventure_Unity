using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class ScoreManager
    {
        private static ScoreManager instance;

        public static ScoreManager Instance { 
            get { 
                if (instance == null)
                    instance = new ScoreManager();

                return instance;
            }
        }
    }
}
