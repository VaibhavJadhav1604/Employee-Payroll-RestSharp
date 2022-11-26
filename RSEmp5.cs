using RestSharp;
using System;

namespace RSEmp5
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
    }
    public class Operation
    {
        RestClient restClient = new RestClient("http://localhost:4000");
        
        public void DeleteEmployee()
        {
            RestRequest rq = new RestRequest("/employee/109", Method.DELETE);
            restClient.Delete(rq);
        }
    }
    public class RSEmp5
    {
        static void Main(string[] args)
        {
            Operation obj= new Operation();
            obj.DeleteEmployee();
        }
    }
}
