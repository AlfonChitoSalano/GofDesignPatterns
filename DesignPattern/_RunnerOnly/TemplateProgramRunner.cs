using DesignPattern.Behavioral.Template;

namespace DesignPattern.RunnerOnly
{
    internal class TemplateProgramRunner : IProgramRunner
    {
        public void Run()
        {
            CloudDatabaseLocator awsCloud = new AwsCloud();
            Console.WriteLine(awsCloud.GetDatabaseName());

            CloudDatabaseLocator azureCloud = new AzureCloud();
            Console.WriteLine(azureCloud.GetDatabaseName());
        }
    }
}
