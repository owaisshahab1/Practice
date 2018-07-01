using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Variables
/// </summary>
public class Initializer
{
	public Initializer()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string strConnection()
    {
        string QueryString = System.Configuration.ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString"].ToString();
        return QueryString;
    }
}