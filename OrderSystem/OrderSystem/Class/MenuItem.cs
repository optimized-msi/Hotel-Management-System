using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystem.Class
{
    class MenuItem
    {
        #region Procedures
        private int _id;
        public virtual int ID
        {
            get { return _id ;}
            set { _id = value; }
        }
        #endregion
    }
}
