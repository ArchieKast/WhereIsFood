using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereIsFood.ElementsOfDB;

namespace WhereIsFood.Sites
{
    public class AlphabetOfTaste : Site
    {
        #region Constructors
        public AlphabetOfTaste(List<string> referenceList)
        {
            _referenceList = new List<string>(referenceList);
        }
        #endregion

        #region Methods
        void AddReferenses(List<string> references)
        {
            _referenceList.AddRange(references);
        }

        /*public DataFrame GetData()
        {
            return dataFrame;
        }*/
        #endregion
    }
}