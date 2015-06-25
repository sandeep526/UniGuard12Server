using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;


/// <summary>
/// Summary description for G60
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class G60 : System.Web.Services.WebService {

    public G60 () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string ibutton(string impRecordCount, string impLiveData)
    {
        //gprsData.StoreData();
        string result = "Try again";
        string connetionString = null;
        MySqlConnection cnn;
        //connetionString = "server=localhost;database=ug12db_n4wamwj5z1jyq79bafz3;uid=root;pwd=;";
       // cnn = new MySqlConnection(connetionString);
        try
        {
            //cnn.Open();

            //string date = Convert.ToDateTime(DateTime.Now).ToString("dd/M/yyyy");

            //string time = Convert.ToDateTime(DateTime.Now).ToString("hh:mm tt");

            //String cmdText = "INSERT INTO import(impDate,impTime,impRecordCount,impLiveData) VALUES('" + date + "','" + time + "','" + impRecordCount + "','" + impLiveData + "')";
            //MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
            //cmd.Prepare();
            ////we will bound a value to the placeholder
            //cmd.ExecuteNonQuery(); //execute the mysql command
            //cnn.Close();
            result = "Connected Successfully";
        }
        catch (Exception ex)
        {
            result = "try again";
        }
        return result;
        // /return impquery = INSERT INTO import (`impDate`, `impTime`, `impRecordCount`, `impLiveData`) VALUES (impDate, impTime, impRecordCount, impLiveData);
    }
    //[WebMethod]
    //public string ibutton(GPRSData gprsData, Record record)
    //{
    //    gprsData.StoreData();
    //    string result = "Try again";
    //    string connetionString = null;
    //    MySqlConnection cnn;
    //    connetionString = "server=localhost;database=ug12db_n4wamwj5z1jyq79bafz3;uid=root;pwd=;";
    //    cnn = new MySqlConnection(connetionString);
    //    try
    //    {
    //        cnn.Open();

    //        string date = Convert.ToDateTime(DateTime.Now).ToString("dd/M/yyyy");

    //        string time = Convert.ToDateTime(DateTime.Now).ToString("hh:mm tt");

    //        String cmdText = "INSERT INTO import(impDate,impTime,impRecordCount,impLiveData) VALUES('" + date + "','" + time + "','" + impRecordCount + "','" + impLiveData + "')";
    //        MySqlCommand cmd = new MySqlCommand(cmdText, cnn);
    //        cmd.Prepare();
    //        //we will bound a value to the placeholder
    //        cmd.ExecuteNonQuery(); //execute the mysql command
    //        cnn.Close();
    //        result = "Insert Successfully";
    //    }
    //    catch (Exception ex)
    //    {
    //        result = "try again";
    //    }
    //    return result;
    //    // /return impquery = INSERT INTO import (`impDate`, `impTime`, `impRecordCount`, `impLiveData`) VALUES (impDate, impTime, impRecordCount, impLiveData);
    //}
    
}
