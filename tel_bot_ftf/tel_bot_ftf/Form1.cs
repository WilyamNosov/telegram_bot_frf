using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using System.Timers;

using MySql.Data.MySqlClient;

namespace tel_bot_ftf
{

    public partial class Form1 : Form
    {
        private static Telegram.Bot.TelegramBotClient BOT;

        private static string name = "";
        private static string date = "";
        private static string schedule = "";
        private static int scheduleIndex = 0;
        private static long chatID = 0;
        static string conn = "SERVER=localhost;DATABASE=telegram-bot-ftf_2;UID=root;PASSWORD=123456";
        static MySqlConnection connection = new MySqlConnection(conn);
        private static string idLecturer = "";
        static Dictionary<int, string> groups = new Dictionary<int, string>();
        static DateTime thisDay = DateTime.Today;


        static string group = "";
        static string discipline = "";
        static string classroom = "";
        static string lectionNum = "";

        static string lecturerData = "";

        private static System.Timers.Timer timer;

        public Form1()
        {
            BOT = new Telegram.Bot.TelegramBotClient("TOKEN");

            BOT.OnMessage += BotOnMessageReceived;
            BOT.StartReceiving(new UpdateType[] { UpdateType.MessageUpdate });

            SetTimer();
            createDict();
            InitializeComponent();
        }

        private void createDict()
        {
            groups.Add(1, "3КН-А");
            groups.Add(2, "3КН-Б1");
            groups.Add(3, "3КН-Б2");
            groups.Add(4, "3КН-В");
            groups.Add(5, "БІКС");
            groups.Add(6, "МтІВТ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            timer = new System.Timers.Timer(86400000);
            //timer = new System.Timers.Timer(60000);
            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private static async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            thisDay = DateTime.Today;
            string thisDayData = thisDay.ToString().Substring(6, 4) + "-"
                + thisDay.ToString().Substring(3, 2) + "-"
                + thisDay.ToString().Substring(0, 2);

            string AnswerData = "";
            string AnswerDataCicle = "";

            string sql = "SELECT `telegram-bot-id` FROM `telegram-bot-ftf_2`.lecturer;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                AnswerData += reader[0].ToString() + " ";
            }
            string[] AnswersDataID = AnswerData.Split(' ');

            reader.Close();
            connection.Close();
            Console.WriteLine(AnswersDataID);

            for (int i = 0; i < AnswersDataID.Length - 1; i++)
            {
                AnswerDataCicle = "";
                sql = "SELECT id FROM `telegram-bot-ftf_2`.lecturer WHERE `telegram-bot-id` = " + AnswersDataID[i] + ";";
                lecturerData = readRequest(sql);

                sql = "SELECT idl FROM `telegram-bot-ftf_2`.lection WHERE data = '" + thisDayData
                    + "' and lecturer_id  = " + lecturerData + ";";
                command = new MySqlCommand(sql, connection);
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AnswerDataCicle += reader[0].ToString() + " ";
                }
                string[] AnswersData = AnswerDataCicle.Split(' ');
                reader.Close();
                connection.Close();

                scheduleIndex = 0;
                getLections(AnswersData, AnswersDataID[i]);
            }
        }

        private static async void BotOnMessageReceived(object sender, MessageEventArgs messageEventArgs)
        {

            Telegram.Bot.Types.Message msg = messageEventArgs.Message;
            chatID = msg.Chat.Id;
            Console.WriteLine(chatID);

            if (msg == null || msg.Type != MessageType.TextMessage) return;

            String Answer = "";

            if (msg.Text == "/start")
            {
                Answer = "Get start";
                await BOT.SendTextMessageAsync(msg.Chat.Id, Answer);
            }
            else if (msg.Text == "/getschedule" || scheduleIndex == 1 || scheduleIndex == 2)
            {
                if (msg.Text == "/getschedule")
                {
                    Answer = "Вкажіть ваше ім'я ";
                    scheduleIndex++;
                    await BOT.SendTextMessageAsync(msg.Chat.Id, Answer);
                }
                else if (scheduleIndex == 1)
                {
                    Answer = "Введіть дату у форматі рррр-мм-дд ";
                    name = msg.Text;
                    idLecturer = searchLecturer(name.Split(' ')[0], name.Split(' ')[1], name.Split(' ')[2]);
                    scheduleIndex++;
                    await BOT.SendTextMessageAsync(msg.Chat.Id, Answer);
                }
                else if (scheduleIndex == 2)
                {
                    Answer = "";
                    date = msg.Text;

                    connection.Open();

                    string sql = "SELECT idl FROM `telegram-bot-ftf_2`.lection WHERE data = '" + date + "' and lecturer_id  = " + idLecturer + ";";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Answer += reader[0].ToString() + " ";
                    }
                    string[] Answers = Answer.Split(' ');
                    reader.Close();
                    connection.Close();

                    scheduleIndex = 0;
                    getLections(Answers, chatID.ToString());
                }
            }
            else
            {
                await BOT.SendTextMessageAsync(msg.Chat.Id, "No information was found in the database");
            }
        }

        private static async void getLections(string[] Answers, string idChat)
        {
            string sql = "";
            for (int i = 0; i < Answers.Length - 1; i++)
            {

                sql = "SELECT group_id FROM shchedule WHERE lection_id = " + Answers[i] + ";";
                group = readRequest(sql);
                Console.WriteLine(group);

                sql = "SELECT discipline.name FROM lection INNER JOIN discipline WHERE lection.idl = " + Answers[i]
                    + " and lection.discipline_id =  discipline.id";
                discipline = readRequest(sql);

                sql = "SELECT classroom_num FROM lection WHERE idl = " + Answers[i] + ";";
                classroom = readRequest(sql);

                sql = "SELECT lection_num FROM lection WHERE idl = " + Answers[i] + ";";
                lectionNum = readRequest(sql);

                string Answ = "Група: " + groups[Int32.Parse(group)] + " Предмет: " + discipline
                    + " Аудиторія: " + classroom + " " + lectionNum;
                await BOT.SendTextMessageAsync(idChat, Answ);
            }
        }

        private static string readRequest(string sql)
        {
            string value = "";
            MySqlCommand commandTrue = new MySqlCommand(sql, connection);
            connection.Open();
            MySqlDataReader read = commandTrue.ExecuteReader();
            read.Read();
            if (read.HasRows == true)
            {
                value = read.GetString(0);
            }
            connection.Close();
            return value;
        }

        private static String searchLecturer(String name, String secondname, String surname)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
