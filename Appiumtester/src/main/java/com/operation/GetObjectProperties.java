package com.operation;

import com.controller.StatementObject;
import org.ho.yaml.Yaml;
import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.HashMap;

public class GetObjectProperties extends StatementObject {



    public GetObjectProperties(String yamlName) {
        yamlFile = yamlName;
        this.getYamlFile();
    }

    private HashMap<String, HashMap<String, String>> ml;

    @SuppressWarnings("unchecked")
    public void getYamlFile() {
        File f = new File("locator/" + yamlFile + ".yaml");
        try {
            ml = Yaml.loadType(new FileInputStream(f.getAbsolutePath()),
                    HashMap.class);
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        }
    }

    private By getBy(String type, String value) {
        By by = null;
        if (type.equals("id")) {
            by = By.id(value);
        }
        else if (type.equals("name")) {
            by = By.name(value);
        }
        else if (type.equals("xpath")) {
            by = By.xpath(value);
        }
        else if (type.equals("className")) {
            by = By.className(value);
        }
        else if (type.equals("linkText")) {
            by = By.linkText(value);
        }
        return by;
    }

    public WebElement getElement(String key) {
        String type = ml.get(key).get("type");
        String value = ml.get(key).get("value");
        System.out.println(type);
        System.out.println(value);
        return UIOperation.waitEle(2,this.getBy(type, value));
    }




    public By getByObject(String key){
        String type = ml.get(key).get("type");
        String value = ml.get(key).get("value");
        return this.getBy(type, value);
    }

    public String getProperty(String key){
        return ml.get(key).get("value");
    }




}