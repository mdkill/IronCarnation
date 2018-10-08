using System;
using System.Collections.Generic;
using System.Xml;

namespace IronCarnation.ModelConfig
{
    public class ElementBase
    {
        public string ID {get;private set;}

        public ElementBase(XmlNode defn)
        {
            this.ID = defn.Attributes["id"].Value;
        }
    }

    public class ElementListBase<ElementType> : List<ElementType> where ElementType : ElementBase
    {
        public ElementType this[string id]
        {
            get
            {
                ElementType found = null;

                foreach(ElementType candidate in this)
                {
                    if(candidate.ID.Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        found = candidate;
                        break;
                    }
                }

                return(found);
            }
        }
    }
}