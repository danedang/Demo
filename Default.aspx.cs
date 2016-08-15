using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using  Chapt2.Models;
namespace Chapt2
{
    public partial class _Default : Page
    {

        private EmployeeRepository _repository;

        public EmployeeRepository Repository
        {
            get { return _repository ?? (_repository=new EmployeeRepository()); }
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            string employeeId = this.RouteData.Values["id"] as string;

            if ("*" == employeeId || string.IsNullOrEmpty(employeeId))
            {
                this.GridViewEmployees.DataSource = Repository.GetEmployees();
                this.GridViewEmployees.DataBind();
                this.DetailsViewEmployee.Visible = false;
            }
            else
            {
                this.DetailsViewEmployee.DataSource = Repository.GetEmployees(employeeId);
                this.DetailsViewEmployee.DataBind();
                this.GridViewEmployees.Visible = false;
            }

        }
    }
}