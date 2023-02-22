using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Enums;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.Tests;

public class PersonShould
{
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_0_AndLessThan_7735_Returns_First()
    {
        //arrange
        var expectedIsrType =  IsrType.First;
        var person = new Person { Salary = 0.01f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_7735_AndLessThan_65651_Returns_Second()
    {
        //arrange
        var expectedIsrType =  IsrType.Second;
        var person = new Person { Salary = 7777f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_65651_AndLessThan_115375_Returns_Third()
    {
        //arrange
        var expectedIsrType =  IsrType.Third;
        var person = new Person { Salary = 77777f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_115375_AndLessThan_134119_Returns_Fourth()
    {
        //arrange
        var expectedIsrType =  IsrType.Fourth;
        var person = new Person { Salary = 115378f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_134119_AndLessThan_160577_Returns_Fifth()
    {
        //arrange
        var expectedIsrType =  IsrType.Fifth;
        var person = new Person { Salary = 134120f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_160577_AndLessThan_323862_Returns_Sixth()
    {
        //arrange
        var expectedIsrType =  IsrType.Sixth;
        var person = new Person { Salary = 260677f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_323862_AndLessThan_510451_Returns_Seventh()
    {
        //arrange
        var expectedIsrType =  IsrType.Seventh;
        var person = new Person { Salary = 423862f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_510451_AndLessThan_974535_Returns_Eighth()
    {
        //arrange
        var expectedIsrType =  IsrType.Eighth;
        var person = new Person { Salary = 710451f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_974535_AndLessThan_1299380_Returns_Nineth()
    {
        //arrange
        var expectedIsrType =  IsrType.Nineth;
        var person = new Person { Salary = 974585f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_1299380_AndLessThan_3898140_Returns_Tenth()
    {
        //arrange
        var expectedIsrType =  IsrType.Tenth;
        var person = new Person { Salary = 1399380f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
    [Fact]
    public void ProcessIsr_WhenSalaryIsMoreThan_3898140_Returns_Eleventh()
    {
        //arrange
        var expectedIsrType =  IsrType.Eleventh;
        var person = new Person { Salary = 38981400f};
        var sut = new IsrService();

        //act
        var result = sut.ProcessISR(person);
	
        //assert
        Assert.Equal(expectedIsrType, result.IsrType);
    }
}