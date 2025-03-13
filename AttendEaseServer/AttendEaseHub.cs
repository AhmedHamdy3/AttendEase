using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace AttendEaseServer
{
    public class AttendEaseHub: Hub
    {
        // Dictionary to store connection IDs and roles
        //private static readonly ConcurrentDictionary<string, string> _userRoles = new ConcurrentDictionary<string, string>();


        // Method for clients to register their role
        //public async Task RegisterUserRole(string role)
        //{
        //    var connectionId = Context.ConnectionId;
        //    _userRoles[connectionId] = role; // Store the role
        //    await Clients.Caller.SendAsync("RoleRegistered", $"You are registered as {role}.");
        //}

        // Method for employees to send leave requests
        public async Task SendLeaveRequest(string employeeName, string leaveDetails)
        {
            // Get all HR connection IDs
            //var hrConnectionIds = _userRoles
            //    .Where(u => u.Value == "HR")
            //    .Select(u => u.Key)
            //    .ToList();

            // Send the leave request only to HR employees
            await Clients.All.SendAsync(
                "ReceiveLeaveRequest",
                $"{employeeName} has submitted a leave request: {leaveDetails}"
            );
        }

        // Handle client disconnection
        //public override async Task OnDisconnectedAsync(Exception exception)
        //{
        //    var connectionId = Context.ConnectionId;
        //    _userRoles.TryRemove(connectionId, out _); // Remove the disconnected client
        //    await base.OnDisconnectedAsync(exception);
        //}
    }
}
