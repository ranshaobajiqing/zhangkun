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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity252 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity254 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity255 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity253 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence250 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData40 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop31Input> Loop31 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData23 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest19 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData29 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity4 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData71 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity10 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData246 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity247 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity248 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData249 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence251 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData34 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity32 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity37 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity48 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData41 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData42 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData55 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData52 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse49Input> IfElse49 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch50 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch51 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData53 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData54 = null;
    
    }
    
    }
    