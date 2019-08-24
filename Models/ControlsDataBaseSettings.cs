namespace ControlsApi.Models {
    public class ControlsDatabaseSettings : IControlsDatabaseSettings
    {
        public string ControlsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IControlsDatabaseSettings
    {
        string ControlsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}