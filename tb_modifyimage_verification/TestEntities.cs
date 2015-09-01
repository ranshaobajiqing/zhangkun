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
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity259 = null;
    public HP.ST.Ext.BasicActivities.DataFetchActivity DataFetchActivity256 = null;
    public HP.ST.Ext.BasicActivities.StartActivity StartActivity1 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input> Loop2 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity258 = null;
    public HP.ST.Ext.BasicActivities.DataExporterActivity DataExporterActivity261 = null;
    public HP.ST.Ext.BasicActivities.DataExporterCloseActivity DataExporterCloseActivity262 = null;
    public HP.ST.Ext.BasicActivities.EndActivity EndActivity3 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity257 = null;
    public HP.ST.Ext.BasicActivities.DataDisconnectActivity DataDisconnectActivity260 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence254 = null;
    public HP.ST.Ext.DatabaseRunTime.DbOpenConnection DbOpenConnection39 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData200 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop201Input> Loop201 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData214 = null;
    public HP.ST.Ext.UFTActivity.QtpTestActivity CallQTPTest215 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData216 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData246 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity217 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity218 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData219 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence Sequence255 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData202 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData252 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity253 = null;
    public HP.ST.Ext.HTTPActivity.HTTPActivity HTTPActivity203 = null;
    public HP.ST.Ext.TransformJsonActivity.StringToJsonActivity StringToJsonActivity204 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse247Input> IfElse247 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData206 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData207 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData208 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse209Input> IfElse209 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch248 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch249 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch210 = null;
    public HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch IfElseBranch212 = null;
    public HP.ST.Ext.BasicActivities.ReplaceStringActivity ReplaceStringActivity250 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData251 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData205 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData211 = null;
    public HP.ST.Ext.DatabaseRunTime.DbFetchData DbFetchData213 = null;
    
    }
    
    }
    