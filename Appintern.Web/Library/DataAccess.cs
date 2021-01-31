using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Appintern.Web.DAL;
using Appintern.Web.DAL.Services;
using Appintern.Web.ViewModels;

namespace Appintern.Web.Library
{
    public class DataAccess
    {
        /// <summary>
        /// CURRENTLY NOT USED! - JUST TESTING
        /// </summary>
        private readonly AppinternWorksEntities db = new AppinternWorksEntities();

        #region EXISTORS

        public bool StudentExists(SignUpModel model)
        {
            var data = (from d in db.Students where d.LoginName == model.Username select d).FirstOrDefault();
            if (data != null)
                return true;

            return false;
        }

        public bool GraduateExists(SignUpModel model)
        {
            var data = (from d in db.Graduates where d.LoginName == model.Username select d).FirstOrDefault();
            if (data != null)
                return true;

            return false;
        }

        public bool SchoolExists(SignUpModel model)
        {
            var data = (from d in db.Schools where d.LoginName == model.Username select d).FirstOrDefault();
            if (data != null)
                return true;

            return false;
        }

        public bool TeacherExists(SignUpModel model)
        {
            var data = (from d in db.Teachers where d.LoginName == model.Username select d).FirstOrDefault();
            if (data != null)
                return true;

            return false;
        }

        public bool EmployerExists(SignUpModel model)
        {
            var data = (from d in db.Employers where d.LoginName == model.Username select d).FirstOrDefault();
            if (data != null)
                return true;

            return false;
        }

        public bool LiaisonOfficerExists(SignUpModel model)
        {
            var data = (from d in db.LiaisonOfficers where d.LoginName == model.Username select d).FirstOrDefault();
            if (data != null)
                return true;

            return false;
        }

        public bool OrganizationExists(SignUpModel model)
        {
            var data = (from d in db.Organizations where d.LoginName == model.Username select d).FirstOrDefault();
            if (data != null)
                return true;

            return false;
        }

        public bool AmbasssadorExists(SignUpModel model)
        {
            var data = (from d in db.Ambassadors where d.LoginName == model.Username select d).FirstOrDefault();
            if (data != null)
                return true;

            return false;
        }

        #endregion

        #region GETTERS

        public string GetMemberGroup(int memberGroupId)
        {
            var data = (from d in db.MemberGroups where d.MemberGroupID == memberGroupId select d).FirstOrDefault();
            if (data != null)
                return data.MemberGroupText;

            return "";
        }

        #endregion
    }
}