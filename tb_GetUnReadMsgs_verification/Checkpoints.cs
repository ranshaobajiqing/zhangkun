//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Script
{
    using System;
    using System.Xml;
    using System.Xml.Schema;
    using System.Collections.Generic;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.CheckpointFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Ext.CheckpointLogicOperators;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Ext.CheckpointRules.ArrayCheckpoints;
    
    
    public partial class WorkFlowScript
    {
        
        private void set_DbFetchData57_checkpoints(STActivityBase activity)
        {
            // Checkpoint 1
            IVTDGetter actualValueGetter1 = new VTDXPathGetter(new VTDPropertyInfoBase("OutputProperties", "/*[local-name(.)='Arguments'][1]/*[local-name(.)='ResultTable'][1]/*[local-name(.)='Row'][1]/*[local-name(.)='token'][1]"), XmlTypeCode.String, false);
            IVTDSetter actualValueSetter1 = new VTDCheckpointSetter(XmlTypeCode.String);
            BindDirection actualBindDirection1 = new BindDirection(_flow.DbFetchData57, actualValueGetter1, actualValueSetter1);
            CpValObj valueActualObject1 = new CpValObj(actualBindDirection1, XmlTypeCode.String, false);
            CpValObj valueExpectedObject1 = new CpValObj("61f048fc016c13ea5cdfa6416c6e6ef9532716b8", XmlTypeCode.String);
            ValueCPRule cpRule1 = new ValueCPRule(valueActualObject1, valueExpectedObject1, StringCP.EqualTo, "=", false);

            ArrayElementCPRule arrayElementCPRule1 = new ArrayElementCPRule();
            ArrayBaseCPRule arrayFixedCpRule1 = new ArrayFixedCPRule("/*[local-name(.)='Arguments'][1]/*[local-name(.)='ResultTable'][1]/*[local-name(.)='Row']", HandlerType.XML);
            arrayElementCPRule1.AddRule(cpRule1);
            arrayFixedCpRule1.AddRule(arrayElementCPRule1);
            activity.AddCheckpointRule(arrayFixedCpRule1);
        }
    }
}
