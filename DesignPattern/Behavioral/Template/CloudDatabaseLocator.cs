namespace DesignPattern.Behavioral.Template
{
    public abstract class CloudDatabaseLocator
    {
        protected string? DatabaseProvider { get; set; }

        public string GetDatabaseName()
        {
            if (!SetDatabaseConnection())
            {
                throw new Exception("Connection failed!");
            }

            return GetName();
        }

        protected abstract bool SetDatabaseConnection();

        private string GetName()
        {
            return $"Database name: DatabaseVerified. From: {DatabaseProvider}";
        }
    }
}