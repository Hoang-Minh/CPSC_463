using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;


[ServiceContract]
public interface IService
{
	[OperationContract]
	string InsertSeriesDetails(TVSeries tvSeriesObj);

	[OperationContract]
    List<TVSeries> GetSeriesDetails();
}


[DataContract]
public class TVSeries
{
    
    string seriesName = "";
    string favMaleChar = "";
    string favFemaleChar = "";

    

    [DataMember]
    public string TVSeriesName 
    {
        get {return seriesName ;}
        set { seriesName=value;}
    }

    [DataMember]
    public string FavMaleCharacter 
    {
        get {return favMaleChar ;}
        set {favMaleChar=value ;}
    }

    [DataMember]
    public string FavFemaleCharacter  
    {
        get {return favFemaleChar ;}
        set { favFemaleChar=value;} 
    }
}
