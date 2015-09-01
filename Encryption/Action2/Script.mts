Call SetUXIN_SQL_FunctionLibrary(obj)
Set SQLDirStr = CreateObject("scripting.dictionary") '创建字典对象以供方法使用
call obj.SQLDirData(SQLDirStr)
fields = "TestCase"
Globalsqlstr = "select * from "&SQLDirStr("GlobalTableName")
Globalsqlrow = obj.GetMysqlRow(SQLDirStr("GlobalTableName"),SQLDirStr("MysqlConnection"))-1
Globalsqlcol = obj.GetMysqlColumn(SQLDirStr("GlobalTableName"),SQLDirStr("MysqlConnection"))-1
ReDim GlobalSqlDic(Globalsqlrow)   '动态生成一维数组（存放字典对象）

Call obj.JDBC_Query_Mysql(Globalsqlstr,GlobalSqlDic,Globalsqlrow,Globalsqlcol,SQLDirStr("MysqlConnection"))
print LCase(sha1_file(GlobalSqlDic(SQLDirStr("GlobalRow"))(SQLDirStr("EncryptionStr"))))
Sqlstr = "update tb_global_table set EncryptionResult = '"+LCase(sha1_file(GlobalSqlDic(SQLDirStr("GlobalRow"))(SQLDirStr("EncryptionStr"))))+"' where TestCase = '1'"
Call obj.JDBC_Update_Mysql(Sqlstr,SQLDirStr("MysqlConnection"))