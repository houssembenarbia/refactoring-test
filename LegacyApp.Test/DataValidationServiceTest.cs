namespace LegacyApp.Test;

public class DataValidationServiceTest
{

    //utilisation du modèle AAA

    [Fact]
    public void ValidateAge()
    {
        //Arrange 
        var TDataValidationService=new DataValidationServiceTest();

        //Act
        bool isValid=TDataValidationService.ValidateAge(DateTime.ParseExact("2005-05-08"));
        //Assert
         Assert.Equal(false,isValid);
    }
/*
    [Fact]
    public void checkCreditImportantClient()
    {
        //Arrange 
        var _Client=new Client();
        var _User=new User();
        var TDataValidationService=new DataValidationServiceTest();
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
        var TDataValidationService=new DataValidationServiceTest();
        //Act
        bool isValid=TDataValidationService.checkCredit();
        //Assert
        Assert.Equal();
    }
    */
}