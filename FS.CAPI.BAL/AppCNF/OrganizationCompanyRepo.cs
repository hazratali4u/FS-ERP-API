using System;
using System.Collections.Generic;
using CST.CCL.Helper.Common;
using FS.DAL.AppCNF;
using FS.ERP.Models.BO;
using FS.ERP.Models.Custom;

namespace FS.CAPI.BAL.AppCNF
{
    public class OrganizationCompanyRepo :CAPIBaseRepo
    {
        public OrganizationCompanyRepo(string conStr) : base(conStr)
        {
            
        }
        public List<BOOrganizationCompany> GetChildOrganizations(int companyId)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("companyCode", companyId));
                return new OrganizationCompany(ConStr).GetChildOrganizations(lpm).DataTableToList<BOOrganizationCompany>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<BOOrganizationCompany> GetParentOrganizations(int orgId)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("organizationId", orgId));
                return new OrganizationCompany(ConStr).GetParentOrganizations(lpm).DataTableToList<BOOrganizationCompany>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<BOOrganizationCompany> GetGroupProfitCenter(int companyId)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("companyCode", companyId));
                return new OrganizationCompany(ConStr).GetGeoupProfitCenter(lpm).DataTableToList<BOOrganizationCompany>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<DuplicateCheck> CheckDuplicateOrganization(int id, string name, int level, string ntn, string gst, string iata, string sns)
        {
            try
            {
                List<ParameterList> lpm = new List<ParameterList>();
                lpm.Add(new ParameterList("id", id));
                lpm.Add(new ParameterList("name", name));
                lpm.Add(new ParameterList("level", level));
                lpm.Add(new ParameterList("ntn", ntn));
                lpm.Add(new ParameterList("gst", gst));
                lpm.Add(new ParameterList("iata", iata));
                lpm.Add(new ParameterList("sns", sns));
                return new OrganizationCompany(ConStr).CheckDuplicateOrganization(lpm).DataTableToList<DuplicateCheck>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
