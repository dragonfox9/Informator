using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Informator
{
    class DataBase
    {

        public static bool LoginValidation(string login, string password)
        {
            string sql = "SELECT * from UserInfo";
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (login == (string)reader["login"] && password == (string)reader["pass"])
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;

        }

        public static void addInfo(long index, string from, string title, string msg, DateTime expiryDate, string addedBy, long isImportant, long isDone)
        {
            string sql = "INSERT INTO info_table ('indx', 'from', 'title', 'msg', 'expiryDate', 'addedBy', 'important', 'isDone') VALUES ('"+index+"', '" + from + "', '" + title + "', '" + msg + "', '" + expiryDate.ToShortDateString() + "', '" + addedBy + "', " + isImportant + ", " + isDone + ")";
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
                
            }
        }

        public static bool isAdmin(string login, string password)
        {
            bool isAdmin = false;
            string sql = "SELECT * from UserInfo";
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (login == (string)reader["login"] && password == (string)reader["pass"] && (long)reader["admin"] == 1)
                            {
                                isAdmin = true;
                                break;
                            }
                        }
                    }
                }
            }

            return isAdmin;

        }

        public static bool userExist(string login)
        {
            string sql = "SELECT login from UserInfo";
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (login == (string)reader["login"])
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static bool isInfoOwner(int index, string userName)
        {
            string sql = "SELECT * from info_table where indx=" + index;
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            if (reader["addedBy"].ToString() == userName)
                                return true;
                        }
                        return false;
                    }
                }
            }
        }
        public static bool createUser(string login, string password, long isAdmin)
        {
            if (!userExist(login))
            {

                string sql = "INSERT INTO UserInfo (login, pass, admin) VALUES ('" + login + "', '" + password + "', " + isAdmin+")";
                using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            return false;
        }


        public static void loadAllInfo(MainWindow mw)
        {
            string sql = "SELECT * FROM info_table order by expiryDate asc";
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                            mw.addInfo((long)reader["indx"], reader["from"].ToString(), reader["title"].ToString(), reader["msg"].ToString(), reader["expiryDate"].ToString(),reader["addedBy"].ToString(), (long)reader["important"], (long)reader["isDone"]);
                    }
                }
            }
        }

        public static void loadInfoToPanel(int rowid)
        {
            string sql = "SELECT * FROM info_table where indx="+rowid;
            using (SQLiteConnection c = new SQLiteConnection("Data source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            infoPanelStorage.from = reader["from"].ToString();
                            infoPanelStorage.title = reader["title"].ToString();
                            infoPanelStorage.msg = reader["msg"].ToString();
                            infoPanelStorage.expiryDate = reader["expiryDate"].ToString();
                            infoPanelStorage.important = (long)reader["important"];
                            infoPanelStorage.addedBy = reader["addedBy"].ToString();
                            infoPanelStorage.isDone = (long)reader["isDone"];
                            infoPanelStorage.doneBy = reader["taskDoneBy"].ToString();
                            infoPanelStorage.index = (long)reader["indx"];
                        }
                    }
                }
            }
        }

        public static void setGlobalIndex()
        {
            string sql = "SELECT * FROM info_table order by indx asc";
            using (SQLiteConnection c = new SQLiteConnection("Data source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GlobalInfoPanelndex.currentIndex = (long)reader["indx"];
                            Console.WriteLine("Highest index in database: " + GlobalInfoPanelndex.currentIndex);
                        }
                    }
                }
            }
        }

        public static void deleteInfo(int index)
        {
            if(UserInfo.getAdminPermissions())
            {
                string sql = "DELETE FROM info_table WHERE indx=" + index;
                using (SQLiteConnection c = new SQLiteConnection("Data source=client.db"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static bool deleteUser(string login)
        {
            if(userExist(login))
            {
                string sql = "DELETE FROM UserInfo WHERE login='" + login + "'";
                using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool isInfoDone(int index)
        {
            string sql = "SELECT * from info_table where indx=" + index;
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            if ((int)reader["isDone"] == 1)
                                return true;
                        }
                        return false;
                    }
                }
            }
        }

        public static void setIsDoneFlag(int index, int flag, string userName)
        {
            string sql = "UPDATE info_table SET isDone='" + flag + "', expiryDate='Zatwierdzone', taskDoneBy='" + userName + "' WHERE indx=" + index;
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void changeInfo(int index, string title, string msg)
        {
            string sql = "UPDATE info_table SET title='" + title + "', msg='" + msg + "' WHERE indx=" + index;
            using (SQLiteConnection c = new SQLiteConnection("Data Source=client.db"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
