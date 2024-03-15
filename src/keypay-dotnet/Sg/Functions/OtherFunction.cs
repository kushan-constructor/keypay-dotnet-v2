using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Sg.Enums;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Models.Other;

namespace KeyPayV2.Sg.Functions
{
    public interface IOtherFunction
    {
        void AwardPackage_Put(AwardPackage_PutQueryModel request);
        Task AwardPackage_PutAsync(AwardPackage_PutQueryModel request, CancellationToken cancellationToken = default);
        void CreatesANewAwardPackageAndAssignsToTheSpecifiedBusiness(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request);
        Task CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessAsync(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request, CancellationToken cancellationToken = default);
        List<GiroBankModel> ListBanks();
        Task<List<GiroBankModel>> ListBanksAsync(CancellationToken cancellationToken = default);
        GiroBankBranchModel GetSpecificBankBranchDetails(GetSpecificBankBranchDetailsQueryModel request);
        Task<GiroBankBranchModel> GetSpecificBankBranchDetailsAsync(GetSpecificBankBranchDetailsQueryModel request, CancellationToken cancellationToken = default);
        List<GiroBankBranchModel> SgBank_Branches(SgBank_BranchesQueryModel request);
        Task<List<GiroBankBranchModel>> SgBank_BranchesAsync(SgBank_BranchesQueryModel request, CancellationToken cancellationToken = default);
        GiroBankModel GetSpecificBankDetails(GetSpecificBankDetailsQueryModel request);
        Task<GiroBankModel> GetSpecificBankDetailsAsync(GetSpecificBankDetailsQueryModel request, CancellationToken cancellationToken = default);
        SgPayRunDetailsModel SgPayRunDetails_Get(int businessId, int payRunId);
        Task<SgPayRunDetailsModel> SgPayRunDetails_GetAsync(int businessId, int payRunId, CancellationToken cancellationToken = default);
        List<RosterLiveLeaveAccruals> ReportsRosterLiveLeaveExport_Get(int businessId, ReportsRosterLiveLeaveExport_GetQueryModel request);
        Task<List<RosterLiveLeaveAccruals>> ReportsRosterLiveLeaveExport_GetAsync(int businessId, ReportsRosterLiveLeaveExport_GetQueryModel request, CancellationToken cancellationToken = default);
        List<MLCSuperReportExportModel> ReportsMLCSuper_Get(int businessId, ReportsMLCSuper_GetQueryModel request);
        Task<List<MLCSuperReportExportModel>> ReportsMLCSuper_GetAsync(int businessId, ReportsMLCSuper_GetQueryModel request, CancellationToken cancellationToken = default);
        void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request);
        Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default);
        List<PayrollExemptReportExportModel> ReportsPayrollExempt_Get(int businessId);
        Task<List<PayrollExemptReportExportModel>> ReportsPayrollExempt_GetAsync(int businessId, CancellationToken cancellationToken = default);
        List<PayrollExemptReportExportModel> ReportsPayrollExempt_Get(int businessId, ReportsPayrollExempt_GetQueryModel request);
        Task<List<PayrollExemptReportExportModel>> ReportsPayrollExempt_GetAsync(int businessId, ReportsPayrollExempt_GetQueryModel request, CancellationToken cancellationToken = default);
        List<WorkersCompReportGridModel> ReportsWorkersComp_Get(int businessId, ReportsWorkersComp_GetQueryModel request);
        Task<List<WorkersCompReportGridModel>> ReportsWorkersComp_GetAsync(int businessId, ReportsWorkersComp_GetQueryModel request, CancellationToken cancellationToken = default);
        void UpdateStatusEvent(int businessId, IList<TeamCollaborationUpdateStatusModel> model, UpdateStatusEventQueryModel request);
        Task UpdateStatusEventAsync(int businessId, IList<TeamCollaborationUpdateStatusModel> model, UpdateStatusEventQueryModel request, CancellationToken cancellationToken = default);
        void HandleRequestsForPollingDataFromZapier(HandleRequestsForPollingDataFromZapierQueryModel request);
        Task HandleRequestsForPollingDataFromZapierAsync(HandleRequestsForPollingDataFromZapierQueryModel request, CancellationToken cancellationToken = default);
    }
    public class OtherFunction : BaseFunction, IOtherFunction
    {
        public OtherFunction(ApiRequestExecutor api) : base(api) {}

        public void AwardPackage_Put(AwardPackage_PutQueryModel request)
        {
            ApiRequest($"/admin/awardpackage?url={request.Url}&businessId={request.BusinessId}", Method.Put);
        }

        public Task AwardPackage_PutAsync(AwardPackage_PutQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/awardpackage?url={request.Url}&businessId={request.BusinessId}", Method.Put, cancellationToken);
        }

        /// <summary>
        /// creates a new award package and assigns to the specified business
        /// </summary>
        public void CreatesANewAwardPackageAndAssignsToTheSpecifiedBusiness(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request)
        {
            ApiRequest($"/admin/awardpackage?businessId={request.BusinessId}", package, Method.Post);
        }

        /// <summary>
        /// creates a new award package and assigns to the specified business
        /// </summary>
        public Task CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessAsync(AwardPackageDataModel package, CreatesANewAwardPackageAndAssignsToTheSpecifiedBusinessQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/admin/awardpackage?businessId={request.BusinessId}", package, Method.Post, cancellationToken);
        }

        /// <summary>
        /// List Banks
        /// </summary>
        /// <remarks>
        /// Lists all of the banks.
        /// </remarks>
        public List<GiroBankModel> ListBanks()
        {
            return ApiRequest<List<GiroBankModel>>($"/bank", Method.Get);
        }

        /// <summary>
        /// List Banks
        /// </summary>
        /// <remarks>
        /// Lists all of the banks.
        /// </remarks>
        public Task<List<GiroBankModel>> ListBanksAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<GiroBankModel>>($"/bank", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Specific Bank Branch Details
        /// </summary>
        /// <remarks>
        /// Search for bank branch based on a Bank Swift, Branch Code and Account Number.
        /// </remarks>
        public GiroBankBranchModel GetSpecificBankBranchDetails(GetSpecificBankBranchDetailsQueryModel request)
        {
            return ApiRequest<GiroBankBranchModel>($"/bank/branch?bankSwift={request.BankSwift}&branchCode={request.BranchCode}&accountNumber={request.AccountNumber}", Method.Get);
        }

        /// <summary>
        /// Get Specific Bank Branch Details
        /// </summary>
        /// <remarks>
        /// Search for bank branch based on a Bank Swift, Branch Code and Account Number.
        /// </remarks>
        public Task<GiroBankBranchModel> GetSpecificBankBranchDetailsAsync(GetSpecificBankBranchDetailsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<GiroBankBranchModel>($"/bank/branch?bankSwift={request.BankSwift}&branchCode={request.BranchCode}&accountNumber={request.AccountNumber}", Method.Get, cancellationToken);
        }

        public List<GiroBankBranchModel> SgBank_Branches(SgBank_BranchesQueryModel request)
        {
            return ApiRequest<List<GiroBankBranchModel>>($"/bank/branches?bankSwift={request.BankSwift}&accountNumber={request.AccountNumber}", Method.Get);
        }

        public Task<List<GiroBankBranchModel>> SgBank_BranchesAsync(SgBank_BranchesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<GiroBankBranchModel>>($"/bank/branches?bankSwift={request.BankSwift}&accountNumber={request.AccountNumber}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Specific Bank Details
        /// </summary>
        /// <remarks>
        /// Search for bank based on a Bank Swift
        /// </remarks>
        public GiroBankModel GetSpecificBankDetails(GetSpecificBankDetailsQueryModel request)
        {
            return ApiRequest<GiroBankModel>($"/bank/details?bankSwift={request.BankSwift}", Method.Get);
        }

        /// <summary>
        /// Get Specific Bank Details
        /// </summary>
        /// <remarks>
        /// Search for bank based on a Bank Swift
        /// </remarks>
        public Task<GiroBankModel> GetSpecificBankDetailsAsync(GetSpecificBankDetailsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<GiroBankModel>($"/bank/details?bankSwift={request.BankSwift}", Method.Get, cancellationToken);
        }

        public SgPayRunDetailsModel SgPayRunDetails_Get(int businessId, int payRunId)
        {
            return ApiRequest<SgPayRunDetailsModel>($"/business/{businessId}/payrun/{payRunId}/details", Method.Get);
        }

        public Task<SgPayRunDetailsModel> SgPayRunDetails_GetAsync(int businessId, int payRunId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SgPayRunDetailsModel>($"/business/{businessId}/payrun/{payRunId}/details", Method.Get, cancellationToken);
        }

        public List<RosterLiveLeaveAccruals> ReportsRosterLiveLeaveExport_Get(int businessId, ReportsRosterLiveLeaveExport_GetQueryModel request)
        {
            return ApiRequest<List<RosterLiveLeaveAccruals>>($"/business/{businessId}/report/leavebalancesexport{ConvertEnumerableToQueryString("payScheduleIds", request.PayScheduleIds?.Select(x => x.ToString()))}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get);
        }

        public Task<List<RosterLiveLeaveAccruals>> ReportsRosterLiveLeaveExport_GetAsync(int businessId, ReportsRosterLiveLeaveExport_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<RosterLiveLeaveAccruals>>($"/business/{businessId}/report/leavebalancesexport{ConvertEnumerableToQueryString("payScheduleIds", request.PayScheduleIds?.Select(x => x.ToString()))}&asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.Get, cancellationToken);
        }

        public List<MLCSuperReportExportModel> ReportsMLCSuper_Get(int businessId, ReportsMLCSuper_GetQueryModel request)
        {
            return ApiRequest<List<MLCSuperReportExportModel>>($"/business/{businessId}/report/mlcsuper{ConvertEnumerableToQueryString("payScheduleIds", request.PayScheduleIds?.Select(x => x.ToString()))}", Method.Get);
        }

        public Task<List<MLCSuperReportExportModel>> ReportsMLCSuper_GetAsync(int businessId, ReportsMLCSuper_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MLCSuperReportExportModel>>($"/business/{businessId}/report/mlcsuper{ConvertEnumerableToQueryString("payScheduleIds", request.PayScheduleIds?.Select(x => x.ToString()))}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public void GetPaymentFilesByFinalisedPayRunId(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request)
        {
            ApiRequest($"/business/{businessId}/report/paymentfile?payRunId={request.PayRunId}&paymentFileId={request.PaymentFileId}", Method.Get);
        }

        /// <summary>
        /// Get Payment Files by Finalised Pay Run Id
        /// </summary>
        /// <remarks>
        /// Gets the payment files for a finalised pay run with the specified Id.
        /// </remarks>
        public Task GetPaymentFilesByFinalisedPayRunIdAsync(int businessId, GetPaymentFilesByFinalisedPayRunIdQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/report/paymentfile?payRunId={request.PayRunId}&paymentFileId={request.PaymentFileId}", Method.Get, cancellationToken);
        }

        public List<PayrollExemptReportExportModel> ReportsPayrollExempt_Get(int businessId)
        {
            return ApiRequest<List<PayrollExemptReportExportModel>>($"/business/{businessId}/report/payrollexempt", Method.Get);
        }

        public Task<List<PayrollExemptReportExportModel>> ReportsPayrollExempt_GetAsync(int businessId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayrollExemptReportExportModel>>($"/business/{businessId}/report/payrollexempt", Method.Get, cancellationToken);
        }

        public List<PayrollExemptReportExportModel> ReportsPayrollExempt_Get(int businessId, ReportsPayrollExempt_GetQueryModel request)
        {
            return ApiRequest<List<PayrollExemptReportExportModel>>($"/business/{businessId}/report/payrollexempt?state={request.State}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get);
        }

        public Task<List<PayrollExemptReportExportModel>> ReportsPayrollExempt_GetAsync(int businessId, ReportsPayrollExempt_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PayrollExemptReportExportModel>>($"/business/{businessId}/report/payrollexempt?state={request.State}&payScheduleId={request.PayScheduleId}&includePostTaxDeductions={request.IncludePostTaxDeductions}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}&employingEntityId={request.EmployingEntityId}", Method.Get, cancellationToken);
        }

        public List<WorkersCompReportGridModel> ReportsWorkersComp_Get(int businessId, ReportsWorkersComp_GetQueryModel request)
        {
            return ApiRequest<List<WorkersCompReportGridModel>>($"/business/{businessId}/report/workerscomp?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}", Method.Get);
        }

        public Task<List<WorkersCompReportGridModel>> ReportsWorkersComp_GetAsync(int businessId, ReportsWorkersComp_GetQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<WorkersCompReportGridModel>>($"/business/{businessId}/report/workerscomp?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}&locationId={request.LocationId}", Method.Get, cancellationToken);
        }

        /// <summary>
        /// Update status event
        /// </summary>
        /// <remarks>
        /// Posts an update status event, the payroll API acts as a transient layer that forwards the event and payload on
        /// to the correct integration adapter. This will then update the user status in the relevant team collaboration app.
        /// </remarks>
        public void UpdateStatusEvent(int businessId, IList<TeamCollaborationUpdateStatusModel> model, UpdateStatusEventQueryModel request)
        {
            ApiRequest($"/business/{businessId}/teamcollaboration/updatestatus?service={request.Service}", model, Method.Post);
        }

        /// <summary>
        /// Update status event
        /// </summary>
        /// <remarks>
        /// Posts an update status event, the payroll API acts as a transient layer that forwards the event and payload on
        /// to the correct integration adapter. This will then update the user status in the relevant team collaboration app.
        /// </remarks>
        public Task UpdateStatusEventAsync(int businessId, IList<TeamCollaborationUpdateStatusModel> model, UpdateStatusEventQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/teamcollaboration/updatestatus?service={request.Service}", model, Method.Post, cancellationToken);
        }

        /// <summary>
        /// Handle requests for polling data from Zapier
        /// </summary>
        /// <remarks>
        /// Accepts a url and businessId from the Zapier app and returns the response from the url in the required format to satisfy Zapier.
        /// </remarks>
        public void HandleRequestsForPollingDataFromZapier(HandleRequestsForPollingDataFromZapierQueryModel request)
        {
            ApiRequest($"/ZapierWebhooks/Polling?url={request.Url}&businessId={request.BusinessId}", Method.Get);
        }

        /// <summary>
        /// Handle requests for polling data from Zapier
        /// </summary>
        /// <remarks>
        /// Accepts a url and businessId from the Zapier app and returns the response from the url in the required format to satisfy Zapier.
        /// </remarks>
        public Task HandleRequestsForPollingDataFromZapierAsync(HandleRequestsForPollingDataFromZapierQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ZapierWebhooks/Polling?url={request.Url}&businessId={request.BusinessId}", Method.Get, cancellationToken);
        }
    }
}
