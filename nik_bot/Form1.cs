using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace nik_bot
{
    public partial class Form1 : Form
    {
        BackgroundWorker bw;

        public Form1()
        {
            InitializeComponent();

            this.bw = new BackgroundWorker();
            this.bw.DoWork += this.bw_DoWork;
        }

        async void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try {
                var key = e.Argument as String;
                var bot = new Telegram.Bot.TelegramBotClient(key);
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                await bot.SetWebhookAsync("");
                int offset = 0;

                while (true) {
                    var updates = await bot.GetUpdatesAsync(offset);

                    foreach (var update in updates) {
                        offset = update.Id + 1;

                        if (update.Type != Telegram.Bot.Types.Enums.UpdateType.Message ||
                            update.Message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                            continue;

                        var message = update.Message;

                        if (message.Text == "/start") {
                            await bot.SendTextMessageAsync(message.Chat.Id,
                                $"Я бот-дразнилка!{Environment.NewLine}" +
                                $"И буду повторять почти всё что ты напишешь!");
                        }
                        else {
                            await bot.SendTextMessageAsync(message.Chat.Id, message.Text);
                        }
                    }
                }
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnRunBot_Click(object sender, EventArgs e)
        {
            var key = txtKey.Text;

            if (key == "") {
                MessageBox.Show("Прежде чем начать, введите ключ бота.");
                return;
            }

            if (this.bw.IsBusy != true) {
                this.bw.RunWorkerAsync(key); 
                btnRunBot.Text = "Бот запущен...";
            }
        }
    }
}
