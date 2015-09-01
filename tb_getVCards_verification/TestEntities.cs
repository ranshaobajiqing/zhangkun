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
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData180 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop181Input> Loop181 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData194 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest195 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData196 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData246 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity197 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity198 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData199 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence250 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData182 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData247 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity248 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity183 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity184 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData185 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData186 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData187 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData188 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse189Input> IfElse189 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch190 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch192 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData191 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData193 = null;
    
    }
    
    }
    