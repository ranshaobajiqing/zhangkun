package com.operation;

import com.controller.APPConnectionTest;
import com.controller.StatementObject;
import io.appium.java_client.android.AndroidDriver;
import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

import java.util.List;
import java.util.NoSuchElementException;

/**
 * Created by Administrator on 2015/9/15.
 */
public class UIOperation extends StatementObject {

    //Ԫ�صĲ���
    // ��ȡĳ��Ԫ��
    public static WebElement getEle(By by) {
        WebElement ele;
        ele = driver.findElement(by);
        return ele;

    }

    //��ȡԪ��list
    public static List<WebElement> getWebEleList(By by) {

        List<WebElement> eleList = driver.findElements(by);

        return eleList;
    }


    // �ж�ĳ��Ԫ���Ƿ����
    public static boolean isExist(By by) {
        try {
            driver.findElement(by);
            return true;
        } catch (NoSuchElementException e) {
            return false;
        }

    }

    // �ȴ�ĳԪ�ر��ҵ�
    public static WebElement waitEle(int waittime, By by) {
        WebElement ele;
        ele = new WebDriverWait(driver, waittime).until(ExpectedConditions
                .presenceOfElementLocated(by));
        return ele;
    }



    // ��ȡ��ǰ������
    public static String runName() {
        String s = new Throwable().getStackTrace()[1].getMethodName();
        return s;
    }

    // ����Լ��ķ�����
    public static void runOUt() {
        System.out.println(new Throwable().getStackTrace()[1].getMethodName()
                + "�Ѿ�����");

    }

    // ���ı��������ı�
    public static void inputBox(By by, String value) {
        driver.findElement(by).sendKeys(value);
    }

    public static void inputBox(WebElement ele, String value) {
        ele.sendKeys(value);
    }

    // ���ı����������
    public static void clearInput(By by, String value) {
        WebElement ele = driver.findElement(by);
        ele.clear();
        ele.sendKeys(value);

    }

    public static void clearIput(WebElement ele, String value) {
        ele.clear();
        ele.sendKeys(value);
    }

    // ����ı���
    public static void clearBox(By by) {
        driver.findElement(by).clear();
    }

    // ��ѡ���ѡ���ж�
    // ѡ�и�ѡ��
    public static void checkBoxSelect(By by) {
        WebElement checkbox = driver.findElement(by);
        while (checkbox.isSelected()) {
            checkbox.click();
        }
    }

    public static void checkBoxSelect(WebElement ele) {
        while (ele.isSelected()) {
            ele.click();
        }

    }

    // ȡ����ѡ��
    public static void checkBoxCancel(By by) {
        WebElement checkbox = driver.findElement(by);
        while (checkbox.isEnabled()) {
            checkbox.click();
        }
    }

    public static void checkBoxCancel(WebElement ele) {
        while (ele.isEnabled()) {
            ele.click();
        }

    }

    // ���ѡ��
    public static void clickButton(By by) {
        driver.findElement(by).click();
    }

    // ��ȡ����ı�
    public static String lableString(By by) {
        try {
            Thread.sleep(5000);
        } catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        String s = driver.findElement(by).getText();
        return s;
    }

    public static String lableString(WebElement ele) {
        try {
            Thread.sleep(5000);
        } catch (InterruptedException e) {
            // TODO Auto-generated catch block
            e.printStackTrace();
        }
        String s = ele.getText();
        return s;
    }

    // �Ƚϻ�ȡ���ı��Ƿ����ָ���ı� �����Ƿ��ָ���ı����
    public static boolean stringEquals(By by, String s1) {
        String s2 = driver.findElement(by).getText();
        if (s2.indexOf(s1) >= 0) {
            return true;
        } else {
            return false;
        }

    }

    public static boolean stringEquals(String s2, String s1) {

        // s2����s1,�������
        if (s2.indexOf(s1) >= 0) {
            return true;
        } else {
            return false;
        }

    }

    public static boolean stringEquals(WebElement ele, String s1) {

        String s2 = ele.getText();
        if (s2.indexOf(s1) >= 0) {
            return true;
        } else {
            return false;
        }
    }

    // �ϴ��ļ��Ĳ���
    public static void uploadFile(By by, String path) {
        WebElement ele = driver.findElement(by);
        ele.sendKeys(path);
    }


    //��������
    public static void swipeoperation(int startx, int starty, int endx, int endy,int duration,String key,GetObjectProperties ObjPor){
        while (isExist(ObjPor.getByObject(key))){
        driver.swipe(startx,starty,endx,endy,duration);
        }
    }
}
