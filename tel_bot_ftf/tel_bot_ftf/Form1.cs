using System;
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
        private static string name = "";
        private static string date = "";
        private static string schedule = "";
        private static int scheduleIndex = 0;
        private static long chatID = 0;

        private static System.Timers.Timer timer;

        private static Telegram.Bot.TelegramBotClient BOT;

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            timer = new System.Timers.Timer(60000);
            // Hook up the Elapsed event for the timer. 
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private static async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Send at {0:HH:mm:ss.fff}",
                              e.SignalTime);
            String Answer = "Hello";
            await BOT.SendTextMessageAsync(chatID, Answer);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BOT = new Telegram.Bot.TelegramBotClient("TOKEN");
            BOT.OnMessage += BotOnMeassageReceived;
            BOT.StartReceiving(new UpdateType[] { UpdateType.MessageUpdate });
        }

        private static async void BotOnMeassageReceived (object sender, MessageEventArgs messageEventArgs)
        {
            /*
            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            */
            Telegram.Bot.Types.Message msg = messageEventArgs.Message;
            /*chatID = msg.Chat.Id;

            SetTimer();

            Console.WriteLine(chatID);
            */
            if (msg == null || msg.Type != MessageType.TextMessage) { return; }

            String Answer = "";

            if(msg.Text == "/start")
            {
                Answer = "Get start";
            }
            else if (msg.Text == "/getschedule" || scheduleIndex == 1 || scheduleIndex == 2)
            {
                if(msg.Text == "/getschedule")
                {
                    Answer = "Вкажіть ваше ім'я ";
                    scheduleIndex++;
                    await BOT.SendTextMessageAsync(msg.Chat.Id, Answer);
                } else if(scheduleIndex == 1)
                {
                    Answer = "Введіть дату у форматі рррр-мм-дд ";
                    name = msg.Text;
                    scheduleIndex++;
                    await BOT.SendTextMessageAsync(msg.Chat.Id, Answer);
                } else if(scheduleIndex == 2)
                {
                    Answer = "";
                    date = msg.Text;
                    string connStr = "server=localhost;user=root;database=db_ftf;password=PWD;";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    string sql = "SELECT lection FROM db_ftf.schedule WHERE lecture = '" + name + "' and data = '" + date + "'";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Answer += reader[0].ToString() + "\n";
                    }
                    string[] Answers = Answer.Split(';'); 
                    
                    reader.Close();

                    conn.Close();
                    scheduleIndex = 0;
                    try
                    {
                        foreach(string Answ in Answers)
                        {
                            await BOT.SendTextMessageAsync(msg.Chat.Id, Answ);
                        }
                    } catch (Telegram.Bot.Exceptions.ApiRequestException e)
                    {
                        await BOT.SendTextMessageAsync(msg.Chat.Id, "No information was found in the database");

                    }
                }

            }
            else
            {
                Answer = "I dont now this comad";

                await BOT.SendTextMessageAsync(msg.Chat.Id, Answer);
            }
            
        }
    }
}
