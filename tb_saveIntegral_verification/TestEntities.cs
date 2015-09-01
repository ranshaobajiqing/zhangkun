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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity272 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity269 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity271 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity274 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity275 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity270 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity273 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence267 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData118 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop119Input> Loop119 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData134 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest135 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData136 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData246 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity137 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData138 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence268 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData120 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData248 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity256 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity121 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity122 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData124 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData125 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData126 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData127 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse129Input> IfElse129 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch130 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch131 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData132 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData133 = null;
    
    }
    
    }
    