namespace MyGalaxy_Auction.Hubs.ConnectionManagement
{
    public interface IConnectionManager
    {
        void AddConnection(string userId, string connectionId);
        string GetConnection(string userId);
        IEnumerable<string> GetConnections(string userId);

        void RemoveConnection(string connectionId);
        List<string> GetAllConnections();   
        List<string> GetSpecificConnections();
    }
}
