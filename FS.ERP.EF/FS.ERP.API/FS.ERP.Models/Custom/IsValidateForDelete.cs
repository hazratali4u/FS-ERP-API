using System;
using System.Runtime.Serialization;

namespace FS.ERP.Models.Custom
{
    [Serializable]
    [DataContract]
    public class IsValidateForDelete
    {
        [DataMember]
        public int IntMenuCode { get; set; }
        [DataMember]
        public string StrPkCode { get; set; }
        [DataMember]
        public long IntPkValue { get; set; }
        [DataMember]
        public bool IsExcludeDeleted { get; set; }
        [DataMember]
        public string StrWhereClause { get; set; }
    }

    public class IsValidateForDeleteResponse
    {
        public string Error { get; set; }
        public bool IsValid { get; set; }
    }

    public class DuplicateCheck
    {
        public string PropertyName { get; set; }

        public int DataCount { get; set; }

        public string ErrorMessage { get; set; }
    }
}
