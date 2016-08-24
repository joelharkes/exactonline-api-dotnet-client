using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using ExactOnline.Client.Sdk.Exceptions;
using Newtonsoft.Json;
using System.Globalization;
using System.Threading;
using System.Diagnostics;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for stripping unnecessary Json tags from API Response
	/// </summary>
	public class ApiResponseCleaner
	{
		#region Public methods

		/// <summary>
		/// Fetch Json Object (Json within ['d'] name/value pair) from response
		/// </summary>
		/// <param name="response"></param>
		/// <returns></returns>
		public static string GetJsonObject(string response)
		{
			var serializer = new JavaScriptSerializer();
			serializer.RegisterConverters(new JavaScriptConverter[] { new JssDateTimeConverter() });
			var oldCulture = Thread.CurrentThread.CurrentCulture;
            		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

		    	string output;
		    	try
		    	{
		        	var dict = (Dictionary<string, object>)serializer.Deserialize<object>(response);
		        	var d = (Dictionary<string, object>)dict["d"];
		        	output = GetJsonFromDictionary(d);
		    	}
		    	finally
		    	{
                		Thread.CurrentThread.CurrentCulture = oldCulture;
		    	}
			return output;
		}

        public static string GetJsonArray(string response)
        {
            var g = "";
            return GetJsonArray(response, ref g);
        }
        /// <summary>
        /// Fetch Json Array (Json within ['d']['results']) from response
        /// </summary>
        public static string GetJsonArray(string response, ref string skipToken)
		{
            //skipToken = Guid.NewGuid();
            var serializer = new JavaScriptSerializer();
			serializer.RegisterConverters(new JavaScriptConverter[] { new JssDateTimeConverter() });
			serializer.MaxJsonLength = Int32.MaxValue;
            var oldCulture = Thread.CurrentThread.CurrentCulture;
			Thread.CurrentThread.CurrentCulture =CultureInfo.InvariantCulture;
			try
			{
				ArrayList results;
				var dict = (Dictionary<string, object>)serializer.Deserialize<object>(response);
				var innerPart = dict["d"];
				if (innerPart.GetType() == typeof(Dictionary<string, object>))
				{
					var d = (Dictionary<string, object>)dict["d"];
                    //$skiptoken=guid'39849964-a616-4847-8907-ddfad99ff4aa'
                    if (d.ContainsKey("__next"))
                    {
                        var link = d["__next"] as string;
                        var param = "$skiptoken=";
                        if (!string.IsNullOrEmpty(link))
                        {
                            if (link.ToLower().Contains(param)) {
                                skipToken = link.Substring(link.IndexOf(param) + param.Length);
                            } else
                            {
                                Debugger.Break();
                            }
                        }
                    } else
                    {
                        skipToken = "";
                    }
					results = (ArrayList)d["results"];
				}
				else
				{
					results = (ArrayList)innerPart;
				}
				return GetJsonFromResultDictionary(results);
			}
			catch (Exception e)
			{
				throw new IncorrectJsonException(e.Message);
			}
			finally
			{
				Thread.CurrentThread.CurrentCulture = oldCulture;
			}

		}

		#endregion

		#region Private methods

		/// <summary>
		/// Converts key/value pairs to json
		/// </summary>
		private static string GetJsonFromDictionary(Dictionary<string, object> dictionary)
		{
			string json = "{";

			foreach (var entry in dictionary)
			{
				if (entry.Value == null || entry.Value.GetType() != typeof(Dictionary<string, object>))
				{
					// Entry is of type keyvaluepair
					json += "\"" + entry.Key + "\":";
					if (entry.Value == null)
					{
						json += "null";
					}
					else
					{
						json += JsonConvert.ToString(entry.Value.ToString());
					}
					json += ",";
				}
				else
				{
					// Create linked entities json
					var subcollection = (Dictionary<string, object>)entry.Value;
					if (subcollection.Keys.Contains("results"))
					{
						var results = (ArrayList)subcollection["results"];
						string subjson = GetJsonFromResultDictionary(results);
						if (subjson.Length > 0)
						{
							json += "\"" + entry.Key + "\":";
							json += subjson;
							json += ",";
						}
					}
				}
			}

			json = json.Remove(json.Length - 1, 1); // Remove last comma
			json += "}";

			return json;
		}

		private static string GetJsonFromResultDictionary(ArrayList results)
		{
			string json = "[";
			if (results != null && results.Count > 0)
			{
				foreach (Dictionary<string, object> entity in results)
				{
					json += GetJsonFromDictionary(entity) + ",";
				}

				json = json.Remove(json.Length - 1, 1); // Remove last comma
			}
			json += "]";
			return json;
		}

		#endregion

	}
}
