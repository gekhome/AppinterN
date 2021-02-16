using Appintern.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using CM = Umbraco.Web.PublishedModels;

namespace Appintern.Web.Library
{
    public class Utilities
    {
        ServiceContext _serviceContext = Umbraco.Web.Composing.Current.Services;

        /// <summary>
        /// Returns custom member type based on the member category selected in the signup form
        /// </summary>
        /// <param name="memberCategory"></param>
        /// <returns>String with member type</returns>
        public string GetMemberType(string memberCategory)
        {
            string memberType;

            if (memberCategory == "VET Student")
                memberType = "Student";
            else if (memberCategory == "VET Graduate")
                memberType = "Graduate";
            else if (memberCategory == "VET Provider")
                memberType = "School";
            else if (memberCategory == "VET Teacher")
                memberType = "Teacher";
            else if (memberCategory == "Business Ambassador")
                memberType = "Ambassador";
            else if (memberCategory == "Liaison Officer")
                memberType = "Liaison";
            else if (memberCategory == "Employer")
                memberType = "Employer";
            else if (memberCategory == "Social Partner")
                memberType = "Organization";
            else
                memberType = "Member";

            return memberType;
        }

        /// <summary>
        /// Returns member group based on the member category selected in the signup form
        /// </summary>
        /// <param name="memberCategory"></param>
        /// <returns>string value</returns>
        public string GetMemberGroup(string memberCategory)
        {
            string memberGroup = "";

            if (memberCategory == "VET Student")
                memberGroup = "VET Students";
            else if (memberCategory == "VET Graduate")
                memberGroup = "VET Graduates";
            else if (memberCategory == "VET Provider" || memberCategory == "VET Teacher")
                memberGroup = "VET Providers-Staff";
            else if (memberCategory == "Business Ambassador")
                memberGroup = "Job Consultants";
            else if (memberCategory == "Liaison Officer")
                memberGroup = "Job Consultants";
            else if (memberCategory == "Employer")
                memberGroup = "Employers";
            else if (memberCategory == "Social Partner")
                memberGroup = "Social Partners";

            return memberGroup;
        }

        /// <summary>
        /// Sets the url slug of members based n custom member type string
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="memberType"></param>
        /// <returns></returns>
        public string SetMemberUrlSlug(int memberId, string memberType)
        {
            // --- IGNORE THESE ---
            //var Members = Current.Services.MemberService.GetAll(0, int.MaxValue, out totalRecords);
            //var fullName = member.GetValue<string>(CM.Member.GetModelPropertyType(p => p.FullName).Alias);
            //string trimName = Regex.Replace(fullName, @"s", "");
            //var name = trimName.ToUrlSegment().ToLower();
            /// -------------------

            var member = Umbraco.Web.Composing.Current.Services.MemberService.GetById(memberId);

            Random rnd = new Random();
            string suffix = rnd.Next(1, 101).ToString();

            string urlSlug = memberId.ToString().ToUrlSegment() + suffix;

            if (memberType == "Student")
                member.SetValue(CM.Student.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "Graduate")
                member.SetValue(CM.Graduate.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "School")
                member.SetValue(CM.School.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "Teacher")
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "Employer")
                member.SetValue(CM.Employer.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "Organization")
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "Liaison")
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "Ambassador")
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else
                member.SetValue(CM.Member.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);

            Umbraco.Web.Composing.Current.Services.MemberService.Save(member);

            return urlSlug;
        }

        /// <summary>
        /// Sets the usrl slug based on the Umbraco member type alias
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="memberType"></param>
        /// <returns>Returns a string with the url slug</returns>
        public string SetUrlSlugByMemberTypeAlias(int memberId, string memberType)
        {
            var member = Umbraco.Web.Composing.Current.Services.MemberService.GetById(memberId);

            Random rnd = new Random();
            string suffix = rnd.Next(10, 101).ToString();

            string urlSlug = memberId.ToString().ToUrlSegment() + suffix;

            // member type aliases are in lowercase!
            if (memberType == "student")
                member.SetValue(CM.Student.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "graduate")
                member.SetValue(CM.Graduate.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "school")
                member.SetValue(CM.School.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "teacher")
                member.SetValue(CM.Teacher.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "employer")
                member.SetValue(CM.Employer.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "organization")
                member.SetValue(CM.Organization.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "liaison")
                member.SetValue(CM.Liaison.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType == "ambassador")
                member.SetValue(CM.Ambassador.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);
            else if (memberType.ToLower() == "member")
                member.SetValue(CM.Member.GetModelPropertyType(p => p.UrlSlug).Alias, urlSlug);

            Umbraco.Web.Composing.Current.Services.MemberService.Save(member);

            return urlSlug;
        }

        /// <summary>
        /// Joins strings of a string array with a comma separator
        /// </summary>
        /// <param name="array"></param>
        /// <returns>The concatenated string</returns>
        public string ConcatenateStringArray(string[] array)
        {
            string result = "";
            foreach (string item in array)
            {
                result += item + ", ";
            }
            result = result.TrimEnd(", ");
            return result;
        }

        #region ALL MEMBER GETTERS

        /// <summary>
        /// Gets a list of all Umbraco members
        /// </summary>
        /// <returns>A list of members</returns>
        [Umbraco.Web.WebApi.UmbracoAuthorize]
        public IEnumerable<IMember> GetAllMembers1()
        {
            return _serviceContext.MemberService.GetAllMembers();
        }

        public IList<UMember> GetAllMembers()
        {
            List<IMember> members = new List<IMember>();
            List<UMember> _members = new List<UMember>();
            var roles = _serviceContext.MemberGroupService.GetAll();
            foreach (var role in roles)
            {
                var groupMembers = _serviceContext.MemberService.GetMembersByGroup(role.Name);

                if (groupMembers != null && groupMembers.Count() > 0)
                {
                    foreach (var member in groupMembers)
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
                            Group = role.Name
                        });
                    }
                }
            }

            long membersCount = 0;
            members = _serviceContext.MemberService.GetAll(0, int.MaxValue, out membersCount).ToList();

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

        #endregion

        public List<string> MemberTypesList()
        {
            List<string> memberTypes = new List<string>();

            memberTypes.Add("ambassador");
            memberTypes.Add("employer");
            memberTypes.Add("graduate");
            memberTypes.Add("liaison");
            memberTypes.Add("organization");
            memberTypes.Add("school");
            memberTypes.Add("student");
            memberTypes.Add("teacher");
            memberTypes.Add("Member");

            return memberTypes;
        }

        public List<string> GetContentCategories()
        {
            List<string> categories = new List<string>
            {
                "News",
                "Events",
                "Jobs",
                "Employment",
                "Apprenticeships"
            };

            return categories;
        }

        public bool ValidImageFileExtension(string extension)
        {
            string[] extensions = { "PNG", "JPEG", "JPG", "GIF", "WEBP", "TIFF" };

            List<string> valid_extensions = new List<string>(extensions);

            if (valid_extensions.Contains(extension.ToUpper()))
                return true;
            return false;
        }

    }

    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        public override bool IsValid(object value)
        {
            var file = value as HttpPostedFileBase;
            if (file == null)
            {
                return false;
            }
            return file.ContentLength <= _maxFileSize;
        }

        public override string FormatErrorMessage(string name)
        {
            return base.FormatErrorMessage(_maxFileSize.ToString());
        }
    }

}