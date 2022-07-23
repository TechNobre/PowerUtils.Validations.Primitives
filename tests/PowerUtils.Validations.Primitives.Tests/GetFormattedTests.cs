using System;
using System.Globalization;
using PowerUtils.Validations.Primitives.Tests.Fakes;

namespace PowerUtils.Validations.Primitives.Tests;

public class GetFormattedTests
{
    [Theory]
    [InlineData("0", "MIN:0")]
    [InlineData("10", "MIN:10")]
    [InlineData("-45", "MIN:-45")]
    public void String_GetMinFormatted_Code(string input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMinFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("0", "MAX:0")]
    [InlineData("10", "MAX:10")]
    [InlineData("-45", "MAX:-45")]
    public void String_GetMaxFormatted_Code(string input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMaxFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData(0, "MIN:0")]
    [InlineData(10, "MIN:10")]
    [InlineData(-45, "MIN:-45")]
    public void Int_GetMinFormatted_Code(int input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMinFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, "MAX:0")]
    [InlineData(10, "MAX:10")]
    [InlineData(-45, "MAX:-45")]
    public void Int_GetMaxFormatted_Code(int input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMaxFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData(0, "MIN:0")]
    [InlineData(10, "MIN:10")]
    [InlineData(45, "MIN:45")]
    public void UInt_GetMinFormatted_Code(uint input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMinFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, "MAX:0")]
    [InlineData(10, "MAX:10")]
    [InlineData(45, "MAX:45")]
    public void UInt_GetMaxFormatted_Code(uint input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMaxFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData(0, "MIN:0")]
    [InlineData(10, "MIN:10")]
    [InlineData(-45, "MIN:-45")]
    public void Long_GetMinFormatted_Code(long input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMinFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, "MAX:0")]
    [InlineData(10, "MAX:10")]
    [InlineData(-45, "MAX:-45")]
    public void Long_GetMaxFormatted_Code(long input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMaxFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData(0, "MIN:0")]
    [InlineData(10, "MIN:10")]
    [InlineData(45, "MIN:45")]
    public void ULong_GetMinFormatted_Code(ulong input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMinFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0, "MAX:0")]
    [InlineData(10, "MAX:10")]
    [InlineData(45, "MAX:45")]
    public void ULong_GetMaxFormatted_Code(ulong input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMaxFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData(0.124, "MIN:0.124")]
    [InlineData(10, "MIN:10")]
    [InlineData(-45, "MIN:-45")]
    [InlineData(-45.454, "MIN:-45.454")]
    public void Float_GetMinFormatted_Code(float input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMinFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.124, "MAX:0.124")]
    [InlineData(10, "MAX:10")]
    [InlineData(-45, "MAX:-45")]
    [InlineData(-45.454, "MAX:-45.454")]
    public void Float_GetMaxFormatted_Code(float input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMaxFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData(0.124, "MIN:0.124")]
    [InlineData(10, "MIN:10")]
    [InlineData(-45, "MIN:-45")]
    [InlineData(-45.454, "MIN:-45.454")]
    public void Double_GetMinFormatted_Code(double input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMinFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.124, "MAX:0.124")]
    [InlineData(10, "MAX:10")]
    [InlineData(-45, "MAX:-45")]
    [InlineData(-45.454, "MAX:-45.454")]
    public void Double_GetMaxFormatted_Code(double input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMaxFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData(0.124, "MIN:0.124")]
    [InlineData(10, "MIN:10")]
    [InlineData(-45, "MIN:-45")]
    [InlineData(-45.454, "MIN:-45.454")]
    public void Decimal_GetMinFormatted_Code(decimal input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMinFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData(0.124, "MAX:0.124")]
    [InlineData(10, "MAX:10")]
    [InlineData(-45, "MAX:-45")]
    [InlineData(-45.454, "MAX:-45.454")]
    public void Decimal_GetMaxFormatted_Code(decimal input, string expected)
    {
        // Arrange && Act
        var act = ErrorCodes.GetMaxFormatted(input);


        // Assert
        act.Should()
            .Be(expected);
    }



    [Theory]
    [InlineData("2000-12-12", "MIN:2000-12-12")]
    [InlineData("1987-01-11", "MIN:1987-01-11")]
    [InlineData("2099-11-01", "MIN:2099-11-01")]
    [InlineData("1977-02-21", "MIN:1977-02-21")]
    public void DateTime_GetMinFormatted_Code(string input, string expected)
    {
        // Arrange
        var dateTime = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture);


        // Act
        var act = ErrorCodes.GetMinFormatted(dateTime);


        // Assert
        act.Should()
            .Be(expected);
    }

    [Theory]
    [InlineData("2000-12-12", "MAX:2000-12-12")]
    [InlineData("1987-01-11", "MAX:1987-01-11")]
    [InlineData("2099-11-01", "MAX:2099-11-01")]
    [InlineData("1977-02-21", "MAX:1977-02-21")]
    public void DateTime_GetMaxFormatted_Code(string input, string expected)
    {
        // Arrange
        var dateTime = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture);


        // Act
        var act = ErrorCodes.GetMaxFormatted(dateTime);


        // Assert
        act.Should()
            .Be(expected);
    }


    [Theory]
    [InlineData(0, "MIN:0", "MAX:0")]
    [InlineData(10, "MIN:10", "MAX:10")]
    [InlineData(-45, "MIN:-45", "MAX:-45")]
    public void Generic_GetFormatted_Code(int input, string minExpected, string maxExpected)
    {
        // Arrange
        var obj = new FakeObj<int>(input, input);


        // Act
        var (minFormatted, maxFormatted) = obj.GetFormatted();


        // Assert
        minFormatted.Should()
            .Be(minExpected);
        maxFormatted.Should()
            .Be(maxExpected);
    }
}
