using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsFood.Sites
{
    public abstract class Site
    {
        #region Fields
        protected List<string> _referenceList;
        #endregion

        #region Properties
        public List<string> ReferenceList { get { return _referenceList; } }
        #endregion
    }
}