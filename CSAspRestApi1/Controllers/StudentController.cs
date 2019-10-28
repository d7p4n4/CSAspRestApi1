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
        private User[] users = new User[]
        {
            new User { id = 1, name = "Haleemah Redfern", email = "email1@mail.com", phone = "01111111", role = 1},
            new User { id = 2, name = "Aya Bostock", email = "email2@mail.com", phone = "01111111", role = 1},
            new User { id = 3, name = "Sohail Perez", email = "email3@mail.com", phone = "01111111", role = 1},
            new User { id = 4, name = "Merryn Peck", email = "email4@mail.com", phone = "01111111", role = 2},
            new User { id = 5, name = "Cairon Reynolds", email = "email5@mail.com", phone = "01111111", role = 3}
        };

        /*public IEnumerable<StudentDataAccess.Student> Get()
        {
            using (StudentDbEntities _entities = new StudentDbEntities())
            {
                return _entities.Students.ToList();
            }
        }*/

        public ResponseModel Get(int id)
        {
            ResponseModel _objResponseModel = new ResponseModel();

            _objResponseModel.Data = StEntityMethods.findFirstById(id);
            _objResponseModel.Status = true;
            _objResponseModel.Message = "Data Received successfully";
            
            return _objResponseModel;
        }
    }
}
