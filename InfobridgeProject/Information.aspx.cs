using InfobridgeProject.App_Code;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InfobridgeProject
{
    public partial class Information : System.Web.UI.Page
    {
        EmployeeCRUD crud = new EmployeeCRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayAllEmps();
        }
        private void DisplayAllEmps()
        {
            DataTable table = crud.GetAllEmployess();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
        private void ClearPageFields()
        {
           txtId.Text = string.Empty;
            txtAddress.Text=string.Empty;
            txtName.Text = string.Empty;
            txtDOB.Text=string.Empty;
            txtPhone.Text = string.Empty;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32((txtId.Text));
                emp.Name = txtName.Text;
                emp.DOB = txtDOB.Text.ToString();
                emp.Sex = rbtSex.SelectedItem.ToString();
                emp.Phone = txtPhone.Text;
                emp.Address = txtAddress.Text;
                int result=crud.AddEmployee(emp);
                if (result == 1)
                {
                    lblMsg.Text = "Recrod saved";
                    ClearPageFields();
                    DisplayAllEmps();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        

        

       

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32((txtId.Text));
                emp.Name = txtName.Text.ToString();
                emp.DOB = txtDOB.Text.ToString();
                emp.Sex = rbtSex.Text.ToString();
                emp.Phone = txtPhone.Text.ToString();
                emp.Address = txtAddress.Text;
                int result = crud.UpdateEmployee(emp);
                if (result == 1)
                {
                    lblMsg.Text = "Recrod Updated";
                    ClearPageFields();
                    DisplayAllEmps();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btnSearch_Click1(object sender, EventArgs e)
        {
            try
            {
                var result = crud.GetEmployeeById(Convert.ToInt32(txtId.Text));
                txtName.Text = result.Name;
                txtDOB.Text = result.DOB;
                txtPhone.Text = result.Phone;
                txtAddress.Text = result.Address;
                rbtSex.Text = result.Sex;

            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btnDelete_Click1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                int result = crud.DeleteEmployee(id);
                if (result == 1)
                {
                    lblMsg.Text = "Record deleted";
                    ClearPageFields();
                    DisplayAllEmps();
                }

            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}