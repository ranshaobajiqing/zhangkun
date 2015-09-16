package com.test;

        import org.ho.yaml.Yaml;
        import org.openqa.selenium.By;
        import org.openqa.selenium.WebDriver;
        import org.openqa.selenium.WebElement;
        import java.io.File;
        import java.io.FileInputStream;
        import java.io.FileNotFoundException;
        import java.util.HashMap;


public class GetObjectProperties {

    private String yamlFile;

    public GetObjectProperties(String yamlName) {
        yamlFile = yamlName;
        this.getYamlFile();
    }

    private HashMap<String, HashMap<String, String>> ml;

    @SuppressWarnings("unchecked")
    public void getYamlFile() {
        System.out.println(yamlFile);
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
        if (type.equals("name")) {
            by = By.name(value);
        }
        if (type.equals("xpath")) {
            by = By.xpath(value);
        }
        if (type.equals("className")) {
            by = By.className(value);
        }
        if (type.equals("linkText")) {
            by = By.linkText(value);
        }
        return by;
    }

    public WebElement getElement(String key,WebDriver driver) {
        String type = ml.get(key).get("type");
        String value = ml.get(key).get("value");
        return driver.findElement(this.getBy(type, value));
    }


    public String getProperty(String key){
        String value = ml.get(key).get("value");
        return value;
    }

}