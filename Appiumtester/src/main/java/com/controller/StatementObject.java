package com.controller;

import io.appium.java_client.android.AndroidDriver;
import io.appium.java_client.ios.IOSDriver;
import org.openqa.selenium.WebDriver;

/**
 * Created by Administrator on 2015/9/15.
 */
public class StatementObject {
//    public static AndroidDriver androiddriver;
    public static IOSDriver iosdriver;
    public static WebDriver webdriver;
    public static String yamlFile;
    public static AndroidDriver driver;
    public static int GlobalRow = 0;
    public static int LocalRow = 0;
}
