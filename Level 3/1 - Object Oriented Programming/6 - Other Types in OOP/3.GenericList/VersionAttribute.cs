namespace _3.Generic_List
{
    using System;
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class VersionAttribute : System.Attribute
    {
        public double Version { get; private set; }
        public VersionAttribute(double version)
        {
            this.Version = version;
        }
    }
}
