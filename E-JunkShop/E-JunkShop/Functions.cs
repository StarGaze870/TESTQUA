using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_JunkShop
{
    class Functions
    {
        public static SqlCommand command;
        public static SqlDataReader reader;

        public static void Query(String query)
        {
            try
            {
                ConnectDB.connect();
                command = new SqlCommand(query, ConnectDB.connection);
                command.ExecuteNonQuery();
                ConnectDB.connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Function.Query()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ADMIN DASHBOARD
       
        // GET SHOP ITEMS
        public static List<(string id, string tag, string type, string name, string price, string weight, string available, string date, string filename)> getShopItems(int option, string search)
        {
            var list = new List<(string id, string tag, string type, string name, string price, string weight, string available, string date, string filename)>();

            string all = $"SELECT Item.itemid AS 'ID', ItemTags.name AS 'TAGS', ItemType.name AS 'TYPE', Item.name AS 'NAME', ('Php' + CONVERT(VARCHAR, Item.sellPrice)) AS 'PRICE', (CONVERT(VARCHAR, Item.weight) + 'kg') as 'WEIGHT', CASE WHEN Item.available = 0 THEN 'Unavailable' ELSE 'Available' END AS 'AVAILABILITY', CONVERT(VARCHAR,Item.date,101) AS 'DATE', Item.filename AS 'FILE NAME' FROM Item INNER JOIN ItemTags ON Item.tagid = ItemTags.tagid INNER JOIN ItemType ON Item.typeid = ItemType.typeid WHERE Item.name LIKE '{search}%';";
            string available = "SELECT Item.itemid AS 'ID', ItemTags.name AS 'TAGS', ItemType.name AS 'TYPE', Item.name AS 'NAME', ('Php' + CONVERT(VARCHAR, Item.sellPrice)) AS 'PRICE', (CONVERT(VARCHAR, Item.weight) + 'kg') as 'WEIGHT', CASE WHEN Item.available = 0 THEN 'Unavailable' ELSE 'Available' END AS 'AVAILABILITY', CONVERT(VARCHAR,Item.date,101) AS 'DATE', Item.filename AS 'FILE NAME' FROM Item INNER JOIN ItemTags ON Item.tagid = ItemTags.tagid INNER JOIN ItemType ON Item.typeid = ItemType.typeid WHERE Item.available = 1 AND Item.approved = 2;";
            string unavaiable = "SELECT Item.itemid AS 'ID', ItemTags.name AS 'TAGS', ItemType.name AS 'TYPE', Item.name AS 'NAME', ('Php' + CONVERT(VARCHAR, Item.sellPrice)) AS 'PRICE', (CONVERT(VARCHAR, Item.weight) + 'kg') as 'WEIGHT', CASE WHEN Item.available = 0 THEN 'Unavailable' ELSE 'Available' END AS 'AVAILABILITY', CONVERT(VARCHAR,Item.date,101) AS 'DATE', Item.filename AS 'FILE NAME' FROM Item INNER JOIN ItemTags ON Item.tagid = ItemTags.tagid INNER JOIN ItemType ON Item.typeid = ItemType.typeid WHERE Item.available = 0 AND Item.approved = 2;";
            string query;

            if (option == 0)
                query = all;
            else if (option == 1)
                query = available;
            else
                query = unavaiable;

            DataTable dt = new DataTable();
            try
            {
                ConnectDB.connect();
                SqlCommand command = new SqlCommand(query, ConnectDB.connection);
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(dt);
                ConnectDB.connection.Close();

                for (int i = 0; i < dt.Rows.Count; ++i)
                    list.Add((dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString()));
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Functions.getShopItems()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return list;
        }
        // GET TAGS LIST OR TYPE LIST
        public static DataTable getTagsOrType(int option) // 0 GET TAGS || 1 GET TYPES
        {            
            string tags = "SELECT tagid AS 'TAG ID', name AS 'NAME' FROM ItemTags;";
            string types = "SELECT typeid AS 'TYPE ID', name AS 'NAME' FROM ItemType;";

            string query = option == 0 ? tags : types;

            DataTable dt = new DataTable();
            try
            {
                ConnectDB.connect();
                SqlCommand command = new SqlCommand(query, ConnectDB.connection);
                SqlDataAdapter data = new SqlDataAdapter(command);
                data.Fill(dt);
                ConnectDB.connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Functions.getTagsOrType()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        // UPDATE IMAGE FILE FOR ITEM
        public static string updateImage(string filename, string id)
        {
            return $"UPDATE Item SET filename = '{filename}' WHERE itemid = '{id}'";
        }

        // GETTING SINGLE DATA FROM A COLUMN
        public static string getColumnData(string table, string columnName1, string value, string columnName2)
        {
            string res = "";
            try
            {
                ConnectDB.connect();
                SqlCommand command = new SqlCommand($"SELECT * FROM {table} WHERE {columnName1}='{value}';", ConnectDB.connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                    res = reader[columnName2].ToString();
                ConnectDB.connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error occured in Function.getColumnData()\n" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }
    }
}
