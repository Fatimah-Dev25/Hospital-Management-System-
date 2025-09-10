using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class UserService : IUserService
    {
        RolesService roleService;

        public UserService()
        {
 
            roleService = new RolesService();
        }

        public int AddUser(Models.User user, int createdBy)
        {
            return UserRepository.AddUser(user.PersonID, user.Username, user.PasswordHash, user.RoleID, user.IsActive, createdBy);
        }

        public bool ChangePassword(int userId, string newPasswordHash, int updatedBy)
        {
            return UserRepository.ChangePassword(userId, newPasswordHash, updatedBy);
        }

        public bool ChangeUserActivation(int userID, bool activation , int updatedID)
        {
            return UserRepository.ChangeUserActivation(userID, activation ,updatedID);
        }

        public User GetUserByCredentials(string username, string passwordHash)
        {
            DataRow userDetail = UserRepository.GetUserByCredentials(username, passwordHash);

            if (userDetail != null) {

                return new User
                {
                    UsertId = Convert.ToInt32(userDetail["UserID"]),
                    Username = userDetail["Username"].ToString(),
                    PasswordHash = userDetail["PasswordHash"].ToString(),
                    PersonID = Convert.ToInt32(userDetail["PersonID"]),
                    IsActive = Convert.ToBoolean(userDetail["IsActive"]),
                    RelatedPerson = new Person
                    {
                        Fullname = userDetail["Fullname"].ToString(),
                        ImagePath = userDetail["Image"].ToString()
                    },
                    RoleID = Convert.ToInt32(userDetail["RoleID"]),
                    Role = userDetail["RoleName"].ToString(),
                };
            }
            return null;
        }

        public DataTable GetUsersList()
        {
            return UserRepository.GetUsersList();
        }

        public bool IsUserExistsByCredentials(string username, string passwordHash)
        {
            return UserRepository.IsUserExistsByCredentials(username, passwordHash);
        }

        public bool IsUserExistsByPersonID(int personID)
        {
            return UserRepository.IsUserExistsByPersonID(personID);
        }

        public bool IsUserExistsByUserID(int userID)
        {
            return UserRepository.IsUserExistsByUserID(userID);
        }

        public bool UpdateUserInfoByID(Models.User user, int updatedBy)
        {
            return UserRepository.UpdateUserInfoByID(user.UsertId, user.RoleID, user.Username, user.IsActive, updatedBy);
        }

        public List<(int, string)> GetUserRoles()
        {
            return roleService.GetAllUsersRole();
        }

        public Models.User GetUserInfoByID(int userID)
        {
 
            DataTable dt = UserRepository.GetUserInfoByID(userID);

            if (dt != null)
            {

                return new User
                {
                    UsertId = Convert.ToInt32(dt.Rows[0]["UserID"]),
                    Username = dt.Rows[0]["Username"].ToString(),
                    PasswordHash = dt.Rows[0]["PasswordHash"].ToString(),
                    PersonID = Convert.ToInt32(dt.Rows[0]["PersonID"]),
                    IsActive = Convert.ToBoolean(dt.Rows[0]["IsActive"]),
                    RelatedPerson = new Person { 
                     Fullname = dt.Rows[0]["Fullname"].ToString(),
                     ImagePath = dt.Rows[0]["Image"].ToString()
                    },
                    RoleID = Convert.ToInt32(dt.Rows[0]["RoleID"]),
                    Role = dt.Rows[0]["RoleName"].ToString(),
                };
            }

            return null;
        }

        public bool CheckUsernameExists(string username)
        {
            return UserRepository.CheckUsernameExists(username);
        }

      
    }
}   
