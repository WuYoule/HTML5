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
    
    public partial class WF_WorkFlowNode
    {
        public WF_WorkFlowNode()
        {
            this.WF_AutoTransactNode = new HashSet<WF_AutoTransactNode>();
            this.WF_BillFlowNode = new HashSet<WF_BillFlowNode>();
        }
    
        public int WorkFlowNodeID { get; set; }
        public Nullable<int> WorkFlowID { get; set; }
        public Nullable<int> NodeID { get; set; }
        public Nullable<int> WorkFlowNodeSequence { get; set; }
        public string Remark { get; set; }
    
        public virtual ICollection<WF_AutoTransactNode> WF_AutoTransactNode { get; set; }
        public virtual ICollection<WF_BillFlowNode> WF_BillFlowNode { get; set; }
        public virtual WF_Node WF_Node { get; set; }
        public virtual WF_WorkFlow WF_WorkFlow { get; set; }
    }
}
