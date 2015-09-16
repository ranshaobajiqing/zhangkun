package com.test;
import io.appium.java_client.android.AndroidDriver;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.testng.annotations.*;
import java.awt.*;
import java.io.File;
import java.net.URL;
import java.util.concurrent.TimeUnit;
public class login {
    private AndroidDriver driver;
    @BeforeClass
    public void setUp() throws Exception {
        File classpathRoot = new File(System.getProperty("user.dir"));
        File appDir = new File(classpathRoot, "apps");
        File app = new File(appDir, "ime_3.0.0.20_0816_1330.apk");
        DesiredCapabilities capabilities = new DesiredCapabilities();
        capabilities.setCapability("app", app.getAbsolutePath());
        capabilities.setCapability("platformName", "Android");
        capabilities.setCapability("deviceName", "HC44XWM00498");
//		capabilities.setCapability("platformVersion", "4.4.2");
//		capabilities.setCapability("appPackage", "com.ime.xmpp");
//		capabilities.setCapability("appActivity", ".WelcomeActivity");
        capabilities.setCapability("app", app.getAbsolutePath());
        capabilities.setCapability("unicodeKeyboard", "True");
        capabilities.setCapability("resetKeyboard", "True");
        driver = new AndroidDriver(new URL("http://127.0.0.1:4723/wd/hub"),
                capabilities);
        driver.manage().timeouts().implicitlyWait(5, TimeUnit.SECONDS);

    }
    @AfterClass
    public void tearDown() throws Exception {
//		driver.quit();
//		webdriver.quit();
    }

    @Test
    public void TestGlobalFunction() throws InterruptedException, AWTException {
        Thread.sleep(2000);
        driver.swipe(1000, 1700, 100, 1700, 1000);
        Thread.sleep(2000);
        driver.swipe(1000, 1700, 100, 1700, 1000);
        Thread.sleep(2000);
        GetObjectProperties d = new GetObjectProperties("com.operation.GetObjectProperties");
        d.getElement("yd_ljks", driver).click();
        Thread.sleep(2000);
        d.getElement("login_username", driver).sendKeys("77401169");
        d.getElement("login_password", driver).sendKeys("123abc");
        d.getElement("login_login", driver).click();
    }
}
