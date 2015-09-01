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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity261 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity258 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity260 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity263 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity264 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity259 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity262 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence256 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData139 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData247 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop140Input> Loop140 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData153 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest154 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData155 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity156 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity254 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData255 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData157 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence257 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData141 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity248 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData249 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest250 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData251 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity252 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity142 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity143 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData144 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData145 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData146 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData147 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse148Input> IfElse148 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch149 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch151 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData150 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData152 = null;
    
    }
    
    }
    