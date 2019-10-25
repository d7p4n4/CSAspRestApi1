using CSAspRestApi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CSAspRestApi1.Controllers
{
    public class StudentController : ApiController
    {
        private User[] users = new User[]
        {
            new User { id = 1, name = "Haleemah Redfern", email = "email1@mail.com", phone = "01111111", role = 1},
            new User { id = 2, name = "Aya Bostock", email = "email2@mail.com", phone = "01111111", role = 1},
            new User { id = 3, name = "Sohail Perez", email = "email3@mail.com", phone = "01111111", role = 1},
            new User { id = 4, name = "Merryn Peck", email = "email4@mail.com", phone = "01111111", role = 2},
            new User { id = 5, name = "Cairon Reynolds", email = "email5@mail.com", phone = "01111111", role = 3}
        };

        public ResponseModel Get()
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = users;
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";

            return _objResponseModel;
        }

        public ResponseModel Get(int id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            StudentPreProcessed _student = new StudentPreProcessed();
            _student = StudentEntityMethods.findFirstById(id);

                    _objResponseModel.Data = _student;
                    _objResponseModel.Status = true;
                    _objResponseModel.Message = "Data Received successfully";
                
            return _objResponseModel;
        }
    }
}
