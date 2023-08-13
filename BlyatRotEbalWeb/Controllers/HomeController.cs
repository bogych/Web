using BlyatRotEbalWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Diagnostics;
using System.Xml.Linq;


namespace BlyatRotEbalWeb.Controllers
{
    public class HomeController : Controller
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=989442ty123ty456yt;database=ocjetpes2");
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Camera()
        {
            return View();
        }
        public IActionResult CameraVivod()
        {
            List<Camera> Names = new List<Camera>();
            MySqlCommand command = new MySqlCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "SELECT * FROM Camera";
            var reader = command.ExecuteReader();

            for (int i = 0; reader.Read(); i++)
            {
                Names.Add(new Camera
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    ModelCode = reader["ModelCode"].ToString(),
                    Sostav = reader["Sostav"].ToString(),
                    Mesto = reader["Mesto"].ToString(),
                    Sost = reader["Sost"].ToString(),
                });
            }
            con.Close();

            return View(Names);
        }
        public IActionResult Complect()
        {
            return View();
        }
        public IActionResult ComplectVivod()
        {
            List<Complect> Names = new List<Complect>();
            MySqlCommand command = new MySqlCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "SELECT * FROM Complect";
            var reader = command.ExecuteReader();

            for (int i = 0; reader.Read(); i++)
            {
                Names.Add(new Complect
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    ModelCode = reader["ModelCode"].ToString(),
                    Sostav = reader["Sostav"].ToString(),
                    Mesto = reader["Mesto"].ToString(),
                    Sost = reader["Sost"].ToString(),
                });
            }
            con.Close();

            return View(Names);
        }
        public IActionResult Ekrani()
        {
            return View();
        }
        public IActionResult EkraniVivod()
        {
            List<Teleki_Monitori> Names = new List<Teleki_Monitori>();
            MySqlCommand command = new MySqlCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "SELECT * FROM ekrani";
            var reader = command.ExecuteReader();

            for (int i = 0; reader.Read(); i++)
            {
                Names.Add(new Teleki_Monitori
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    ModelCode = reader["ModelCode"].ToString(),
                    Sostav = reader["Sostav"].ToString(),
                    Mesto = reader["Mesto"].ToString(),
                    Sost = reader["Sost"].ToString(),
                });
            }
            con.Close();

            return View(Names);
        }
        public IActionResult PC()
        {
            return View();
        }
        public IActionResult PCVivod()
        {
            List<PC> Names = new List<PC>();
            MySqlCommand command = new MySqlCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "SELECT * FROM pc";
            var reader = command.ExecuteReader();

            for (int i = 0; reader.Read(); i++)
            {
                Names.Add(new PC
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    ModelCode = reader["ModelCode"].ToString(),
                    Sostav = reader["Sostav"].ToString(),
                    Mesto = reader["Mesto"].ToString(),
                    Sost = reader["Sost"].ToString(),
                });
            }
            con.Close();

            return View(Names);
        }
        public IActionResult Perefiria()
        {
            return View();
        }
        public IActionResult PerefiriaVivod()
        {
            List<Perefiria> Names = new List<Perefiria>();
            MySqlCommand command = new MySqlCommand();
            con.Open();
            command.Connection = con;
            command.CommandText = "SELECT * FROM perefiria";
            var reader = command.ExecuteReader();

            for (int i = 0; reader.Read(); i++)
            {
                Names.Add(new Perefiria
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    ModelCode = reader["ModelCode"].ToString(),
                    Sostav = reader["Sostav"].ToString(),
                    Mesto = reader["Mesto"].ToString(),
                    Sost = reader["Sost"].ToString(),
                });
            }
            con.Close();

            return View(Names);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Check(Camera user)
        {
            MySqlConnection connect = new MySqlConnection("server=localhost;user=root;password=989442ty123ty456yt;database=ocjetpes2");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = $"INSERT INTO camera (Id,Name,ModelCode,Sostav,Mesto,Sost) VALUES ({user.Id},'{user.Name}','{user.ModelCode}','{user.Sostav}','{user.Mesto}','{user.Sost}')";
            //command.CommandText = $"INSERT INTO camera (Name) VALUES ({user.Name})";
            //command.CommandText = $"INSERT INTO camera (ModelCode) VALUES ({user.ModelCode})";
            //command.CommandText = $"INSERT INTO camera (Sostav) VALUES ({user.Sostav})";
            //command.CommandText = $"INSERT INTO camera (Mesto) VALUES ({user.Mesto})";
            //command.CommandText = $"INSERT INTO camera (Sost) VALUES ({user.Sost})";
            command.ExecuteNonQuery();
            connect.Close();
            return Redirect("/Home/Camera");
        }
        public IActionResult Check1(Complect user)
        {
            MySqlConnection connect = new MySqlConnection("server=localhost;user=root;password=989442ty123ty456yt;database=ocjetpes2");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = $"INSERT INTO complect (Id,Name,ModelCode,Sostav,Mesto,Sost) VALUES ({user.Id},'{user.Name}','{user.ModelCode}','{user.Sostav}','{user.Mesto}','{user.Sost}')";
            //command.CommandText = $"INSERT INTO camera (Name) VALUES ({user.Name})";
            //command.CommandText = $"INSERT INTO camera (ModelCode) VALUES ({user.ModelCode})";
            //command.CommandText = $"INSERT INTO camera (Sostav) VALUES ({user.Sostav})";
            //command.CommandText = $"INSERT INTO camera (Mesto) VALUES ({user.Mesto})";
            //command.CommandText = $"INSERT INTO camera (Sost) VALUES ({user.Sost})";
            command.ExecuteNonQuery();
            connect.Close();
            return Redirect("/Home/Complect");
        }
        public IActionResult Check2(Teleki_Monitori user)
        {
            MySqlConnection connect = new MySqlConnection("server=localhost;user=root;password=989442ty123ty456yt;database=ocjetpes2");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = $"INSERT INTO ekrani (Id,Name,ModelCode,Sostav,Mesto,Sost) VALUES ({user.Id},'{user.Name}','{user.ModelCode}','{user.Sostav}','{user.Mesto}','{user.Sost}')";
            //command.CommandText = $"INSERT INTO camera (Name) VALUES ({user.Name})";
            //command.CommandText = $"INSERT INTO camera (ModelCode) VALUES ({user.ModelCode})";
            //command.CommandText = $"INSERT INTO camera (Sostav) VALUES ({user.Sostav})";
            //command.CommandText = $"INSERT INTO camera (Mesto) VALUES ({user.Mesto})";
            //command.CommandText = $"INSERT INTO camera (Sost) VALUES ({user.Sost})";
            command.ExecuteNonQuery();
            connect.Close();
            return Redirect("/Home/Ekrani");
        }
        public IActionResult Check3(PC user)
        {
            MySqlConnection connect = new MySqlConnection("server=localhost;user=root;password=989442ty123ty456yt;database=ocjetpes2");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = $"INSERT INTO pc (Id,Name,ModelCode,Sostav,Mesto,Sost) VALUES ({user.Id},'{user.Name}','{user.ModelCode}','{user.Sostav}','{user.Mesto}','{user.Sost}')";
            //command.CommandText = $"INSERT INTO camera (Name) VALUES ({user.Name})";
            //command.CommandText = $"INSERT INTO camera (ModelCode) VALUES ({user.ModelCode})";
            //command.CommandText = $"INSERT INTO camera (Sostav) VALUES ({user.Sostav})";
            //command.CommandText = $"INSERT INTO camera (Mesto) VALUES ({user.Mesto})";
            //command.CommandText = $"INSERT INTO camera (Sost) VALUES ({user.Sost})";
            command.ExecuteNonQuery();
            connect.Close();
            return Redirect("/Home/PC");
        }
        public IActionResult Check4(Perefiria user)
        {
            MySqlConnection connect = new MySqlConnection("server=localhost;user=root;password=989442ty123ty456yt;database=ocjetpes2");
            connect.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = $"INSERT INTO perefiria (Id,Name,ModelCode,Sostav,Mesto,Sost) VALUES ({user.Id},'{user.Name}','{user.ModelCode}','{user.Sostav}','{user.Mesto}','{user.Sost}')";
            //command.CommandText = $"INSERT INTO camera (Name) VALUES ({user.Name})";
            //command.CommandText = $"INSERT INTO camera (ModelCode) VALUES ({user.ModelCode})";
            //command.CommandText = $"INSERT INTO camera (Sostav) VALUES ({user.Sostav})";
            //command.CommandText = $"INSERT INTO camera (Mesto) VALUES ({user.Mesto})";
            //command.CommandText = $"INSERT INTO camera (Sost) VALUES ({user.Sost})";
            command.ExecuteNonQuery();
            connect.Close();
            return Redirect("/Home/Perefiria");
        }
        public IActionResult DeleteCamera(int IdForDelete) 
        {
            con.Open();
            MySqlCommand command=new MySqlCommand();
            command.Connection=con;
            command.CommandText = $"DELETE FROM camera WHERE Id='{IdForDelete}'";
            var reader = command.ExecuteReader();
            con.Close();
            IdForDelete = 0;
            return Redirect("/Home/CameraVivod");
        }
        public IActionResult DeletePC(int IdForDelete)
        {
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            command.CommandText = $"DELETE FROM pc WHERE Id='{IdForDelete}'";
            var reader = command.ExecuteReader();
            con.Close();
            IdForDelete = 0;
            return Redirect("/Home/PCVivod");
        }
        public IActionResult DeleteComplect(int IdForDelete)
        {
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            command.CommandText = $"DELETE FROM complect WHERE Id='{IdForDelete}'";
            var reader = command.ExecuteReader();
            con.Close();
            IdForDelete = 0;
            return Redirect("/Home/ComplectVivod");
        }
        public IActionResult DeleteEkrani(int IdForDelete)
        {
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            command.CommandText = $"DELETE FROM ekrani WHERE Id='{IdForDelete}'";
            var reader = command.ExecuteReader();
            con.Close();
            IdForDelete = 0;
            return Redirect("/Home/EkraniVivod");
        }
        public IActionResult DeletePerefiria(int IdForDelete)
        {
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            command.CommandText = $"DELETE FROM perefiria WHERE Id='{IdForDelete}'";
            var reader = command.ExecuteReader();
            con.Close();
            IdForDelete = 0;
            return Redirect("/Home/PerefiriaVivod");
        }
    }
}