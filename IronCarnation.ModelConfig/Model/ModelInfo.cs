using System;
using System.Xml;

namespace IronCarnation.ModelConfig.Model
{
    public class ModelInfo : ElementBase
    {
        public ModelInfo(XmlNode defn) : base(defn)
        {

        }
    }

    public class ModelInfoList : ElementListBase<ModelInfo>    
    {
        
    }
}
