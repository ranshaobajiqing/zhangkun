package com.controller;

import com.dao.MysqlQuery;
import com.operation.GetObjectProperties;
import com.dao.MysqlConnection;
import com.operation.UIOperation;
import io.appium.java_client.android.*;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.testng.annotations.*;

import java.awt.*;
import java.io.File;
import java.net.URL;
import java.util.HashMap;
import java.util.concurrent.TimeUnit;

public class APPConnectionTest extends StatementObject {

    @BeforeClass
    public void setUp() throws Exception {
        MysqlQuery mq = new MysqlQuery();
        HashMap[] GlobalTable = new HashMap[mq.getDatatableRow("tb_global_table")];
        mq.MysqlQuery("tb_global_table", GlobalTable);
        File classpathRoot = new File(System.getProperty("user.dir"));
        File appDir = new File(classpathRoot, "apps");
        File app = new File(appDir, "ime.apk");
        DesiredCapabilities capabilities = new DesiredCapabilities();
        capabilities.setCapability("app", app.getAbsolutePath());
        capabilities.setCapability("platformName", GlobalTable[GlobalRow].get("TheFirstModelSystem"));
        capabilities.setCapability("deviceName", "E5987b1803542");
//        capabilities.setCapability("deviceName", "HC44XWM00498");
        capabilities.setCapability("unicodeKeyboard", "True");
        capabilities.setCapability("resetKeyboard", "True");
//        driver = new AndroidDriver(new URL("http://127.0.0.2:4723/wd/hub"),
//                capabilities);
        driver = new AndroidDriver(new URL("http://localhost:4444/wd/hub"),
                capabilities);
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);

    }

    @AfterClass
    public void tearDown() throws Exception {
//		driver.quit();
//		webdriver.quit();
    }

    @Test
    public void TestGlobalFunction() throws InterruptedException, AWTException {
        GetObjectProperties ObjPor = new GetObjectProperties("GetObjectProperties");
//        UIOperation.isExist();
//        UIOperation.swipeoperation(1000,1700,100,1700,1000,"yd_ljks",ObjPor);
        Thread.sleep(2000);
        driver.swipe(400, 700, 100, 700, 1000);
        Thread.sleep(2000);
        driver.swipe(400, 700, 100, 700, 1000);
        Thread.sleep(2000);

        ObjPor.getElement("yd_ljks").click();
        ObjPor.getElement("login_username").sendKeys("77401169");
        ObjPor.getElement("login_password").sendKeys("123abc");
        ObjPor.getElement("login_login").click();


    }
}






