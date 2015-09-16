package com.dao;

import com.operation.GetObjectProperties;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class MysqlConnection {
    public static String MysqlAppiumTestCaseURL;
    public static String MysqlConnection;
    public static String MysqlUsername;
    public static String MysqlPassword;
    public MysqlConnection(){
        GetObjectProperties objpro = new GetObjectProperties("MysqlConnection");
        MysqlAppiumTestCaseURL=objpro.getProperty("MysqlAppiumTestCaseURL");
        MysqlConnection = objpro.getProperty("MysqlConnection");
        MysqlUsername = objpro.getProperty("MysqlUsername");
        MysqlPassword = objpro.getProperty("MysqlPassword");
    }

    //声明数据连接实例（表示程序和数据库连接的通道）
    public static Connection con = null;
    //声明SQL语句容器（对sql语句进行管理）
    public static PreparedStatement ps = null;
    //声明结果集（临时存放从数据库中取得的结果）
    public static ResultSet res = null;
    public static MysqlConnection mSqlConnection;


    public static  MysqlConnection getMysqlConnection(){
        if(mSqlConnection==null){
            mSqlConnection=new MysqlConnection();
        }
        return mSqlConnection;

    }

    /**
     * 方法：获得数据库连接
     * 功能：获得程序和数据库的联通通道
     * 参数：无
     * 返回值：Connection实例
     */
    public static Connection getConnction() {
        Connection con = null;
        try {
            Class.forName(MysqlConnection);
            con = DriverManager.getConnection(MysqlAppiumTestCaseURL, MysqlUsername, MysqlPassword);
        } catch (Exception e) {
            System.err.println("数据库连接出现问题，请检查");
        }
        //返回连接实例
        return con;
    }







}