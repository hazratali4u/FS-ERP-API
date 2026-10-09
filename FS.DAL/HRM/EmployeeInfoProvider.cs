using System;
using System.Data;
using System.Data.SqlClient;
using FS.DAL.Common;
using System.Data.Common;

namespace FS.DAL.HRM
{
    public class EmployeeInfoProvider : BaseProvider
    {
        public EmployeeInfoProvider(string conStr) : base(conStr)
        {
            
        }
        public DataTable GetCompleteEmployeeInfo(int empId)
        {
            SqlConnection con = null;
            try
            {
                using (con = Connection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "HRM.procGetCompleteEmployeeInfo";
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@empId", empId);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                // LogUtility.LogError.ExceptionUtility.objErrorLogging.LogExceptionInDB(0, 0, 0, "Login", "GetLocation", "tblUser", "dbo.ProcGetLocationSite", ex, false, false);
                return null;
            }
            finally
            {
                if (con != null && con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }
        public DataSet GetEmployeeDDLs(int companyCode)
        {
            using (SqlConnection conn = Connection())
            {
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("[HRM].WebEmployeeDDLs", conn);
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTableMapping dtm1, dtm2, dtm3, dtm4, dtm5, dtm6, dtm7, dtm8, dtm9, dtm10, dtm11, dtm12, dtm13, dtm14, dtm15, dtm16, dtm17;
                dtm1 = adapter.TableMappings.Add("Table", "Designation");
                dtm2 = adapter.TableMappings.Add("Table1", "Department");
                dtm3 = adapter.TableMappings.Add("Table2", "Religion");
                dtm4 = adapter.TableMappings.Add("Table3", "Country");
                dtm5 = adapter.TableMappings.Add("Table4", "Location");
                dtm6 = adapter.TableMappings.Add("Table5", "ProfitCenter");
                dtm7 = adapter.TableMappings.Add("Table6", "Employee");
                dtm8 = adapter.TableMappings.Add("Table7", "HireType");
                dtm9 = adapter.TableMappings.Add("Table8", "Policy");
                dtm10 = adapter.TableMappings.Add("Table9", "Shift");
                dtm11 = adapter.TableMappings.Add("Table10", "TeamInfo");
                dtm12 = adapter.TableMappings.Add("Table11", "MaritalStatus");
                dtm13 = adapter.TableMappings.Add("Table12", "Relation");
                dtm14 = adapter.TableMappings.Add("Table13", "BankBranch");
                dtm15 = adapter.TableMappings.Add("Table14", "Companies");
                dtm16 = adapter.TableMappings.Add("Table15", "EmpCode");
                dtm17 = adapter.TableMappings.Add("Table16", "Configs");

                adapter.SelectCommand.Parameters.AddWithValue("companyCode", companyCode);

                adapter.Fill(dataset);
                return dataset;
            }
        }
    }
}
