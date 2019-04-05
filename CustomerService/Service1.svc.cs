using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CustomerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public int addCustomer(Customer customer)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DGAB2KA;Initial Catalog=Bank;Integrated Security=True");
            conn.Open();
            string procedure_name = "addCustomer";
            SqlCommand command = new SqlCommand(procedure_name, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter _name = new SqlParameter("@custName", customer.CustomerName);
            command.Parameters.Add(_name);
            SqlParameter _gender = new SqlParameter("@gender", customer.Gender);
            command.Parameters.Add(_gender);
            SqlParameter _dob = new SqlParameter("@dob", customer.Dob);
            command.Parameters.Add(_dob);
            SqlParameter _address = new SqlParameter("@state", customer.State);
            command.Parameters.Add(_address);
            SqlParameter _state = new SqlParameter("@address", customer.Dob);
            command.Parameters.Add(_state);
            SqlParameter _city = new SqlParameter("@city", customer.City);
            command.Parameters.Add(_city);
            SqlParameter _pincode = new SqlParameter("@pincode", customer.Pincode);
            command.Parameters.Add(_pincode);
            SqlParameter _phoneNo = new SqlParameter("@phoneNo", customer.PhoneNo);
            command.Parameters.Add(_phoneNo);
            SqlParameter _email = new SqlParameter("@email", customer.Email);
            command.Parameters.Add(_email);
            SqlParameter _createdDate = new SqlParameter("@createdDate", customer.CreatedDate);
            command.Parameters.Add(_createdDate);
            SqlParameter _editedDate = new SqlParameter("@editedDate", customer.EditedDate);
            command.Parameters.Add(_editedDate);
            SqlParameter _userId = new SqlParameter("@userId", customer.UserID);
            command.Parameters.Add(_userId);
            int rows_affected = command.ExecuteNonQuery();
            conn.Close();
            return rows_affected;
        }

        public DataSet getSpecificCustomer(int custId)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DGAB2KA;Initial Catalog=Bank;Integrated Security=True");
            conn.Open();
            //string procedure_name = "getSpecificCustomer";
            SqlCommand command = new SqlCommand("select * from Customer where customerId = " + custId, conn);
            //SqlParameter id = new SqlParameter("@custId", custId);
            //command.Parameters.Add(id);
            //command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter reader = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            reader.Fill(ds);
            conn.Close();
            return ds;
        }

        public int deleteCustomer(int custId)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DGAB2KA;Initial Catalog=Bank;Integrated Security=True");
            conn.Open();
            string procedure_name = "deleteCustomer";
            SqlCommand command = new SqlCommand(procedure_name, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter("@custId", custId);
            command.Parameters.Add(id);
            int rows_affected = command.ExecuteNonQuery();
            conn.Close();
            return rows_affected;
        }

        public int updateCustomer(Customer customer)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DGAB2KA;Initial Catalog=Bank;Integrated Security=True");
            conn.Open();
            string procedure_name = "updateCustomer";
            SqlCommand command = new SqlCommand(procedure_name, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter("@custId", customer.CustomerID);
            command.Parameters.Add(id);
            SqlParameter _name = new SqlParameter("@custName", customer.CustomerName);
            command.Parameters.Add(_name);
            SqlParameter _gender = new SqlParameter("@gender", customer.Gender);
            command.Parameters.Add(_gender);
            SqlParameter _dob = new SqlParameter("@dob", customer.Dob);
            command.Parameters.Add(_dob);
            SqlParameter _address = new SqlParameter("@state", customer.State);
            command.Parameters.Add(_address);
            SqlParameter _state = new SqlParameter("@address", customer.Dob);
            command.Parameters.Add(_state);
            SqlParameter _city = new SqlParameter("@city", customer.City);
            command.Parameters.Add(_city);
            SqlParameter _pincode = new SqlParameter("@pincode", customer.Pincode);
            command.Parameters.Add(_pincode);
            SqlParameter _phoneNo = new SqlParameter("@phoneNo", customer.PhoneNo);
            command.Parameters.Add(_phoneNo);
            SqlParameter _email = new SqlParameter("@email", customer.Email);
            command.Parameters.Add(_email);
            SqlParameter _editedDate = new SqlParameter("@editedDate", customer.EditedDate);
            command.Parameters.Add(_editedDate);
            SqlParameter _userId = new SqlParameter("@userId", customer.UserID);
            command.Parameters.Add(_userId);
            int rows_affected = command.ExecuteNonQuery();
            conn.Close();
            return rows_affected;
        }

        public int addLogin(string userId, string password, string userType)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DGAB2KA;Initial Catalog=Bank;Integrated Security=True");
            conn.Open();
            string procedure_name = "addLogin";
            SqlCommand command = new SqlCommand(procedure_name, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter("@userId", userId);
            command.Parameters.Add(id);
            SqlParameter pass = new SqlParameter("@password", password);
            command.Parameters.Add(pass);
            SqlParameter role = new SqlParameter("@role", userType);
            command.Parameters.Add(role);
            int rows_affected = command.ExecuteNonQuery();
            conn.Close();
            return rows_affected;
        }

        public DataSet showAll()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DGAB2KA;Initial Catalog=Bank;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand("select * from Customer", conn);
            SqlDataAdapter reader = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            reader.Fill(ds);
            conn.Close();
            return ds;
        }

        public int updateUserId(string newUserID, string oldUserID)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DGAB2KA;Initial Catalog=Bank;Integrated Security=True");
            conn.Open();
            string procedure_name = "updateUserID";
            SqlCommand command = new SqlCommand(procedure_name, conn);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter newId = new SqlParameter("@newuserId", newUserID);
            command.Parameters.Add(newId);
            SqlParameter oldId = new SqlParameter("@olduserId", oldUserID);
            command.Parameters.Add(oldId);
            int rows_affected = command.ExecuteNonQuery();
            return rows_affected;
        }
    }
}
