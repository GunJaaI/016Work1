namespace TestProgram;

public class UnitTest1
{
    [Fact]
    public void ConvertStringToIntNumber()
    {
        int number = Program.ConvertStringToIntNumber("1000");
        Assert.Equal(number,1000);
    }

    [Fact]
    public void IncorrectConvertStringToIntNumber()
    {
        Assert.Throws<Exception>(()=>Program.ConvertStringToIntNumber("Songtham"));
    }

    [Fact]
    public void ConvertStringToIntRV()
    {
        long number = Program.ConvertStringToIntRV("7124574235102");
        Assert.Equal(number,7124574235102);
    }

    [Fact]
    public void IncorrectConvertStringToIntRV()
    {
        Assert.Throws<Exception>(()=>Program.ConvertStringToIntRV("Hello"));
    }

    [Fact]
    public void ConvertStringToIntMoney()
    {
        double number = Program.ConvertStringToIntMoney("7879.75");
        Assert.Equal(number,7879.75f);
    }

    [Fact]
    public void IncorrectConvertStringToIntMoney()
    {
        Assert.Throws<Exception>(()=>Program.ConvertStringToIntMoney("Byee"));
    }


    [Fact]
    public void CheckB1000()
    {
        float number = Coin.B1000(1000f);
        Assert.Equal(number,1);
    }

    [Fact]
    public void CheckB500()
    {
        float number = Coin.B500(500f);
        Assert.Equal(number,1);
    }

    [Fact]
    public void CheckB100()
    {
        float number = Coin.B100(100f);
        Assert.Equal(number,1);
    }

    [Fact]
    public void CheckB50()
    {
        float number = Coin.B50(50f);
        Assert.Equal(number,1);
    }

    [Fact]
    public void CheckB20()
    {
        float number = Coin.B20(20f);
        Assert.Equal(number,1);
    }

    [Fact]
    public void CheckB10()
    {
        float number = Coin.B10(10f);
        Assert.Equal(number,1);
    }

    [Fact]
    public void CheckB5()
    {
        float number = Coin.B5(5f);
        Assert.Equal(number,1);
    }

    [Fact]
    public void CheckB2()
    {
        float number = Coin.B2(2f);
        Assert.Equal(number,1);
    }

    [Fact]
    public void CheckB1()
    {
        float number = Coin.B1(1f);
        Assert.Equal(number,1);
    }
}