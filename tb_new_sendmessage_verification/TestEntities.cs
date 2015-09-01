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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity254 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity251 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity253 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity256 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity257 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity252 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity255 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence249 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData139 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop140Input> Loop140 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData153 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest154 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData155 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData246 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity156 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData157 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence250 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData141 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData247 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity248 = null;
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
    