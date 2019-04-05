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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
        [OperationContract]
        int addCustomer(Customer customer);

        [OperationContract]
        DataSet getSpecificCustomer(int custId);

        [OperationContract]
        int deleteCustomer(int custId);

        [OperationContract]
        int updateCustomer(Customer customer);

        [OperationContract]
        int addLogin(string userId, string password, string userType);

        [OperationContract]
        DataSet showAll();

        [OperationContract]
        int updateUserId(string newUserID, string oldUserID);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Customer
    {
        int customerID;
        string customerName;
        char gender;
        string dob;
        string address;
        string state;
        string city;
        string pincode;
        string phoneNo;
        string email;
        string createdDate;
        string editedDate;
        string userID;

        [DataMember]
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        [DataMember]
        public string CustomerName {
            get { return customerName; }
            set { customerName = value; }
        }

        [DataMember]
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DataMember]
        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [DataMember]
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        [DataMember]
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        [DataMember]
        public string Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }

        [DataMember]
        public string PhoneNo
        {
            get { return phoneNo; }
            set { phoneNo = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public string CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        [DataMember]
        public string EditedDate
        {
            get { return editedDate; }
            set { editedDate = value; }
        }

        [DataMember]
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
    }
}