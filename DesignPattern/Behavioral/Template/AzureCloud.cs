namespace DesignPattern.Behavioral.Template
{
    public class AzureCloud : CloudDatabaseLocator
    {
        protected override bool SetDatabaseConnection()
        {
            DatabaseProvider = "Azure";
            return true;
        }
    }
}