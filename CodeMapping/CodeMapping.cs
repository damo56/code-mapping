using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMapping
{
    public enum CodeType
    {
        ExternalCode,
        InternalCode,
        InternalKey,
        Description
    }
    public struct CodeMapping
    {
        public string ExternalCode;
        public string InternalCode;
        public string InternalKey;
        public string Description;

        public string GetValue(CodeType type)
        {
            switch (type)
            {
                case CodeType.ExternalCode:
                    return ExternalCode;
                case CodeType.InternalCode:
                    return InternalCode;
                case CodeType.InternalKey:
                    return InternalKey;
                case CodeType.Description:
                    return Description;
                default:
                    return null;
            }
        }
    }
}
