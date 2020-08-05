using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace QbyteApiExperiment
{
    class Program
    {
        static void Main()
        {
            using (var connection =
                new OracleConnection("replace this with the connection string"))
            {
                var cmd = new OracleCommand
                {
                    BindByName = true,
                    Connection = connection,
                    CommandText = "afes_api.insert_afe",
                    CommandType = CommandType.StoredProcedure
                };

                // ---------------------------------------------
                // Inputs
                // ---------------------------------------------

                var afeNumber = new OracleParameter("i_afe_num", OracleDbType.Varchar2, 10)
                {
                    Direction = ParameterDirection.Input, 
                    Value = "C20-0001"
                };
                cmd.Parameters.Add(afeNumber);

                var afeType = new OracleParameter("i_afe_type_code", OracleDbType.Varchar2, 6)
                {
                    Direction = ParameterDirection.Input,
                    Value = "A"
                };
                cmd.Parameters.Add(afeType);

                var afeName = new OracleParameter("i_afe_name", OracleDbType.Varchar2, 40)
                {
                    Direction = ParameterDirection.Input,
                    Value = "Test Qbyte API"
                };
                cmd.Parameters.Add(afeName);

                var afeStatCode = new OracleParameter("i_afe_stat_code", OracleDbType.Varchar2, 10)
                {
                    Direction = ParameterDirection.Input,
                    Value = "U"
                };
                cmd.Parameters.Add(afeStatCode);

                var user = new OracleParameter("i_user", OracleDbType.Varchar2, 30)
                {
                    Direction = ParameterDirection.Input,
                    Value = "Pandell1"
                };
                cmd.Parameters.Add(user);

                // optional parameters
                cmd.Parameters.Add("i_ownership_org_id", OracleDbType.Decimal, ParameterDirection.Input);
                cmd.Parameters.Add("i_jib_flag", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_cip_transfer_flag", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_use_jibe_edits_flag", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_accrual_flag", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_budget_activity_id", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_budget_activity_year", OracleDbType.Date, ParameterDirection.Input);
                cmd.Parameters.Add("i_effective_date", OracleDbType.Date, ParameterDirection.Input);
                cmd.Parameters.Add("i_commitment_dat", OracleDbType.Date, ParameterDirection.Input);
                cmd.Parameters.Add("i_alloc_amt", OracleDbType.Decimal, ParameterDirection.Input);
                cmd.Parameters.Add("i_tax_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_start_date", OracleDbType.Date, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_finish_date", OracleDbType.Date, ParameterDirection.Input);
                cmd.Parameters.Add("i_managing_org_id", OracleDbType.Decimal, ParameterDirection.Input);
                cmd.Parameters.Add("i_net_estimate_pct", OracleDbType.Decimal, ParameterDirection.Input);
                cmd.Parameters.Add("i_province", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_success_effort_type_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_capital_accrual_cc_num", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_geologist_assigned", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_geophysicist_assigned", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_engineer_assigned", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_equip_component_amt", OracleDbType.Decimal, ParameterDirection.Input);
                cmd.Parameters.Add("i_wrhse_component_amt", OracleDbType.Decimal, ParameterDirection.Input);
                cmd.Parameters.Add("i_translation_rate", OracleDbType.Decimal, ParameterDirection.Input);
                cmd.Parameters.Add("i_allow_other_orgs_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_survey_system_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_location_element_1", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_location_element_2", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_location_element_3", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_location_element_4", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_location_element_5", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_location_element_6", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_location_element_7", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_location_element_8", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_doi_type_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_accrual_org_id", OracleDbType.Decimal, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_class_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_default_gl_sub_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_overhead_start_date", OracleDbType.Date, ParameterDirection.Input);
                cmd.Parameters.Add("i_overhead_end_date", OracleDbType.Date, ParameterDirection.Input);
                cmd.Parameters.Add("i_last_accrued_date", OracleDbType.Date, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_1_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_2_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_3_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_4_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_5_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_6_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_7_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_8_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_9_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_10_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_11_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_12_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_13_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_14_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_15_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_16_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_17_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_18_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_19_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_udf_20_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_reporting_udf_1_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_reporting_udf_2_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_afe_reporting_udf_3_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_capital_or_dry_hole_exp_code", OracleDbType.Varchar2, ParameterDirection.Input);
                cmd.Parameters.Add("i_country_code", OracleDbType.Varchar2, ParameterDirection.Input);

                // ---------------------------------------------
                // Outputs
                // ---------------------------------------------
                var returnStatus = new OracleParameter("o_return_status", OracleDbType.Varchar2)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(returnStatus);

                var returnCode = new OracleParameter("o_return_code", OracleDbType.Decimal)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(returnCode);


                var returnMessage = new OracleParameter("o_return_message", OracleDbType.Varchar2)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(returnMessage);

                // ---------------------------------------------
                // Execute
                // ---------------------------------------------
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Console.WriteLine("Query finished. Return result:");
                    Console.WriteLine("{0}", returnStatus.Value);
                    Console.WriteLine("{0}", returnMessage.Value);
                }
                catch (OracleException e)
                {
                    Console.WriteLine("Test failed -----------------------------------------------");
                    Console.WriteLine(e.Number);
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);

            }
        }
    }
}
