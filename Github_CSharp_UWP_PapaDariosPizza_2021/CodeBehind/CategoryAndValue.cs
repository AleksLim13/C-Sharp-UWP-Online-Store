using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaDariosPizza
{
    class CategoryAndValue
    {

        private string category;
        private string value;

        public CategoryAndValue()
        {

        }//End C:*

        public CategoryAndValue(string category, string value)
        {
            this.category = category;
            this.value = value;
        }//End C:*

        public string Category { get => category; set => category = value; }

        public string Value { get => value; set => this.value = value; }

    }//End CL:*

}//End NS:*
