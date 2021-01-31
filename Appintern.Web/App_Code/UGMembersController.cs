/**
 * Author r.tarik
 * Added on 24.05.2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Umbraco.Web.WebApi;
using Umbraco.Core;
using Umbraco.Core.Cache;
using Umbraco.Core.Persistence;
using Umbraco.Core.Composing;
using Umbraco.Core.Services;
using Umbraco.Core.Models;
using Umbraco.Core.Persistence.Querying;
using Umbraco.Web.Mvc;
using Umbraco.Web.Editors;
using Constants = Umbraco.Core.Constants;
using Umbraco.Web.WebApi.Filters;

namespace UGardian.Api
{
    //[UmbracoApplicationAuthorize("UGardian")]
    //[IsBackOffice]
    //[PluginController("UmbracoApi")]
    public class UGMembersController : UmbracoAuthorizedApiController
    {
        ServiceContext _serviceContext = Current.Services;

        /// <summary>
        /// Gets a list of all Umbraco members
        /// </summary>
        /// <returns>A list of members</returns>
        [Umbraco.Web.WebApi.UmbracoAuthorize]
        public IEnumerable<IMember> GetAllMembers()
        {
            return _serviceContext.MemberService.GetAllMembers();
        }

        /// <summary>
        /// Gets a list of all Umbraco members
        /// </summary>
        /// <returns>A list of members</returns>
        //[Umbraco.Web.WebApi.UmbracoAuthorize, OverrideAuthorization]
        [HttpGet]
        //[Umbraco.Web.WebApi.UmbracoAuthorize]
        public IList<UMember> GetAllMembers1()
        {
           List<IMember> members = new List<IMember>();
            List<UMember> _members = new List<UMember>();
           var roles = _serviceContext.MemberGroupService.GetAll();
           foreach (var role in roles)
           {
               var groupMembers = _serviceContext.MemberService.GetMembersByGroup(role.Name);
               if (groupMembers != null && groupMembers.Count() > 0){
                 foreach(var member in groupMembers){
              _members.Add(new UMember(){
                 Id = member.Id,
                  Key = member.Key,
                  Name  = member.Name,
                 Login = member.Username,
                 LastLogin = member.LastLoginDate,
                 CreatedOn = member.CreateDate,
                 UpdatedOn = member.UpdateDate,
                 Type = member.ContentTypeAlias,
                 Email = member.Email,
                 Group = role.Name
                });
           }
               }
           }
            long membersCount = 0;
            members = _serviceContext.MemberService.GetAll(0, 1000000000,
            out membersCount).ToList();
            foreach (var member in members)
            {
                int index = _members.FindIndex(item => item.Id == member.Id);
                if (index < 0)
                {
                    _members.Add(new UMember()
                    {
                        Id = member.Id,
                        Key = member.Key,
                        Name = member.Name,
                        Login = member.Username,
                        LastLogin = member.LastLoginDate,
                        CreatedOn = member.CreateDate,
                        UpdatedOn = member.UpdateDate,
                        Type = member.ContentTypeAlias,
                        Email = member.Email,
                        Group = ""
                    });
                }

            }
                return _members;
        }

        /// <summary>
        /// Gets a list of all Umbraco member roles
        /// </summary>
        /// <returns>Returns all roles</returns>

        [HttpGet]
        //[Umbraco.Web.WebApi.UmbracoAuthorize]
        public IEnumerable<string> GetAllRoles()
        {
            return _serviceContext.MemberService.GetAllRoles();
        }

    }

}