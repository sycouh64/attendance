using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace GSProject.Forms
{
    public partial class Main : Form
    {
        static readonly string _dbPath = Application.StartupPath + @"\database.db";
        static readonly string _dataSource = $"Data Source={_dbPath}";// "Data Source="+_daPath

        public Main()
        {
            InitializeComponent(); // 디자인 불러오기
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_dbPath))
            {
                using (SqliteConnection connection = new(_dataSource))
                {
                    connection.Open();

                    SqliteCommand command = connection.CreateCommand();
                    command.CommandText =
                    $@"
                        CREATE Table Users (
                            StudentNumber TEXT PRIMARY KEY,
                            Name TEXT,
                            Password TEXT
                        );
                    ";
                    command.ExecuteNonQuery();

                    command = connection.CreateCommand();
                    command.CommandText =
                    $@"
                        CREATE Table Attendances (
                            StudentNumber TEXT,
                            Time TEXT
                        );
                    ";
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                RefreshTable();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string studentNumber = txbxStudentNumber.Text.Trim();
            string password = txbxPassword.Text.Trim();

            string name = string.Empty;
            bool is_password_correct = false;

            string time = DateTime.Now.ToLocalTime().ToString();

            using (SqliteConnection connection = new(_dataSource))
            {
                connection.Open();

                SqliteCommand command = connection.CreateCommand();
                command.CommandText =
                $@"
                    SELECT Password
                    FROM Users
                    WHERE StudentNumber='{studentNumber}';
                ";

                object? result = command.ExecuteScalar();
                if (result != null)
                {
                    is_password_correct = result.ToString()!.Equals(password);
                }

                if (is_password_correct)
                {
                    command = connection.CreateCommand();
                    command.CommandText =
                    $@"
                        INSERT INTO Attendances(StudentNumber, Time)
                        VALUES('{studentNumber}', '{time}');
                    ";
                    command.ExecuteNonQuery();


                    //command = connection.CreateCommand();
                    //command.CommandText =
                    //$@"
                    //    SELECT Name
                    //    FROM Users
                    //    WHERE StudentNumber='{studentNumber}';
                    //";

                    //result = command.ExecuteScalar();
                    //if (result != null)
                    //{
                    //    name = result.ToString()!;
                    //}

                    RefreshTable();
                }
                else
                {
                    MessageBox.Show(
                        $"학번 또는 비밀번호가 올바르지 않은 것 같습니다.",
                        "출석 실패",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void RefreshTable()
        {
            dgvAttendances.Rows.Clear();

            using (SqliteConnection connection = new(_dataSource))
            {
                connection.Open();

                SqliteCommand command = connection.CreateCommand();
                command.CommandText =
                $@"
                    SELECT A.StudentNumber, U.Name, A.Time
                    FROM Users AS U, Attendances AS A
                    WHERE U.StudentNumber=A.StudentNumber
                    ORDER BY A.rowid DESC;
                ";

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    int maximum = 14;
                    int i = 0;
                    while (reader.Read() && i < maximum)
                    {
                        string studentNumber = reader.GetString(0);
                        string name = reader.GetString(1);
                        string time = reader.GetString(2);

                        dgvAttendances.Rows.Add(new object[] { $"{i + 1:00}", studentNumber, name, time });

                        i += 1;
                    }
                }
            }
        }

        private void dgvAttendances_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}