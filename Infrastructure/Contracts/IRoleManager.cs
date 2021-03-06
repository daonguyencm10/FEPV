﻿// © 2007 IDesign Inc. All rights reserved 
//Questions? Comments? go to 
//http://www.idesign.net

using System;
namespace CredentialsManager
{
    public partial interface IRoleManager
    {
        /// <summary>
        /// Adds the specified users to the specified role.
        /// </summary>

        void AddUsersToRole(string application, string[] userNames, string role);

        /// <summary>
        /// Adds the specified users to the specified roles.
        /// </summary>
        void AddUsersToRoles(string application, string[] userNames, string[] roles);

        /// <summary>
        /// Adds the specified user to the specified role.
        /// </summary>
        void AddUserToRole(string application, string userName, string role);

        /// <summary>
        /// Adds the specified user to the specified roles.
        /// </summary>
        void AddUserToRoles(string application, string userName, string[] roles);

        /// <summary>
        /// Adds a new role to the data source.
        /// </summary>
        void CreateRole(string application, string role);

        /// <summary>
        /// Removes a role from the data source. If throwOnPopulatedRole is true,throws an exception if roleName has one or more members.
        /// </summary>
        bool DeleteRole(string application, string role, bool throwOnPopulatedRole);

        /// <summary>
        /// Removes all the roles from the data source. If throwOnPopulatedRole is true,throws an exception if any of the roles has one or more members
        /// </summary>
        void DeleteAllRoles(string application, bool throwOnPopulatedRole);

        /// <summary>
        /// Gets a list of all the roles for the application.
        /// </summary>
        string[] GetAllRoles(string application);

        /// <summary>
        /// Gets a list of the roles that a user is in.
        /// </summary>
        string[] GetRolesForUser(string application, string userName);

        /// <summary>
        /// Gets a list of users in the specified role.
        /// </summary>
        string[] GetUsersInRole(string application, string role);

        /// <summary>
        /// Returns true if role management is enabled; otherwise,false
        /// </summary>
        bool IsRolesEnabled(string application);

        /// <summary>
        /// Returns true if the role name already exists in the data source; otherwise,false.
        /// </summary>
        bool RoleExists(string application, string role);

        /// <summary>
        /// Removes the specified user from the specified role.
        /// </summary>
        void RemoveUserFromRole(string application, string userName, string roleName);

        /// <summary>
        /// Removes the specified users from the specified role.
        /// </summary>
        void RemoveUsersFromRole(string application, string[] users, string role);

        /// <summary>
        /// Removes the specified user from the specified roles.
        /// </summary>
        void RemoveUserFromRoles(string application, string user, string[] roles);

        /// <summary>
        /// Removes the specified user names from the specified roles.
        /// </summary>
        void RemoveUsersFromRoles(string application, string[] users, string[] roles);
    }
}