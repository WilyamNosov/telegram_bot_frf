using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

namespace db_add_schedule
{
    public partial class Form1 : Form
    {
        static string conn = "SERVER=localhost;DATABASE=telegram-bot-ftf_2;UID=root;PASSWORD=PWD";
        MySqlConnection connection = new MySqlConnection(conn);
        static Dictionary<string, int> groups = new Dictionary<string, int>();
        static ArrayList activeGroups = new ArrayList();


        public Form1()
        {
            createDict();
            InitializeComponent();
        }
        private void addToShchedule_Click(object sender, EventArgs e)
        {
            //connection.Open();
            string idLection = "";
            String calendar = shcheduleCalendar.SelectionRange.Start.ToString().Substring(6, 4) + "-"
                + shcheduleCalendar.SelectionRange.Start.ToString().Substring(3, 2) + "-"
                + shcheduleCalendar.SelectionRange.Start.ToString().Substring(0, 2);
            String lectionNumber = lectionNum.Text;
            String classroomNumber = classroom.Text;

            String disciplineStr = discipline.Text;
            String[] lecturer = lecturers.Text.Split(' ');

            String idDiscipline = disciplineSearch(disciplineStr);
            String idLecturer = searchLecturer(lecturer[0], lecturer[1], lecturer[2]);
            string com = "INSERT INTO lection (data, classroom_num, lection_num, discipline_id, lecturer_id) VALUES ('" 
                + calendar + "', '" + classroomNumber + "', '" + lectionNumber +"', '" + idDiscipline + "', '" + idLecturer + "');";
            
            MySqlCommand commandInsert = new MySqlCommand(com, connection);
            connection.Open();
            commandInsert.ExecuteNonQuery();
            connection.Close();

            string searchCommand = "SELECT idl FROM `telegram-bot-ftf_2`.lection WHERE lection.data = '" + calendar 
                + "' and lection.classroom_num = '" + classroomNumber + "' and lection.lection_num = '" + lectionNumber +
                "' and lection.discipline_id = '" + idDiscipline + "' and lection.lecturer_id = '" + idLecturer + "';";
            MySqlCommand commandSearch = new MySqlCommand(searchCommand, connection);
            connection.Open();
            MySqlDataReader reader = commandSearch.ExecuteReader();
            reader.Read();
            if (reader.HasRows == true)
            {
                idLection = reader.GetString(0);
            }
            connection.Close();
            

            if (tabControl2.SelectedTab.Name == back1.Name) {
                getCheked(backList1);
            } else if(tabControl2.SelectedTab.Name == back2.Name) {
                getCheked(backList2);
            } else if (tabControl2.SelectedTab.Name == back3.Name) {
                getCheked(backList3);
            } else if (tabControl2.SelectedTab.Name == back4.Name) {
                getCheked(backList4);
            } else {
                getCheked(magisterList);
            }
            for (int i = 0; i < activeGroups.Count; i++)
            {
                Console.WriteLine(activeGroups[i]);
                com = "INSERT INTO shchedule (group_id, lection_id) VALUES ('" + activeGroups[i] + "', '" + idLection + "');";
                commandInsert = new MySqlCommand(com, connection);
                connection.Open();
                commandInsert.ExecuteNonQuery();
                connection.Close();
            }

            //connection.Close();
        }

        private void getCheked(CheckedListBox box)
        {
            for (int i = 0; i < box.Items.Count; i++)
            {
                if (box.GetItemChecked(i) == true)
                {
                    try
                    {
                        activeGroups.Add(groups[box.Items[i].ToString()]);
                    } catch (KeyNotFoundException e)
                    {
                        Console.WriteLine("kek");
                    }
                }
            }
        }

        private String disciplineSearch(String discipline)
        {
            string searchCommand = "SELECT id FROM `telegram-bot-ftf_2`.discipline WHERE discipline.name = \"" + discipline + "\";";
            string insertCommand = "";
            String res = "";
            MySqlCommand commandTrue = new MySqlCommand(searchCommand, connection);
            connection.Open();
            MySqlDataReader reader = commandTrue.ExecuteReader();
            reader.Read();
            if (reader.HasRows == true)
            {
                res = reader.GetString(0);
                connection.Close();
            }
            else
            {
                insertCommand = "INSERT INTO `telegram-bot-ftf_2`.discipline (name, chair_id) VALUES ('" + discipline + "'," + "'1');";
                MySqlCommand commandFalse = new MySqlCommand(insertCommand, connection);
                connection.Close();
                connection.Open();
                commandFalse.ExecuteNonQuery();
                reader = commandTrue.ExecuteReader();
                reader.Read();
                res = reader.GetString(0);
                connection.Close();
            }
            return res;
        }

        private String searchLecturer(String name, String secondname, String surname)
        {
            string searchCommand = "SELECT id FROM `telegram-bot-ftf_2`.lecturer WHERE lecturer.firstname = \"" + name + "\" and lecturer.secondname = \"" + secondname + "\" and lecturer.surname = \"" + surname + "\";";
            MySqlCommand commandTrue = new MySqlCommand(searchCommand, connection);
            String res = "";
            connection.Open();
            MySqlDataReader reader = commandTrue.ExecuteReader();
            reader.Read();
            if (reader.HasRows == true)
            {
                res = reader.GetString(0);
                connection.Close();
            }
            else
            {
                res = "null";
                connection.Close();
            }
            return res;
        }

        private void createDict()
        {
            groups.Add("3КН-А", 1);
            groups.Add("3КН-Б1", 2);
            groups.Add("3КН-Б2", 3);
            groups.Add("3КН-В", 4);
            groups.Add("БІКС", 5);
            groups.Add("МтІВТ", 6);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



