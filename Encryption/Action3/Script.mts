Call SetUXIN_SQL_FunctionLibrary(obj)
Set SQLDirStr = CreateObject("scripting.dictionary") '创建字典对象以供方法使用
call obj.SQLDirData(SQLDirStr)
obj.timestamps(SQLDirStr("MysqlConnection"))