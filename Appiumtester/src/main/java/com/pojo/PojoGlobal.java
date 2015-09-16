package com.pojo;

/**
 * Created by Administrator on 2015/9/16.
 */
public class PojoGlobal {
    private int TestCaseID;
    private String PlatformName;
    private String TeacherUserName;
    private String StudentUserName;
    private String Password;
    private String TheFirstModelSystem;
    private String TheSecondModelSystem;


    public int getTestCaseID() {
        return TestCaseID;
    }

    public String getPlatformName() {
        return PlatformName;
    }

    public String getTeacherUserName() {
        return TeacherUserName;
    }

    public String getStudentUserName() {
        return StudentUserName;
    }

    public String getPassword() {
        return Password;
    }

    public String getTheFirstModelSystem() {
        return TheFirstModelSystem;
    }

    public String getTheSecondModelSystem() {
        return TheSecondModelSystem;
    }

    public void setTestCaseID(int testCaseID) {
        TestCaseID = testCaseID;
    }

    public void setPlatformName(String platformName) {
        PlatformName = platformName;
    }

    public void setTeacherUserName(String teacherUserName) {
        TeacherUserName = teacherUserName;
    }

    public void setStudentUserName(String studentUserName) {
        StudentUserName = studentUserName;
    }

    public void setPassword(String password) {
        Password = password;
    }

    public void setTheFirstModelSystem(String theFirstModelSystem) {
        TheFirstModelSystem = theFirstModelSystem;
    }

    public void setTheSecondModelSystem(String theSecondModelSystem) {
        TheSecondModelSystem = theSecondModelSystem;
    }
}
