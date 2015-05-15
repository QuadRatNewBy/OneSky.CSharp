namespace OneSkyDotNetTests
{
    using Xunit;

    // This test class uses ordering to create everything from scratch.
    // For example. Project.Create requires 'project_group_id' so we need to create ProjectGroup first.
    [TestCaseOrderer("PriorityOrderer", "OneSkyDotNetTests")]
    public class Platform
    {
         
    }
}