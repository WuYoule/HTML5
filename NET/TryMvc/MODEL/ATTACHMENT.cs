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
    
    public partial class ATTACHMENT
    {
        public int ID { get; set; }
        public string OBSERVE_ID { get; set; }
        public int TASK_ID { get; set; }
        public string STEP_ID { get; set; }
        public string IMAGE { get; set; }
        public string VIDEO { get; set; }
    
        public virtual STEP STEP { get; set; }
        public virtual TASK TASK { get; set; }
        public virtual USER USER { get; set; }
    }
}
