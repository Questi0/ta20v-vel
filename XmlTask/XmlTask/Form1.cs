using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XmlTask
{
    public partial class Form1 : Form
    {
        // Список предметов
        private List<Footballer> Footballers = new List<Footballer>();
        // Имя файла XML
        private string XmlFilename = "footballers.xml";

        public Form1()
        {
            InitializeComponent();

            // Привязать список к источнику данных
            FootballersSource.DataSource = Footballers;

            // Запросить файл XML при запуске
            //OpenXMLToolStripMenuItem_Click(null, null);
            LoadXml(XmlFilename);

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAllToolStripMenuItem_Click(sender, e);
        }

        private void OpenXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadXml(openFileDialog1.FileName);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveXml(XmlFilename);
        }

        private void SaveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.DefaultExt = "xml";
            SaveFileDialog.Filter = "XML files (*.xml)|*.xml";
            if(SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveXml(SaveFileDialog.FileName);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FootballersSource.Clear();
        }

        private void ExecuteTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Вывести сведения о футболисте , старшего 20 лет , и забивающих не менее 0.4 мяча.
            var footballers = Footballers.FindAll(footballer => (DateTime.Now - footballer.BirthDate).TotalDays > (20 * 365) && ((float)footballer.ScoredBallsCount / footballer.GamesCount) > 0.4f);
            // Замена 
            Footballers = footballers.ToList();
            // Показать сведения 
            FootballersSource.DataSource = Footballers;
        }

        private void AddExamplesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void MoveToStartButton_Click(object sender, EventArgs e)
        {
            FootballersSource.MoveFirst();
        }

        private void PreviousElementButton_Click(object sender, EventArgs e)
        {
            FootballersSource.MovePrevious();
        }

        private void NextElementButton_Click(object sender, EventArgs e)
        {
            FootballersSource.MoveNext();
        }

        private void MoveToEndButton_Click(object sender, EventArgs e)
        {
            FootballersSource.MoveLast();
        }

        private void FootballersSource_PositionChanged(object sender, EventArgs e)
        {
            var index = Footballers.IndexOf((Footballer)FootballersSource.Current);
            ElementIndexAndCountLabel.Text = $"{index + 1}/{Footballers.Count}";
        }

        private void FootballersSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            var index = Footballers.IndexOf((Footballer)FootballersSource.Current);
            ElementIndexAndCountLabel.Text = $"{index + 1}/{Footballers.Count}";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FootballersSource.Add(GetFootballer());
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            var index = Footballers.IndexOf((Footballer)FootballersSource.Current);
            if(index == -1)
            {
                AddButton_Click(sender, e);
                return;
            }
            FootballersSource.Insert(index, GetFootballer());
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var index = Footballers.IndexOf((Footballer)FootballersSource.Current);
            FootballersSource[index] = GetFootballer();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Footballers.Remove((Footballer)FootballersSource.Current);
            FootballersSource.RemoveCurrent();
        }

        private Footballer GetFootballer()
        {
            return new Footballer(
                    SecondNameTextBox.Text,
                    BirthDatePicker.Value,
                    RoleTextBox.Text,
                    (int)GamesCountUpDown.Value,
                    (int)ScoredBallsCountUpDown.Value,
                    BirthPlaceTextBox.Text);
        }

        private void LoadXml(string filename)
        {
            // Показать ошибку, если файл не существует
            if (!File.Exists(filename))
            {
                MessageBox.Show("File not found!");
                return;
            }
            // Открыть файл
            using (var stream = File.OpenRead(filename))
            {
                
                var serializer = new XmlSerializer(typeof(List<Footballer>));
                Footballers = (List<Footballer>)serializer.Deserialize(stream);
                FootballersSource.DataSource = Footballers;
            }
        }

        private void SaveXml(string filename)
        {
            // Удалить файл, если он существует
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            // Создать и открыть файл
            using (var stream = File.Create(filename))
            {
                // Сериализовать
                var serializer = new XmlSerializer(typeof(List<Footballer>));
                serializer.Serialize(stream, Footballers);
            }
        }
    }
}
