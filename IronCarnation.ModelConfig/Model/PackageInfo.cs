using System;
using System.Xml;

namespace IronCarnation.ModelConfig.Model
{
    public class PackageInfo : ElementBase
    {
        public PackageInfo(XmlNode defn) : base(defn)
        {
            
        }
    }

    public class PackageInfoList : ElementListBase<PackageInfo> {}
}