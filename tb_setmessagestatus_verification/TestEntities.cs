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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity18 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity20 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity21 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity19 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence16 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection5 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData4 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData6 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData7 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData8 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop9Input> Loop9 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence17 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData10 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity12 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity13 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity14 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData15 = null;
    
    }
    
    }
    