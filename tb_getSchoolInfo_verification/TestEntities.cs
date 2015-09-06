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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity265 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity262 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity264 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity267 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity268 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity263 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity266 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence260 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData79 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData248 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData250 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop78Input> Loop78 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData93 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest94 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData95 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData246 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity92 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity259 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity115 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData247 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData96 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence261 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData80 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity249 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity251 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData253 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest254 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData255 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity252 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity81 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity82 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity258 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData83 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData84 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData85 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData86 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse87Input> IfElse87 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch88 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch89 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData90 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData91 = null;
    
    }
    
    }
    