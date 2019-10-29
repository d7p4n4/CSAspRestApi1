using CSAspRestApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentDataAccess;

namespace CSAspRestApi1.Controllers
{
    public class StudentController : ApiController
    {

        public ResponseModel GetById(int id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = StEntityMethods.findFirstById(id);
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }

        public ResponseModel GetByName(string id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = StEntityMethods.findFirstByName(id);
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }

        public ResponseModel GetListByAge(int id)
        {
            ResponseModel _objResponseModel = new ResponseModel();
            List<Students> _studentList = StEntityMethods.findListByAge(id);

            _objResponseModel.Data = _studentList;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;

        }

        public void Post(Students student)
        {
            StEntityMethods.addNewStudent(student);
        }

        public void Delete(int id)
        {
            StEntityMethods.deleteById(id);
        }
    }
}
