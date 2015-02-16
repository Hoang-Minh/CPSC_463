using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


public class Service : IService
{
    SqlConnection xconn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStrings"].ToString());

   public string InsertSeriesDetails(TVSeries tvSeriesObj)
    {
        string msg = string.Empty;
        SqlCommand xcmd = new SqlCommand("Insert into Development.dbo.TVSeries(TVSeriesName,FavMaleChar,FavFemaleChar) values(@seriesName,@favMale,@favFemale)", xconn);
        
        xcmd.Parameters.AddWithValue("@seriesName", tvSeriesObj.TVSeriesName);
        xcmd.Parameters.AddWithValue("@favMale", tvSeriesObj.FavMaleCharacter);
        xcmd.Parameters.AddWithValue("@favFemale", tvSeriesObj.FavFemaleCharacter);
        try
        {
            xconn.Open();
            int ret = xcmd.ExecuteNonQuery();
            if (ret == 1)
            {
                msg = "Hurray...You have now entered your favorite TV Series Details..";
            }
            else
            {
                msg = "Some error occurred..Please try again";
            }
        }
        finally
        {
            xconn.Close();
        }
        return msg;
        

    }

    public List<TVSeries> GetSeriesDetails()
    {
        
        List<TVSeries> TVlist = new List<TVSeries>();
        SqlDataAdapter da = new SqlDataAdapter("select * from Development.dbo.TVSeries", xconn);
        DataTable dt = new DataTable();
        
        try
        {
            xconn.Open();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    TVSeries obj = new TVSeries();
                    obj.TVSeriesName = dt.Rows[i][0].ToString();
                    obj.FavMaleCharacter = dt.Rows[i][1].ToString();
                    obj.FavFemaleCharacter = dt.Rows[i][2].ToString();
                    TVlist.Add(obj);
                }
            }
        }
        finally
        {
            xconn.Close();
        }
        
        return TVlist;
    }

    
}
