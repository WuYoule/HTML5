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
    
    public partial class OBSERVE
    {
        public int ID { get; set; }
        public string OBSERVE_ID { get; set; }
        public int TASK_ID { get; set; }
        public string STEP_ID { get; set; }
        public string TARGET_ID { get; set; }
        public string TARGET_SUBID { get; set; }
        public string TARGET_SUBID2 { get; set; }
        public string EVALUATE_ID { get; set; }
        public string EVALUATE_LEVEL_ID { get; set; }
        public string EVALUATE_CONTENT { get; set; }
        public string EVALUATE_LEVEL_CONT { get; set; }
        public string EVALUATE_LEVEL_RESULT { get; set; }
        public int EVALUATE_LEVEL_SCORE { get; set; }
        public string COMMENT { get; set; }
        public System.DateTime MODIFY_TIME { get; set; }
    
        public virtual EVALUATE EVALUATE { get; set; }
        public virtual STEP STEP { get; set; }
        public virtual TARGET TARGET { get; set; }
        public virtual TASK TASK { get; set; }
        public virtual USER USER { get; set; }
    }
}
