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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity263 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity265 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity266 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity264 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence261 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData97 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData250 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData251 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData252 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop98Input> Loop98 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData111 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest112 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData113 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData246 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData247 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity114 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity260 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity177 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData248 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData116 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence262 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData99 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity249 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity253 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity254 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData255 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest256 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData257 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity258 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity100 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity101 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity259 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData102 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData103 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData104 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData105 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse106Input> IfElse106 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch107 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch108 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData109 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData110 = null;
    
    }
    
    }
    