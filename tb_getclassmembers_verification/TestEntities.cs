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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity257 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity254 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity256 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity259 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity260 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity255 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity258 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence252 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData158 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop159Input> Loop159 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData246 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData172 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest173 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData178 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData247 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity175 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity179 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData176 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence253 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData160 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData248 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity249 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity161 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity162 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData163 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData164 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData165 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData166 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse167Input> IfElse167 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch168 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch170 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData169 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData171 = null;
    
    }
    
    }
    