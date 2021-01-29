using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2_Inheritance
{
    class UndergraduateStudent:Student,IUniversityStudent
    {
        private string _universityName { get; set; }
        public string UniversityName
        {
            get
            {
                return _universityName;
            }
            set
            {
                _universityName = value;
            }
        }

        public void ThesisProposal()
        {
            throw new NotImplementedException();
        }
    }
}
