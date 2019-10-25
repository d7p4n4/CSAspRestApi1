using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSAspRestApi1.Models
{
    public class StudentAlgebra : StudentPreProcessed
    {

        public Int32 getId()
        {
            return id;
        }

        public String getGUID()
        {
            return GUID;
        }

        public Int32 getAge()
        {
            return age;
        }

        public String getName()
        {
            return name;
        }

        public String getAddress()
        {
            return address;
        }


        public void setId(Int32 newValue)
        {
            id = newValue;
        }

        public void setGUID(String newValue)
        {
            GUID = newValue;
        }

        public void setAge(Int32 newValue)
        {
            age = newValue;
        }

        public void setName(String newValue)
        {
            name = newValue;
        }

        public void setAddress(String newValue)
        {
            address = newValue;
        }

        public Boolean hasId()
        {
            if (this.getId() != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean hasGUID()
        {
            if (this.getGUID() != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean hasAge()
        {
            if (this.getAge() != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean hasName()
        {
            if (this.getName() != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean hasAddress()
        {
            if (this.getAddress() != null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
