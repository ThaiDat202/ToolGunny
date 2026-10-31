using GunTools.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GunTools
{
    public class csFunction
    {
        public static string CreateCompressXml(XElement result, string file, bool isCompress)
        {
            return CreateCompressXml(StaticsMgr.CurrentPath, result, file, isCompress);
        }

        public static string CreateCompressXml(string path, XElement result, string file, bool isCompress)
        {
            try
            {
                file += ".xml";
                path = Path.Combine(path, file);
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    if (isCompress)
                    {
                        using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                        {
                            binaryWriter.Write(StaticFunction.Compress(result.ToString(false)));
                        }

                    }
                    else
                    {
                        using (StreamWriter streamWriter = new StreamWriter(fileStream))
                            streamWriter.Write(result.ToString(false));
                    }
                }
                return "Build: " + file + ", Success!";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return "Build: " + file + ", Fail!";
            }
        }

        public static XElement CreateUnCompressXml(string path, bool isSaveXml)
        {
            byte[] read = File.ReadAllBytes(path);
            read = StaticFunction.Uncompress(read);
            XDocument xmlDoc = XDocument.Load(new MemoryStream(read));
            string file = Path.Combine(StaticsMgr.TempPath, Path.GetFileName(path));
            CheckFolder(file);
            
            if (isSaveXml)
                xmlDoc.Save(file);
            return xmlDoc.Root;
        }

        public static List<string> GetNameAtrr(XElement element)
        {
            if(element.Element("ItemTemplate") != null)
            {
                element = element.Element("ItemTemplate");
            }else if (element.Element("Store") != null)
            {
                element = element.Element("Store");
            }
            else if (element.Element("RuneTemplate") != null)
            {
                element = element.Element("RuneTemplate");
            }
            else if (element.Element("item") != null)
            {
                element = element.Element("item");
                return XmlAtrr(element.FirstAttribute);
            }
            return XmlAtrr(element.Element("Item").FirstAttribute);
        }

        private static List<string> XmlAtrr(XAttribute attribute, List<string> list = null)
        {
            List<string> result = list;
            if (list == null)
            {
                result = new List<string>();
            }

            result.Add(attribute.Name.LocalName);
            if(attribute.NextAttribute != null)
            {
                XmlAtrr(attribute.NextAttribute, result);
            }
            return result;
        }

        private static List<string> XmlAtrrValue(XElement element, List<string> name)
        {
            List<string> result = new List<string>();
            foreach (var item in name)
            {
                result.Add(element.Attribute(item).Value);
            }
            return result;
        }

        public static void CheckFolder(string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
        }

        private static string CreateSqlQueryValue(XElement element, List<string> name)
        {
            string result = "";
            List<string> value = XmlAtrrValue(element, name);

            foreach (var item in value)
            {
                if(item.ToLower() != "true" && item.ToLower() != "false")
                {
                    if (!double.TryParse(item, out double n) || item.Contains(","))
                    {
                        result += $"N'{item}', ";
                        continue;
                    }
                }

                if (item.ToLower() == "true" && item.ToLower() == "false")
                {
                    if(item.ToLower() == "true")
                    {
                        result += $"1, ";
                    }
                    else
                    {
                        result += $"0, ";
                    }
                    continue;
                }
                    result += item + ", ";
            }
            result = result.Remove(result.Length - 2, 2) + ");";
            return result;
        }

        private static void CreateSqlQuery(StreamWriter writer, XNode node, string sql, UserControl_RequestTools userControl, List<string> name, bool AutoID)
        {
            int id = 1;
            do
            {
                if (AutoID)
                {
                    sql += id.ToString() + ", ";
                    id++;
                }
                string sqlTemp = sql + CreateSqlQueryValue(XElement.Parse(node.ToString()), name);
                userControl.Log("Create SQL: " + sqlTemp, System.Drawing.Color.Green);
                writer.WriteLine(sqlTemp);
                node = node.NextNode;
                if (node == null)
                    break;
                id++;
            } while (true);
        }

        public static void GenarateSqlQuery(string path, UserControl_RequestTools userControl,string NameTable, bool AutoID, bool isSaveXml = false, bool isUnPack = true)
        {
            string file = Path.Combine(StaticsMgr.SqlQueryPath, Path.GetFileNameWithoutExtension(path) + ".sql");
            CheckFolder(file);
            XElement data = null;
            if (isUnPack)
            {
                data = CreateUnCompressXml(path, isSaveXml);

            }
            else
            {
                byte[] read = File.ReadAllBytes(path);
                data = XDocument.Load(new MemoryStream(read)).Root;
            }
            XNode node = null;
            List<string> name = GetNameAtrr(data);
            string sql = $"INSERT INTO {NameTable} (";
            if (AutoID)
            {
                sql = sql + "ID, ";
            }
            foreach (var item in name)
            {
                sql += item + ", ";
            }
            sql = sql.Remove(sql.Length - 2, 2) + ") VALUES (";

            if (data.Element("ItemTemplate") != null)
            {
                data = data.Element("ItemTemplate");
            }
            else if (data.Element("Store") != null)
            {
                data = data.Element("Store");
            }
            else if (data.Element("RuneTemplate") != null)
            {
                data = data.Element("RuneTemplate");
            }

            using (StreamWriter sw = new StreamWriter(new FileStream(file, FileMode.Create), Encoding.UTF8))
            {
               if(data.Element("Item")!= null)
                {
                    node = data.Element("Item");
                }
                else
                {
                    node = data.Element("item");
                }

                CreateSqlQuery(sw, node, sql, userControl, name, AutoID);
            }
        }
    }
}
