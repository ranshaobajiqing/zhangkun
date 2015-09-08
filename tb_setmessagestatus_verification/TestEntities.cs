using System;
    using System.Collections.Generic;
    using System.Text;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    
    namespace Script
    {
    
    public class TestEntities
    {
    public ISTRunTimeContext Context = null;
    public Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource> dataSourceNameToDataSource = new Dictionary<string, HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource>();
    
    protected HP.ST.Fwk.RunTimeFWK.DataHandling.IDataSource GetDataSource(string dataSourceName)
    {
    if(!dataSourceNameToDataSource.ContainsKey(dataSourceName))
    	throw new Exception(("A data source with the specified name does not exist."));
    return dataSourceNameToDataSource[dataSourceName];
    }
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity33 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity35 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity36 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity34 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence31 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection5 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData4 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData6 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData7 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData8 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData28 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop9Input> Loop9 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity27 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData30 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence32 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData10 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity12 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity13 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity14 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity29 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity16 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity17 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData18 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData19 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData20 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData21 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse22Input> IfElse22 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch23 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch24 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData25 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData26 = null;
    
    }
    
    }
    