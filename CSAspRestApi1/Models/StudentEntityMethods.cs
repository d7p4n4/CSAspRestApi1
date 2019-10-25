using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSAspRestApi1.Models
{

    public class StudentEntityMethods
    {
        public static Student findFirstById(Int32 id)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                try
                {
                    var query = ctx.Students
                                    .Where(ss => ss.id == id)
                                    .FirstOrDefault<Student>();

                    s = query;
                } catch (Exception _exception)
                {
                    Console.WriteLine(_exception.StackTrace);
                }
            }
            return s;
        }
        public static Student findFirstByGUID(String GUID)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.GUID == GUID)
                                .FirstOrDefault<Student>();

                s = query;
            }
            return s;
        }
        public static Student findFirstByAge(Int32 age)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.age == age)
                                .FirstOrDefault<Student>();

                s = query;
            }
            return s;
        }
        public static Student findFirstByName(String name)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.name == name)
                                .FirstOrDefault<Student>();

                s = query;
            }
            return s;
        }
        public static Student findFirstByAddress(String address)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.address == address)
                                .FirstOrDefault<Student>();

                s = query;
            }
            return s;
        }

        public static IQueryable<Student> findListById(Int32 id)
        {
            IQueryable<Student> s;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.id == id);

                s = query;
            }
            return s;
        }
        public static IQueryable<Student> findListByGUID(String GUID)
        {
            IQueryable<Student> s;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.GUID == GUID);

                s = query;
            }
            return s;
        }
        public static IQueryable<Student> findListByAge(Int32 age)
        {
            IQueryable<Student> s;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.age == age);

                s = query;
            }
            return s;
        }
        public static IQueryable<Student> findListByName(String name)
        {
            IQueryable<Student> s;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.name == name);

                s = query;
            }
            return s;
        }
        public static IQueryable<Student> findListByAddress(String address)
        {
            IQueryable<Student> s;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.address == address);

                s = query;
            }
            return s;
        }

        public Boolean existsInStudentById(Int32 id)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.id == id)
                                .FirstOrDefault<Student>();

                s = query;
            }
            if (s != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean existsInStudentByGUID(String GUID)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.GUID == GUID)
                                .FirstOrDefault<Student>();

                s = query;
            }
            if (s != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean existsInStudentByAge(Int32 age)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.age == age)
                                .FirstOrDefault<Student>();

                s = query;
            }
            if (s != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean existsInStudentByName(String name)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.name == name)
                                .FirstOrDefault<Student>();

                s = query;
            }
            if (s != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean existsInStudentByAddress(String address)
        {
            Student s = null;

            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Where(ss => ss.address == address)
                                .FirstOrDefault<Student>();

                s = query;
            }
            if (s != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void deleteById(Int32 id)
        {
            using (var ctx = new StudentContext())
            {
                var query = ctx.Students
                                .Remove(ctx.Students.Single(ss => ss.id == id));

                ctx.SaveChanges();
            }
        }

        public static void addNewStudent(Student s)
        {
            using (var ctx = new StudentContext())
            {
                ctx.Students.Add(s);

                ctx.SaveChanges();
            }
        }
    }
}
