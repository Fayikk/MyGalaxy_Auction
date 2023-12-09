namespace MyGalaxy_Auction.Hubs.ConnectionManagement
{
    public class ConnectionManager : IConnectionManager
    {

        public static Dictionary<string, List<string>> _userConnections = new Dictionary<string, List<string>>(); 


        public void AddConnection(string userId, string connectionId)
        {
            lock (_userConnections)
            {
                if (_userConnections.ContainsKey(userId))
                {
                    _userConnections[userId].Add(connectionId);
                }
                else
                {
                    _userConnections[userId] = new List<string>() { connectionId };
                }
            }
        }

        public List<string> GetAllConnections()
        {
            return _userConnections.Values.SelectMany(connections => connections).ToList();
        }

        public string GetConnection(string userId)
        {
            lock (_userConnections)
            {
                return _userConnections.ContainsKey(userId) ? _userConnections[userId].FirstOrDefault() : null;
            }
        }

        public IEnumerable<string> GetConnections(string userId)
        {
            lock (_userConnections)
            {   
                return _userConnections.ContainsKey(userId) ? _userConnections[userId] : Enumerable.Empty<string>();    
            }
        }

        public List<string> GetSpecificConnections()
        {
            var result = _userConnections.Values;
            return new List<string>();
        }

        public void RemoveConnection(string connectionId)
        {
           lock ( _userConnections)
            {
                foreach (var userId in _userConnections.Keys)
                {
                    _userConnections[userId].Remove(connectionId);
                }
            }
        }
    }
}
