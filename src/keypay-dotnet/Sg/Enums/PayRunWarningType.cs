using System;
using System.Collections.Generic;

namespace KeyPayV2.Sg.Enums
{
    public enum PayRunWarningType
    {
        PaymentFile,
        MoreLeaveThanAccrued,
        UnpaidEarnings,
        Birthday,
        Anniversary,
        NegativeEarnings,
        PreviouslyTerminated,
        TerminatedWithExpenseReimbursements,
        ExpiredQualification,
        DuplicateEarningsLines,
        TaxCodeMissing,
        Bpay,
        LeaveYearCapReached,
        AutoEnrolmentChanges,
        EmployeePensionContributionRefund,
        PensionSchemeRequiresAuthorization,
        UkTaxCodeUpdate,
        UkTaxCodeUpdateError,
        NINOUnknown,
        ProRataEarnings,
        HmrcLateReasonWarning,
        BelowMinimumWage,
        ExpiredSpecialTaxRate,
        ExpiredStudentLoanRate,
        PendingLeaveRequest,
        LeaveRequestBeyondPayPeriod,
        PrecedingLeaveRequest,
        IncompletePayRunTasks,
        PendingExpenseRequests,
        PayDayFiling,
        PayDayFilingAmendment,
        EmployeeInformation,
        IrdSettings,
        AutoUpdatedNICategory,
        UkStudentLoanUpdate,
        PensionProviderDoesNotAllowOverseasAddress,
        MissingLeaveYearEntitlement,
        LeaveRequestUnitTypeMismatch,
        ExpiredNric,
        ExcessOvertime,
        ForeignEmployee,
        ExcessDeductions,
        TerminatedForeignEmployee,
        StatutoryPaymentApplied,
        StatutoryPaymentAppliedPrevious,
        NationalInsuranceValidations,
        MixedOffsets,
        PendingSapPayment,
        ScheduledUpdateApplied,
        PensionSettingsUpdated,
        TaxReliefThresholdExceeded,
        UkNotNoticeUpdate,
        EarningsAutomaticallyAdjusted,
        EarningsRequireAdjustment,
        UkTaxCodeP9Update,
        HrdfEmployeeWarning,
        NewPayrolledBenefits,
        SubmitTerminatedEmployeeToHmrc,
        SuperReconciliationPreviousPayRun,
        SuperReconciliationThisPayRun,
        MoreThan28DaysWithoutTfnQuoted,
        BackCalculationsApplied,
        LeaveAccrualReconciliationPreviousPayRun,
        LeaveAccrualReconciliationThisPayRun,
        PublicHolidayAutomation,
        CisSubcontractorRequiresVerification,
        ItnRequiresUpdate,
        CisSubcontractorLastPaymentDate,
        CisSubcontractorUnmatched,
        CpfRefundRequired,
        CpfYearEndRecalculationRequired,
        TaxCodeDisplayNameTooLong,
        TimesheetOutOfSequence,
        ExpiredContractorTaxRate,
        ConcurrentPayRun,
        StudentLoanAdjustment,
        UnpaidLeaveWithAvailableBalance,
        OccupationalLeaveApplied,
        OccupationalLeaveAppliedPrevious,
        OccupationalLeaveEntitlementExhausted,
        AnnualLeaveCashedOut,
        EmployeeHasTakenPaidFamilyAndDomesticViolenceLeave,
        ConcurrentPayRunAU,
        EmployeePensionOptoutForPeriod,
        EmployeePensionContributionsCeased,
        EmployeePensionOptoutOrCease,
        PensionOptOutCouldNotConnect,
        PensionOptoutScopeUnauthorised,
        PensionOptoutUnmatched,
        PensionCeaseUnmatched
    }
}
