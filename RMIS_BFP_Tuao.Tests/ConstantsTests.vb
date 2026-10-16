Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Linq

<TestClass>
Public Class ConstantsTests

    <TestMethod>
    Public Sub IncidentTypes_ContainsExpectedValues()
        Assert.IsTrue(Constants.IncidentTypes.Contains("Structure Fire"))
        Assert.IsTrue(Constants.IncidentTypes.Contains("Vehicular Fire"))
        Assert.IsTrue(Constants.IncidentTypes.Contains("Grass Fire"))
        Assert.IsTrue(Constants.IncidentTypes.Contains("Industrial Fire"))
        Assert.IsTrue(Constants.IncidentTypes.Contains("Electrical Fire"))
        Assert.IsTrue(Constants.IncidentTypes.Contains("Other"))
    End Sub

    <TestMethod>
    Public Sub IncidentTypes_HasSixEntries()
        Assert.AreEqual(6, Constants.IncidentTypes.Length)
    End Sub

    <TestMethod>
    Public Sub Statuses_ContainsExpectedValues()
        Assert.IsTrue(Constants.Statuses.Contains("Active"))
        Assert.IsTrue(Constants.Statuses.Contains("Resolved"))
        Assert.IsTrue(Constants.Statuses.Contains("Under Investigation"))
        Assert.IsTrue(Constants.Statuses.Contains("Closed"))
    End Sub

    <TestMethod>
    Public Sub Statuses_HasFourEntries()
        Assert.AreEqual(4, Constants.Statuses.Length)
    End Sub

    <TestMethod>
    Public Sub LogConstants_HaveExpectedValues()
        Assert.AreEqual("Success", Constants.LogSuccess)
        Assert.AreEqual("Failed",  Constants.LogFailed)
    End Sub

    <TestMethod>
    Public Sub UserTypeConstants_HaveExpectedValues()
        Assert.AreEqual("Admin", Constants.UserTypeAdmin)
        Assert.AreEqual("Staff", Constants.UserTypeStaff)
        Assert.AreEqual("Super Admin", Constants.UserTypeSuperAdmin)
        Assert.AreEqual("Sub Admin", Constants.UserTypeSubAdmin)
        Assert.AreEqual(2, Constants.Roles.Length)
        Assert.IsTrue(Constants.Roles.Contains("Super Admin"))
        Assert.IsTrue(Constants.Roles.Contains("Sub Admin"))
        Assert.IsFalse(Constants.Roles.Contains("Staff"))
    End Sub

End Class
