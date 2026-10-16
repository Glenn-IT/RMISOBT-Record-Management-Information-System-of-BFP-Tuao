Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports RMIS_BFP_Tuao

<TestClass>
Public Class SignatoryHelperTests

    <TestMethod>
    Public Sub GetSignatories_ReturnsDefaultSignatories()
        Dim sigs = SignatoryHelper.GetSignatories()
        Assert.IsNotNull(sigs)
        Assert.AreEqual(3, sigs.Count)

        Dim s1 = sigs(0)
        Assert.AreEqual("Signatory1", s1.KeyPrefix)
        Assert.IsFalse(String.IsNullOrWhiteSpace(s1.Label))
        Assert.IsFalse(String.IsNullOrWhiteSpace(s1.Name))
        Assert.IsTrue(s1.Enabled)

        Dim s2 = sigs(1)
        Assert.AreEqual("Signatory2", s2.KeyPrefix)
        Assert.IsFalse(String.IsNullOrWhiteSpace(s2.Label))
        Assert.IsFalse(String.IsNullOrWhiteSpace(s2.Name))
        Assert.IsTrue(s2.Enabled)
    End Sub

End Class
