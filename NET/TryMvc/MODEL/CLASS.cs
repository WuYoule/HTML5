//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CLASS
    {
        public CLASS()
        {
            this.TASKs = new HashSet<TASK>();
        }
    
        public int ID { get; set; }
        public string CLASS_ID { get; set; }
        public string CLASS_NAME { get; set; }
        public string CLASS_N { get; set; }
        public string CLASS_TYPE { get; set; }
        public string SCHOOL_ID { get; set; }
        public string SCHOOL_N { get; set; }
    
        public virtual ICollection<TASK> TASKs { get; set; }
        public virtual SCHOOL SCHOOL { get; set; }
    }
}
