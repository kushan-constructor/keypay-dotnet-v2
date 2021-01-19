using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Au.Enums;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Models.Employee;

namespace KeyPayV2.Au.Functions
{
    public class EmployeeFunction : BaseFunction
    {
        public EmployeeFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <remarks>
        /// Deletes the employee with the specified ID.
        /// </remarks>
        public void DeleteEmployee(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}", Method.DELETE);
        }

        /// <summary>
        /// Get Employee basic details by ID
        /// </summary>
        /// <remarks>
        /// returns the basic employee details for the specified employee
        /// </remarks>
        public EmployeeDetailsModel GetEmployeeBasicDetailsById(int businessId, int employeeId)
        {
            return ApiRequest<EmployeeDetailsModel>($"/business/{businessId}/employee/{employeeId}/details");
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/image");
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int businessId, int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/business/{businessId}/employee/{employeeId}/image", Method.POST);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/image", Method.DELETE);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets leave balances for this employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int businessId, int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/business/{businessId}/employee/{employeeId}/leavebalances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}");
        }

        /// <summary>
        /// Get Employee Notes
        /// </summary>
        /// <remarks>
        /// Gets the notes for the specified employee.
        /// </remarks>
        public List<EmployeeNoteModel> GetEmployeeNotes(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeeNoteModel>>($"/business/{businessId}/employee/{employeeId}/notes");
        }

        /// <summary>
        /// Set Employee Notes
        /// </summary>
        /// <remarks>
        /// Sets the notes for the specified employee.
        /// </remarks>
        public void SetEmployeeNotes(int businessId, int employeeId, CreateEmployeeNoteModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/notes", model, Method.POST);
        }

        /// <summary>
        /// Get Opening Balances
        /// </summary>
        /// <remarks>
        /// Gets the opening balances for this employee.
        /// </remarks>
        public AuOpeningBalancesModel GetOpeningBalances(int businessId, int employeeId)
        {
            return ApiRequest<AuOpeningBalancesModel>($"/business/{businessId}/employee/{employeeId}/openingbalances");
        }

        /// <summary>
        /// Set Opening Balances
        /// </summary>
        /// <remarks>
        /// Sets the opening balances for this employee.
        /// </remarks>
        public void SetOpeningBalances(int businessId, int employeeId, AuOpeningBalancesModel model)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/openingbalances", model, Method.POST);
        }

        /// <summary>
        /// Get Pay Rates
        /// </summary>
        /// <remarks>
        /// Gets the pay rates for this employee.
        /// </remarks>
        public List<EmployeePayRateModel> GetPayRates(int businessId, int employeeId)
        {
            return ApiRequest<List<EmployeePayRateModel>>($"/business/{businessId}/employee/{employeeId}/payrate");
        }

        /// <summary>
        /// Get Employee Shift Conditions
        /// </summary>
        /// <remarks>
        /// Lists all the shift conditions for this employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<WorkTypeModel> GetEmployeeShiftConditions(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<WorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/shiftcondition{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Get standard hours for employee
        /// </summary>
        /// <remarks>
        /// Gets the standard hours for this employee.
        /// </remarks>
        public StandardHoursModel GetStandardHoursForEmployee(int businessId, int employeeId)
        {
            return ApiRequest<StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours");
        }

        /// <summary>
        /// Set standard hours for employee
        /// </summary>
        /// <remarks>
        /// Sets the standard hours for this employee.
        /// </remarks>
        public StandardHoursModel SetStandardHoursForEmployee(int businessId, int employeeId, StandardHoursModel model)
        {
            return ApiRequest<StandardHoursModel,StandardHoursModel>($"/business/{businessId}/employee/{employeeId}/standardhours", model, Method.PUT);
        }

        /// <summary>
        /// Sync Employee to QBO
        /// </summary>
        /// <remarks>
        /// Syncs an employee record to QBO.
        /// </remarks>
        public void SyncEmployeeToQbo(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/synctoqbo", Method.POST);
        }

        /// <summary>
        /// Get Employee Work Types
        /// </summary>
        /// <remarks>
        /// Lists all the work types for the employee.
        /// This operation supports OData queries.
        /// </remarks>
        public List<WorkTypeModel> GetEmployeeWorkTypes(int businessId, int employeeId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<WorkTypeModel>>($"/business/{businessId}/employee/{employeeId}/worktype{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Activate Employee
        /// </summary>
        /// <remarks>
        /// Activates the employee with the specified ID.
        /// </remarks>
        public void ActivateEmployee(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/activate/{employeeId}", Method.POST);
        }

        /// <summary>
        /// List basic details for employees
        /// </summary>
        /// <remarks>
        /// This endpoint returns a list of employees. The details are a subset of the 'unstructured' employee endpoint.
        /// This data can be filtered much more efficiently though so if you only need the basic employee details, this endpoint is preferred.
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<EmployeeDetailsModel> ListBasicDetailsForEmployees(int businessId, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<EmployeeDetailsModel>>($"/business/{businessId}/employee/details{ODataQuery.ToQueryString(oDataQuery, "?")}");
        }

        /// <summary>
        /// Grant Kiosk Access
        /// </summary>
        /// <remarks>
        /// Grants kiosk access to the specified employee.
        /// </remarks>
        public void GrantKioskAccess(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/grantkioskaccess/{employeeId}", Method.POST);
        }

        /// <summary>
        /// Revoke Kiosk Access
        /// </summary>
        /// <remarks>
        /// Revokes kiosk access from the specified employee.
        /// </remarks>
        public void RevokeKioskAccess(int businessId, int employeeId)
        {
            ApiRequest($"/business/{businessId}/employee/revokekioskaccess/{employeeId}", Method.POST);
        }

        /// <summary>
        /// List Employees
        /// </summary>
        /// <remarks>
        /// This endpoint returns the unstructured employee details for all matching employees.
        /// <p>
        /// See also: List basic details for employees (which is much more efficient if that is all the information that is required)
        /// </p>
        /// This operation supports OData queries (only $filter, $orderby, $top, $skip).
        /// </remarks>
        public List<AuUnstructuredEmployeeModel> ListEmployees(int businessId, ListEmployeesQueryModel request, ODataQuery oDataQuery = null)
        {
            return ApiRequest<List<AuUnstructuredEmployeeModel>>($"/business/{businessId}/employee/unstructured?payScheduleId={request.PayScheduleId}&locationId={request.LocationId}{ODataQuery.ToQueryString(oDataQuery, "&")}");
        }

        /// <summary>
        /// Create or Update Employee
        /// </summary>
        /// <remarks>
        /// If the employee with the specified ID already exists, update it. Otherwise, create a new employee.
        /// </remarks>
        public EmployeeUpdateResponseModel CreateOrUpdateEmployee(int businessId, AuUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,AuUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured", model, Method.POST);
        }

        /// <summary>
        /// Get Employee By ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified ID.
        /// </remarks>
        public AuUnstructuredEmployeeModel GetEmployeeById(int businessId, int employeeId)
        {
            return ApiRequest<AuUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}");
        }

        /// <summary>
        /// Update Employee
        /// </summary>
        /// <remarks>
        /// Updates the employee with the specified ID.
        /// </remarks>
        public EmployeeUpdateResponseModel UpdateEmployee(int businessId, int employeeId, AuUnstructuredEmployeeModel model)
        {
            return ApiRequest<EmployeeUpdateResponseModel,AuUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/{employeeId}", model, Method.PUT);
        }

        /// <summary>
        /// Get Employee By External ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external ID.
        /// </remarks>
        public AuUnstructuredEmployeeModel GetEmployeeByExternalId(int businessId, string externalId)
        {
            return ApiRequest<AuUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalid/{externalId}");
        }

        /// <summary>
        /// Get Employee By External Reference ID
        /// </summary>
        /// <remarks>
        /// Gets the employee with the specified external reference ID.
        /// </remarks>
        public AuUnstructuredEmployeeModel GetEmployeeByExternalReferenceId(int businessId, string externalReferenceId, ExternalService source)
        {
            return ApiRequest<AuUnstructuredEmployeeModel>($"/business/{businessId}/employee/unstructured/externalreferenceid/{externalReferenceId}/{source}");
        }
    }
}
