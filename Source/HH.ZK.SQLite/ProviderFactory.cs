using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using LJH.GeneralLibrary;
using LJH.GeneralLibrary.Core.DAL;

namespace HH.ZK.SQLite
{
    /// <summary>
    /// 表示数据库提供者的工厂类
    /// </summary>
    public class ProviderFactory
    {

        /// <summary>
        /// 创建一个数据提供者实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="repUri"></param>
        /// <returns></returns>
        public static T Create<T>(string connStr) where T : class
        {
            T instance = null;
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                if (asm != null)
                {
                    foreach (Type t in asm.GetTypes())
                    {
                        if (t.IsClass && !t.IsAbstract && t == typeof(T))
                        {
                            Stream stream = asm.GetManifestResourceStream("HH.ZK.SQLite.DataMapping.xml");
                            MappingSource mappingSource = XmlMappingSource.FromStream(stream);
                            instance = Activator.CreateInstance(t, connStr, mappingSource) as T;
                            return instance;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            throw new Exception(string.Format("没有找到 {0} ,请确保 {1} 已经存在!", typeof(T).FullName, typeof(T).FullName));
        }

        public static void UpgradeLocalDB(string connStr)
        {
            string path = System.IO.Path.Combine(Application.StartupPath, "DbUpdate_Sqlite.sql");
            if (File.Exists(path))
            {
                List<string> commands = (new LJH.GeneralLibrary.SQLHelper.SQLStringExtractor()).ExtractFromFile(path);
                if (commands != null && commands.Count > 0)
                {
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection(new SQLConnectionURI(connStr).ConnectString))
                    {
                        using (System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();
                            foreach (string command in commands)
                            {
                                try
                                {
                                    cmd.CommandText = command;
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    //LJH.GeneralLibrary.ExceptionPolicy.HandleException(ex);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
