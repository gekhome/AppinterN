using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Mvc;
using Umbraco.Core.Composing;

namespace Appintern.Core.Helpers
{
    public class MemberHelper
    {
        public static bool MemberExists(string email, string username)
        {
            bool emailExists = Current.Services.MemberService.GetByEmail(email) != null;
            bool usernameExists = Current.Services.MemberService.GetByUsername(username) != null;

            return emailExists || usernameExists;
        }

        /// <summary>
        /// Creates an Umbraco member and assigns them to a role/group if you wish. Returns the member Id.
        /// </summary>
        /// <param name="username">The username for the member</param>
        /// <param name="name">The name of the member</param>
        /// <param name="email">The email address for the member</param>
        /// <param name="password">A predefined password for the member (leave blank if you want a random password to be created)</param>
        /// <param name="roleName">A role / group to assign the member to</param>
        /// <returns>Member Id</returns>
        public static int CreateMember(string username, string name, string email, string password = null, string roleName = null)
        {
            // Create the member
            // TODO: select member type based on group passed
            var member = Current.Services.MemberService.CreateMember(username, email, name, "Member");

            //Set them to be approved
            member.IsApproved = true;

            //Save the member before adding a password or assigning them to a role.
            Current.Services.MemberService.Save(member);

            //if no password was provided, create a random one here, so people can't login with an empty password.
            if (string.IsNullOrEmpty(password))
            {
                password = Guid.NewGuid().ToString().Substring(0, 10);
            }
            Current.Services.MemberService.SavePassword(member, password);

            //If a role name was passed in, assign them to the role (member group) here.
            if (!string.IsNullOrEmpty(roleName))
            {
                Current.Services.MemberService.AssignRole(member.Id, roleName);
            }
            return member.Id;
        }

        /// <summary>
        /// Creates an Umbraco member and assigns them to a role/group if you wish. Returns the member Id.
        /// </summary>
        /// <param name="username">The username for the member</param>
        /// <param name="name">The name of the member</param>
        /// <param name="email">The email address for the member</param>
        /// <param name="password">A predefined password for the member (leave blank if you want a random password to be created)</param>
        /// <param name="roleName">A role / group to assign the member to</param>
        /// <returns>Member Id</returns>
        public static int CreateCustomMember(string username, string name, string email, string password = null, string memberType = null, string roleName = null)
        {
            // Create the member
            var member = Current.Services.MemberService.CreateMember(username, email, name, memberType);

            //Set them to be approved
            member.IsApproved = true;

            //Save the member before adding a password or assigning them to a role.
            Current.Services.MemberService.Save(member);

            //if no password was provided, create a random one here, so people can't login with an empty password.
            if (string.IsNullOrEmpty(password))
            {
                password = Guid.NewGuid().ToString().Substring(0, 10);
            }
            Current.Services.MemberService.SavePassword(member, password);

            //If a role name was passed in, assign them to the role (member group) here.
            if (!string.IsNullOrEmpty(roleName))
            {
                Current.Services.MemberService.AssignRole(member.Id, roleName);
            }
            return member.Id;
        }



    }
}
