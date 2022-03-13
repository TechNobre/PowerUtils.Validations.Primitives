using System;
using System.Globalization;

namespace PowerUtils.Validations.Primitives.Tests;

public class GetFormattedTests
{
    [Theory]
    [InlineData("0", "MIN:0")]
    [InlineData("10", "MIN:10")]
    [InlineData("-45", "MIN:-45")]
    public void GetMinFormatted_String_Code(string input, string expected)
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
    public void GetMaxFormatted_String_Code(string input, string expected)
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
    public void GetMinFormatted_Int_Code(int input, string expected)
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
    public void GetMaxFormatted_Int_Code(int input, string expected)
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
    public void GetMinFormatted_UInt_Code(uint input, string expected)
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
    public void GetMaxFormatted_UInt_Code(uint input, string expected)
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
    public void GetMinFormatted_Long_Code(long input, string expected)
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
    public void GetMaxFormatted_Long_Code(long input, string expected)
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
    public void GetMinFormatted_ULong_Code(ulong input, string expected)
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
    public void GetMaxFormatted_ULong_Code(ulong input, string expected)
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
    public void GetMinFormatted_Float_Code(float input, string expected)
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
    public void GetMaxFormatted_Float_Code(float input, string expected)
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
    public void GetMinFormatted_Double_Code(double input, string expected)
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
    public void GetMaxFormatted_Double_Code(double input, string expected)
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
    public void GetMinFormatted_Decimal_Code(decimal input, string expected)
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
    public void GetMaxFormatted_Decimal_Code(decimal input, string expected)
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
    public void GetMinFormatted_DateTime_Code(string input, string expected)
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
    public void GetMaxFormatted_DateTime_Code(string input, string expected)
    {
        // Arrange
        var dateTime = DateTime.ParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture);


        // Act
        var act = ErrorCodes.GetMaxFormatted(dateTime);


        // Assert
        act.Should()
            .Be(expected);
    }
}
