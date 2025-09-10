using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IUserService
    {
        DataTable GetUsersList();
        Models.User GetUserInfoByID(int userID);
        bool IsUserExistsByUserID(int userID);
        bool IsUserExistsByPersonID(int personID);
        bool IsUserExistsByCredentials(string username, string passwordHash);
        Models.User GetUserByCredentials(string username, string passwordHash);
        int AddUser(Models.User user, int createdBy);
        bool ChangeUserActivation(int userID, bool isActive, int updatedBy);
        bool UpdateUserInfoByID(Models.User user, int updatedBy);
        bool ChangePassword(int userId, string newPasswordHash, int updatedBy);
    
        bool CheckUsernameExists(string username);
    }
}
