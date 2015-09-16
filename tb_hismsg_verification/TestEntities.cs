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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity23 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity25 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity26 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity24 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence21 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection4 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData5 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData8 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData9 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData10 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop6Input> Loop6 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence22 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData7 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity12 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity13 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity14 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData15 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest16 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData17 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity18 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity19 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity20 = null;
    
    }
    
    }
    