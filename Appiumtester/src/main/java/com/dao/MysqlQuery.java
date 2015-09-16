package com.dao;

import java.util.HashMap;

public class MysqlQuery {
    public MysqlQuery(){
        MysqlConnection con = new MysqlConnection();
    }
    /**
     * 方法：根据表名获取行数
     * 参数：表名
     * 返回值：row
     */
    public int getDatatableRow(String TableName) {
        String sqlstr = "select * from " + TableName;
        try {
            MysqlConnection.con = MysqlConnection.getConnction();
            MysqlConnection.ps = MysqlConnection.con.prepareStatement(sqlstr);
            MysqlConnection.res = MysqlConnection.ps.executeQuery();
            MysqlConnection.res.last();
            System.out.println(MysqlConnection.res.getRow());
            return MysqlConnection.res.getRow();
        } catch (Exception e) {
            e.printStackTrace();
            return -1;
        }
    }


    /**
     * 方法：根据表名获取列数
     * 参数：表名
     * 返回值：column
     */
    public int getDatatableCol(String TableName) {
        String sqlstr = "SELECT count(column_name) as 'column_Number' from information_schema.columns WHERE TABLE_SCHEMA='test_automation_appium' and table_name ='"
                + TableName + "'";
        try {
            MysqlConnection.con = MysqlConnection.getConnction();
            MysqlConnection.ps = MysqlConnection.con.prepareStatement(sqlstr);
            System.out.println(sqlstr);
            MysqlConnection.res = MysqlConnection.ps.executeQuery();
            MysqlConnection.res.next();
            return MysqlConnection.res.getInt("column_Number");
        } catch (Exception e) {
            e.printStackTrace();
            return -1;
        }
    }


    /**
     * 方法：查询表中所有数据，且封装到hashmap中
     * 参数：表名，数组名称
     * 返回值：column
     */

    public void MysqlQuery(String TableName, HashMap[] HashMapArrayList) {
        String sqlstr = "select * from " + TableName;
        int Row, col;
        try {
            Row = this.getDatatableRow(TableName) - 1;
            col = this.getDatatableCol(TableName);
            MysqlConnection.con = MysqlConnection.getConnction();
            MysqlConnection.ps = MysqlConnection.con.prepareStatement(sqlstr);
            MysqlConnection.res = MysqlConnection.ps.executeQuery();
            MysqlConnection.res.last();
            for (int i = 0; i <= Row; i++) {
                HashMapArrayList[i] = new HashMap<String, String>();
                for (int j = 1; j <= col; j++) {
                    HashMapArrayList[i].put(MysqlConnection.res.getMetaData().getColumnName(j), MysqlConnection.res.getString(MysqlConnection.res.getMetaData().getColumnName(j).toString()));
                }
                MysqlConnection.res.next();
            }

        } catch (Exception e) {
            e.printStackTrace();
        }

    }


    public static void main(String[] args) {
        MysqlConnection con = new MysqlConnection();
        MysqlQuery my = new MysqlQuery();
        System.out.println(my.getDatatableRow("tb_test_table"));
        HashMap[] aTweightList = new HashMap[my
                .getDatatableRow("tb_test_table")];
        my.MysqlQuery("tb_test_table", aTweightList);
        System.out.println("-------------------------------------------"
                + aTweightList[1].get("TestCase"));

    }
}

