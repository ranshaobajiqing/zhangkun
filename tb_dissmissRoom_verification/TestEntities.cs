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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity276 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity273 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity275 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity278 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity279 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity274 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity277 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence271 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData58 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData247 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData252 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest253 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData254 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop56Input> Loop56 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData265 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest266 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData267 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity262 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity263 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData268 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest269 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData270 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity73 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData77 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence272 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData57 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity250 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity251 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity255 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity257 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData258 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest259 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData260 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity261 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity59 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity60 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData61 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData62 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData117 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData63 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse64Input> IfElse64 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch65 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch66 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData67 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData68 = null;
    
    }
    
    }
    