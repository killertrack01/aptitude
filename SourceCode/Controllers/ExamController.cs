using Aptitude.Data;
using Aptitude.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Identity;

namespace Aptitude.Controllers
{
    
    public class ExamController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public ExamController(ApplicationDbContext context, SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> UserManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = UserManager;
        }
        public IActionResult CheckProfile()
        {
            HttpContext.Session.Clear();
            _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult Index()
        {
            var modelUser = _context.CV.SingleOrDefault(m => m.Email.Equals(User.Identity.Name));
            ViewBag.model = modelUser;
            var countGeneral = _context.Question.Where(l => l.DepartmentId == 1).ToList().Count;
            var countMath = _context.Question.Where(l => l.DepartmentId == 2).ToList().Count;
            var countComputer = _context.Question.Where(l => l.DepartmentId == 3).ToList().Count;
            if (countGeneral != 5 || countMath != 5 || countComputer != 5)
            {
                ViewBag.error = 1;
            }

            var isUser = User.IsInRole("Admin");
            if (isUser)
                ViewBag.Admin = "admin";
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("exam")))
                HttpContext.Session.SetString("exam", "1");

            var checkTest = _context.Exam.SingleOrDefault(c=>c.Id.Equals(modelUser.ExamId));
            var checkTest1 = _context.Exam.SingleOrDefault(c => c.Id.Equals(modelUser.ExamId+1));
            var checkTest2 = _context.Exam.SingleOrDefault(c => c.Id.Equals(modelUser.ExamId+2));// phai cho logout truoc roi moi login lai
            if (checkTest.Answer == "f" || checkTest1.Answer == "f" || checkTest2.Answer == "f")
            {
                ViewBag.checkTest = 0;
            }
            else 
            {
                ViewBag.checkTest = 1;
            }
            return View();
        }
        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult GeneralExam()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("exam")))
            {
                return RedirectToAction("Homepage", "Home");
            }
            var ModelCV = _context.CV.SingleOrDefault(c => c.Email.Equals(User.Identity.Name));
            if (!HttpContext.Session.GetString("exam").Equals("1") || ModelCV.Status != 0)
            {
                return RedirectToAction("Index");
            }
            var listquestion = _context.Question.Where(q => q.Category == 1).Take(5);
            ViewBag.Result = "open";
            ViewBag.checking = 1;

            HttpContext.Session.SetString("exam", "2");
            return View(listquestion);
        }
        [HttpPost]
        public IActionResult GeneralExam(IFormCollection form, string submit)
        {
            string aswn1 = "";
            if (string.IsNullOrEmpty(form["answer1"]))
                aswn1 = "t+1";
            else
                aswn1 = form["answer1"];
            string aswn2 = "";
            if (string.IsNullOrEmpty(form["answer2"]))
                aswn2 = "t+1";
            else
                aswn2 = form["answer2"];
            string aswn3 = "";
            if (string.IsNullOrEmpty(form["answer3"]))
                aswn3 = "t+1";
            else
                aswn3 = form["answer3"];
            string aswn4 = "";
            if (string.IsNullOrEmpty(form["answer4"]))
                aswn4 = "t+1";
            else
                aswn4 = form["answer4"];
            string aswn5 = "";
            if (string.IsNullOrEmpty(form["answer5"]))
                aswn5 = "t+1";
            else
                aswn5 = form["answer5"];
            string FinalAnswer = aswn1 + "//" + aswn2 + "//" + aswn3 + "//" + aswn4 + "//" + aswn5;
            string[] array1 = aswn1.Split('+');
            string[] array2 = aswn2.Split('+');
            string[] array3 = aswn3.Split('+');
            string[] array4 = aswn4.Split('+');
            string[] array5 = aswn5.Split('+');

            var listquestion = _context.Question.ToList();

            //check answer
            int Point = 0;
            if (!String.IsNullOrEmpty(aswn1))
            {
                var question1 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array1[1])));
                if(question1 == null)
                {
                    Point += 0;
                }
                else if (question1.FinalAnswer.Equals(array1[0]))
                {
                    Point += question1.Level;
                }
            }

            if (!String.IsNullOrEmpty(aswn2))
            {
                var question2 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array2[1])));
                if (question2 == null)
                {
                    Point += 0;
                }
                else if (question2.FinalAnswer.Equals(array2[0]))
                {
                    Point += question2.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn3))
            {
                var question3 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array3[1])));
                if (question3 == null)
                {
                    Point += 0;
                }
                else if (question3.FinalAnswer.Equals(array3[0]))
                {
                    Point += question3.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn4))
            {
                var question4 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array4[1])));

                if (question4 == null)
                {
                    Point += 0;
                }
                else if (question4.FinalAnswer.Equals(array4[0]))
                {
                    Point += question4.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn5))
            {
                var question5 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array5[1])));

                if (question5 == null)
                {
                    Point += 0;
                }
                else if (question5.FinalAnswer.Equals(array5[0]))
                {
                    Point += question5.Level;
                }
            }

            //save record
            var modelCV = _context.CV.SingleOrDefault(c => c.Email.Equals(User.Identity.Name));
            var general = _context.Exam.Find(modelCV.ExamId);
            general.Mark = Point;
            if (Point <= 50)
                general.Result = "Failed";
            else
                general.Result = "Passed";
            general.Date = DateTime.Now;
            general.Answer = FinalAnswer;

            _context.Exam.Update(general);
            _context.SaveChanges();
            //end save record
            ViewBag.Point = Point;
            ViewBag.Result = "done";
            ViewBag.checking = 2;
            HttpContext.Session.SetString("GeneralPoints", Point.ToString());
            return View(listquestion);
        }
        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult MathExam()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("exam")))
            {
                return View("Homepage", "Home");
            }
            if (!HttpContext.Session.GetString("exam").Equals("2"))
            {
                return View("Index");
            }

            var listquestion = _context.Question.Where(q => q.Category == 2).Take(5);
            ViewBag.Result = "open";
            ViewBag.checking = 1;

            HttpContext.Session.SetString("exam", "3");

            return View(listquestion);
        }
        [HttpPost]
        public IActionResult MathExam(IFormCollection form, string submit)
        {
            string aswn1 = "";
            if (string.IsNullOrEmpty(form["answer1"]))
                aswn1 = "t+1";
            else
                aswn1 = form["answer1"];
            string aswn2 = "";
            if (string.IsNullOrEmpty(form["answer2"]))
                aswn2 = "t+1";
            else
                aswn2 = form["answer2"];
            string aswn3 = "";
            if (string.IsNullOrEmpty(form["answer3"]))
                aswn3 = "t+1";
            else
                aswn3 = form["answer3"];
            string aswn4 = "";
            if (string.IsNullOrEmpty(form["answer4"]))
                aswn4 = "t+1";
            else
                aswn4 = form["answer4"];
            string aswn5 = "";
            if (string.IsNullOrEmpty(form["answer5"]))
                aswn5 = "t+1";
            else
                aswn5 = form["answer5"];
            string FinalAnswer = aswn1 + "//" + aswn2 + "//" + aswn3 + "//" + aswn4 + "//" + aswn5;
            string[] array1 = aswn1.Split('+');
            string[] array2 = aswn2.Split('+');
            string[] array3 = aswn3.Split('+');
            string[] array4 = aswn4.Split('+');
            string[] array5 = aswn5.Split('+');

            var listquestion = _context.Question.ToList();

            //check answer
            int Point = 0;
            if (!String.IsNullOrEmpty(aswn1))
            {
                var question1 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array1[1])));

                if (question1 == null)
                {
                    Point += 0;
                }
                else if (question1.FinalAnswer.Equals(array1[0]))
                {
                    Point += question1.Level;
                }
            }

            if (!String.IsNullOrEmpty(aswn2))
            {
                var question2 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array2[1])));

                if (question2 == null)
                {
                    Point += 0;
                }
                else if (question2.FinalAnswer.Equals(array2[0]))
                {
                    Point += question2.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn3))
            {
                var question3 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array3[1])));

                if (question3 == null)
                {
                    Point += 0;
                }
                else if (question3.FinalAnswer.Equals(array3[0]))
                {
                    Point += question3.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn4))
            {
                var question4 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array4[1])));

                if (question4 == null)
                {
                    Point += 0;
                }
                else if (question4.FinalAnswer.Equals(array4[0]))
                {
                    Point += question4.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn5))
            {
                var question5 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array5[1])));

                if (question5 == null)
                {
                    Point += 0;
                }
                else if (question5.FinalAnswer.Equals(array5[0]))
                {
                    Point += question5.Level;
                }
            }

            //save record
            var modelCV = _context.CV.SingleOrDefault(c => c.Email.Equals(User.Identity.Name));
            var examID = modelCV.ExamId + 1;
            var general = _context.Exam.Find(examID);
            general.Mark = Point;
            if (Point <= 50)
                general.Result = "Failed";
            else
                general.Result = "Passed";
            general.Date = DateTime.Now;
            general.Answer = FinalAnswer;

            _context.Exam.Update(general);
            _context.SaveChanges();
            //end save record

            ViewBag.Point = Point;
            ViewBag.Result = "done";
            ViewBag.checking = 2;
            HttpContext.Session.SetString("MathPoints", Point.ToString());
            return View(listquestion);
        }
        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult ComputerExam()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("exam")))
            {
                return View("Homepage", "Home");
            }
            if (!HttpContext.Session.GetString("exam").Equals("3"))
            {
                return View("Index");
            }

            var listquestion = _context.Question.Where(q => q.Category == 3).Take(5);
            ViewBag.Result = "open";
            ViewBag.checking = 1;

            HttpContext.Session.SetString("exam", "4");
            return View(listquestion);
        }
        [HttpPost]
        public IActionResult ComputerExam(IFormCollection form, string submit)
        {
            string aswn1 = "";
            if (string.IsNullOrEmpty(form["answer1"]))
                aswn1 = "t+1";
            else
                aswn1 = form["answer1"];
            string aswn2 = "";
            if (string.IsNullOrEmpty(form["answer2"]))
                aswn2 = "t+1";
            else
                aswn2 = form["answer2"];
            string aswn3 = "";
            if (string.IsNullOrEmpty(form["answer3"]))
                aswn3 = "t+1";
            else
                aswn3 = form["answer3"];
            string aswn4 = "";
            if (string.IsNullOrEmpty(form["answer4"]))
                aswn4 = "t+1";
            else
                aswn4 = form["answer4"];
            string aswn5 = "";
            if (string.IsNullOrEmpty(form["answer5"]))
                aswn5 = "t+1";
            else
                aswn5 = form["answer5"];
            
            string FinalAnswer = aswn1 + "//" + aswn2 + "//" + aswn3 + "//" + aswn4 + "//" + aswn5;
            string[] array1 = aswn1.Split('+');
            string[] array2 = aswn2.Split('+');
            string[] array3 = aswn3.Split('+');
            string[] array4 = aswn4.Split('+');
            string[] array5 = aswn5.Split('+');

            var listquestion = _context.Question.ToList();

            //check answer
            int Point = 0;
            if (!string.IsNullOrEmpty(aswn1))
            {
                var question1 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array1[1])));

                if (question1 == null)
                {
                    Point += 0;
                }
                else if (question1.FinalAnswer.Equals(array1[0]))
                {
                    Point += question1.Level;
                }
            }

            if (!string.IsNullOrEmpty(aswn2))
            {
                var question2 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array2[1])));

                if (question2 == null)
                {
                    Point += 0;
                }
                else if (question2.FinalAnswer.Equals(array2[0]))
                {
                    Point += question2.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn3))
            {
                var question3 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array3[1])));

                if (question3 == null)
                {
                    Point += 0;
                }
                else if (question3.FinalAnswer.Equals(array3[0]))
                {
                    Point += question3.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn4))
            {
                var question4 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array4[1])));

                if (question4 == null)
                {
                    Point += 0;
                }
                else if (question4.FinalAnswer.Equals(array4[0]))
                {
                    Point += question4.Level;
                }
            }


            if (!String.IsNullOrEmpty(aswn5))
            {
                var question5 = listquestion.SingleOrDefault(l => l.Id.Equals(int.Parse(array5[1])));

                if (question5 == null)
                {
                    Point += 0;
                }
                else if (question5.FinalAnswer.Equals(array5[0]))
                {
                    Point += question5.Level;
                }
            }

            //save record
            var modelCV = _context.CV.SingleOrDefault(c => c.Email.Equals(User.Identity.Name));
            var examID = modelCV.ExamId + 2;
            var general = _context.Exam.Find(examID);
            general.Mark = Point;
            if (Point <= 50)
                general.Result = "Failed";
            else
                general.Result = "Passed";
            general.Date = DateTime.Now;
            general.Answer = FinalAnswer;

            _context.Exam.Update(general);
            _context.SaveChanges();
            //end save record


            ViewBag.Point = Point;
            ViewBag.Result = "done";
            ViewBag.checking = 2;

            HttpContext.Session.SetString("ComputerPoints", Point.ToString());
            return View(listquestion);
        }
        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult ResultExam()
        {
            var ModelCV = _context.CV.SingleOrDefault(c => c.Email.Equals(User.Identity.Name));
            double generalPoint = 0;
            double mathPoint = 0;
            double computerPoint = 0;
            //get general points
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("GeneralPoints")))
            {
                generalPoint = _context.Exam.SingleOrDefault(e => e.Id.Equals(ModelCV.ExamId)).Mark;
            }
            else
            {
                generalPoint = double.Parse(HttpContext.Session.GetString("GeneralPoints"));
            }
            //get math points
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("GeneralPoints")))
            {
                mathPoint = _context.Exam.SingleOrDefault(e => e.Id.Equals(ModelCV.ExamId+1)).Mark;
            }
            else
            {
                mathPoint = double.Parse(HttpContext.Session.GetString("MathPoints"));
            }
            //get computer points
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("ComputerPoints")))
            {
                computerPoint = _context.Exam.SingleOrDefault(e => e.Id.Equals(ModelCV.ExamId+2)).Mark;
            }
            else
            {
                computerPoint = double.Parse(HttpContext.Session.GetString("ComputerPoints"));
            }

            ViewBag.general = generalPoint;
            ViewBag.math = mathPoint;
            ViewBag.computer = computerPoint;
            if(ModelCV.Status == 0)
            {
                ModelCV.Status = 1;
                _context.SaveChanges();
            }
            if (generalPoint <= 50 || mathPoint <= 50 || computerPoint <= 50)
            {
                ViewBag.resultPoint = "Failed";
                ModelCV.Status = 1;
                _context.SaveChanges();
            }
            else
            {
                ViewBag.resultPoint = "Passed";
                ModelCV.Status = 2;
                _context.SaveChanges();
            }
            return View();
        }

        [Authorize(Roles = "Admin")]
        //SelectGeneral
        [HttpGet]
        public IActionResult Select()
        {   
            var listDepartment = _context.Department.ToList();

            ViewBag.Question = _context.Question.Where(q => q.Status.Equals(1));

            return View(listDepartment);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult SelectGeneral(int id)
        {
            var depart = _context.Department.SingleOrDefault(d => d.Id == id);
            ViewBag.nameDepart = depart.Name;
            var listQuestion = _context.Question.Where(q => q.Status == 1 && q.Category == 1 && q.DepartmentId == id).ToList();
            var point = 0;
            foreach (var item in listQuestion)
            {
                point += item.Level;
            }
            ViewBag.points = point;
            ViewBag.count = listQuestion.Count;
            var model = _context.Question.Where(q => q.Category == 1 && q.DepartmentId == id).OrderByDescending(q => q.Status).ToList();
            ViewBag.Depart = _context.Department.ToList();
            ViewBag.Default = 0;
            ViewBag.Uri = HttpContext.Request.Path;
            return View(model);

        }
        //SelectMath
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult SelectMath(int id)
        {
            var depart = _context.Department.SingleOrDefault(d => d.Id == id);
            ViewBag.nameDepart = depart.Name;
            var listQuestion = _context.Question.Where(q => q.Status == 1 && q.Category == 2 && q.DepartmentId == id).ToList();
            var point = 0;
            foreach (var item in listQuestion)
            {
                point += item.Level;
            }
            ViewBag.points = point;
            ViewBag.count = listQuestion.Count;
            var model = _context.Question.Where(q => q.Category == 2 && q.DepartmentId == id).OrderByDescending(q => q.Status).ToList();
            ViewBag.Depart = _context.Department.ToList();
            ViewBag.Default = 0;
            return View(model);

        }
        //SelectComputer
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult SelectComputer(int id)
        {
            var depart = _context.Department.SingleOrDefault(d => d.Id == id);
            ViewBag.nameDepart = depart.Name;
            var listQuestion = _context.Question.Where(q => q.Status == 1 && q.Category == 3 && q.DepartmentId == id).ToList();
            var point = 0;
            foreach (var item in listQuestion)
            {
                point += item.Level;
            }
            ViewBag.points = point;
            ViewBag.count = listQuestion.Count;
            var model = _context.Question.Where(q => q.Category == 3 && q.DepartmentId == id).OrderByDescending(q => q.Status).ToList();
            ViewBag.Depart = _context.Department.ToList();
            ViewBag.Default = 0;
            return View(model);

        }

        //All Test
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AllCV()
        {
            var listCV = _context.CV.Where(c=>c.Status > 0).ToList();
            ViewBag.Exam = _context.Exam.ToList();
            ViewBag.Depart = _context.Department.ToList();
            return View(listCV);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult HR()
        {
            var listCV = _context.HR.ToList();
            ViewBag.Depart = _context.Department.ToList();
            ViewBag.Exam = _context.Exam.ToList();
            return View(listCV);
        }

        // ajax enable
        [HttpPost]
        public JsonResult Change(int sms, int result, int cate, int depart)
        {
            var listQuestion = _context.Question.Where(q => q.Status == 1 && q.Category == cate && q.DepartmentId == depart).ToList();
            var check = 0;
            if (listQuestion.Count >= 5)
                check = 1;
            var point = 0;
            foreach (var item in listQuestion)
            {
                point += item.Level;
            }
            var question = _context.Question.Find(result);
            //ViewBag.points = point;
            if (point < 100)
            {
                if (sms == 0)
                {
                    var pointcheck = point + question.Level;
                    if (pointcheck > 100)
                        check = 2;
                }
                else if (sms == 1 && listQuestion.Count < 5)
                {
                    check = 0;
                }
            }
            if (point > 100)
                check = 2;
            if (listQuestion.Count >= 5 && sms == 1)
                check = 0;
            if (check == 0)
            {
                if (sms == 0)
                {
                    question.Status = 1;
                    point += question.Level;
                    _context.SaveChanges();
                }
                else
                {
                    question.Status = 0;
                    point -= question.Level;
                    _context.SaveChanges();
                }

            }

            var lastList = _context.Question.Where(q => q.Status == 1 && q.Category == cate && q.DepartmentId == depart).ToList();
            //var listQuestion1 = context.Question.Where(q => q.Status == 1).ToList();

            //var point1 = 0;
            //foreach (var item in listQuestion)
            //{
            //    point1 += item.Level;
            //}

            //var p = point1.ToString();
            return Json(new { foo = result, baz = question.Status, result = check, points = point, count = lastList.Count });
        }
        [HttpPost]
        public JsonResult Tranfer(int id)
        {
            var c = _context.CV.SingleOrDefault(c => c.ID == id);
            var h = new HR();
            h.FirstName = c.FirstName;
            h.LastName = c.LastName;
            h.Email = c.Email;
            h.University = c.University;
            h.Mark = c.Mark;
            h.PersonalDetail = c.PersonalDetail;
            h.Advantage = c.Advantage;
            h.Disadvantage = c.Disadvantage;
            h.Hobby = c.Hobby;
            h.Language = c.Language;
            h.Experience = c.Experience;
            h.Project = c.Project;
            h.LastPostion = c.LastPostion;
            h.Status = 3;
            h.DepartmentId = c.DepartmentId;
            h.ExamId = c.ExamId;
            _context.HR.Add(h);
            c.Status = 3;
            _context.SaveChanges();
            return Json(new { result = "ok" });
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            _signInManager.SignOutAsync();
            return RedirectToAction("Homepage", "Home");
        }
    }
}
