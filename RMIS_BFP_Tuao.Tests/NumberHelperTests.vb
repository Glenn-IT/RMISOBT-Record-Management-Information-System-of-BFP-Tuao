Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports RMIS_BFP_Tuao

<TestClass>
Public Class NumberHelperTests

    <TestMethod>
    Public Sub FormatCasualties_ValidValues_ReturnsFormattedString()
        Assert.AreEqual("0", NumberHelper.FormatCasualties(""))
        Assert.AreEqual("0", NumberHelper.FormatCasualties("0"))
        Assert.AreEqual("5", NumberHelper.FormatCasualties("5"))
        Assert.AreEqual("1,250", NumberHelper.FormatCasualties("1250"))
    End Sub

    <TestMethod>
    Public Sub FormatDamage_ValidValues_ReturnsFormattedWithPesoSign()
        Assert.AreEqual("₱ 0", NumberHelper.FormatDamage(""))
        Assert.AreEqual("₱ 0", NumberHelper.FormatDamage("0"))
        Assert.AreEqual("₱ 500,000", NumberHelper.FormatDamage("500000"))
        Assert.AreEqual("₱ 1,500,000", NumberHelper.FormatDamage("1500000"))
    End Sub

    <TestMethod>
    Public Sub FormatDamageNumber_ValidValues_ReturnsSeparatedInteger()
        Assert.AreEqual("0", NumberHelper.FormatDamageNumber(""))
        Assert.AreEqual("500,000", NumberHelper.FormatDamageNumber("500000"))
    End Sub

    <TestMethod>
    Public Sub IsValidInteger_ValidIntegers_ReturnsTrue()
        Dim outVal As Long
        Assert.IsTrue(NumberHelper.IsValidInteger("0", outVal))
        Assert.AreEqual(0L, outVal)

        Assert.IsTrue(NumberHelper.IsValidInteger("15", outVal))
        Assert.AreEqual(15L, outVal)

        Assert.IsTrue(NumberHelper.IsValidInteger("1,500,000", outVal))
        Assert.AreEqual(1500000L, outVal)

        Assert.IsTrue(NumberHelper.IsValidInteger("", outVal))
        Assert.AreEqual(0L, outVal)
    End Sub

    <TestMethod>
    Public Sub IsValidInteger_DecimalsNegativesAndLetters_ReturnsFalse()
        Dim outVal As Long
        Assert.IsFalse(NumberHelper.IsValidInteger("50.5", outVal))
        Assert.IsFalse(NumberHelper.IsValidInteger("-10", outVal))
        Assert.IsFalse(NumberHelper.IsValidInteger("abc", outVal))
        Assert.IsFalse(NumberHelper.IsValidInteger("100a", outVal))
    End Sub

End Class
