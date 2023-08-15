using System;
using LegacyApp;
namespace LegacyApp.Test;

public class DataValidationServiceTest
{

    //utilisation du modèle AAA

    [Fact]
    public void ValidateAge()
    {
        //Arrange 
        var TDataValidationService=new DataValidationService();

        //Act
        bool isValid=TDataValidationService.ValidateAge(new DateTime(1993, 1, 1));
        //Assert
        Assert.False(isValid);
    }
/*
    [Fact]
    public void checkCreditImportantClient()
    {
        //Arrange 
        var _Client=new Client();
        var _User=new User();
        var TDataValidationService=new DataValidationService();
        //Act
        bool isValid=TDataValidationService.checkCredit();
        //Assert
        Assert.Equal();
    }
    [Fact]
    public void checkCreditVeryImportantClient()
    {
        //Arrange 
        var _User=new User();
        var _User=new User();
        var TDataValidationService=new DataValidationService();
        //Act
        bool isValid=TDataValidationService.checkCredit();
        //Assert
        Assert.Equal();
    }
    */
}