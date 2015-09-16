package com.dao;

/**
 * Created by Administrator on 2015/9/15.
 */
public class MysqlUpdate {
    /**
     * 方法：更新表中指定字段值
     * 参数：表名，更改的字段名称，更改的值，参照的字段名称，参照的字段值
     * 返回值：null
     */
    public void MysqlUpdate(String TableName ,String updatekey, String updatevalue , String conditionkey ,String conditionvalue ){
        String sqlstr = "UPDATE "+TableName+" set "+updatekey+" = '"+updatevalue+"' where "+conditionkey+" = "+conditionvalue+"";
        System.out.println(sqlstr);
        try{
            MysqlConnection.con = MysqlConnection.getConnction();
            //访问数据库第三步：将SQL字符串放入ps容器
            MysqlConnection.ps = MysqlConnection.con.prepareStatement(sqlstr);
            //访问数据库第五步：操纵ps执行更改操作，返回影响条数
            MysqlConnection.ps.executeUpdate();
        }catch(Exception e){
            e.printStackTrace();
        }
    }






}
