namespace DesignPattern.Behavioral.Template
{
    public class AwsCloud : CloudDatabaseLocator
    {
        protected override bool SetDatabaseConnection()
        {
            DatabaseProvider = "AWS";
            return true;
        }
    }
}