using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudent.entities
{
    public class MainManager
    {
        private MainManager() { }
        private static readonly MainManager _instance = new MainManager();

        public static MainManager Instance
        {
            get { return _instance; }

        }
        public Hashtable StudentsTbl = new Hashtable();
    }
}
