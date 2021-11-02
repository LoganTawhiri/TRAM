using System;
using System.Collections.Generic;
using System.Text;

namespace TuwharetoaMaps.Classes.AppConstant
{
	public static class Constants
	{
		public static string AppName = "Tuwharetoa Maps";

		// OAuth
		// For Google login, configure at https://console.developers.google.com/
		public static string iOSClientId = "";
		public static string AndroidClientId = "259735158270-2dtj3i6souo4r8n7ng05oaebnc2ge852.apps.googleusercontent.com";

		// These values do not need changing
		public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
		public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
		public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
		public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

		// Set these to reversed iOS/Android client ids, with :/oauth2redirect appended
		public static string iOSRedirectUrl = "";
		public static string AndroidRedirectUrl = "com.googleusercontent.apps.259735158270-2dtj3i6souo4r8n7ng05oaebnc2ge852:/oauth2redirect";
	}
}
